using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace integratieDemoConsole
{
    class Alert
    {
        public int itemId { get; set; }
        public int userId { get; set; }
        public double relatieveVerandering { get; set; }
        public int absoluteVerandering { get; set; }
        public AlertType alertType { get; set; }

        public Alert(int itemId, User user, double relatieveVerandering)
        {
            this.itemId = itemId;
            this.userId = user.registratieId;
            this.relatieveVerandering = relatieveVerandering;
            this.alertType = AlertType.webNotificatie;
        }
        public Alert(int itemId, User user, double relatieveVerandering, AlertType alertType)
        {
            this.itemId = itemId;
            this.userId = user.registratieId;
            this.relatieveVerandering = relatieveVerandering;
            this.alertType = alertType;
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
                Console.WriteLine("// checkt of de alert triggert => het is groter");
                notifyUser(alertItem, users, change);
                return true;
            }

            return false;
        }

        private Boolean notifyUser(Item item, User[] users, Double change)
        {
            User alertUser = null;
            foreach (var user in users)
            {
                if (user.registratieId == userId)
                {
                    alertUser = user;
                }
            }

            switch (this.alertType)
            {
                case AlertType.webNotificatie:
                    Console.WriteLine("//De user wil een web notificatie");
                    break;
                case AlertType.androidNotificatie:
                    Console.WriteLine("//De user wil een android notificatie");
                    break;
                case AlertType.email:
                    Console.WriteLine("//De user wil een email");
                    break;
            }

            Console.WriteLine("// alert haalt user op als het triggert: " + alertUser.getNaam());
            Console.WriteLine("Geachte user " + alertUser.getNaam() + ", uw alert op " + item.naam + " is afgegaan: het item is met " + (change - 1) * 100 + "% veranderd. (Dit bericht wordt verstuurd via " + this.alertType.ToString());
            return true;
        }

    }
}
