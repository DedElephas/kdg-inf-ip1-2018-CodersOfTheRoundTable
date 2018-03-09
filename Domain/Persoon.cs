using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Persoon : Item
    {
        public DateTime GeboorteDatum { get; set; }
        public SocialeMediaLinks SocialeMedia { get; set; }
    }
}
