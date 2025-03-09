using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WEBAPI
{
    public class UsersController : ApiController
    {
        private readonly OceanGateDBEntities _context;

        public UsersController()
        {
            _context = new OceanGateDBEntities();
        }

        // GET: api/users
        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(_context.Users.ToList());
        }

        // GET: api/users/5
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var user = _context.Users.Find(id);
            if (user == null)
                return NotFound();

            return Ok(user);
        }

        // POST: api/users
        [HttpPost]
        public IHttpActionResult Post([FromBody] Users user)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _context.Users.Add(user);
            _context.SaveChanges();

            return Ok(user);
        }

        // PUT: api/users/5
        [HttpPut]
        public IHttpActionResult Put(int id, [FromBody] Users user)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existingUser = _context.Users.Find(id);
            if (existingUser == null)
                return NotFound();

            existingUser.FirstName = user.FirstName;
            existingUser.LastName = user.LastName;
            existingUser.TCNumber = user.TCNumber;
            existingUser.Email = user.Email;
            existingUser.PasswordHash = user.PasswordHash;
            existingUser.RoleID = user.RoleID;
            existingUser.UpdatedAt = user.UpdatedAt;

            _context.SaveChanges();

            return Ok(existingUser);
        }

        // DELETE: api/users/5
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var user = _context.Users.Find(id);
            if (user == null)
                return NotFound();

            _context.Users.Remove(user);
            _context.SaveChanges();

            return Ok();
        }
    }
}