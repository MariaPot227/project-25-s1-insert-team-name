using System;
using System.Globalization;
using System.IO.Pipes;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
namespace TeamCSFile
{
    internal class Program
    {

        // The inventory amount holds how much of an item you have, the inventory name holds the name of the item.
        public static int[] InventoryAmount = { 0, 0, 0, 0 };

        public static string[] InventoryName = { "Baseball Cap", "Bluetooth Speaker", "Item 3", "Yard Chair" }; //Maybe put these inside the inventory method

        //This one is for combat
        public static int[] CombatInventoryAmount = { 3, 0, 2 };
        public static string[] CombatInventoryName = { "Small potion", "Medium potion", "Large potion" };

        //Random added
        public static Random rand = new Random();

        //Global Combat Variables
        public static int Health = 100;

        public static int Stamina = 100;

        public static int Room = 0; // < lets combat method know which room the player is in and thus which set of enemies to pull from
        //------------------------------

        static void Main()
        { // Intro :
            
            Console.WriteLine("Your goal is to get an item from all four rooms/sections. \nEach room has different obstacles. \nFind all four items and make it to checkout to finish shopping" +
                $" GOOD LUCK. \nYou need to find a {InventoryName[0]}, a {InventoryName[1]}, a {InventoryName[2]} and a {InventoryName[3]}");
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
                            Room = 1;
                            Clothing();
                            Console.WriteLine("This is Clothing\n" + "Press 0 to exit");
                            return "Clothing";

                        case 2:
                            Room = 2;
                            Electronics();
                            Console.WriteLine("This is Electronics\n" + "Press 0 to exit");
                            return "Electronics";

                        case 3:
                            Room = 3;
                            Toys();
                            Console.WriteLine("This is Toys\n" + "Press 0 to exit");
                            return "Toys";

                        case 4:
                            Room = 4;
                            Camping();
                            Console.WriteLine("This is Camping\n" + "Press 0 to exit");
                            return "Camping";

                        case 0:

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
            Console.WriteLine($"Your health is {Health}HP.");
            for (int i = 0; i < CombatInventoryAmount.Length; i++)
            {
                if (CombatInventoryAmount[i] != 0)
                {
                    Console.WriteLine($"Enter {i + 1} to use one of your {CombatInventoryAmount[i]} {CombatInventoryName[i]}s.");
                }

            }
            Console.WriteLine("Enter the item you want to do or 0 if you want to exit.");
            int temp = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (temp)
            {
                case 1:
                    if (CombatInventoryAmount[temp - 1] > 0)
                    {
                        Console.WriteLine($"You use one of your {CombatInventoryName[temp - 1]}s");
                        Health = Health + 10;  //Change this and the other values like this for the amount of health you want the potion to do. 
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






        public static void Combat()
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

            // ^ Intro to combat scenario




            // v Attack List

            int Light = 20, Strong = 35; // < values are how much damage each attack does (and stamina drained?)




            // v Amount of enemies, random number per battle

            int enemies = 0;        // < number of enemies in battle

            string[] onfield = { "null", "null", "null" };    // < array of the enemies that are on the field, will be populated by pulling from room's array of possible enemies

            int PullEnemy = 0;

            Random rand = new Random();

            enemies = rand.Next(1, 4);  // < generates number of enemies that will appear in the battle, from 1 - 3 (4 exclusive)

            int enem1Health = 0, enem2Health = 0, enem3Health = 0, bossHealth = 0, target = 0, option = 0;              //< initialize enemy healthbars

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

                    enem1Health = 100;

                    break;

                case 2:

                    Console.WriteLine($"\n\nYou are stopped by {onfield[0]} and {onfield[1]}.");

                    enem1Health = 100;

                    enem2Health = 100;

                    break;

                case 3:

                    Console.WriteLine($"\n\nYou run into {onfield[0]}, {onfield[1]} and {onfield[2]}");

                    enem1Health = 100;

                    enem2Health = 100;

                    enem3Health = 100;

                    break;


                default:
                    // < for boss battles?
                    break;


                

            }

            Thread.Sleep(1000);

            Console.Clear();
            
            // Combat UI v

            string border = new string('-', 60);

            do 
            { 
              Console.Write(border);

              Thread.Sleep(1000);

              Console.Write("\n\n\t\t\t\tENEMIES");

              if (enem1Health > 0 && enem2Health > 0 && enem3Health > 0)        // if all enemies are alive
                {
                    Console.Write($"\n\n\t{onfield[0]}: {enem1Health}HP \t{onfield[1]}: {enem2Health}HP \t{onfield[2]}: {enem3Health}HP");
                }

              else if (enem1Health > 0 && enem2Health > 0 && enem3Health <= 0)  // if only enemy 1 and 2 are alive
                {
                    Console.Write($"\n\n\t{onfield[0]}: {enem1Health}HP \t{onfield[1]}: {enem2Health}HP");
                }

               else if (enem1Health > 0 && enem2Health <= 0 && enem3Health <= 0)    // if only enemy 1 is alive
                {
                    Console.Write($"\n\n\t{onfield[0]}: {enem1Health}HP");
                }

                else if (enem1Health > 0 && enem2Health <= 0 && enem3Health > 0)        // if only enemy 1 and 3 are alive
                {
                    Console.Write($"\n\n\t{onfield[0]}: {enem1Health}HP \t{onfield[2]}: {enem3Health}HP");
                }

                else if (enem1Health > 0 && enem2Health > 0 && enem3Health > 0)        // if only enemy 2 and 3 are alive
                {
                    Console.Write($"\n\n\t{onfield[1]}: {enem2Health}HP \t{onfield[2]}: {enem3Health}HP");
                }

                else if (enem1Health > 0 && enem2Health > 0 && enem3Health > 0)        // if only enemy 2 is alive
                {
                    Console.Write($"\n\n\t{onfield[1]}: {enem2Health}HP");
                }

                else       // if only enemy 3 is alive
                {
                    Console.Write($"\n\n\t{onfield[2]}: {enem3Health}HP");
                }

                Console.Write($"\n\n\n\nYOU\n\nHP: {Health} \t\t STM: {Stamina}\n\n1. Attack\t\t2. Items\t\t3. Guard");

                option = Convert.ToInt16(Console.ReadLine());

                if (option == 1)    // if Attack chosen
                {
                    Console.Clear();

                    Console.WriteLine("Select a target: ");

                    if (enem1Health > 0 && enem2Health > 0 && enem3Health > 0)        // if all enemies are alive
                    {
                        Console.Write($"\n\n\t{onfield[0]}: {enem1Health}HP \t{onfield[1]}: {enem2Health}HP \t{onfield[2]}: {enem3Health}HP");
                    }

                    else if (enem1Health > 0 && enem2Health > 0 && enem3Health <= 0)  // if only enemy 1 and 2 are alive
                    {
                        Console.Write($"\n\n\t{onfield[0]}: {enem1Health}HP \t{onfield[1]}: {enem2Health}HP");
                    }

                    else if (enem1Health > 0 && enem2Health <= 0 && enem3Health <= 0)    // if only enemy 1 is alive
                    {
                        Console.Write($"\n\n\t{onfield[0]}: {enem1Health}HP");
                    }

                    else if (enem1Health > 0 && enem2Health <= 0 && enem3Health > 0)        // if only enemy 1 and 3 are alive
                    {
                        Console.Write($"\n\n\t{onfield[0]}: {enem1Health}HP \t{onfield[2]}: {enem3Health}HP");
                    }

                    else if (enem1Health > 0 && enem2Health > 0 && enem3Health > 0)        // if only enemy 2 and 3 are alive
                    {
                        Console.Write($"\n\n\t{onfield[1]}: {enem2Health}HP \t{onfield[2]}: {enem3Health}HP");
                    }

                    else if (enem1Health > 0 && enem2Health > 0 && enem3Health > 0)        // if only enemy 2 is alive
                    {
                        Console.Write($"\n\n\t{onfield[1]}: {enem2Health}HP");
                    }

                    else       // if only enemy 3 is alive
                    {
                        Console.Write($"\n\n\t{onfield[2]}: {enem3Health}HP");
                    }

                    target = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();

                    Console.WriteLine("Select an attack: ");

                    Console.WriteLine("\n\n1. Light Attack (20 DMG, req. 10 STM)\t\t2. Heavy Attack (40 DMG, req 20 STM)\t\t3. Hail Mary (Do I feel lucky?)");

                    option = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();

                    if (option == 1)    // if Light Attack chosen
                    {
                        Stamina = Stamina - 10;

                        switch (target) //enemy chosen
                        {

                            case 1:
                                enem1Health = enem1Health - 20;
                                break;

                            case 2:
                                enem2Health = enem2Health - 20;
                                break;

                            default:
                                enem3Health = enem3Health - 20;
                                break;
                        }














                    }














                }

































            }
            while (Health > 0 || enem1Health > 0 && enem2Health > 0 && enem3Health > 0);

            Console.Clear();

            if (Health <= 0)
            {
                Console.WriteLine("\n\nYOU DIED");
            }

            else
            {
                Console.WriteLine("\n\nA WINNER IS YOU");
            }

            Console.Clear();


        }



        static void Clothing()
        {
            Console.Clear();
            Console.WriteLine($"You enter the Clothing section in order to find the {InventoryName[0]}."); //Need variable option for what you're finding
            Console.ReadLine();
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("You look around to see racks of clothing all around you, maybe what you're searching for is in these racks.");
                Console.WriteLine("You also see that you can continue forward between these racks, but it looks like the prime spot for you to get jumped.\nDo you");
                Console.WriteLine("1: Search the clothing racks in hopes of finding the lost item.\n2: Continue forward, knowing you are most likely to get jumped.");
                Console.WriteLine("3: Leave.");
                int temp = 0;
                try
                {
                    temp = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Huh");
                    Console.ReadLine();
                }
                Console.Clear();
                switch (temp)
                {
                    case 1:
                        Console.WriteLine("You look in the clothing racks.");
                        Thread.Sleep(1000);
                        temp = rand.Next(1000);
                        if (temp == 365)
                        {
                            Console.WriteLine($"And found a {InventoryName[0]}!");
                            InventoryAmount[0]++;
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("And found nothing.");
                            Console.ReadLine();
                        }
                        break;
                    case 2:
                        Console.WriteLine("You venture between the racks to find the item.");
                        ClothingDeeper();
                        break;
                    case 3:
                        Console.WriteLine("You decided to leave.\nEnter to continue.");
                        running = false;
                        break;
                    default:
                        break;
                }
            }
        }
        static void ClothingDeeper()
        {
            Console.Clear();
            //Continue with it here for clean look.
            Console.WriteLine($"After passing between the aisle you notice a pedestal ahead. On it is a {InventoryName[0]} on display. But it's under a glass container.");
            Console.WriteLine("It looks like there is a dial on the pedestal that unlocks the glass container. Or maybe you just break the glass.\nDo you");
            bool running = true;
            while (running)
            {
                Console.WriteLine("1: Break the glass.\n2: Try the dial.\n3: Leave.");
                int temp = 0;
                try
                {
                    temp = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Huh");
                    Console.ReadLine();
                }
                Console.Clear();
                switch (temp)
                {
                    case 1:
                        Console.WriteLine("You try to break the glass.");
                        Thread.Sleep(1000);
                        temp = rand.Next(100);
                        if (temp == 65)
                        {
                            Console.WriteLine($"And succeed!");
                            Console.WriteLine($"You got a {InventoryName[0]}!");
                            InventoryAmount[0]++;
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("And failed.");
                            Console.ReadLine();
                        }
                        break;
                    case 2:
                        Console.WriteLine("You take a closer look at the dial.");
                        break;
                    case 3:
                        Console.WriteLine("You decided to leave.\nEnter to continue.");
                        running = false;
                        break;
                    default:
                        break;
                }
                Console.Clear();
            }
        }




        static void Camping()
        {
            






        }





        static void Toys()
        {







        }





        static void Electronics()
        {
            bool sectionActive = true, gotItem = false; // keeps the section active until the player leaves
            int playerChoice = 0, pickUp = 0;
            string answer;
            rand = new Random();
            
           
            Console.Clear();
            Console.WriteLine("You step into the Electronics section.");
            //Thread.Sleep(2000);
            Console.WriteLine("Rows of glittering screens, RGB keyboards and tangled cables stretch before you.");
            //Thread.Sleep(3000);
            Console.WriteLine($"\n\nYou’re here looking for a {InventoryName[1]} \n");  // e.g. “Smart Phone”
            //Thread.Sleep(2000);
            do
            {
                Console.WriteLine("As you scan the shelves, you see:\n  " +
                                  "1) A neat stack of USB cables.\n  " +
                                  "2) A half-broken display of portable chargers.\n  " +
                                  "3) A frazzled Granny clutching a tangled headset.\n  " +
                                  "4) A dimly lit aisle that makes it hard to see what’s ahead.");
                Console.WriteLine("\n\n\nPress Enter to continue.");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("What do you want to do?\n  " +
                                  "1) Approach the USB cables.\n  " +
                                  "2) Investigate the portable chargers.\n  " +
                                  "3) Help the Granny with her headset.\n  " +
                                  "4) Go down the dimly lit aisle.\n  " +
                                  "0) Leave the section.\n");
                
                

                try
                {
                    playerChoice = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Input");
                }

                switch (playerChoice)
                {
                    case 0:
                        Console.WriteLine("You decide to leave the Electronics section.");
                        sectionActive = false;
                        break;

                    case 1:
                        Console.WriteLine("You approach the USB cables. ");// combat section maybe 
                        Thread.Sleep(500);
                        Console.WriteLine("You pick up a USB cable that stands out as its the only one there that is un-spooled.");

                        //Combat();
                        break;

                    case 2:
                        Chargers();
                        Console.Write("\nPress enter to continue.");
                        Console.ReadLine();
                        break;

                    case 3:
                        Granny();
                        
                        Console.Write("\nPress enter to continue.");
                        Console.ReadLine();
                        break;

                    case 4:
                        Console.WriteLine("You step cautiously into the dimly lit aisle. The flickering lights above barely illuminate the path ahead.");// boss fight room if you dont get the item earlier
                        //Combat();
                        // InventoryAmount[2]+ 1 when getting the item
                        break;

                    default:
                        Console.WriteLine("Invalid choice, please pick 1, 2 or 3.");
                        break;

                }
                Console.Clear();

                if (gotItem == true)
                {
                    sectionActive = false;
                }

            } while (sectionActive);

            void Chargers()
            {
                Console.WriteLine("You sort through the pile of portable chargers. One claims to charge a fridge. Another has three buttons and no ports.\n" +
                          $"Then — jackpot! Behind a toppled charger display, you spot a {CombatInventoryName[1]} just sitting there like a free sample.\n  You casually slip it into your inventory before anyone notices.");
                Console.WriteLine("You don't see anything else useful in the area.");
                CombatInventoryAmount[1] += 1;
            }

            void Granny()
            {
                Console.WriteLine("You approach the Granny, who’s poking at a wireless headset like it's an alien artifact.\n'Excuse me,' she says, adjusting her comically large glasses,\n'Help me get this contraption working, and I’ll make it worth your while.\n\n");// riddle? 
                Thread.Sleep(2000);
                Console.WriteLine("Now listen here, dear — this thing says it's wireless, but I don’t see how it works without a wire!\nMaybe you can figure it out if you’re clever:\nI travel through air,\nbut I’m not a bird.\nI carry music,\nyet say not a word.\nWhat am I?");// bluetooth 
                answer = Convert.ToString(Console.ReadLine().Trim().ToLower());
                if (answer == "bluetooth" ||  answer == "signal")
                {
                    Console.WriteLine($"Granny blinks, then breaks into a wide grin.\n“Well I’ll be — you got it right! Smarter than the manager around here, that’s for sure.”\nShe digs around in her trolley, moving aside half a loaf of bread and some unlabelled cans.\n“Here, take this. I grabbed it earlier thinking it was a fancy hearing aid, but it’s actually what you’re after.”\nShe hands you the {InventoryName[1]}.\n“Don’t let it bite!”");
                    
                    InventoryAmount[1] += 1;
                    Console.WriteLine("Item acquired! You successfully found what you were looking for.");
                    gotItem = true;
                }
                else
                {
                    Console.WriteLine("Oh heavens, I was hoping you knew. Maybe we should both go back to using tin cans and string!");
                    // exit interaction
                }

            }

            // change kmartItems to an array of arrays so we can pick 1 of each as it loops as atm if we loop through it. we might get 2 from one section but not another.
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



