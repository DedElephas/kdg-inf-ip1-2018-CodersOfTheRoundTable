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
         var alertItem = Array.Find(items, item => item.itemId == this.itemId);
          var fooItem = Array.Find(users, user => user. == "bar");
         return false;
       }
    }
}
