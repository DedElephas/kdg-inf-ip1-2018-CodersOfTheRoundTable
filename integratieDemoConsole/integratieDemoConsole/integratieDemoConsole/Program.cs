using System;



namespace integratieDemoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo Alerttriggering!");
           //1. MakeItem
           var BDW = new Item(1,"Bart De Wever",0.5,100);
         //2. MakeUser
           var SimonSomville = new User(1);
         //3. MakeAlert
           var userAlert = new Alert(1, 1, 0.75);
            //4. UpdateItem
            Console.Write("Hoeveel punten is " + BDW.naam + " gestegen in populariteit? aantal:");
            double stijging = Convert.ToDouble(Console.ReadLine());
            BDW.populariteit = stijging;
           //5. CheckAlert
           //5.1 Trigger Alert
           //6. AlertNotifiesUser
        }
    }
}
