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
    public partial class Ertekelo : Form
    {
        
        private Controller control;
        public Ertekelo(Controller control)
        {
            this.control = control;
            InitializeComponent();
            addRestaurantNamestoComboBox();

        }

        private void addRestaurantNamestoComboBox()
        {
            foreach (String item in control.getRestaurantNames())
            {
                comboEtterem.Items.Add(item);
            }
        }
        private void cbUjEtterem_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUjEtterem.Checked == true)
            {
                tbNev.Visible = true;
                tbCim.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                btnHozzaAd.Visible = true;
            }
            else
            {
                tbNev.Visible = false;
                tbCim.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                btnHozzaAd.Visible = false;
            }
        }

        private void btnHozzaAd_Click(object sender, EventArgs e)
        {
            if (tbNev.Text != "" && tbCim.Text != "")
            {
                control.AddRestaurant(tbNev.Text, tbCim.Text);
                comboEtterem.Items.Add(tbNev.Text);
                MessageBox.Show("Étterem hozzáadva!","Sikeres étteremfelvétel" ,MessageBoxButtons.OK);
                tbNev.Text = "";
                tbCim.Text = "";
                tbNev.Focus();
                

            }
            else
            {
                if (tbNev.Text == "" && tbCim.Text != "")
                {
                    MessageBox.Show("Hiányzó étteremnév! ", "Hiba", MessageBoxButtons.OK);
                    tbNev.Focus();
                }
                if (tbNev.Text != "" && tbCim.Text == "")
                {
                    MessageBox.Show("Hiányzó cím! ", "Hiba", MessageBoxButtons.OK);
                    tbCim.Focus();
                }
                
            }
        }

        private void btnErtekel_Click(object sender, EventArgs e)
        {
            if (comboEtterem.SelectedItem != null)
            {
                string userName = control.User.UserId;
                string restaurantName = (string)comboEtterem.SelectedItem;
                int qualityOfFood = (int)numEtelMin.Value;
                int priceValue = (int)numArErtek.Value;
                int service = (int)numKiszolg.Value;
                int mood = (int)numHangulat.Value;
                int clean = (int)numTisztasag.Value;

                control.AddRating(userName,restaurantName,qualityOfFood,priceValue,service,mood,clean);
                MessageBox.Show("Köszönjük értékelését!", "Sikeres értékelés", MessageBoxButtons.OK);

                comboEtterem.SelectedItem = null;
                numArErtek.Value = 1;
                numEtelMin.Value = 1;
                numHangulat.Value = 1;
                numKiszolg.Value = 1;
                numTisztasag.Value = 1;

            }
            else
            {
                MessageBox.Show("Válassz ki egy éttermet! ","Hiányzó étteremnév", MessageBoxButtons.OK);
            }
        }
    }
}
