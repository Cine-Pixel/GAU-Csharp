using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Work6_DelegatesAndEvents 
{
    public delegate void MovingButton(int distance);
    class MovableButton 
    {
        Button button = null;
        int distance = 0;

        public int Distance {
            get => distance;
            set { distance = value; }
        }

        public MovableButton(Button b)
        {
            // we know which button this is
            button = b;
        }

        public void MoveDown(int distanceDown)
        {
            // move button left a bit
            button.Top = button.Top + distanceDown;
        }
        public void MoveRight(int distanceRight)
        {
            // move button left a bit
            button.Left = button.Left + distanceRight;
        }
        public void MoveHome(int junk) {
            MoveHome();
        }
        public void MoveHome() {
            button.Top = 0;
            button.Left = 0;
        }
        public void Move(MovingButton mb) {
            mb(distance);
        }
        public void Home()
        {
            // move the button to top left;
            button.Top = 0;
            button.Left = 0;
        }

    }
}
