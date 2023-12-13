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
    public partial class Play2Form : Form
    {
        public Play2Form()
        {
            InitializeComponent();
        }

        private void RTbtnpy2_Click(object sender, EventArgs e)
        {
            this.Close();
            HomeForm back = new HomeForm();
            back.Show();
        }

        private void P1Sbtn_Click(object sender, EventArgs e)
        {
            Play1v1Form form = new Play1v1Form();
            form.pname1 = P1textBox.Text;
            form.pname2 = P2textBox.Text;
            form.Show();
            this.Close();
        }
    }
}
