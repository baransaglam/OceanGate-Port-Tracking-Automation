using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;

namespace DAL
{
    public class UserOperations
    {
        public bool AddUser(string firstName,string lastName, string tcNumber, string email, string passwordHash, int role)
        {
            try
            {
                using (var context = new OceanGateDBEntities())
                {
                    Users newUser = new Users
                    {
                        FirstName = firstName,
                        LastName =lastName,
                        TCNumber = tcNumber,
                        Email = email,
                        PasswordHash = passwordHash,
                        RoleID = role
                    };

                    context.Users.Add(newUser);
                    return context.SaveChanges() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Veritabanına kullanıcı eklenirken hata oluştu.", ex);
            }
        }

        public List<Users> GetUsersByFilter(string firstName,string lastName ,string tcNumber, string email)
        {
            using (var context = new OceanGateDBEntities())
            {
                var query = context.Users.AsQueryable();

                if (!string.IsNullOrEmpty(firstName))
                    query = query.Where(u => u.FirstName.Contains(firstName));

                if (!string.IsNullOrEmpty(lastName))
                    query = query.Where(u => u.LastName.Contains(lastName));

                if (!string.IsNullOrEmpty(tcNumber))
                    query = query.Where(u => u.TCNumber == tcNumber);

                if (!string.IsNullOrEmpty(email))
                    query = query.Where(u => u.Email.Contains(email));

                return query.ToList();
            }
        }


        // Kullanıcı varlığını TC numarasına göre kontrol eden metot
        public bool IsTcNumberExists(string tcNumber)
        {
            using (var context = new OceanGateDBEntities())
            {
                return context.Users.Any(u => u.TCNumber == tcNumber);
            }
        }

        // Kullanıcı varlığını e-posta adresine göre kontrol eden metot
        public bool IsEmailExists(string email)
        {
            using (var context = new OceanGateDBEntities())
            {
                return context.Users.Any(u => u.Email == email);
            }
        }

        public bool DeleteUser(int userId)
        {
            try
            {
                using (var context = new OceanGateDBEntities())
                {
                    // Kullanıcıyı bul
                    var user = context.Users.FirstOrDefault(u => u.UserID == userId);
                    if (user == null)
                        return false;

                    // Kullanıcıyı sil
                    context.Users.Remove(user);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Hata loglama
                Console.WriteLine($"Hata: {ex.Message}");
                return false;
            }
        }

        public Users GetUserID(int userId)
        {
            using (var context = new OceanGateDBEntities())
            {
                try
                {
                    
                    var user = context.Users.FirstOrDefault(u => u.UserID == userId);
                    return user; 
                }
                catch (Exception ex)
                {
                    
                    Console.WriteLine($"Kullanıcı alınırken hata oluştu: {ex.Message}");
                    return null; 
                }
            }
        }

        public Users GetUserIdentity(string identity)
        {
            using (var context = new OceanGateDBEntities())
            {
                try
                {
                    
                    var user = context.Users.FirstOrDefault(u => u.TCNumber == identity);
                    return user; 
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Kullanıcı alınırken hata oluştu: {ex.Message}");
                    return null; 
                }
            }
        }

        public bool UpdateUser(int userId, string firstName, string lastName,string tcNumber, string email, string passwordHash, int roleId)
        {
            using (var context = new OceanGateDBEntities())
            {
                try
                {
                    
                    var user = context.Users.FirstOrDefault(u => u.UserID == userId);
                    if (user != null)
                    {
                        
                        user.FirstName = firstName;
                        user.LastName = lastName;
                        user.TCNumber = tcNumber;
                        user.Email = email;
                        user.PasswordHash = passwordHash;
                        user.RoleID = roleId;

                        
                        context.SaveChanges();
                        return true; 
                    }
                    else
                    {
                        return false; 
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Kullanıcı güncellenirken hata oluştu: {ex.Message}");
                    return false; // Hata durumu
                }
            }
        }
        
        public bool ControlUserLogin(string tcNumber, string password)
        {
            using (var context = new OceanGateDBEntities())
            {
                try
                {
                    
                    return context.Users.Any(u => u.TCNumber == tcNumber && u.PasswordHash == password);
                }
                catch (Exception ex)
                {
                    
                    throw new Exception($"DAL'de hata oluştu: {ex.Message}");
                }
            }
        }

        public int GetUserRoleId(string tcNumber, string passwordHash)
        {
            using (var context = new OceanGateDBEntities())
            {
                try
                {
                    
                    var user = context.Users.FirstOrDefault(u => u.TCNumber == tcNumber && u.PasswordHash == passwordHash);

                    if (user != null)
                    {
                        return user.RoleID; 
                    }

                    return 0; 
                }
                catch (Exception ex)
                {
                    throw new Exception($"DAL'de rol ID alırken hata oluştu: {ex.Message}");
                }
            }
        }

        public static List<Users> ListAllUsers()
        {
            OceanGateDBEntities vt = new OceanGateDBEntities();
            var list = vt.Users.ToList();
            return list;
        }

    }



}



