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
        List<Study_books> books = new List<Study_books>();
        List<Article> articles = new List<Article>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string bookId = textBoxBbook.Text;

            for(int i=0; i<books.Count; i++)
            {
                if(bookId == books[i].id)
                {
                    books[i].quantity -= 1;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBoxSbId.Text;
            string title = textBoxSbtitle.Text;
            string isbn = textBoxIsbn.Text;
            string genre = textBoxGenre.Text;
            string author = textBoxSbAuthor.Text;
            string publisher = textBoxSbPublisher.Text;
            int quantity = Convert.ToInt32(textBoxSbQuantity.Text);

            Study_books dummy = new Study_books();
            dummy.id = id;
            dummy.title = title;
            dummy.isbn = isbn;
            dummy.genre = genre;
            dummy.author = author;
            dummy.publisher = publisher;
            dummy.quantity = quantity;

            MessageBox.Show("This book has been added.");

            books.Add(dummy);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = textBoxRbId.Text;
            string title = textBoxRbtitle.Text;
            string publishDate = textBoxPd.Text;
            string doi = textBoxDoi.Text;
            string author = textBoxRbAuthor.Text;
            string publisher = textBoxRbPublisher.Text;
            string cj = textBoxCj.Text;

            int quantity = Convert.ToInt32(textBoxRbQuantity.Text);

            Article dummy = new Article();
            dummy.id = id;
            dummy.title = title;
            dummy.publishDate = publishDate;
            dummy.doi = doi;
            dummy.author = author;
            dummy.publisher = publisher;
            dummy.quantity = quantity;
            dummy.cj = cj;

            MessageBox.Show("This article has been added.");

            articles.Add(dummy);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string articleId = textBoxArId.Text;

            for(int i=0; i<articles.Count; i++)
            {
                if(articleId == articles[i].id)
                {
                    articles[i].quantity -= 1;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBoxShowSbooks.Items.Clear();
            for(int i=0; i<books.Count; i++)
            {
                listBoxShowSbooks.Items.Add(books[i].getInfo());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBoxShowArticles.Items.Clear();
            for(int i=0; i<articles.Count; i++)
            {
                listBoxShowArticles.Items.Add(articles[i].getInfo());
            }
        }

        private void listBoxShowArticles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
