using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._1
{
    public partial class Form5 : Form
    {
        private List<Book> books = new List<Book>();
        private Random random = new Random();

        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title = textBox1.Text;
            string author = textBox2.Text;
            string genre = textBox3.Text;

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author) || string.IsNullOrEmpty(genre))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            Book book = new Book(title, author, genre);
            books.Add(book);
            listBox1.Items.Add(book);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Пожалуйста, выберите книгу.");
                return;
            }

            Book selectedBook = (Book)listBox1.SelectedItem;
            int randomEvent = random.Next(3);

            switch (randomEvent)
            {
                case 0:
                    MessageBox.Show($"Вы прочли книгу \"{selectedBook.Title}\"! Вам очень понравилось.");
                    break;
                case 1:
                    MessageBox.Show($"Вы нашли \"{selectedBook.Title}\" в библиотеке. К сожалению, она уже занята.");
                    break;
                case 2:
                    MessageBox.Show($"Вы купили \"{selectedBook.Title}\" в интернет-магазине с хорошей скидкой.");
                    break;
            }
        }
    }
}
