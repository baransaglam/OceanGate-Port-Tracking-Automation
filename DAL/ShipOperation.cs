using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ShipOperation
    {
        private OceanGateDBEntities context;

        public ShipOperation()
        {
            context = new OceanGateDBEntities();
        }

        public void SaveShipToDatabase(string shipName, string shipType, int capacity)
        {
            try
            {
                var ship = new Ships
                {
                    ShipName = shipName,
                    ShipType = shipType,
                    Capacity = capacity
                };

                context.Ships.Add(ship);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Gemi veritabanına kaydedilemedi: " + ex.Message);
            }
        }

        public void UpdateShipInDatabase(int shipID, string shipName, string shipType, int capacity)
        {
            try
            {
                var ship = context.Ships.FirstOrDefault(p => p.ShipID == shipID);
                if (ship == null)
                    throw new Exception($"Ship ID: {shipID} ile eşleşen gemi bulunamadı.");

                ship.ShipName = shipName;
                ship.ShipType = shipType;
                ship.Capacity = capacity;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Gemi güncellenemedi: " + ex.Message);
            }
        }

        public Ships GetShipByID(int shipID)
        {
            try
            {
                return context.Ships.FirstOrDefault(u => u.ShipID == shipID);
            }
            catch (Exception ex)
            {
                throw new Exception("Gemi alınırken hata oluştu: " + ex.Message);
            }
        }

        public Ships GetShipByName(string shipName)
        {
            try
            {
                return context.Ships.FirstOrDefault(u => u.ShipName == shipName);
            }
            catch (Exception ex)
            {
                throw new Exception("Gemi alınırken hata oluştu: " + ex.Message);
            }
        }

        public bool DeleteShip(int shipID)
        {
            try
            {
                var ship = context.Ships.FirstOrDefault(u => u.ShipID == shipID);
                if (ship == null)
                    return false;

                context.Ships.Remove(ship);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Gemi silinirken hata oluştu: " + ex.Message);
            }
        }

        public List<Ships> GetShipsByPortID(int portID)
        {
            try
            {
                return context.Ships.Where(s => s.PortID == portID).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Liman ID'si ile gemiler alınırken hata oluştu: " + ex.Message);
            }
        }   
           public List<Ships> GetAllShips()
           {
            using (var context = new OceanGateDBEntities())
            {
                try
                {
                    return context.Ships.ToList();
                }
                catch (Exception ex)
                {
                    throw new Exception($"DAL'de gemileri listeleme işlemi sırasında hata oluştu: {ex.Message}");
                }
            }
           }
        
        public List<ShipMovements> GetAllMovements()
        {
            using (var context = new OceanGateDBEntities())
            {
                try
                {
                    // İlişkili tabloları dahil et
                    return context.ShipMovements
                        .Include("Ships")
                        .Include("Ports")
                        .ToList();
                }
                catch (Exception ex)
                {
                    throw new Exception($"DAL'de gemi hareketlerini listeleme işlemi sırasında hata oluştu: {ex.Message}");
                }
            }
        }
        public static List<Ships> ListAllShips()
        {
            OceanGateDBEntities vt = new OceanGateDBEntities();
            var list = vt.Ships.ToList();
            return list;
        }

    }
}