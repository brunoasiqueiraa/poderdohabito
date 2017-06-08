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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 populares = new Form2();
            populares.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 populares = new Form3();
            populares.ShowDialog();
        }
    }
}
