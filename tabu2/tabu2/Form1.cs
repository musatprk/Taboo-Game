using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
  
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWX000KXWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMWNK0kdoooodxOKNWMMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMWXKOxooooooooolooxk0XWMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMWNX0kdoooloooooooooooooodxOKNWMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMWNKOxooolooooooooooooooooooolooxk0XWMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMWNX0kdollooloooooooooooooooooooooloooodk0KNWMMMMMMMMMMMMM
MMMMMMMMMMWNKOxoollooooooloooooooooooooooooooooooooooooxOKNWMMMMMMMMMM
MMMMMMMWX0kdoooooooooooooooooooooooooooooooooooooooooooooodk0XNMMMMMMM
MMMMMMNkdoloooooooooooooooooooooooooooooooooooooooooooooooooooxOXWMMMM
MMMMMMXxooooloooooooooooooooooooooooooooooooooooooooooooooolool:oKWMMM
MMMMMMXdooooooooooooooooooooooooooooooooooooooooooooooooooolooc;:OWMMM
MMMMMMXxooooooooooooooooooooooooooooooooooooooooooooooooooooooc;:OWMMM
MMMMMMXxooooooooooooooooooooooooooooooooooooooooooooooooooooooc;:OWMMM
MMMMMMXdooooooooooooooooooooooooooooooooooooooooooooooooooolooc;:OWMMM
MMMMMMXdooooooooooooooooooooooooooooooooooooooooooooooooooolooc;:OWMMM
MMMMMMXdooooooooooooooooooooooooooooooooooooooooooooooooooooooc;:OWMMM
MMMMMMXdooooooooooooooooooooooooooooooooooooooooooooooooooooooc;:OWMMM 
        _   _   _   _   _   _   _   _     _   _   _   _   _   _    
       / \ / \ / \ / \ / \ / \ / \ / \   / \ / \ / \ / \ / \ / \ 
      ( n | e | w | - | n | o | d | e ) ( s | o | c | i | a | l )
       \_/ \_/ \_/ \_/ \_/ \_/ \_/ \_/   \_/ \_/ \_/ \_/ \_/ \_/
MMMMMMXdooooooooooooooooooooooooooooooooooooooooooooooooooooooc;:OWMMM
MMMMMMXdooooooooooooooooooooooooooooooooooooooooooooooooooooooc;:OWMMM
MMMMMMXdooooooooooooooooooooooooooooooooooooooooooooooooooooooc;:OWMMM
MMMMMMXdooooooooooooooooooooooooooooooooooooooooooooooooooooooc;:OWMMM
MMMMMMXdooooooooooooooooooooooooooooooooooooooooooooooooooooooc;:OWMMM
MMMMMMXxooooooooooooooooooooooooooooooooooooooooooooooooooooool;:OWMMM
MMMMMMXxooolooooooooooooooooooooooooooooooooooooooooooooooooooc;:OWMMM
MMMMMMW0xoloolooooooooooooooooooooooooooooooooooooooooooooollc;,c0WMMM
MMMMMMMWXkdollloooooooooooooooooooooooooooooooooooooooollc:;,;:oONMMMM
MMMMMMMMMWNKOxollloooooooooooooooooooooooooooooooooollc;,,;cdOXNWMMMMM
MMMMMMMMMMMMMWX0kdolllooooolooooooooooooooooooooolc:;,,:ok0NWMMMMMMMMM
MMMMMMMMMMMMMMMMWNKOxollloooloooooooooooooooollc:,,;cdOKNWMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMWX0kdollloooooooooooollc:;,,:lx0NWMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMWNKOxollloooooollc:;,;cdOKNWMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMWX0kdolllc:;,,:lx0XWMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWNKOdoc:cdkKNWMMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWNXK0KNWMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
*/

namespace tabu2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form team = new Form2();
            team.Show();
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
