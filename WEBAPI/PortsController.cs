using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Data.Entity;
using DAL;

namespace WEBAPI.Controllers
{
    public class PortsController : ApiController
    {
        private readonly OceanGateDBEntities _context;

        public PortsController()
        {
            _context = new OceanGateDBEntities();
        }

        // GET: api/Ports
        [HttpGet]
        public IEnumerable<Ports> Get()
        {
            return _context.Ports.Include("ShipMovements").Include("Ships").ToList();
        }

        // GET: api/Ports/5
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var port = _context.Ports
                .Include("ShipMovements")
                .Include("Ships")
                .FirstOrDefault(p => p.PortID == id);

            if (port == null)
                return NotFound();

            return Ok(port);
        }

        // POST: api/Ports
        [HttpPost]
        public IHttpActionResult Post([FromBody] Ports port)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _context.Ports.Add(port);
            _context.SaveChanges();

            return Ok(port);
        }

        // PUT: api/Ports/5
        [HttpPut]
        public IHttpActionResult Put(int id, [FromBody] Ports port)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existingPort = _context.Ports.Find(id);
            if (existingPort == null)
                return NotFound();

            existingPort.PortName = port.PortName;
            existingPort.Location = port.Location;
            existingPort.Capacity = port.Capacity;
            existingPort.CreatedAt = port.CreatedAt;
            existingPort.Latitude = port.Latitude;
            existingPort.Longitude = port.Longitude;
            existingPort.UpdatedAt = port.UpdatedAt;

            _context.SaveChanges();

            return Ok(existingPort);
        }

        // DELETE: api/Ports/5
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var port = _context.Ports.Find(id);
            if (port == null)
                return NotFound();

            _context.Ports.Remove(port);
            _context.SaveChanges();

            return Ok();
        }
    }
}
