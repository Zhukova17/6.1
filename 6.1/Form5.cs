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
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Добавить книгу в библиотеку
            string name = textBox1.Text;
            string author = textBox2.Text;
            string genre = textBox3.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(author) || string.IsNullOrEmpty(genre))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            Library.Instance.AddBook(new Book(name, author, genre));
            MessageBox.Show("Книга добавлена в библиотеку!");

        }
    }
}
