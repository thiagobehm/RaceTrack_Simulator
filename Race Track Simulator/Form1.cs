using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Race_Track_Simulator
{
    public partial class Form1 : Form
    {
        Greyhound[] greyHoundArray = new Greyhound[4];
        Guy[] guyArray = new Guy[3];
        Random myRandom = new Random();

        public Form1()
        {
            InitializeComponent();

            minimumBetLabel.Text = "Minimum bet: " + numericUpDownBet.Minimum.ToString() + " bucks";
            nameLabel.Text = "Joe";//primeiro valor vem com joe selecionado

            greyHoundArray[0] = new Greyhound() 
            {
                myPicturebox = dogPictureBox1,
                startingPosition = dogPictureBox1.Right - raceTrackPicture.Left,
                racetrackLength = raceTrackPicture.Width - dogPictureBox1.Width,                
            };

            greyHoundArray[1] = new Greyhound()
            {
                myPicturebox = dogPictureBox2,
                startingPosition = dogPictureBox2.Right - raceTrackPicture.Left,
                racetrackLength = raceTrackPicture.Size.Width - dogPictureBox2.Size.Width,
            };
           
            greyHoundArray[2] = new Greyhound()
            {
                myPicturebox = dogPictureBox3,
                startingPosition = dogPictureBox3.Right - raceTrackPicture.Left,
                racetrackLength = raceTrackPicture.Size.Width - dogPictureBox3.Size.Width,               
            };

            greyHoundArray[3] = new Greyhound()
            {
                myPicturebox = dogPictureBox4,
                startingPosition = dogPictureBox4.Right - raceTrackPicture.Left,
                racetrackLength = raceTrackPicture.Size.Width - dogPictureBox4.Size.Width,
            };

            guyArray[0] = new Guy()
            {
                name = "Joe",
                cash = 50,
                myBet = null,
                myLabel = joeBetLabel,
                myRadioButton = joeRadioButton
            };

            guyArray[1] = new Guy()
            {
                name = "Bob",
                cash = 75,
                myBet = null,
                myLabel = bobBetLabel,
                myRadioButton = bobRadioButton
            };

            guyArray[2] = new Guy()
            {
                name = "Al",
                cash = 45,
                myBet = null,
                myLabel = alBetLabel,
                myRadioButton = alRadioButton
            };

            foreach (var guy in guyArray)
            {
                guy.updateLabels();
            }
        }

        private void joeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = "Joe";
        }

        private void bobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = "Bob";
        }

        private void alRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = "Al";
        }

        private void betsButton_Click(object sender, EventArgs e)
        {
            int guyNumber = 0;

            if (joeRadioButton.Checked)
            {
                guyNumber = 0;
            }
            if (bobRadioButton.Checked)
            {
                guyNumber = 1;
            }
            if (alRadioButton.Checked)
            {
                guyNumber = 2;
            }

            guyArray[guyNumber].placeBet((int)numericUpDownBet.Value, (int)numericUpDownDog.Value);
            guyArray[guyNumber].updateLabels();
        }

        private void raceButton_Click(object sender, EventArgs e)
        {
            groupBox.Enabled = false;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {   
            int i = 1;

            foreach (var dog in greyHoundArray)
            {                
                if (dog.run())
                {                    
                    timer1.Stop();
                    MessageBox.Show("Dog #" + i + " won the race!");
                    foreach (var guys in guyArray)
                    {
                        guys.collect(i);
                    }
                    foreach (var dogs in greyHoundArray)
                    {
                        dogs.TakeStartingPosition();
                    }
                    groupBox.Enabled = true;
                }
                i++;
            }
            
        }

        
    }
}
