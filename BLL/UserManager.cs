using DAL;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace BLL
{
    public class UserManager
    {
        private readonly UserOperations _userOperations;

        public UserManager()
        {
            _userOperations = new UserOperations();
        }

        // Kullanıcı ekleme metodu
        public bool AddUser(string firstName, string lastName, string tcNumber, string email, string password, int roleId)
        {
            try
            {
                // Girdi doğrulama
                if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(tcNumber) ||
                    string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(lastName) || roleId <= 0)
                {
                    throw new ArgumentException("Tüm alanlar doldurulmalıdır.");
                }

                // Aynı kimlik veya e-posta adresi ile kullanıcı olup olmadığını kontrol etme
                bool isTcNumberExists = _userOperations.IsTcNumberExists(tcNumber);
                bool isEmailExists = _userOperations.IsEmailExists(email);

                if (isTcNumberExists && isEmailExists)
                {
                    throw new ArgumentException("Bu kimlik ve e-posta adresine sahip bir kullanıcı zaten kayıtlı.");
                }
                else if (isTcNumberExists)
                {
                    throw new ArgumentException("Bu kimlik numarasına sahip bir kullanıcı zaten kayıtlı.");
                }
                else if (isEmailExists)
                {
                    throw new ArgumentException("Bu e-posta adresine sahip bir kullanıcı zaten kayıtlı.");
                }

                // Şifreyi hashleme
                string passwordHash = ComputeSha256Hash(password);

                // DAL katmanına veriyi gönderme
                return _userOperations.AddUser(firstName, lastName, tcNumber, email, passwordHash, roleId);
            }
            catch (ArgumentException argEx)
            {
                // Kullanıcı hataları için
                throw new ArgumentException($"Kullanıcı eklenirken hata oluştu: {argEx.Message}");
            }
            catch (Exception ex)
            {
                // Genel hata yönetimi
                throw new Exception($"Kullanıcı eklenirken hata oluştu: {ex.Message}");
            }
        }


        private string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }


        public int GetRoleIdByRoleName(string roleName)
        {
            if (string.IsNullOrEmpty(roleName)) return 0;

            switch (roleName.ToLower())
            {
                case "admin": return 1;
                case "analyst": return 4;
                case "manager": return 2;
                case "operator": return 3;
                case "user": return 5;
                default: return 0;
            }
        }

        public List<Users> GetUsersByFilter(string firstName, string lastName, string tcNumber, string email)
        {
            try
            {
                return _userOperations.GetUsersByFilter(firstName, lastName, tcNumber, email);
            }
            catch (Exception ex)
            {
                throw new Exception($"Kullanıcıları filtreleme sırasında hata oluştu: {ex.Message}");
            }
        }

        public bool DeleteUserById(int userId)
        {
            if (userId <= 0)
                throw new ArgumentException("Geçersiz kullanıcı ID'si.");

            return _userOperations.DeleteUser(userId);
        }

        public Users GetUserByID(int userId)
        {
            try
            {
                // DAL katmanındaki GetUser metodunu çağırıyoruz ve sonucu döndürüyoruz
                var user = _userOperations.GetUserID(userId);

                if (user == null)
                {
                    // Kullanıcı bulunamadığında özel bir durum yönetebilirsiniz.
                    throw new Exception("Kullanıcı bulunamadı.");
                }

                return user; // Kullanıcıyı döndürüyoruz
            }
            catch (Exception ex)
            {
                // Hata durumunda daha detaylı bir mesaj döndürüyoruz
                throw new Exception($"Kullanıcı verisi alınırken hata oluştu: {ex.Message}");
            }
        }

        public Users GetUserByIdentity(string identity)
        {
            try
            {
                return _userOperations.GetUserIdentity(identity); // DAL katmanındaki metodu çağırıyoruz
            }
            catch (Exception ex)
            {
                throw new Exception($"Kullanıcı verisi alınırken hata oluştu: {ex.Message}");
            }
        }

        public bool UpdateUser(int userId, string firstName, string lastName, string tcNumber, string email, string passwordHash, int roleId)
        {
            try
            {
                return _userOperations.UpdateUser(userId, firstName, lastName, tcNumber, email, passwordHash, roleId); // DAL katmanındaki metodu çağırıyoruz
            }
            catch (Exception ex)
            {
                throw new Exception($"Kullanıcı verisi güncellenirken hata oluştu: {ex.Message}");
            }
        }
        public bool ControlUser(string tcNumber, string password)
        {
            try
            {
                // Şifre hashleme
                string hashedPassword = ComputeSha256Hash(password);

                // Hashlenmiş şifre ile DAL katmanına gönder
                return _userOperations.ControlUserLogin(tcNumber, hashedPassword);
            }
            catch (Exception ex)
            {
                // Hata loglama ve tekrar fırlatma
                throw new Exception($"BLL Kullanıcı giriş işlemi yaparken hata oluştu: {ex.Message}");
            }
        }

        public int GetUserRole(string tcNumber, string password)
        {
            try
            {
                // Şifre hashleme
                string hashedPassword = ComputeSha256Hash(password);

                // Role ID'yi döndür
                return _userOperations.GetUserRoleId(tcNumber, hashedPassword);
            }
            catch (Exception ex)
            {
                throw new Exception($"BLL'de rol ID alırken hata oluştu: {ex.Message}");
            }
        }

        public static List<Users> ListAllUsers()
        {
            var result = UserOperations.ListAllUsers();
            return result;
        }
    }
}


