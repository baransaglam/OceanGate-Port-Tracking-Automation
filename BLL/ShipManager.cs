using BLL.DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
namespace BLL
{
    public class ShipManager
    {
        private DAL.ShipOperation shipOperation;

        public ShipManager()
        {
            shipOperation = new DAL.ShipOperation();
        }

        public void SaveShip(string shipName, string shipType, int capacity)
        {
            try
            {
                shipOperation.SaveShipToDatabase(shipName, shipType, capacity);
            }
            catch (Exception ex)
            {
                throw new Exception($"Gemi kaydedilirken hata oluştu: {ex.Message}");
            }
        }

        public void UpdateShip(int shipID, string shipName, string shipType, int capacity)
        {
            try
            {
                shipOperation.UpdateShipInDatabase(shipID, shipName, shipType, capacity);
            }
            catch (Exception ex)
            {
                throw new Exception($"Gemi güncellenirken hata oluştu: {ex.Message}");
            }
        }

        public Ships GetShipByID(int shipID)
        {
            try
            {
                var ship = shipOperation.GetShipByID(shipID);
                return ship ?? throw new Exception("Gemi bulunamadı.");
            }
            catch (Exception ex)
            {
                throw new Exception($"Gemi alınırken hata oluştu: {ex.Message}");
            }
        }

        public Ships GetShipByName(string shipName)
        {
            try
            {
                var ship = shipOperation.GetShipByName(shipName);
                return ship ?? throw new Exception("Gemi adıyla eşleşen veri bulunamadı.");
            }
            catch (Exception ex)
            {
                throw new Exception($"Gemi alınırken hata oluştu: {ex.Message}");
            }
        }

        public bool DeleteShipById(int shipID)
        {
            if (shipID <= 0)
                throw new ArgumentException("Geçersiz Ship ID.");

            try
            {
                return shipOperation.DeleteShip(shipID);
            }
            catch (Exception ex)
            {
                throw new Exception($"Gemi silinirken hata oluştu: {ex.Message}");
            }
        }

        public List<Ships> GetShipsByPort(int portID)
        {
            try
            {
                var ships = shipOperation.GetShipsByPortID(portID);
                return ships ?? throw new Exception("Belirtilen limanda gemi bulunamadı.");
            }
            catch (Exception ex)
            {
                throw new Exception($"Liman ID'si: {portID} ile gemiler alınırken hata oluştu: {ex.Message}");
            }
        }

   
         public List<Ships> GetShips()
        {
            try
            {
                return shipOperation.GetAllShips();
            }
            catch (Exception ex)
            {
                throw new Exception($"BLL'de gemileri listeleme işlemi sırasında hata oluştu: {ex.Message}");
            }
        }

        public List<ShipMovementDTO> GetShipMovements()
        {
            try
            {
                var movements = shipOperation.GetAllMovements(); // DAL'den verileri çek

                return movements.Select(m => new ShipMovementDTO
                {
                    MovementID = m.MovementID,
                    ShipName = m.Ships != null ? m.Ships.ShipName : "Bilinmiyor", // İlişkili gemi adı
                    PortName = m.Ports != null ? m.Ports.PortName : "Bilinmiyor", // İlişkili liman adı
                    ArrivalDate = m.ArrivalDate?.ToString("yyyy-MM-dd") ?? "Belirtilmedi",
                    DepartureDate = m.DepartureDate?.ToString("yyyy-MM-dd") ?? "Belirtilmedi"
                }).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"BLL'de gemi hareketlerini listeleme işlemi sırasında hata oluştu: {ex.Message}");
            }
        }

        public static List<Ships> ListAllShips()
        {
            var result = ShipOperation.ListAllShips();
            return result;
        }
    }
 }


