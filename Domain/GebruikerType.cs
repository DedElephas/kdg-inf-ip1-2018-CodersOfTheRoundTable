using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public enum GebruikerType: byte
    {
        NotRegistred = 0,
        Registred,
        Admin,
        SuperAdmin
    }
}
