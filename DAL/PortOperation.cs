using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class PortOperation
    {
        // Liman bilgisini veritabanına kaydeder
        public void SavePortToDatabase(string portName, string location, double? latitude, double? longitude, int? capacity)
        {
            try
            {
                using (var context = new OceanGateDBEntities())  // Veritabanı bağlamı
                {
                    var port = new Ports
                    {
                        PortName = portName,  // Liman adı
                        Location = location,  // Liman adresi
                        Latitude = latitude,  // Liman enlemi
                        Longitude = longitude, // Liman boylamı
                        Capacity = capacity,   // Liman kapasitesi
                        CreatedAt = DateTime.Now  // Kayıt oluşturulma tarihi
                    };

                    // Liman kaydını veritabanına ekliyoruz
                    context.Ports.Add(port);

                    // Değişiklikleri veritabanına kaydediyoruz
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Liman kaydedilirken hata oluştu: {ex.Message}");
                throw new Exception("Liman veritabanına kaydedilemedi. Lütfen tekrar deneyin.");
            }
        }

        // Limanı günceller
        public void UpdatePortInDatabase(int portID, string portName, string location, double? latitude, double? longitude, int? capacity)
        {
            try
            {
                using (var context = new OceanGateDBEntities())
                {
                    // Mevcut limanı PortID'ye göre buluyoruz
                    var port = context.Ports.FirstOrDefault(p => p.PortID == portID);
                    if (port != null)
                    {
                        // Liman bilgilerini güncelliyoruz
                        port.PortName = portName;
                        port.Location = location;
                        port.Latitude = latitude;
                        port.Longitude = longitude;
                        port.Capacity = capacity;
                        port.UpdatedAt = DateTime.Now; // Güncelleme zamanı

                        // Değişiklikleri veritabanına kaydediyoruz
                        context.SaveChanges();
                    }
                    else
                    {
                        throw new Exception($"Port ID: {portID} ile eşleşen liman bulunamadı.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Liman güncellenirken hata oluştu: {ex.Message}");
                throw new Exception($"Liman güncellenemedi: {ex.Message}");
            }
        }

        // Port ID ile limanı döndürür
        public Ports GetPortID(int portId)
        {
            try
            {
                using (var context = new OceanGateDBEntities())
                {
                    // Port ID'ye göre limanı arıyoruz
                    var port = context.Ports.FirstOrDefault(u => u.PortID == portId);
                    if (port == null)
                    {
                        throw new Exception($"Port ID: {portId} ile eşleşen liman bulunamadı.");
                    }
                    return port; // Limanı döndürüyoruz
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Liman alınırken hata oluştu: {ex.Message}");
                throw new Exception($"Port ID: {portId} ile liman alınırken hata oluştu: {ex.Message}");
            }
        }

        // Port adı ile limanı döndürür
        public Ports GetPortName(string portName)
        {
            try
            {
                using (var context = new OceanGateDBEntities())
                {
                    // Port adı ile limanı arıyoruz
                    var port = context.Ports.FirstOrDefault(u => u.PortName == portName);
                    if (port == null)
                    {
                        throw new Exception($"Port adı: {portName} ile eşleşen liman bulunamadı.");
                    }
                    return port; // Limanı döndürüyoruz
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Liman alınırken hata oluştu: {ex.Message}");
                throw new Exception($"Port adı: {portName} ile liman alınırken hata oluştu: {ex.Message}");
            }
        }

        public List<Ports> GetAllPorts()
        {
            using (var context = new OceanGateDBEntities())
            {
                try
                {
                    return context.Ports.ToList();
                }
                catch (Exception ex)
                {
                    throw new Exception($"DAL'de limanları listeleme işlemi sırasında hata oluştu: {ex.Message}");
                }
            }
        }

        public bool DeletePort(int portID)
        {
            try
            {
                using (var context = new OceanGateDBEntities())
                {

                    var port = context.Ports.FirstOrDefault(u => u.PortID == portID);
                    if (port == null)
                        return false;


                    context.Ports.Remove(port);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Hata: {ex.Message}");
                return false;
            }
        }


        public static List<Ports> ListAllPorts()
        {
            OceanGateDBEntities vt = new OceanGateDBEntities();
            var list = vt.Ports.ToList();
            return list;
        }


    }
}



