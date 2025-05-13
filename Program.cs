using System;
using System.Threading;
namespace TeamCSFile
{
    internal class Program
    {
        static void Main()
        {
            






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







        }






        static void Combat()
        {







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
    

