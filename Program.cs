using System;
using System.IO.Pipes;
using System.Threading;
namespace TeamCSFile
{
    internal class Program
    {


        public static int[] InventoryAmount = {0, 0, 0, 0};
        public static string[] InventoryName = {"Item 1", "Item 2", "Item 3", "Item 4"};


        //Global Combat Variables
        public static int Health = 100;

        public static int Stamina = 100;
        //------------------------------

        static void Main()
        {
            Console.WriteLine("You have entered K-mart and you need to collect a few items");
            Hub();
            







        }






        public static void Hub()
        {

            // move rooms - to which room new method
            // rest? 
            // place to check inventory 
            // show  list of rooms completed
            // cross off shopping list
            // 

            int num = 0;
            bool inMenu = true;
            
            do
            {
                Console.Clear();

                Console.WriteLine("Main Menu\n" + "Please select from the numbers below\n");
                Console.WriteLine("1  Rest\n" +
                                  "2  Room Selection\n" +
                                  "3  Check Your inventory\n" +
                                  "4  Show rooms completed\n" +
                                  "5  Shopping list\n" +
                                  "0  Exit The Menu");

                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Huh");
                    Console.ReadLine();
                }

                Console.Clear();

                switch (num)
                {
                    case 1:
                        //Task1();
                        break;

                    case 2:
                        //Task2();
                        break;

                    case 3:
                        //Task3();
                        break;

                    case 4:
                        //Task4();
                        break;

                    case 0:
                        //Exit();
                        inMenu = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input. Please keep it between 0-4");
                        Console.ReadLine();
                        break;
                }


            } while (inMenu);

            string RoomSelection()
            {
                switch (num)
                {
                    case 1:
                        //Task1();
                        break;

                    case 2:
                        //Task2();
                        break;

                    case 3:
                        //Task3();
                        break;

                    case 4:
                        //Task4();
                        break;

                    case 0:
                        //Exit();
                        inMenu = false;
                        break;
                    
                }



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

            int Light = 10, Strong = 20; // < values are how much damage each attack does (and stamina drained?)

            // v Amount of enemies, random number per battle

            int enemies = 0;

            Random rand = new Random();

            enemies = rand.Next(1, 4);

            
            







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
    

