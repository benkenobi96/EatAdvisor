using EatAdvisor.Class_models;
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
    public partial class Bejelentkezes : Form
    {
        public Controller Control { get; }

        public Bejelentkezes(Controller control)
        {
            InitializeComponent();
            this.Control = control;
            LoadControls();
        }
        private void LoadControls()
        {
            this.textBoxUserID.ForeColor = SystemColors.GrayText;
            this.textBoxUserID.Text = "Kérem adja meg felhasználónevét!";
            this.textBoxPW.ForeColor = SystemColors.GrayText;
            this.textBoxPW.Text = "Kérem adja meg jelszavát!";

            this.textBoxUserID.Leave += new
                System.EventHandler(this.textBoxUserID_Leave);
            this.textBoxUserID.Enter += new
                System.EventHandler(this.textBoxUserID_Enter);
            this.textBoxUserID.KeyDown += new
                KeyEventHandler(this.enterHandler);
            this.textBoxPW.Leave += new
                System.EventHandler(this.textBoxPW_Leave);
            this.textBoxPW.Enter += new
                System.EventHandler(this.textBoxPW_Enter);
            this.textBoxPW.KeyDown += new KeyEventHandler(this.enterHandler);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void textBoxUserID_Leave(object sender, EventArgs e)
        {
            if (textBoxUserID.Text.Length == 0)
            {
                textBoxUserID.Text = "Kérem adja meg felhasználónevét!"; ;
                textBoxUserID.ForeColor = SystemColors.GrayText;
            }
        }
        private void textBoxUserID_Enter(object sender, EventArgs e)
        {
            textBoxUserID.Text = "";
            textBoxUserID.ForeColor = SystemColors.ControlDarkDark;
        }
        private void textBoxPW_Leave(object sender, EventArgs e)
        {
            if (textBoxPW.Text.Length == 0)
            {
                textBoxPW.Text = "Jelszó";
                textBoxPW.ForeColor = SystemColors.GrayText;
            }
        }
        private void textBoxPW_Enter(object sender, EventArgs e)
        {
            textBoxPW.Text = "";
            textBoxPW.ForeColor = SystemColors.ControlDarkDark;
        }
        private void enterHandler(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnBelep.PerformClick();
            }
        }

        private void btnBelep_Click(object sender, EventArgs e)
        {
            User u = null;
            if (textBoxUserID.Text != String.Empty && textBoxPW.Text != String.Empty)
            {
                u = Control.LogIn(textBoxUserID.Text, textBoxPW.Text);
                Control.User = u;
            }
            else
            {
                MessageBox.Show("Nem adott meg felhasználónevet vagy jelszót!",
                "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (u == null)
            {
                MessageBox.Show("Rossz felhasználónév/jelszó páros!", "Hiba",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBoxUserID.Text = "";
                this.textBoxPW.Text = "";
                return;
            }
            if (u != null)
            {
                this.Hide();
                MessageBox.Show("Üdvözlet: " + u.UserId + " !", " Sikeres bejelentkezés ", MessageBoxButtons.OK);
                new FoAblak(Control).ShowDialog();
                this.Show();

            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Regisztracio(this).ShowDialog();
            this.Show();
        }
    }
}
