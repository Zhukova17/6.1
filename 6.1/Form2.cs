using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _6._1
{
    public partial class Form2 : Form
    {
        private Random random = new Random();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int situation = random.Next(3);

            switch (situation)
            {
                case 0:
                    MessageBox.Show("Поздравляем! Книга доступна для взятия.");
                    break;
                case 1:
                    MessageBox.Show("К сожалению, эта книга сейчас временно недоступна. Выберите другую.");
                    break;
                case 2:
                    MessageBox.Show("В библиотеке проходит акция! При покупке этой книги, вы получаете скидку на следующий заказ.");
                    break;
            }
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int situation = random.Next(3);

            switch (situation)
            {
                case 0:                   
                    MessageBox.Show("Вам повезло! Свободное место найдено.");
                    break;
                case 1:                    
                    MessageBox.Show("К сожалению, все места заняты. Попробуйте позже.");
                    break;
                case 2:
                    MessageBox.Show("К сожалению, свободных мест нет. Но вы можете попробовать присесть на пол. Это как медитация, только с книгами.");
                    break;
            }
        }
    }
}
