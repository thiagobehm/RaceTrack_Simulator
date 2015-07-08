using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Race_Track_Simulator
{
    public class Guy
    {
        public string name;
        public Bet myBet;
        public int cash;
        public RadioButton myRadioButton;
        public Label myLabel;

        public void updateLabels()
        {
            if (myBet == null)
            {
                myLabel.Text = name + " hasn't placed a bet";                
            }
            else
            {
                myLabel.Text = myBet.getDescription();               
            }
            myRadioButton.Text = name + " has " + cash + " bucks.";         
           
        }
        //faz a aposta e retorna falso caso, não seja possível
        public bool placeBet(int betAmount, int dogToWin)
        {
            if (cash >= betAmount)
            {
                cash -= betAmount;
                myBet = new Bet()
                {
                    amount = betAmount,
                    bettor = this,
                    dog = dogToWin
                };
                updateLabels();
                return true;
            }
            else
                return false;
        }
        public void clearBeat()
        {
            myBet.amount = 0;
        }
        public void collect(int winner)
        {
            if (myBet != null)
            {
                this.cash += myBet.payOut(winner);
                clearBeat();
                updateLabels();
            }
        }
    }
}
