using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tabu2
{
    public partial class Form2 : Form
    {
        public static string bteam;
        public static string rteam;
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            bteam = textBox1.Text;
            rteam = textBox2.Text;
            Form team = new Form3();
            team.Show();
            this.Hide();
        }
    }
}
