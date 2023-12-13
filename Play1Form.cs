using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe__FormsApp
{
    public partial class Play1Form : Form
    {
        
        public Play1Form()
        {
            InitializeComponent();
           

        }

        private void RTbtnpy1_Click(object sender, EventArgs e)
        {
            this.Close();
            HomeForm back = new HomeForm();
            back.Show();
        }

        private void P1Sbtn_Click(object sender, EventArgs e)
        {
           
           Play1vCForm form = new Play1vCForm();
           form.pname = nameTextBox.Text;
           form.Show();
           this.Close();
           
        }

        private void RTbtnpy1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            HomeForm back = new HomeForm();
            back.Show();
        }

        

        
    }
}
