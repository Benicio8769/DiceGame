using System.Drawing;
using System.Threading.Channels;

namespace DiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int point = 0;
            int pointDealer = 0;
            
            Console.WriteLine("Welcome to Black Jack!");
            Console.WriteLine("Want to play");
            

            string player = Console.ReadLine();
            
            Console.WriteLine("Hit or stay?");


            while (player != "Stay")
            {
              player = Console.ReadLine();
                if (player == "Hit")
                {
                   
                    Random rand = new Random();
                    int randomNumber = rand.Next(1, 7);
                    

                    point += randomNumber;

                    Random randDealer = new Random();
                    int randomNumberOfDealer = rand.Next(1, 7);
                    

                    pointDealer += randomNumberOfDealer;
                   
                    
                    Console.WriteLine("You got " + randomNumber + " You have a total of " + point );
                   Console.WriteLine("The dealer got " + randomNumberOfDealer + " The dealer have a total of " + pointDealer);
                
                
                if (point != 21 )
                    {Console.WriteLine("Hit or stay?");
                }   }
                if (point >= 22  )
                {
                  Console.WriteLine( "You busted");
                  Console.WriteLine("Bank always wins");
                    break;
                    
                }
                if (pointDealer >= 22)
                {
                    Console.WriteLine("Bank lost");
                    break;
                }
            }


          
        }   
    }
}
