using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work6_DelegatesAndEvents 
{
    public partial class frmMovableButtons : Form
    {
        public frmMovableButtons()
        {
            InitializeComponent();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            // move the button down
            MovableButton b = new MovableButton(btn);
            b.Distance = (int)amountMove.Value;
            MovingButton iWantToMoveIt = null;
            iWantToMoveIt += b.MoveDown;
            iWantToMoveIt += b.MoveRight;

            b.Move(iWantToMoveIt);

        }
        private void topLeft_Click(object sender, EventArgs e) {
            MovableButton b = new MovableButton(btn);
            b.Distance = (int)amountMove.Value;
            MovingButton iWantToMoveIt = null;
            iWantToMoveIt += b.MoveHome;
            iWantToMoveIt += b.MoveDown;
            iWantToMoveIt += b.MoveRight;
            b.Move(iWantToMoveIt);
        }

        private void frmMovableButtons_Load(object sender, EventArgs e) {

        }

    }
}
