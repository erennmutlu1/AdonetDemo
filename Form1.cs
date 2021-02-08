using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdonetDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDal _productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }

        private void Form1_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void dgwProducts_AutoSizeColumnModeChanged(object sender, DataGridViewAutoSizeColumnModeEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                Name= textBox1.Text,
                UnitPrice = Convert.ToDecimal(textBox2.Text),
                StockAmount = Convert.ToInt32(textBox3.Text)
            });
            LoadProducts();
            MessageBox.Show("Product added!");

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox4.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            textBox5.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            textBox6.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = textBox4.Text,
                UnitPrice  = Convert.ToDecimal(textBox5.Text),
                StockAmount = Convert.ToInt32(textBox6.Text)
            };
            _productDal.Update(product);
            LoadProducts();
            MessageBox.Show("Updated!!");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value);
                _productDal.Delete(id);
                LoadProducts();
                MessageBox.Show("Deleted!");
        }
    }
}
