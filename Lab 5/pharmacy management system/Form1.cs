using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacy_management_system
{
    public partial class Form1 : Form
    {
        private int balance = 0;
        List<Medicine> medicines = new List<Medicine>();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddMedicine_Click(object sender, EventArgs e)
        {
            string name = textBoxMedicineName.Text;
            string id = textBoxMedicineId.Text;
            int amount = Convert.ToInt32(textBoxAmount.Text);
            int price = Convert.ToInt32(textBoxPrice.Text);

            Medicine dummy = new Medicine();
            dummy.name = name;
            dummy.price = price;
            dummy.setAmount(amount);
            dummy.setId(id);

            comboBox1.Items.Add(dummy.name);
            MessageBox.Show("Medicine added.");
            medicines.Add(dummy);
        }

        private void buttonSell_Click(object sender, EventArgs e)
        {
            string id = textBoxMedicineIdSell.Text;
            int amount = Convert.ToInt32(textBoxSellAmount.Text);
            int flag = 0;

            for(int i=0; i<medicines.Count; i++)
            {
                if(id == medicines[i].getId())
                {
                    flag = 1;
                    if(amount > medicines[i].getAmount())
                    {
                        MessageBox.Show("Not enough medicine!");
                    }
                    else
                    {
                        medicines[i].setAmount(medicines[i].getAmount() - amount);
                        balance += medicines[i].price * amount;
                    }

                }
            }

            if(flag == 0)
            {
                MessageBox.Show("The medicine doesn't exist!");
            }
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            listBoxShow.Items.Clear();
            for(int i=0; i<medicines.Count; i++)
            {
                listBoxShow.Items.Add(medicines[i].getInfo());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxShowBalance.Text = balance.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxAmount.Text = String.Empty;
            textBoxMedicineId.Text = String.Empty;
            textBoxMedicineName.Text = String.Empty;
            textBoxPrice.Text = String.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxMedicineIdSell.Text = String.Empty;
            textBoxSellAmount.Text = String.Empty;
        }

        private void buttonAddAmount_Click(object sender, EventArgs e)
        {
            string id = textBoxAddextra.Text;
            int amount = Convert.ToInt32(textBoxExtraAmount.Text);
            int flag = 0;

            for (int i = 0; i < medicines.Count; i++)
            {
                if (id == medicines[i].getId())
                {
                    int temp = medicines[i].getAmount();
                    medicines[i].setAmount(temp += amount);
                    MessageBox.Show("The amount has been added.");
                    flag = 1;
                }
            }

            if(flag == 0)
            {
                MessageBox.Show("The medicine doesn't exist!");
            }
        }
    }
}
