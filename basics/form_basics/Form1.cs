using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using basic_function_library;

namespace form_basics {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e) {
            double s1 = double.Parse(this.Side1.Text);
            double s2 = double.Parse(this.Side2.Text);
            double s3 = double.Parse(this.Side3.Text);
            try {
                double output = BasicHelperFunctions.HeronsFormula(s1, s2, s3);
                this.Output.Text = output.ToString();
            } catch(Exception err) {
                string output = err.Message; 
                MessageBox.Show(output.ToString());
            }
        }
    }
}
