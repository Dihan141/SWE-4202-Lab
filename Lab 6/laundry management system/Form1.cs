using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laundry_management_system
{
    public partial class Form1 : Form
    {
        int balance = 0;
        int orderNo = 0;
        List<User> users = new List<User>();
        List<Order> orders = new List<Order>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSetStatus_Click(object sender, EventArgs e)
        {
            string orderId = textBoxOrderId.Text;
            int flag = 0;

            for(int i=0; i<orders.Count; i++)
            {
                if(orderId == orders[i].orderId)
                {
                    orders[i].status = comboBoxStatus.Text;
                    flag = 1;
                }
            }

            if(flag == 0)
            {
                MessageBox.Show("Order Not Found!");
            }
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            string id = textBoxUserId.Text;
            string name = textBoxUserName.Text;
            string address = textBoxUserAddress.Text;

            User dummy = new User();
            dummy.id = id;
            dummy.name = name; 
            dummy.address = address;

            users.Add(dummy);

            MessageBox.Show("The user has been added.");
        }

        private void buttonPlaceOrder_Click(object sender, EventArgs e)
        {
            string id = textBoxUidOrder.Text;
            int shirt = Convert.ToInt32(textBoxShirt.Text);
            int pant = Convert.ToInt32(textBoxPant.Text);
            int suit = Convert.ToInt32(textBoxSuit.Text);
            int sheet = Convert.ToInt32(textBoxSheets.Text);
            string shirttodo = comboBoxShirt.Text;
            string panttodo = comboBoxPant.Text;
            string suittodo = comboBoxSuit.Text;
            string sheettodo = comboBoxSheet.Text;

            Order dummy =  new Order();
            dummy.shirt = shirt;
            dummy.pant = pant;
            dummy.suit = suit;
            dummy.sheet = sheet;
            dummy.shirttodo = shirttodo;
            if (shirttodo == "Wash")
                dummy.shirtPrice = 7;
            else if (shirttodo == "Iron")
                dummy.shirtPrice = 8;
            else if(shirttodo == "Both")
                dummy.shirtPrice= 15;
            dummy.panttodo = panttodo;
            if (panttodo == "Wash")
                dummy.pantPrice = 10;
            else if (panttodo == "Iron")
                dummy.pantPrice = 13;
            else if (panttodo == "Both")
                dummy.pantPrice = 23;
            dummy.suittodo = suittodo;
            if (suittodo == "Wash")
                dummy.suitPrice = 15;
            else if (suittodo == "Iron")
                dummy.suitPrice = 20;
            else if (suittodo == "Both")
                dummy.suitPrice = 35;
            dummy.sheettodo = sheettodo;
            if (sheettodo == "Wash")
                dummy.sheetPrice = 12;
            else if (sheettodo == "Iron")
                dummy.sheetPrice = 14;
            else if (sheettodo == "Both")
                dummy.sheetPrice = 26;
            dummy.status = "Pending";

            dummy.orderId = orderNo.ToString();
            int flag = 0;
            for(int i = 0; i<users.Count; i++)
            {
                if (users[i].id == id)
                {
                    users[i].orderId = orderNo.ToString();
                    flag = 1;
                }
            }

            if (flag == 0)
            {
                MessageBox.Show("User Not Found!");
            }
            else
            {
                orders.Add(dummy);
                MessageBox.Show("Your order has been placed and Order ID: " + orderNo);
                orderNo++;
            }
        }

        private void buttonDetails_Click(object sender, EventArgs e)
        {
            string id = textBoxOrderIdShow.Text;
            int flag = 0;
            listBoxShow.Items.Clear();

            for(int i=0; i<orders.Count; i++)
            {
                if(id == orders[i].orderId)
                {
                    listBoxShow.Items.Add(orders[i].getShirtInfo());
                    listBoxShow.Items.Add(orders[i].getPantInfo());
                    listBoxShow.Items.Add(orders[i].getSuitInfo());
                    listBoxShow.Items.Add(orders[i].getSheetInfo());
                    labelStatus.Text = orders[i].status;
                    labelAmount.Text = orders[i].getAmount();
                    balance += Convert.ToInt32(orders[i].getAmount());
                    if(labelStatus.Text == "Delivered")
                    {
                        labelCurrBalance.Text = orders[i].getAmount();
                    }
                    flag = 1;
                }
            }

            if(flag == 0)
            {
                MessageBox.Show("Order not found!");
            }

            for(int i=0; i<users.Count; i++)
            {
                if(users[i].orderId == id)
                {
                    labelName.Text = users[i].name;
                    labelAddress.Text = users[i].address;
                }
            }
        }
    }
}
