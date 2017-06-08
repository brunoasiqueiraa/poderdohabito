using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poderdohabito
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            almocar populares = new almocar();
            populares.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cafe populares = new cafe();
            populares.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            faculdade populares = new faculdade();
            populares.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            domingo populares = new domingo();
            populares.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sexta populares = new sexta();
            populares.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            quarta populares = new quarta();
            populares.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form3 populares = new Form3();
            populares.ShowDialog();
        }
    }
}
