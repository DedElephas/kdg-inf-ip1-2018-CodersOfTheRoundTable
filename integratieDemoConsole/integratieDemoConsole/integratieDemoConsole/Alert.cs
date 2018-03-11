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
          Console.Write(alertItem.naam);
         User alertUser = null;
          foreach (var VARIABLE in users)
          {
             if (VARIABLE.registratieId == userId)
             {
                alertUser = VARIABLE;
             }
          }
          Console.Write(alertUser.getNaam());


         double change = alertItem.populariteit / alertItem.populariteitOud;
          if (change >= relatieveVerandering)
          {
             Console.Write("groter");
             notifyUser(alertItem, alertUser,change);
             return true;
          }

          return false;
       }

       private Boolean notifyUser(Item item, User user, Double change)
       {
          Console.Write("Geachte user " + user.getNaam() + ", uw alert op " + item.naam + " is afgegaan: het item is met " + change + " veranderd." );
         return true;
       }
    }
}
