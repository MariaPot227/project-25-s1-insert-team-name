using System;
using System.IO.Pipes;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
namespace TeamCSFile
{
    internal class Program
    {


        public static int[] InventoryAmount = { 0, 0, 0, 0 };
        public static string[] InventoryName = { "Item 1", "Item 2", "Item 3", "Item 4" };


        //Global Combat Variables
        public static int Health = 100;

        public static int Stamina = 100;

        public static int Room = 0; // < lets combat method know which room the player is in and thus which set of enemies to pull from
        //------------------------------

        static void Main()
        {
            Console.WriteLine("You have entered K-mart and you need to collect a few items");
            Hub();








        }






        static void Hub()
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
                                  "4  Show areas completed\n" +
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
                        //Rest(); // replenishes HP?
                        break;

                    case 2:
                        RoomSelection();
                        break;

                    case 3:
                        Inventory();
                        break;

                    case 4:
                        //AreasCompleted();
                        break;

                    case 5:
                        //ShoppingList();
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

            static void Exit()
            {
                Console.WriteLine("Please press any key to exit");
                Console.ReadLine();
            }
            string RoomSelection()
            {
                int num = 0;
                bool inMenu = true;

                do
                {
                    Console.Clear();

                    Console.WriteLine("Main Menu\n" + "Please select from the numbers below\n");
                    Console.WriteLine("1  Clothing\n" +
                                      "2  Electronics\n" +
                                      "3  Toys\n" +
                                      "4  Camping\n" +
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

                    switch (num)
                    {
                        case 1:
                            Clothing();
                            Room = 1;
                            Console.WriteLine("This is Clothing\n" + "Press 0 to exit");
                            return "Clothing";


                        case 2:
                            Electronics();
                            Room = 2;
                            Console.WriteLine("This is Electronics\n" + "Press 0 to exit");
                            return "Electronics";

                        case 3:
                            Toys();
                            Room = 3;
                            Console.WriteLine("This is Toys\n" + "Press 0 to exit");
                            return "Toys";

                        case 4:
                            Camping(); 
                            Room = 4;
                            Console.WriteLine("This is Camping\n" + "Press 0 to exit");
                            return "Camping";

                        case 0:
                            //Console.WriteLine("This is task 1\n" + "Press 0 to exit");

                            //return to menu;
                            inMenu = false;
                            return "Exiting";
                        default:
                            Console.WriteLine("Invalid Input. Please keep it between 0-4");
                            Console.ReadLine();
                            return "Invalid";

                    }

                } while (inMenu);


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
            string[] Room1Enemies = { "TestEnemy1", "TestEnemy2", "TestEnemy3", "TestEnemy4", "TestEnemy5" };

            string[] Room2Enemies = { "TestEnemy1", "TestEnemy2", "TestEnemy3", "TestEnemy4", "TestEnemy5" };

            string[] Room3Enemies = { "TestEnemy1", "TestEnemy2", "TestEnemy3", "TestEnemy4", "TestEnemy5" };

            string[] Room4Enemies = { "TestEnemy1", "TestEnemy2", "TestEnemy3", "TestEnemy4", "TestEnemy5" };

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

            int enemies = 0;        // < number of enemies in battle

            string[] onfield = { "null", "null", "null" };    // < array of the enemies that are on the field, will be populated by pulling from room's array of possible enemies

            Random rand = new Random();

            enemies = rand.Next(1, 4);  // < generates number of enemies that will appear in the battle, from 1 - 3 (4 exclusive)

            for (int i = 0; i < enemies; i++)     // will loop as many times as there are enemies in the battle as decided by rng earlier (1-3 ^)
            {
                switch (Room)   // < depending on current room
                {
                    case 1:             // < if player is in Room 1 (Clothing Section)

                        int PullEnemy = rand.Next(Room1Enemies.Length);     // < generates random number to pick random enemy from available

                        onfield[i] = Room2Enemies[PullEnemy];               // < assigns a random enemy as decided from the previous line to the current field slot

                        break;

                    default:
                        break;

                }





            }




            // v Combat UI

            switch (enemies)                        // < changes starting text depending on number of enemies
            {

                case 1:                            // < if there is only one enemy

                    Console.WriteLine($"\n\nA wild {onfield[0]} approaches!");  // < tells user what enemy they are facing

                    break;

                case 2:

                    Console.WriteLine($"\n\nYou are stopped by {onfield[0]} and {onfield[1]}.");

                    break;

                case 3:

                    Console.WriteLine($"\n\nYou run into {onfield[0]}, {onfield[1]} and {onfield[2]}");

                    break;


                default:
                    // < for boss battles?
                    break;




            }































        }





        static void Clothing()
        {







        }





        static void Camping()
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



