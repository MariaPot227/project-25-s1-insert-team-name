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


            int num = 0;
            bool inMenu = true;
            // can only use clear console twice
            do
            {
                Console.Clear();

                Console.WriteLine("Main Menu\n" + "Please select from the numbers below\n");
                Console.WriteLine("1  Task 1\n" +
                                  "2  Task 2\n" +
                                  "3  Task 3\n" +
                                  "4  Task 4\n" +
                                  "0 Exit The Menu");

                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid Input");
                    Console.ReadLine();
                }

                Console.Clear();

                switch (num)
                {
                    case 1:
                        Task1();
                        break;

                    case 2:
                        Task2();
                        break;

                    case 3:
                        Task3();
                        break;

                    case 4:
                        Task4();
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
    

