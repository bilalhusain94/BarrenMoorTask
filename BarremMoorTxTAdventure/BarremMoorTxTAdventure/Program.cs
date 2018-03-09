
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarremMoorTxTAdventure
{
    class Program
    {
        static void Main(string[] args)
        {

            reach player = new reach();
            player.function(2);
            Console.ReadLine();
        }
    }
}



    class reach
    {
        public void function(int player)
        {
            if ((player >= 1 && player <= 2))
            {
                switch (player)
                {
                    case 1:
                        Console.WriteLine("Game Won!");
                        break;
                    case 2:
                    Console.WriteLine("Treasure Found!");
                        break;

                }
            }
            else Console.WriteLine("Go back to Start");
        }
    }
