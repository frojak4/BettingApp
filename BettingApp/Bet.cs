using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingApp
{
    internal class Bet
    {
        private string _name;
        private int _chance;
        private int _maxcount;
        public int Startnumber;

        public Bet(string name, int chance, int maxcount)
        {
            _name = name;
            _chance = chance;
            _maxcount = maxcount;
        }

        public void Go()
        {
            Startnumber = 0;
            Random random = new Random();
            int randomNumber = random.Next(Startnumber, _maxcount);
        }
    }
}
