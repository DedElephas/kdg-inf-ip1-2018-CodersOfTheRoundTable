using System;
using Domain;



namespace integratieDemoConsole
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Demo Alerttriggering!");
            AlertManager alertManager = new AlertManager();
            UserManager userManager = new UserManager();
            ItemManager itemManager = new ItemManager();

            //1. MakeItem
            Console.WriteLine("// items, user & alert worden aangemaakt");
            itemManager.AddItem("Bart De Wever", 0.5, 100);
            itemManager.AddItem("Bart De Pauw", 0.5, 100);
            Console.WriteLine(itemManager.GetItem(0).naam + " zijn populariteit is " + itemManager.GetItem(0).populariteit + " en zijn vermeldingen zijn: " + itemManager.GetItem(0).vermelding);


            //2. MakeUser
            userManager.AddUser("Simon Somville");
            userManager.AddUser("Seppe Maes");


            //3. MakeAlert
            alertManager.AddAlert(new Alert(1, userManager.GetUser(0), 0.75, AlertType.androidNotificatie));
            alertManager.AddAlert(new Alert(0, userManager.GetUser(1), 0.25));


            //4. UpdateItem
            itemManager.UpdateItems();


            //5. CheckAlert
            //5.1 Trigger Alert
            alertManager.checkAlerts(itemManager.GetItems(), userManager.GetUsers());


            //6. AlertNotifiesUser



            // wacht op input voor het sluiten van de console
            Console.WriteLine("\nDruk op ENTER voor de console te sluiten");
            Console.ReadLine();
        }
    }
}
