using System;
using System.Collections.Generic;
using System.Text;

namespace integratieDemoConsole
{
    class Alert
    {
       public int itemId { get; set; }
       public int userId { get; set; }
       public double relatieveVerandering { get; set; }
       public int absoluteVerandering { get; set; }

       public Alert(int itemId, int userId, double relatieveVerandering)
       {
          this.itemId = itemId;
          this.userId = userId;
          this.relatieveVerandering = relatieveVerandering;
       }

       public Boolean checkAlert(Item[] items, User[] users)
       {
          Item alertItem = null;
          foreach (var VARIABLE in items)
          {
             if (VARIABLE.itemId == itemId)
             {
                alertItem = VARIABLE;
             }
          }
          Console.WriteLine("// alert haalt item op: " + alertItem.naam);
         


         double change = (double)alertItem.vermelding / (double)alertItem.vermeldingOud;

 

         if (change >= relatieveVerandering)
          {
             Console.WriteLine( "// checkt of de alert triggert => het is groter");
             notifyUser(alertItem,users,change);
             return true;
          }

          return false;
       }

       private Boolean notifyUser(Item item,User[] users, Double change)
       {
          User alertUser = null;
          foreach (var VARIABLE in users)
          {
             if (VARIABLE.registratieId == userId)
             {
                alertUser = VARIABLE;
             }
          }
          Console.WriteLine("// alert haalt user op als het triggert: " + alertUser.getNaam());
         Console.WriteLine("Geachte user " + alertUser.getNaam() + ", uw alert op " + item.naam + " is afgegaan: het item is met " + (change-1)*100 + "% veranderd." );
         return true;
       }
    }
}
