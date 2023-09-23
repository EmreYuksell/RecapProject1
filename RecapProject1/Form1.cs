using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapProject1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listCategories();
           ListProducts();
        }

        private void ListProducts()
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                dgwProduct.DataSource = context.Products.ToList();

            }
        }
        private void listCategories()
        {
            using (NorthWindContext context = new NorthWindContext())
            {
            cbxCategory.DataSource = context.Categories.ToList();
                cbxCategory.DisplayMember = "CategoryName";
                cbxCategory.ValueMember = "CategoryId";
            }
        }
    }
}
