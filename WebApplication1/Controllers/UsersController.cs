using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class UsersController : ApiController
    {

        OceanGateDBEntities _context;

        public UsersController()
        {
            _context = new OceanGateDBEntities();
            _context.Configuration.ProxyCreationEnabled = false; 
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(_context.Users.ToList());
        }

    }
}