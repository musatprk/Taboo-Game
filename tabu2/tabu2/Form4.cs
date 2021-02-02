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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form team = new Form3();
            if (Form3.tm == 0)
            {
                Form3.tm = 1;
            }
            else if (Form3.tm == 1)
            {
                Form3.tm = 0;
            }
            team.Show();
            this.Hide();
        }
    }
}
