using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingApp
{
    internal class Start
    {
        private List<Bet> BettingList = new List<Bet>()
        {
            new Bet("50/50", 50, 100),
            new Bet("Lucky Strike", 1, 100),
            new Bet("The Safe Bet", 80, 100),
            new Bet("Coin Flip", 1, 2)
    };
        public decimal Money { get; set; } = 1000;
        public void Run()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to BettingApp, what would you like to do?");
                Console.WriteLine($"Total money: {Money}$");
                Console.WriteLine("1. Place bet");
                Console.WriteLine("2. Create bet");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1": 
                        PlaceBet();
                        break;
                    case "2":
                        CreateBet();
                        break;
                    default: 
                        Console.WriteLine("Invalid input");
                        break;
                }
            }


           
           
            
        }

        public void PlaceBet()
        {
            bool validBet = false;
            decimal betAmount = 0;
            Console.Clear();
            Console.WriteLine("What bet would you like to do?");
            Console.WriteLine($"Total money: {Money}$");

            for (int i = 0; i < BettingList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Name: {BettingList[i].getName()}");
                Console.WriteLine($"Odds: {BettingList[i].getchance()} / {BettingList[i].getMaxcount()}");
                Console.WriteLine();
            }
            string userInput = Console.ReadLine();
            int betNumber = Convert.ToInt32(userInput);
            Bet currentBet = BettingList[betNumber - 1];
            Console.Clear();
            while (!validBet) { 
                Console.WriteLine("How much do you want to bet?");
                Console.WriteLine($"You have {Money}$.");

                userInput = Console.ReadLine();
                betAmount = Convert.ToInt32(userInput);
                if (betAmount <= Money)
                {
                    validBet = true;
                    Money -= betAmount;
                }
                else
                {
                    Console.WriteLine("Invalid bet.");
                    Console.ReadKey(true);
                }

                
                Console.Clear();
            }

            decimal odds = currentBet.Go();

            if (odds != 0)
            {
                Console.Clear();
                betAmount *= odds;
                Money += betAmount;
                Console.WriteLine($"Congratulations, you won {betAmount}$");
                Console.WriteLine($"Total money:{Money}");
                Console.ReadKey(true);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You lost! Better luck next time!");
                Console.ReadKey(true);
            }

        }

        public void CreateBet()
        {
            Console.Clear();
            Console.WriteLine("What's the name of your bet?");
            string name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("What's the odds?");
            string odds = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("What's the max count?");
            string maxCount = Console.ReadLine();
            Console.Clear();

            int oddsint = Convert.ToInt32(odds);
            int maxcountint = Convert.ToInt32(maxCount);

            BettingList.Add(new Bet(name, oddsint, maxcountint));

            Console.WriteLine("Bet successfully added!");
            Console.ReadKey(true);
        }
    }
}
