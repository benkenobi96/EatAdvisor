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
    public partial class Etterem : Form
    {
        private Controller control;
        public Etterem(Controller control)
        {
            this.control = control;
            InitializeComponent();
            addRestauratnNamestoListBox();
        }

        private void btnVissza_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addRestauratnNamestoListBox()
        {
            foreach (String item in control.getRestaurantNames())
            {
                lbEttermek.Items.Add(item);
            }
        }

        private void lbEttermek_SelectedIndexChanged(object sender, EventArgs e)
        {
            control.setAvergaes();
            string restaurantName = (string)lbEttermek.SelectedItem;

            tbCim.Text = control.selectRestaurantAddress(restaurantName);

            tbEteMin.Text = control.selectRestaurantQualityAVG(restaurantName).ToString();
            tbArErtek.Text = control.selectRestaurantPVAVG(restaurantName).ToString();
            tbKiszolg.Text = control.selectRestaurantServiceAVG(restaurantName).ToString();
            tbHangulat.Text = control.selectRestaurantMoodAVG(restaurantName).ToString();
            tbTisztasag.Text = control.selectRestaurantCleanAVG(restaurantName).ToString();

            TextColorChange(tbEteMin);
            TextColorChange(tbArErtek);
            TextColorChange(tbKiszolg);
            TextColorChange(tbHangulat);
            TextColorChange(tbTisztasag);

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextColorChange(TextBox tbInput)
        {

            if (tbInput.Text.Equals("5") )
            {
                tbInput.BackColor = Color.PaleGreen;
            }
            else if (tbInput.Text.Equals("4"))
            {
                tbInput.BackColor = Color.PaleGreen;
            }
            else if (tbInput.Text.Equals("3"))
            {
                tbInput.BackColor = Color.Tomato;
            }
            else if (tbInput.Text.Equals("1") || tbInput.Text.Equals("2"))
            {
                tbInput.BackColor = Color.LightCoral;
            }

        }
    }
}
