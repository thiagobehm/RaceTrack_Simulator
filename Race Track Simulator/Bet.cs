using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race_Track_Simulator
{
    public class Bet
    {
        public int amount;
        public int dog;
        public Guy bettor;

        public string getDescription()
        {
            if (amount > 0)
            {
                return bettor.name + " bets " + amount + " on dog #" + dog;
            }
            else
            {
                return bettor.name + " hasn't placed a bet";
            }
            
        }

        public int payOut(int winner)
        {
            if (dog == winner)
            {
                return amount*2;
            }
            else
            {
                return 0;
            }
           
        }
    }
}
