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
    public partial class Regisztracio : Form
    {
        private Bejelentkezes loginWindow;
        
        public Regisztracio(Bejelentkezes loginWindow)
        {
            InitializeComponent();
            this.loginWindow = loginWindow;
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            bool success = false;
            if (this.tbFelhNev.Text != "" && this.tbJelszo.Text != "" &&
                this.tbJelszoUjra.Text != "" && this.tbEmail.Text != "")
            {
                if (!loginWindow.Control.CheckUserNameUnique(tbFelhNev.Text))
                {
                    MessageBox.Show("Már létező felhasználónév!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbFelhNev.Text = "";
                    tbFelhNev.Focus();
                    return;
                }
                if (this.tbJelszo.Text != this.tbJelszoUjra.Text)
                {
                    MessageBox.Show("A jelszavak nem egyeznek meg!", "Eltérő jelszavak", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbJelszo.Text = "";
                    tbJelszoUjra.Text = "";
                    tbJelszo.Focus();
                    return;
                }
                if (!loginWindow.Control.IsValidEmail(tbEmail.Text) )
                {
                    MessageBox.Show("Nem megfelelő formátumú E-mail cím!", "Helytelen E-mail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbEmail.Text = "";
                    tbEmail.Focus();
                    return;
                }
                if (!loginWindow.Control.CheckEmailUnique(tbEmail.Text))
                {
                    MessageBox.Show("Ezzel az Email címmel már regisztráltak", "Helytelen E-mail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbEmail.Text = "";
                    tbEmail.Focus();
                    return;
                }
                else
                {
                    success = loginWindow.Control.Registration(tbFelhNev.Text, tbJelszo.Text, tbNev.Text, tbEmail.Text);
                    this.Show();
                }
            }
            else
            {
            MessageBox.Show("Hiányoznak a regisztrációhoz nélkülözhetetlen adatok!" ,"Hiányos mezők", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            if (success)
            {
                this.Close();
            }
        }

        private void btnMegse_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
