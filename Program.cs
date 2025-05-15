using System;
using System.IO.Pipes;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
namespace TeamCSFile
{
    internal class Program
    {

        // The inventory amount holds how much of an item you have, the inventory name holds the name of the item.
        public static int[] InventoryAmount = { 0, 0, 0, 0 };
        public static string[] InventoryName = { "Item 1", "Item 2", "Item 3", "Item 4" };
        //This one is for combat
        public static int[] CombatInventoryAmount = { 3, 0, 2};
        public static string[] CombatInventoryName = { "Small potion", "Medium potion", "Large potion"};


        //Global Combat Variables
        public static int Health = 100;

        public static int Stamina = 100;

        public static int Room = 0; // < lets combat method know which room the player is in and thus which set of enemies to pull from
        //------------------------------

        static void Main()
            { // Intro :

                Console.WriteLine("Your goal is to get an item form four  rooms/sections each room has different obstacles Find all four items and, make it to checkout and you win " +
                    "GOOD LUCK ");
                Console.WriteLine("Press Enter to proceed");
                Console.ReadLine();
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

            int num = 10;
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
                catch (Exception)
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

                    case 0:
                        Exit();
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
                                      "0  Back to the menu");




                    try
                    {
                        num = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
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

        static void CombatInventory()
        {
            Console.Clear();
            int temp = 0;
            Console.WriteLine($"Your health is {Health}HP.");
            for (int i = 0; i < CombatInventoryAmount.Length; i++)
            {
                if (CombatInventoryAmount[i] != 0)
                {
                    Console.WriteLine($"Enter {i + 1} to use one of your {CombatInventoryAmount[i]} {CombatInventoryName[i]}s.");
                }
                
            }
            Console.WriteLine("Enter the item you want to do or 0 if you want to exit.");
            temp = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (temp)
            {
                case 1:
                    if (CombatInventoryAmount[temp - 1] > 0)
                    {
                        Console.WriteLine($"You use one of your {CombatInventoryName[temp - 1]}s");
                        Health = Health + 10;
                        if (Health > 100)
                        {
                            Health = 100;
                        }
                        Console.WriteLine($"You gain 10 Health. You have now have {Health}HP.\nEnter to continue");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough of that potion");
                        Console.ReadLine();
                    }
                    break;
                case 2:
                    if (CombatInventoryAmount[temp - 1] > 0)
                    {
                        Console.WriteLine($"You use one of your {CombatInventoryName[temp - 1]}s");
                        Health = Health + 25;
                        if (Health > 100)
                        {
                            Health = 100;
                        }
                        Console.WriteLine($"You gain 25 Health. You have now have {Health}HP.\nEnter to continue");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough of that potion");
                        Console.ReadLine();
                    }
                    break;
                case 3:
                    if (CombatInventoryAmount[temp - 1] > 0)
                    {
                        Console.WriteLine($"You use one of your {CombatInventoryName[temp - 1]}s");
                        Health = Health + 50;
                        if (Health > 100)
                        {
                            Health = 100;
                        }
                        Console.WriteLine($"You gain 50 Health. You have now have {Health}HP.\nEnter to continue");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough of that potion");
                        Console.ReadLine();
                    }
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("Invalid Input. Please keep it between 0-3");
                    Console.ReadLine();
                    break;

            }

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

            Thread.Sleep(1500);

            Console.ReadLine();

            // ^ Intro to combat scenario




            // v Attack List

            int Light = 10, Strong = 20; // < values are how much damage each attack does (and stamina drained?)




            // v Amount of enemies, random number per battle

            int enemies = 0;        // < number of enemies in battle

            string[] onfield = { "null", "null", "null" };    // < array of the enemies that are on the field, will be populated by pulling from room's array of possible enemies

            int PullEnemy = 0;

            Random rand = new Random();

            enemies = rand.Next(1, 4);  // < generates number of enemies that will appear in the battle, from 1 - 3 (4 exclusive)

            int enem1Health = 0, enem2Health = 0, enem3Health = 0, bossHealth = 0;              //< initialize enemy healthbars

            for (int i = 0; i < enemies; i++)     // will loop as many times as there are enemies in the battle as decided by rng earlier (1-3 ^)
            {
                switch (Room)   // < depending on current room
                {
                    case 1:             // < if player is in Room 1 (Clothing Section)

                        PullEnemy = rand.Next(Room1Enemies.Length);     // < generates random number to pick random enemy from available

                        onfield[i] = Room1Enemies[PullEnemy];               // < assigns a random enemy as decided from the previous line to the current field slot

                        break;

                    case 2:             

                        PullEnemy = rand.Next(Room2Enemies.Length);     

                        onfield[i] = Room2Enemies[PullEnemy];               

                        break;

                    case 3:

                        PullEnemy = rand.Next(Room3Enemies.Length);

                        onfield[i] = Room3Enemies[PullEnemy];

                        break;

                    case 4:

                        PullEnemy = rand.Next(Room4Enemies.Length);

                        onfield[i] = Room4Enemies[PullEnemy];

                        break;

                    default:
                        break;

                }





            }




            // v Enemy Names and amount

            switch (enemies)                        // < changes starting text depending on number of enemies
            {

                case 1:                            // < if there is only one enemy

                    Console.WriteLine($"\n\nA wild {onfield[0]} approaches!");  // < tells user what enemy they are facing

                    enem1Health = 50;

                    break;

                case 2:

                    Console.WriteLine($"\n\nYou are stopped by {onfield[0]} and {onfield[1]}.");

                    enem1Health = 50;

                    enem2Health = 50;

                    break;

                case 3:

                    Console.WriteLine($"\n\nYou run into {onfield[0]}, {onfield[1]} and {onfield[2]}");

                    enem1Health = 50;

                    enem2Health = 50;

                    enem3Health = 50;

                    break;


                default:
                    // < for boss battles?
                    break;




            }


            Thread.Sleep(1000);                         

            Console.Clear();

            CombatUI();

        }

        static void CombatUI()
        {
            string border = new string('-', 60);        
        
            //do 
            //{ 
            
            
            
            
            
            
            
            
            
            
            
            
            //}
            
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        











        }



        static void Clothing()
        {
            Console.Clear();
            Console.WriteLine("You enter the Clothing section in order to find the ______.");






        }





        static void Camping()
        {







        }





        static void Toys()
        {







        }





        static void Electronics()
        {
            bool sectionActive = true; // keeps the section active until the player leaves
            int playerChoice = 0; // player choice
            Console.Clear();
            Console.WriteLine("You step into the Electronics section.");
            Thread.Sleep(2000);
            Console.WriteLine("Rows of glittering screens, RGB keyboards and tangled cables stretch before you.");
            Thread.Sleep(3000);
            Console.WriteLine($"You’re here for: ");  // e.g. “Smart Phone”
            Thread.Sleep(2000);
            do
            {
                Console.WriteLine("As you scan the shelves, you see:\n  " +
                                  "A) A neat stack of USB cables.\n  " +
                                  "B) A half-broken display of portable chargers.\n  " +
                                  "C) A frazzled Granny clutching a tangled headset.\n");
                Console.WriteLine("Press Enter to continue.");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("What do you want to do?\n  " +
                                  "1) Approach the USB cables.\n  " +
                                  "2) Investigate the portable chargers.\n  " +
                                  "3) Help the Granny with her headset.\n  " +
                                  "0) Leave the section.\n");
                Thread.Sleep(2000);
                Console.Clear();

                playerChoice = Convert.ToInt32(Console.ReadLine());

                switch (playerChoice)
                {
                    case 0:
                        Console.WriteLine("You decide to leave the Electronics section.");
                        sectionActive = false;
                        break;
                    case 1:
                        Console.WriteLine("You approach the USB cables. ");
                        //Console.WriteLine("You pick up a USB cable.");
                        
                        break;

                    case 2:
                        Console.WriteLine("You investigate the portable chargers. ");
                        
                        
                        break;
                    case 3:
                        Console.WriteLine("You help the Granny with her headset.");// riddle? 
                        
                        
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

            } while (sectionActive);

            Console.ReadLine();
        }


        string[] kmartItems = new string[]
           {
                //Electronics

                 "Bluetooth Speaker",
                 "Smart Phone",
                 "gaming Console",
                 "Smart Watch",
                 "Portable Charger",
                 
                 //Clothing

                 "Men's Hoodie",
                 "Women's Jeans",
                 "Running Shoes",
                 "Baseball cap",
                 "Swimsuit",

                 //Camping
                
                 "Sleeping Bag",
                 "Tent",
                 "Camping Stove",
                 "Flashlight",
                 "portable Cooler",

                 //Toys

                 "Remote Control Car",
                 "Building Blocks Set",
                 "Action Figure",
                 "Board Game",
                 "Plush Teddy Bare",
           };


















































            }
}



