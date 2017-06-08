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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cafef2 populares = new cafef2();
            populares.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            almocarf2 populares = new almocarf2();
            populares.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            faculdadef2 populares = new faculdadef2();
            populares.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            quartaf2 populares = new quartaf2();
            populares.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sextaf2 populares = new sextaf2();
            populares.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            domingof2 populares = new domingof2();
            populares.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 populares = new Form2();
            populares.ShowDialog();
        }
    }
}
