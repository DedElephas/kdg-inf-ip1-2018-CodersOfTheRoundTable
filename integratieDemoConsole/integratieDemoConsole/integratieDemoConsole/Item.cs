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
      public double populariteit { get; set; }
      public int vermelding { get; set; }

       public Item(int itemId, string naam, int populariteit, int vermelding)
       {
          this.itemId = itemId;
          this.naam = naam;
          this.populariteit = populariteit;
          this.vermelding = vermelding;
       }

       public Boolean update(Item oudItem)
       {
         
          return false;
       }
    }
}
