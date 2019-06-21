using EatAdvisor.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EatAdvisor
{
    public partial class FoAblak : Form
    {
        private Controller control;
        public FoAblak(Controller control)
        {
            InitializeComponent();
            this.control = control;

        }

        private void btnErtekel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ertekelo ert = new Ertekelo(control);
            ert.ShowDialog();
            this.Show();
            
        }

        private void btnRangsor_Click(object sender, EventArgs e)
        {
            this.Hide();
            Etterem ett = new Etterem(control);
            ett.ShowDialog();
            this.Show();
        }

        private void btnKijelentkezes_Click(object sender, EventArgs e)
        {
            control.User = null;
            this.Hide();
            this.Close();
        }
    }
}
