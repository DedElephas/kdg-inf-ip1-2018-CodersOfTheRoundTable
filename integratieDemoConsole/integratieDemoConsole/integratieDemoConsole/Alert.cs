using System;
using System.Collections.Generic;
using System.Text;

namespace integratieDemoConsole
{
    class Alert
    {
       public int itemId { get; set; }
       public int userId { get; set; }
       public int relatieveVerandering { get; set; }
       public int absoluteVerandering { get; set; }

       public Alert(int itemId, int userId, int relatieveVerandering)
       {
          this.itemId = itemId;
          this.userId = userId;
          this.relatieveVerandering = relatieveVerandering;
       }

       public Boolean checkAlert()
       {


          return false;
       }
    }
}
