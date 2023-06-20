using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsLogos
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            //Timer MyTimer = new Timer();
            //MyTimer.Interval = 5000;        // 5 seconds
            //MyTimer.Tick += new EventHandler(MyTimer_Tick);
            //MyTimer.Start();
            //MyTimer.Stop();
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            //this.Hide();
            //frmLogos Logo = new frmLogos();
            //Logo.ShowDialog();
        }

        private void btnMainForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogos Logo = new frmLogos();
            Logo.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitProgramOrNot();
        }

        private void ExitProgramOrNot()
        {
            DialogResult dialog = MessageBox.Show(
                   "Do You Really Want To Exit?",
                   "EXIT NOW?",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
