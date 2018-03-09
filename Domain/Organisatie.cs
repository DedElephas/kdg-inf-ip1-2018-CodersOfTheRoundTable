using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Organisatie : Item
    {
        public DateTime OprichtingsDatum { get; set; }
        //public GeoLocation HoofdZetel { get; set; }
        public int AantalWerknemers { get; set; }
        public Persoon VoorZitter { get; set; }
        public SocialeMediaLinks socialeMedia { get; set; }
        public List<Persoon> leden { get; set; }
    }
}
