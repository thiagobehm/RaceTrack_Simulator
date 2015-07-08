using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Race_Track_Simulator
{
    public class Greyhound
    {
        public int startingPosition;
        public int racetrackLength;
        public PictureBox myPicturebox = null;
        public int location = 0;
        public Random myRandom;

        public bool run()
        {
            myRandom = new Random();
            int distance = myRandom.Next(1, 5);

            moveMyPictureBox(distance);

            location += distance;
            if (location >= (racetrackLength - startingPosition))
            {
                return true;
            }
            return false;
        }

        public void TakeStartingPosition()
        {
            moveMyPictureBox(-location);
            location = 0;
        }

        public void moveMyPictureBox(int distance)
        {
            Point p = myPicturebox.Location;
            p.X += distance;
            myPicturebox.Location = p;
        }
    }
}
