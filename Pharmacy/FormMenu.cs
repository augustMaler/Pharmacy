using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
        private void buttonPharmacy_Click(object sender, EventArgs e)
        {
            Form Pharmacy = new FormPharmacy();
            Pharmacy.Show();
            this.Hide();
        }
        private void buttonDrugs_Click(object sender, EventArgs e)
        {
            Form Drugs = new FormDrugs();
            Drugs.Show();
            this.Hide();
        }

        private void buttonAvailability_Click(object sender, EventArgs e)
        {
            Form Avil = new FormAvailability();
            Avil.Show();
            this.Hide();
        }
    }
}