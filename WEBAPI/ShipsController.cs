using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WEBAPI
{
    public class ShipsController : ApiController
    {
        private readonly OceanGateDBEntities _context;

        public ShipsController()
        {
            _context = new OceanGateDBEntities();
        }

        [HttpGet]
        public IEnumerable<Ships> Get()
        {
            return _context.Ships;
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var ship = _context.Ships.Find(id);
            if (ship == null)
                return NotFound();

            return Ok(ship);
        }

        [HttpPost]
        public IHttpActionResult Post([FromBody] Ships ship)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _context.Ships.Add(ship);
            _context.SaveChanges();

            return Ok(ship);
        }

        [HttpPut]
        public IHttpActionResult Put(int id, [FromBody] Ships ship)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existingShip = _context.Ships.Find(id);
            if (existingShip == null)
                return NotFound();

            existingShip.ShipName = ship.ShipName;
            existingShip.Capacity = ship.Capacity;
            existingShip.ShipType = ship.ShipType;
            _context.SaveChanges();

            return Ok(existingShip);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var ship = _context.Ships.Find(id);
            if (ship == null)
                return NotFound();

            _context.Ships.Remove(ship);
            _context.SaveChanges();

            return Ok();
        }
    }
}