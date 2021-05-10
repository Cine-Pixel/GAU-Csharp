using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqToXml {
    public partial class Form1 : Form {
        string XMLEndpoint = "http://127.0.0.1:8000/api/cart/";
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            productsDisplay.DataSource = FormUtils.LoadData(XMLEndpoint);
        }

        private void AddStudent_Click(object sender, EventArgs e) {
            
            try {
                Product product = new Product(name.Text, description.Text, owner.Text, cost.Text, shipping.Text);
                Client.Post(XMLEndpoint, product.GetXml());
            } catch {
                throw new Exception("Invalid Data");
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            productsDisplay.DataSource = FormUtils.LoadData(XMLEndpoint);
        }

        private void applyCustomFilter_Click(object sender, EventArgs e) {
            float limit;
            if (!float.TryParse(maxForItem.Text, out limit))
                throw new Exception("Value should be float");

            productsDisplay.DataSource = FormUtils.ApplyFilter(limit);
            productsDisplay.Update();
            productsDisplay.Refresh();
        }
    }
}
