using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceBag
{
    class DieRow
    {
        int num, sides, modifier;
       
        
        public DieRow(){
            num = 0;
            sides = 0;
            modifier = 0;

        }
        public DieRow(int numberOfDice, int sidesOnDie, int modiferToBeAdded)
        {
            num = numberOfDice;
            sides = sidesOnDie;
            modifier = modiferToBeAdded;
        }
        public void SetSides(int sidesOnDie){
            sides = sidesOnDie;
        }
        public void SetMod(int modiferToBeAdded)
        {
            sides = modiferToBeAdded;
        }
        public void SetNumber(int numberOfDice)
        {
            sides = numberOfDice;
        }
    }
    
}

