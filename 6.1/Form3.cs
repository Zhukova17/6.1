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
    public partial class Form3 : Form
    {
        private Random random = new Random();
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int situation = random.Next(2); 

            switch (situation)
            {
                case 0:                   
                    MessageBox.Show("Вам повезло! Свободное место найдено.");
                    break;
                case 1:
                    MessageBox.Show("К сожалению, все места заняты. Попробуйте позже.");
                    break;
            }
        }
    }
}
