using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace integratieDemoConsole
{
    class User
    {
        private Domain.Registratie registratie ;
        private int registratieId;

        public User(Registratie registratie, int registratieId)
        {
            this.registratie = registratie;
            this.registratieId = registratieId;
        }
    }
}
