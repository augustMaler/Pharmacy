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
    public partial class FormAvailability : Form
    {
        public void ShowAvailib()
        {
            listViewAvailib.Items.Clear();
            foreach(Availability availability in Program.PhDB.Availability)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    availability.Id.ToString(),
                    availability.Pharmacy.PharmacyName,
                    availability.Drugs.DrugName,
                    availability.Value,
                    availability.Price
                });
                item.Tag = availability;
                listViewAvailib.Items.Add(item);
            }
        }
        public void ShowComboBox()
        {
            comboBoxDrugs.Items.Clear();
            foreach (Drugs drugs in Program.PhDB.Drugs)
            {
                string[] item = { drugs.Id + ". ", drugs.DrugName };
                comboBoxDrugs.Items.Add(string.Join(" ", item));
            }
            comboBoxPharmacy.Items.Clear();
            foreach (Pharmacy Ph in Program.PhDB.Pharmacy)
            {
                string[] item = { Ph.Id + ". ", Ph.PharmacyName };
                comboBoxPharmacy.Items.Add(string.Join(" ", item));
            }
        }
        public FormAvailability()
        {
            InitializeComponent();
            ShowComboBox();
            ShowAvailib();
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!Char.IsDigit(num) && num != 8 || num == 127)
            {
                e.Handled = true;
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Availability availability = new Availability();
            availability.IdPharmacy = Convert.ToInt32(comboBoxPharmacy.SelectedItem.ToString().Split('.')[0]);
            availability.IdDrugs = Convert.ToInt32(comboBoxDrugs.SelectedItem.ToString().Split('.')[0]);
            availability.Value = textBoxValue.Text;
            availability.Price = textBoxPrice.Text;
            Program.PhDB.Availability.Add(availability);
            Program.PhDB.SaveChanges();
            ShowAvailib();
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewAvailib.SelectedItems.Count == 1)
            {
                Availability availability = listViewAvailib.SelectedItems[0].Tag as Availability;
                availability.IdPharmacy = Convert.ToInt32(comboBoxPharmacy.SelectedItem.ToString().Split('.')[0]);
                availability.IdDrugs = Convert.ToInt32(comboBoxDrugs.SelectedItem.ToString().Split('.')[0]);
                availability.Value = textBoxValue.Text;
                availability.Price = textBoxPrice.Text;
                Program.PhDB.SaveChanges();
                ShowAvailib();
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewAvailib.SelectedItems.Count == 1)
                {
                    Availability availability = listViewAvailib.SelectedItems[0].Tag as Availability;
                    Program.PhDB.Availability.Remove(availability);
                    Program.PhDB.SaveChanges();
                    ShowAvailib();
                    comboBoxDrugs.SelectedIndex = 0;
                    comboBoxPharmacy.SelectedIndex = 0;
                    textBoxPrice.Text = "";
                    textBoxValue.Text = "";
                }
                else
                {
                    comboBoxDrugs.SelectedIndex = 0;
                    comboBoxPharmacy.SelectedIndex = 0;
                    textBoxPrice.Text = "";
                    textBoxValue.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form Menu = Application.OpenForms[0];
            Menu.Show();
            this.Close();
        }
    }
}