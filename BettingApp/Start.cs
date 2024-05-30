using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingApp
{
    internal class Start
    {
        public void Run()
        {
            //while (true)
            {
                Console.WriteLine("Welcome to BettingApp, what would you like to do?");
                Console.WriteLine("1. Place bet");
                Console.WriteLine("2. Create bet");
            }

            Bet test = new Bet("50/50", 50, 50);
            test.Go();
        }
    }
}
