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
    public partial class Form1 : Form
    {
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int situation = random.Next(4);
            switch (situation)
            {
                case 0:
                    MessageBox.Show("К сожалению, читальный зал сейчас на ремонте. Попробуйте другой зал.");
                    break;
                case 1:
                    MessageBox.Show("Голуби, внезапно залетевшие в читальный зал и усевшиеся на стол, стали причиной срочной эвакуации.");
                    break;
                case 2:
                    MessageBox.Show("В тишине читального зала, где все погружены в сон, звучит тревожный сигнал эвакуации из-за пожара.");
                    break;
                case 3:                    
                    DialogResult result = MessageBox.Show("В читальном зале идет интересное обсуждение новой книги. Хотите присоединиться?", "Присоединиться?", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Form2 f2 = new Form2();
                        f2.ShowDialog();
                    }
                    else
                    {
                        Form3 f3 = new Form3();
                        f3.ShowDialog();
                    }
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int situation = random.Next(4);
            switch (situation)
            {
                case 0:
                    MessageBox.Show("К сожалению, ленивый зал сейчас на ремонте. Возвращайтесь позже, когда он будет готов.");
                    break;
                case 1:
                    MessageBox.Show("В библиотеку случайно забредает бродячая кошка, которая устраивает себе лежбище на стопке книг.");
                    break;
                case 2:
                    MessageBox.Show("Внезапно отключили электричество, и все в зале уснули.");
                    break;
                case 3:
                    DialogResult result = MessageBox.Show("В ленивом зале кто-то уютно устроился с чашкой чая и книгой.Хотите присоединиться?", "Присоединиться?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                    {
                        Form3 f3 = new Form3();
                        f3.ShowDialog();
                    }
                    else
                    {
                        Form2 f2 = new Form2();
                        f2.ShowDialog();
                    }
                    break;
            } 
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();          
        }
    }
}
