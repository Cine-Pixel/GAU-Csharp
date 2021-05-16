using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work6_Inheritance {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void magicButton_Click(object sender, EventArgs e) {
            Toy t1 = new Toy(99.99, "Games console");
            t1.Buy();

            Toy t2 = new Toy(11.99,"Lego set");
            t2.Buy();

            CuddlyToy t3 = new CuddlyToy(5.99, "Flopsy rabbit");
            t3.Animal = "Rabbit";
            t3.Buy();

            string s = "";
            foreach (Toy t in Toy.Toys) 
                s += t.Description + "\n";

            MessageBox.Show(s.Trim(),"Purchases");
        }
    }
}
