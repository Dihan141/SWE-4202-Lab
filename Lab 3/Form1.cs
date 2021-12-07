using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace something
{
    public partial class Form1 : Form
    {
        List<User> users = new List<User>();
        List<Book> books = new List<Book>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string address = textBoxAddress.Text;
            string id = textBoxUid.Text;

            User dummy = new User();
            dummy.setName(name);
            dummy.setAddress(address);
            dummy.setId(id);

            MessageBox.Show("User has been added!");

            users.Add(dummy);
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            string id = textBoxBid.Text;
            string name = textBoxBname.Text;
            string author = textBoxAuthor.Text;
            string publisher = textBoxPublisher.Text;
            int quantity = Convert.ToInt32(textBoxQuantity.Text);

            Book dummy = new Book();
            dummy.setName(name);
            dummy.setId(id);
            dummy.setAuthor(author);
            dummy.setPublisher(publisher);
            dummy.setQuantity(quantity);

            MessageBox.Show("The book has been added!");

            books.Add(dummy);
        }

        private void buttonBorrow_Click(object sender, EventArgs e)
        {
            string id = textBoxuid2.Text;
            string bookId = textBoxBid2.Text;

            User dummy = new User();
            Book dummyB = new Book();
            dummyB.setId(bookId);

            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].getId() == bookId)
                {
                    books[i].setQuantity(books[i].getQuantity() - 1);
                    dummyB.setName(books[i].getName());
                }
            }
            for (int i=0;i<users.Count;i++)
            {
                if (users[i].getId() == id)
                {
                    users[i].bBooks.Add(dummyB);
                }
            }
        }

        private void buttonShowB_Click(object sender, EventArgs e)
        {
            string id = textBoxBid3.Text;
            int flag = 0;

            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].getId() == id)
                {
                    textBox5.Text = books[i].getName();
                    textBox4.Text = books[i].getAuthor();
                    textBox3.Text = books[i].getPublisher();
                    int temp = books[i].getQuantity();
                    textBox2.Text = Convert.ToString(temp);
                    flag = 1;
                }
            }

            if (flag == 0)
                MessageBox.Show("Book not found!");

        }

        private void buttonShowU_Click(object sender, EventArgs e)
        {
            string id = textBoxUid3.Text;

            for(int i=0;i<users.Count;i++)
            {
                if(users[i].getId() == id)
                {
                    listBoxBid.Items.Clear();
                    listBoxBname.Items.Clear();

                    for (int j=0;j<users[i].bBooks.Count;j++)
                    {
                        listBoxBid.Items.Add(users[i].bBooks[j].getId());
                        listBoxBname.Items.Add(users[i].bBooks[j].getName());
                    }
                }
            }

        }
    }
}
