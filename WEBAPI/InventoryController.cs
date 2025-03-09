using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WEBAPI
{
    public class InventoryController : ApiController
    {
        private readonly OceanGateDBEntities _context;

        public InventoryController()
        {
            _context = new OceanGateDBEntities();
        }

        // GET: api/Inventory
        [HttpGet]
        public IEnumerable<CargoDetails> Get()
        {
            return _context.CargoDetails.Include("Ships").Include("ShipMovements").ToList();
        }

        // GET: api/Inventory/5
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var cargoDetail = _context.CargoDetails
                .Include("Ships")
                .Include("ShipMovements")
                .FirstOrDefault(cd => cd.CargoDetailID == id);

            if (cargoDetail == null)
                return NotFound();

            return Ok(cargoDetail);
        }

        // POST: api/Inventory
        [HttpPost]
        public IHttpActionResult Post([FromBody] CargoDetails cargoDetail)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _context.CargoDetails.Add(cargoDetail);
            _context.SaveChanges();

            return Ok(cargoDetail);
        }

        // PUT: api/Inventory/5
        [HttpPut]
        public IHttpActionResult Put(int id, [FromBody] CargoDetails cargoDetail)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existingCargoDetail = _context.CargoDetails.Find(id);
            if (existingCargoDetail == null)
                return NotFound();

            existingCargoDetail.ShipID = cargoDetail.ShipID;
            existingCargoDetail.MovementID = cargoDetail.MovementID;
            existingCargoDetail.CargoDescription = cargoDetail.CargoDescription;
            existingCargoDetail.CargoType = cargoDetail.CargoType;
            existingCargoDetail.Weight = cargoDetail.Weight;
            existingCargoDetail.Units = cargoDetail.Units;
            existingCargoDetail.Origin = cargoDetail.Origin;
            existingCargoDetail.Destination = cargoDetail.Destination;
            existingCargoDetail.Status = cargoDetail.Status;
            existingCargoDetail.DeliveryDate = cargoDetail.DeliveryDate;
            existingCargoDetail.EstimatedDeliveryDate = cargoDetail.EstimatedDeliveryDate;
            existingCargoDetail.CustomsDetails = cargoDetail.CustomsDetails;

            _context.SaveChanges();

            return Ok(existingCargoDetail);
        }

        // DELETE: api/Inventory/5
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var cargoDetail = _context.CargoDetails.Find(id);
            if (cargoDetail == null)
                return NotFound();

            _context.CargoDetails.Remove(cargoDetail);
            _context.SaveChanges();

            return Ok();
        }
    }
}