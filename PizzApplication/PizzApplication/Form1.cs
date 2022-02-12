using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Size small = new Size() { size = "Small", AdditionalPrice = 1 };
            Size medium = new Size() { size = "Medium", AdditionalPrice = 1.25 };
            Size large = new Size() { size = "Large", AdditionalPrice = 1.5 };
            comboBox1.Items.Add(small);
            comboBox1.Items.Add(medium);
            comboBox1.Items.Add(large);
            Edge thin = new Edge() { edge = "Thin", AdditionalPrice = 1 };
            Edge thick = new Edge() { edge = "Thick", AdditionalPrice = 3 };
            radioButton1.Tag = thin;
            radioButton2.Tag = thick;
            Types pizza1 = new Types() { Name = "Turkish", Price = 25 };
            Types pizza2 = new Types() { Name = "İtalian", Price = 30 };
            Types pizza3 = new Types() { Name = "Korean", Price = 24 };
            Types pizza4 = new Types() { Name = "American", Price = 27 };
            Types pizza5 = new Types() { Name = "English", Price = 22 };
            Types.Items.Add(pizza1);
            Types.Items.Add(pizza2);
            Types.Items.Add(pizza3);
            Types.Items.Add(pizza4);
            Types.Items.Add(pizza5);

        }
        Basket basket;
        Types tp; 
        private void button1_Click(object sender, EventArgs e)
        {  tp = (Types)Types.SelectedItem;
            
            tp.Size = (Size)comboBox1.SelectedItem;
            tp.Edge = radioButton1.Checked ? (Edge)radioButton1.Tag : (Edge)radioButton2.Tag;

            List<string> ing = new List<string>();
            foreach(CheckBox chb in groupBox1.Controls)
            {
                if (chb.Checked)
                {
                    ing.Add(chb.Text);
                }
            }
            tp.Ingredients = ing;
            textBox1.Text = Convert.ToString(numericUpDown1.Value * tp.Amount);
            basket = new Basket();
            basket.Number = (int)numericUpDown1.Value;
            basket.types = tp;
            basket.Total = tp.Amount*numericUpDown1.Value;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tp!=null)
            {
                Basket.Items.Add(basket);
            }
            
        }

        private void order_Click(object sender, EventArgs e)
        {
            totalorder.Text= "Total Amount of Order:";
            decimal total = 0;
            foreach(Basket items in Basket.Items)
            {
                total += items.Total;
            }
            totalorder.Text += total;
        }
    }
}
