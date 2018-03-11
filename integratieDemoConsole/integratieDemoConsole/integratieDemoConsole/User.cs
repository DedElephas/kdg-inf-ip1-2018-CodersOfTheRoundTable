using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace integratieDemoConsole
{
    class User
    {
       private Domain.Registratie registratie;
       public int registratieId;

       public User(int registratieId)
       {
          this.registratie = new Registratie();
          this.registratieId = registratieId;

       }

        public User(int registratieId, String userName)
        {
            this.registratie = new Registratie();
            registratie.Username = userName;
            this.registratieId = registratieId;
        }

        public String getNaam()
        {
            return this.registratie.Username;
        }
   }
}
