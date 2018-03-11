﻿using System;



namespace integratieDemoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo Alerttriggering!");
           //1. MakeItem
           Console.WriteLine("// items, user & alert worden aangemaakt");
           var BDW = new Item(1,"Bart De Wever",0.5,100);
            Console.WriteLine(BDW.naam + " zijn populariteit is " + BDW.populariteit + " en zijn vermeldingen zijn: " + BDW.vermelding);
           Item[] items = new Item[1];
           items[0] = BDW;
            //2. MakeUser
            var SimonSomville = new User(1, "Simon Somville");
           User[] users = new User[1];
           users[0] = SimonSomville;
         //3. MakeAlert
         var userAlert = new Alert(1, 1, 0.75);
            //4. UpdateItem
            BDW.update(-0.15, 150);
         //5. CheckAlert
         //5.1 Trigger Alert
           userAlert.checkAlert(items, users);
            //6. AlertNotifiesUser

            // wacht op input voor het sluiten van de console
            Console.WriteLine("\nDruk op ENTER voor de console te sluiten");
            Console.ReadLine();
        }
    }
}
