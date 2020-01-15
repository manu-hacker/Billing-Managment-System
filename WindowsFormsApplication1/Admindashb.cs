using System;
using System.Windows.Forms;
using WindowsFormsApplication1.UI;

namespace WindowsFormsApplication1
{
    public partial class Admindashb : Form
    {
        public Admindashb()
        {
            InitializeComponent();
        }

        private void Admindashb_Load(object sender, EventArgs e)
        {
          
        }

        private void lblloggedin_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmUsers user = new frmUsers();
            user.Show();
        }
    }
}
