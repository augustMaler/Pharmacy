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
    public partial class FormDrugs : Form
    {
        public void ShowDrugs()
        {
            listViewDrugs.Items.Clear();
            foreach (Drugs drugs in Program.PhDB.Drugs)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    drugs.Id.ToString(),
                    drugs.DrugName,
                    drugs.ReleaseForm,
                    drugs.Dosage,
                    drugs.Manufacturer,
                    drugs.DateOfManufacture
                });
                item.Tag = drugs;
                listViewDrugs.Items.Add(item);
            }
        }
        public FormDrugs()
        {
            InitializeComponent();
            ShowDrugs();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Drugs drugs = new Drugs();
            drugs.DrugName = textBoxName.Text;
            drugs.ReleaseForm = comboBoxFormRel.Text;
            drugs.Dosage = textBoxDos.Text;
            drugs.Manufacturer = textBoxMan.Text;
            drugs.DateOfManufacture = textBoxDateOfMan.Text;
            Program.PhDB.Drugs.Add(drugs);
            Program.PhDB.SaveChanges();
            ShowDrugs();
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewDrugs.SelectedItems.Count == 1)
            {
                Drugs drugs = listViewDrugs.SelectedItems[0].Tag as Drugs;
                drugs.DrugName = textBoxName.Text;
                drugs.ReleaseForm = comboBoxFormRel.Text;
                drugs.Dosage = textBoxDos.Text;
                drugs.Manufacturer = textBoxMan.Text;
                drugs.DateOfManufacture = textBoxDateOfMan.Text;
                Program.PhDB.SaveChanges();
                ShowDrugs();
            }
        }

        private void listViewDrugs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDrugs.SelectedItems.Count == 1)
            {
                Drugs drugs = listViewDrugs.SelectedItems[0].Tag as Drugs;
                textBoxName.Text = drugs.DrugName;
                comboBoxFormRel.Text = drugs.ReleaseForm;
                textBoxDos.Text = drugs.Dosage;
                textBoxMan.Text = drugs.Manufacturer;
                textBoxDateOfMan.Text = drugs.DateOfManufacture;
                double a = 0;
                double b = 0;
                foreach (Availability availability in Program.PhDB.Availability)
                {
                    if (drugs.Id == availability.IdDrugs)
                    {
                        b++;
                        a += Convert.ToInt32(availability.Price);
                        ListViewItem item = new ListViewItem(new string[]
                        {
                            availability.Id.ToString(),
                            availability.Pharmacy.PharmacyName,
                            availability.Value
                        });
                        item.Tag = availability;
                        listView1.Items.Add(item);
                    }

                }
                a = a / b;
                textBoxPrice.Text = a.ToString();
            }
            else
            {
                textBoxName.Text = "";
                comboBoxFormRel.Text = "";
                textBoxDos.Text = "";
                textBoxMan.Text = "";
                textBoxDateOfMan.Text = "";
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewDrugs.SelectedItems.Count == 1)
                {
                    Drugs drugs = listViewDrugs.SelectedItems[0].Tag as Drugs;
                    Program.PhDB.Drugs.Remove(drugs);
                    Program.PhDB.SaveChanges();
                    ShowDrugs();
                    textBoxName.Text = "";
                    comboBoxFormRel.Text = "";
                    textBoxDos.Text = "";
                    textBoxMan.Text = "";
                    textBoxDateOfMan.Text = "";
                }
                else
                {
                    textBoxName.Text = "";
                    comboBoxFormRel.Text = "";
                    textBoxDos.Text = "";
                    textBoxMan.Text = "";
                    textBoxDateOfMan.Text = "";
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