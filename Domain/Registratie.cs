using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Registratie
    {
        public DateTime RegistrationDate { get; set; }
        
        public int RegistrationId { get; set; }
        public int UserId { get; set; }
        protected String UserEmail { get; set; }
        protected String Password { get; set; }
        public Boolean Verified { get; set; }
        public int Role { get; set; }
        public String Username { get; set; }

    }
}
