using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductOrder
{
    public partial class MyProductOrder : Form
    {
        OrderDetail orderDetail;
        public MyProductOrder()
        {
            InitializeComponent();
            orderDetail = new OrderDetail(this);
            Product.Rows = orderDetail.Rows;

            string[] fileNames = Directory.GetFiles("D:\\B SETEC School\\Year 1\\Semester 2\\GRAPHIC DESIGN II\\Nham nham");
            //MessageBox.Show(fileNames.Length + "");
            int i=1;
            Random random = new Random();
            int col = 1, row = 0;
            foreach(string fileName in fileNames)
            {
                int id = i++;
                string name = Path.GetFileNameWithoutExtension(fileName);
                Image photo = Image.FromFile(fileName);
                double price = random.Next(10) + 1;
                Product product = new Product();
                product.PName = name;
                product.Price = price;
                product.ID = id;
                product.Photo = photo;

                tableLayoutPanel.Controls.Add(product, col, row);
                col++;
                if (col > 3)
                {
                    col = 1;
                    row++;
                }
            } 
        }

        private void MyProductOrder_Load(object sender, EventArgs e)
        {
            //full Screen
            //this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void MenuCheckOrderDetail_Click(object sender, EventArgs e)
        {
            if (Product.Rows.Count > 0)
            {
                orderDetail.ShowDialog();
            }

            else
                MessageBox.Show("Please order some Product");

        }

        private void menuPayment_Click(object sender, EventArgs e)
        {
            if (Product.Rows.Count > 0)
            {
                Payment payment = new Payment();
                DialogResult dialogResult = payment.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    this.Dispose();
                    new MyProductOrder().Show();
                }
               
            }
            else
                MessageBox.Show("Please order some Product");
        }

        private void MyProductOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
