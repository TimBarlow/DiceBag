﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceBag
{
    

    class DiceBag
    {
       
        //private members
        int sides;
        private string log;
        private Random rand;
      
        //Constructor
        public DiceBag()
        {
            rand = new Random(Guid.NewGuid().GetHashCode());
            log = null;
        }
        
        //Function deffinitions
        public int Roll(int d)
        {
            return rand.Next(1, d+1);// +1 to make it inclusive
        }

        public int Roll(int d, int n)
        {
            int total = 0;
            for (int i = 1; i <= n; i++)
            {
                total += rand.Next(1, d +1);
            }
            return total;
        }

        public int RollMod(int d, int mod)
        {
            return rand.Next(1, d + 1) + mod;
        }

        public int RollMod(int d, int n, int mod) 
        {
            int total = 0;
            for (int i = 1; i <= n; i++)
            {
                total += rand.Next(1, d + 1);
            }
            return total + mod;
        }



    }
}
