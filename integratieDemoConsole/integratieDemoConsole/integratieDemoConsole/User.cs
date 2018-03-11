using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace integratieDemoConsole
{
    class User
    {
       private Domain.Registratie registratie;
       private int registratieId;
       private Alert userAlert;

       public User(int registratieId)
       {
          this.registratie = new Registratie();
          this.registratieId = registratieId;

       }
   }
}
