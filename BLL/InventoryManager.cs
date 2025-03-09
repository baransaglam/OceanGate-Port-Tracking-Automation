using BLL.DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class InventoryManager
    {
        private DAL.InventoryOperationcs cargoOperation;

        public InventoryManager()
        {
            cargoOperation = new DAL.InventoryOperationcs();
        }
        public void SaveCargo(string cargoDes, string cargoType, decimal weight, int units, string orign, string destination, string status, DateTime deliveryDate, DateTime estimatedDeliveryDate, string CustomsDetails, int shipID, int movementID)
        {

            try
            {
                cargoOperation.SaveCargoToDatabase(cargoDes, cargoType, weight, units, orign, destination, status, deliveryDate, estimatedDeliveryDate, CustomsDetails, shipID,movementID);
            }
            catch (Exception ex)
            {
                // Loglama (daha sonra bir dosyaya veya log sistemine yazabilirsiniz)
                Console.WriteLine($"BLL'de bir hata oluştu: {ex.Message}\nStack Trace: {ex.StackTrace}");

                // Daha anlamlı bir mesaj ile kullanıcıya geri bildirim yapabilirsiniz.
                throw new Exception("Veriler işlenirken bir hata oluştu. Daha fazla bilgi için sistem yöneticisine başvurun.", ex);
            }
        }

        public CargoDetails GetCargoByName(string cargoName)
        {
            try
            {
                var cargo = cargoOperation.GetCargoByName(cargoName);
                return cargo ?? throw new Exception("Kargo adıyla eşleşen veri bulunamadı.");
            }
            catch (Exception ex)
            {
                throw new Exception($"Kargo alınırken hata oluştu: {ex.Message}");
            }
        }

        public void UpdateCargo(string cargoName, string cargoType, decimal weight, int units, string origin, string destination, string status, DateTime deliveryDate, DateTime estimatedDeliveryDate, string CustomsDetails, int shipID, int movementID,int cargoID)
        {
            try
            {
                cargoOperation.UpdateCargoInDatabase(cargoName,cargoType,weight,units,origin,destination,status,deliveryDate,estimatedDeliveryDate,CustomsDetails,shipID,movementID,cargoID);
            }
            catch (Exception ex)
            {
                throw new Exception($"Kargo güncellenirken hata oluştu: {ex.Message}");
            }
        }

        public bool DeleteCargoById(int cargoID)
        {
            if (cargoID <= 0)
                throw new ArgumentException("Geçersiz Kargo ID.");

            try
            {
                return cargoOperation.DeleteCargo(cargoID);
            }
            catch (Exception ex)
            {
                throw new Exception($"Kargo silinirken hata oluştu: {ex.Message}");
            }
        }

        public List <CargoDetails> GetCargo()
        {
            try
            {
                var cargos = cargoOperation.GetAllCargo(); // DAL'den verileri çek

                return cargos.Select(m => new CargoDetails
                {
                    CargoDetailID = m.CargoDetailID,
                    ShipID = m.ShipID,
                    MovementID = m.MovementID,
                    CargoDescription = m.CargoDescription,
                    CargoType = m.CargoType,
                    Weight = m.Weight,
                    Units = m.Units,
                    Origin = m.Origin,
                    Destination = m.Destination,
                    Status = m.Status,
                    DeliveryDate = m.DeliveryDate,
                    EstimatedDeliveryDate = m.EstimatedDeliveryDate,
                    CustomsDetails = m.CustomsDetails,
                    ShipMovements = m.ShipMovements,
                    Ships = m.Ships

                }).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"BLL'de gemi hareketlerini listeleme işlemi sırasında hata oluştu: {ex.Message}");
            }
        }

        public static List<CargoDetails> ListAllCargo()
        {
            var result = InventoryOperationcs.ListAllCargo();
            return result;
        }



    }
}
