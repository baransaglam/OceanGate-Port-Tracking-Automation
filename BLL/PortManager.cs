using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public class PortManager
    {
        private DAL.PortOperation portOperation;

        public PortManager()
        {
            portOperation = new DAL.PortOperation();
        }

        public void SavePort(string portName, string location, double? latitude, double? longitude, int? capacity)
        {
            try
            {
                portOperation.SavePortToDatabase(portName, location, latitude, longitude, capacity);
            }
            catch (Exception ex)
            {
                throw new Exception($"Liman verisi kaydedilirken hata oluştu: {ex.Message}");
            }
        }

        public void UpdatePort(int portID, string portName, string location, double? latitude, double? longitude, int? capacity)
        {
            try
            {
                portOperation.UpdatePortInDatabase(portID, portName, location, latitude, longitude, capacity);
            }
            catch (Exception ex)
            {
                throw new Exception($"Liman verisi güncellenirken hata oluştu: {ex.Message}");
            }
        }

        public Ports GetPortByID(int portID)
        {
            try
            {
                // Limanı almak için doğru metodu çağırıyoruz
                var port = portOperation.GetPortID(portID);

                if (port == null)
                {
                    // Liman bulunamadığında özel bir durum yönetebilirsiniz
                    throw new Exception("Liman bulunamadı.");
                }

                return port; // Limanı döndürüyoruz
            }
            catch (Exception ex)
            {
                throw new Exception($"Liman verisi alınırken hata oluştu: {ex.Message}");
            }
        }

        public Ports GetPortByName(string portName)
        {
            try
            {
                // Liman adını almak için doğru metodu çağırıyoruz
                var port = portOperation.GetPortName(portName);

                if (port == null)
                {
                    // Liman adıyla eşleşen veri bulunamadı
                    throw new Exception("Liman adıyla eşleşen veri bulunamadı.");
                }

                return port; // Limanı döndürüyoruz
            }
            catch (Exception ex)
            {
                throw new Exception($"Liman isim verisi alınırken hata oluştu: {ex.Message}");
            }
        }


        public List<Ports> GetPorts()
        {
            try
            {
                return portOperation.GetAllPorts();
            }
            catch (Exception ex)
            {
                throw new Exception($"BLL'de limanları listeleme işlemi sırasında hata oluştu: {ex.Message}");
            }
        }

        public bool DeletePortById(int portID)
        {
            if (portID <= 0)
                throw new ArgumentException("Geçersiz port ID'si.");

            return portOperation.DeletePort(portID);
        }

        public static List<Ports> ListAllPorts()
        {
            var result = PortOperation.ListAllPorts();
            return result;
        }


    }
}



