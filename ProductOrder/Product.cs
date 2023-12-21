using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductOrder
{
    public partial class Product : UserControl
    {
        public Product()
        {
            InitializeComponent();
        }
        public int ID { get; set; }
        public string PName
        {
            get => txtName.Text;
            set => txtName.Text = value;
        }
        private double price;
        public double Price
        {
            get => price;
            set
            {
                price = value;
                txtPrice.Text = price.ToString("c2");
            }
        }
        public int Qty { get; set; }
        public Image Photo
        {
            get => picture.Image;
            set => picture.Image = value;
        }
        public static DataGridViewRowCollection Rows { get; set; }
        public static double TotalAmount
        {
            get
            {
                double TotalAmount = 0;
                foreach(DataGridViewRow row in Rows)
                {
                    string st = "" + row.Cells[4].Value;
                    double amount = double.Parse(st, NumberStyles.Currency);
                    TotalAmount += amount;
                }
                return TotalAmount;

            }
        }
        private int CheckID(int id)
        {
            for (int i = 0; i < Rows.Count; i++)
            {
                int data_id = int.Parse("" + Rows[i].Cells[0].Value);
                if (data_id == id)
                    return i;
            }
            return -1;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"{ID}\n{PName}\n{price:c2}");//testing
            Qty++;
            btnOrder.Text = $"Order({Qty})";
            btnCancel.Visible = true;
            int index = CheckID(ID);
            if (index == -1)

                Rows.Add(ID.ToString("000"), PName, Price.ToString("c2"), Qty, (Price * Qty).ToString("c2"));
            else
            {
                Rows[index].Cells[3].Value = Qty;
                Rows[index].Cells[4].Value = (Qty * Price).ToString("c2");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Qty--;
            int index = CheckID(ID);
            if (Qty == 0)
            {
                btnOrder.Text = "Order";
                btnCancel.Visible = false;
                Rows.RemoveAt(index);
            }
            else
            {
                
                btnOrder.Text = $"Order({Qty})";
                Rows[index].Cells[3].Value = Qty;
                Rows[index].Cells[4].Value = (Qty * Price).ToString("c2");
            }
        }
    }
}
