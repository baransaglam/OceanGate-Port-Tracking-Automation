using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class Users
    {
        public int UserID { get; set; }
        public string FullName { get; set; }
        public int TCNumber { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }  
        public int RoleID { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
