using System;
using Domain;



namespace integratieDemoConsole
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Demo Alerttriggering!");
            AlertRepository alertRepo = new AlertRepository();
            UserRepository userRepo = new UserRepository();

            //1. MakeItem
            Console.WriteLine("// items, user & alert worden aangemaakt");
            var BDW = new Item(1, "Bart De Wever", 0.5, 100);
            Console.WriteLine(BDW.naam + " zijn populariteit is " + BDW.populariteit + " en zijn vermeldingen zijn: " + BDW.vermelding);
            Item[] items = new Item[1];
            items[0] = BDW;


            //2. MakeUser
            userRepo.AddUser("Simon Somville");
            userRepo.AddUser("Seppe Maes");


            //3. MakeAlert
            alertRepo.AddAlert(new Alert(1, userRepo.GetUser(0), 0.75, AlertType.androidNotificatie));
            alertRepo.AddAlert(new Alert(1, userRepo.GetUser(1), 0.25));


            //4. UpdateItem
            BDW.update(-0.15, 150);


            //5. CheckAlert
            //5.1 Trigger Alert
            alertRepo.checkAlerts(items, userRepo.GetUsers());


            //6. AlertNotifiesUser



            // wacht op input voor het sluiten van de console
            Console.WriteLine("\nDruk op ENTER voor de console te sluiten");
            Console.ReadLine();
        }
    }
}
