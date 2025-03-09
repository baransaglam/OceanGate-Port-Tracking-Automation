using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class InventoryOperationcs
    {

        private OceanGateDBEntities context;

        public InventoryOperationcs()
        {
            context = new OceanGateDBEntities();
        }
        public void SaveCargoToDatabase(string cargoDes, string cargoType, decimal weight,int units,string orign,string destination,string status,DateTime deliveryDate, DateTime estimatedDeliveryDate,string CustomsDetails, int shipID, int movementID)
        {
            try
            {
                var cargo = new CargoDetails
                {
                    CargoDescription = cargoDes,
                    CargoType = cargoType,
                    Weight = weight,
                    Units = units,
                    Origin = orign,
                    Destination = destination,
                    Status = status,
                    DeliveryDate = deliveryDate,
                    EstimatedDeliveryDate = estimatedDeliveryDate,
                    CustomsDetails = CustomsDetails,
                    ShipID = shipID,
                    MovementID = movementID
                };

                context.CargoDetails.Add(cargo);
                context.SaveChanges();
            }
            catch (DbUpdateException dbEx)
            {
                throw new Exception("Veritabanı güncelleme hatası: " + dbEx.InnerException?.Message, dbEx);
            }
            catch (Exception ex)
            {
                throw new Exception("Bilinmeyen bir hata oluştu: " + ex.Message, ex);
            }
        }

        public CargoDetails GetCargoByName(string cargoName)
        {
            try
            {
                return context.CargoDetails.FirstOrDefault(u => u.CargoDescription == cargoName);
            }
            catch (Exception ex)
            {
                throw new Exception("Kargo alınırken hata oluştu: " + ex.Message);
            }
        }

        public void UpdateCargoInDatabase(string cargoName, string cargoType, decimal weight, int units, string orign, string destination, string status, DateTime deliveryDate, DateTime estimatedDeliveryDate, string CustomsDetails, int shipID, int movementID,int cargoID)
        {
            try
            {
                var cargo = context.CargoDetails.FirstOrDefault(p => p.CargoDetailID == cargoID);
                if (cargo == null)
                    throw new Exception($"Cargo ID: {cargoID} ile eşleşen kargo bulunamadı.");

                cargo.CargoDescription = cargoName;
                cargo.CargoType = cargoType;
                cargo.Weight = weight;
                cargo.Units = units;
                cargo.Origin = orign;
                cargo.Destination = destination;
                cargo.Status = status;
                cargo.DeliveryDate = deliveryDate;
                cargo.EstimatedDeliveryDate = estimatedDeliveryDate;
                cargo.CustomsDetails = CustomsDetails;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Kargo güncellenemedi: " + ex.Message);
            }
        }

        public bool DeleteCargo(int cargoID)
        {
            try
            {
                var cargo = context.CargoDetails.FirstOrDefault(u => u.CargoDetailID == cargoID);
                if (cargo == null)
                    return false;

                context.CargoDetails.Remove(cargo);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Kargo silinirken hata oluştu: " + ex.Message);
            }
        }

        public List<CargoDetails> GetAllCargo()
        {
            using (var context = new OceanGateDBEntities())
            {
                try
                {
                    return context.CargoDetails.ToList();
                }
                catch (Exception ex)
                {
                    throw new Exception($"DAL'de kargoları listeleme işlemi sırasında hata oluştu: {ex.Message}");
                }
            }
        }

        public static List<CargoDetails> ListAllCargo()
        {
            OceanGateDBEntities vt = new OceanGateDBEntities();
            var list = vt.CargoDetails.ToList();
            return list;
        }
    }
}
