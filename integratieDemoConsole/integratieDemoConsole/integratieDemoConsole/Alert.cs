﻿using System;
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
         var alertItem = Array.Find(items, item => item.itemId == itemId);
          var alertUser = Array.Find(users, user => user.registratieId == userId);
          double change = alertItem.populariteit / alertItem.populariteitOud;
          if (change >= relatieveVerandering)
          {
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
