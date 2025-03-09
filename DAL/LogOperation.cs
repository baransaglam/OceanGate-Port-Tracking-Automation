
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DAL
{
    public class LogOperation
    {
        public void SaveLog(string action)
        {
            using (var db = new OceanGateDBEntities())  // OceanGateDBEntities, DbContext sınıfı
            {
                var log = new Logs  // Logs sınıfı (ORM'de veritabanı logları için oluşturulan sınıf)
                {
                    Action = action,
                    Timestamp = DateTime.Now  // Kayıt zamanı
                };

                db.Logs.Add(log);  // Logu veritabanına ekle
                db.SaveChanges();  // Değişiklikleri kaydet
            }
        }

        public List<Logs> GetLogs()
        {
            using (var db = new OceanGateDBEntities())  // DbContext
            {
                return db.Logs.ToList();  // Veritabanındaki tüm logları getir
            }
        }
    }
    }


