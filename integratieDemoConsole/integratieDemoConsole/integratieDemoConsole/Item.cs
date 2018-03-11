using System;
using System.Collections.Generic;
using System.Text;

namespace integratieDemoConsole
{
    class Item
    {
      public int itemId { get; set; }
      public int type { get; set; }
      public String naam { get; set; }
      public double populariteitOud { get; set; }
      public double populariteit { get; set; }
      public int vermeldingOud { get; set; }
      public int vermelding { get; set; }

      public Item(int itemId, string naam, double populariteit, int vermelding)
       {
          this.itemId = itemId;
          this.naam = naam;
          this.populariteit = populariteit;
          this.vermelding = vermelding;
       }

       public Boolean update(double populariteitNew, int vermeldingNew)
       {
         populariteitOud += populariteit;
         populariteit += populariteitNew;
         vermeldingOud += vermelding;
         vermelding += vermeldingNew;
         Console.WriteLine("// item ge-update");

         return true;
       }
    }
}
