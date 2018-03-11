using System;



namespace integratieDemoConsole
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Demo Alerttriggering!");
           //1. MakeItem
           var BDW = new Item(1,"Bart De Wever",0.5,100);
           Item[] items = new Item[5];
           items[0] = BDW;
           //2. MakeUser
           var SimonSomville = new User(1);
           User[] users = new User[5];
           users[0] = SimonSomville;
           //3. MakeAlert
           var userAlert = new Alert(1, 1, 0.75);
           //4. UpdateItem
           BDW.update(-0.15, 150);
           //4.1 CheckAlert
           userAlert.checkAlert();
           //4.1.1 Trigger Alert
           //6. AlertNotifiesUser
        }
    }
}
