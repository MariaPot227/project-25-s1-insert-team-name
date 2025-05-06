using System;

namespace TeamCSFile
{
    internal class Program
    {
        static void Main()
        {
            //Liam types here|          Latest programming lab (I added some intentional errors so that no one can cheat
            Console.WriteLine("What would you like the starting character to be?"); //Start character input
            char startChar = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("What would you like the finishing character to be?"); //End character input
            char endChar = Convert.ToChar(Console.ReadLine());
            Console.Clear();
            for (char i = startChar; i <= endChar; i++) //Sets the rows up
            {
                for (char j = startChar; j+1 <= i; j++) //Increments the chars
                {
                    Console.Write($"{startChar++}"); //Prints them as they go
                }
                Console.WriteLine(); //Separates the lines
            }
            Console.ReadLine();
            //Mohammad types here
           
            Console.WriteLine("Hello my name is Mohammad");
            
            {
                Console.WriteLine("Welcome to the Heads or Tails Game!");

                Console.Write("Enter your guess (h for Heads, t for Tails): ");
                char guess = char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine();

                Random random = new Random();
                int computer = random.Next(2);

                char coin = (computer == 0) ? 'h' : 't';
                string coinResult = (coin == 'h') ? "Heads" : "Tails";


                Console.WriteLine($"Computer tossed a {coinResult}");


                if (coin == guess)
                {
                    Console.WriteLine("You won!");
                }
                else
                {
                    Console.WriteLine("You lost.");
                }


                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }










            //Michael
            Console.WriteLine("Hello, my name is Michael and I'm working in a group project.");
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Look at me, I can count!");
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("I also can count down!");
            Console.WriteLine("Goodbye.");



            //Jot types here
            Console.WriteLine("Hello my name is Akaljot but you can call me jot.");
            Console.WriteLine("I am from India from a state called Punjab and I came here as a international student to start my career in IT field");
            Console.WriteLine("So my Idea about game project is to make a sci-fi game which will include ...............");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j <=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            Console.ReadLine();












        }
    }


}
    

