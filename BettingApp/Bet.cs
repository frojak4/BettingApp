﻿using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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
        
        public decimal Go()
        {
            Startnumber = 0;
            Random random = new Random();
            int randomNumber = random.Next(Startnumber, _maxcount);

            while (Startnumber <= randomNumber)
            {
                Console.Clear();
                Console.WriteLine($"{Startnumber} / {_chance}");
                Startnumber++;
                Thread.Sleep(100);
            }

            if (Startnumber <= _chance)
            {
                decimal odds = (decimal) _maxcount / _chance;
                return odds;

            }
            else
            {
                return 0;
            }
        }

        public string getName()
        {
            return _name;
        }

        public int getchance()
        {
            return _chance;
        }

        public int getMaxcount()
        {
            return _maxcount;
        }
    }
}
