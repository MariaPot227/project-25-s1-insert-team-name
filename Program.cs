using System;
using System.IO.Pipes;
using System.Threading;
namespace TeamCSFile
{
    internal class Program
    {


        public static int[] InventoryAmount = {0, 0, 0, 0};
        public static string[] InventoryName = {"Item 1", "Item 2", "Item 3", "Item 4"};

        public static int Health = 100;

        public static int Stamina = 100;
        static void Main()
        {
            Console.WriteLine("You have entered K-mart and you need to collect a few items");
            Hub();
            







        }






        static void Hub()
        {







        }






        static void Inventory()
        {
            Console.Clear();
            for (int i = 0; i < InventoryAmount.Length; i++)
            {
                Console.WriteLine($"You have {InventoryAmount[i]} {InventoryName[i]}s.");
            }
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();

        }






        static void Combat()
        {
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.Red;

            Console.Clear();

            Thread.Sleep(100);

            Console.BackgroundColor = ConsoleColor.Yellow;

            Console.Clear();

            Thread.Sleep(100);

            Console.BackgroundColor = ConsoleColor.Green;

            Console.Clear();

            Thread.Sleep(100);

            Console.BackgroundColor = ConsoleColor.Blue;

            Console.Clear();

            Thread.Sleep(100);

            Console.BackgroundColor = ConsoleColor.Magenta;

            Console.Clear();

            Thread.Sleep(100);

            Console.BackgroundColor = ConsoleColor.Cyan;

            Console.Clear();

            Thread.Sleep(100);

            Console.BackgroundColor = ConsoleColor.Black;

            Console.Clear();

            Console.BackgroundColor = ConsoleColor.Red;

            Console.Clear();

            Thread.Sleep(100);

            Console.BackgroundColor = ConsoleColor.Yellow;

            Console.Clear();

            Thread.Sleep(100);

            Console.BackgroundColor = ConsoleColor.Green;

            Console.Clear();

            Thread.Sleep(100);

            Console.BackgroundColor = ConsoleColor.Blue;

            Console.Clear();

            Thread.Sleep(100);

            Console.BackgroundColor = ConsoleColor.Magenta;

            Console.Clear();

            Thread.Sleep(100);

            Console.BackgroundColor = ConsoleColor.Cyan;

            Console.Clear();

            Thread.Sleep(100);

            Console.BackgroundColor = ConsoleColor.Black;

            Console.Clear();

            Console.ReadLine();

            // ^ Intro to combat scenario

            // v Attack List

            int Light = 1, Strong = 2;

            









        }





        static void Clothing()
        {







        }





        static void Outdoor()
        {







        }





        static void Toys()
        {







        }




        
        static void Electronics()
        {


            // Needs a boss: 
            // Enemies: 
            // Electronics related riddles 
            // Descriptions of areas and whats around as you go 
            // different options on what to do in areas or riddles 
            // Items to pick up or skip 
            // Extra pop-up quest to help someone adds for good ending or gives bonus loot
            



        }















































    }


}
    

