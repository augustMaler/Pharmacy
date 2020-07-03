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
    public partial class FormPharmacy : Form
    {
        public void ShowPharmacy()
        {
            listViewPharmacy.Items.Clear();
            foreach (Pharmacy Ph in Program.PhDB.Pharmacy)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    Ph.Id.ToString(),
                    Ph.PharmacyName,
                    Ph.Adress,
                    Ph.Email,
                    Ph.Phone
                });
                item.Tag = Ph;
                listViewPharmacy.Items.Add(item);
            }
        }
        public FormPharmacy()
        {
            InitializeComponent();
            ShowPharmacy();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Pharmacy Ph = new Pharmacy();
            Ph.PharmacyName = textBoxName.Text;
            Ph.Adress = textBoxAddress.Text;
            Ph.Phone = textBoxPhone.Text;
            if ((textBoxEmail.Text.Contains("@")) & (textBoxEmail.Text.Contains(".")))
            {
                Ph.Email = textBoxEmail.Text;
                Program.PhDB.Pharmacy.Add(Ph);
                Program.PhDB.SaveChanges();
                ShowPharmacy();
            }
            else
            {
                labelAttention.Text = "Неверно введена почта";
            }
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewPharmacy.SelectedItems.Count == 1)
            {
                Pharmacy Ph = listViewPharmacy.SelectedItems[0].Tag as Pharmacy;
                Ph.PharmacyName = textBoxName.Text;
                Ph.Adress = textBoxAddress.Text;
                Ph.Email = textBoxEmail.Text;
                Ph.Phone = textBoxPhone.Text;
                Program.PhDB.SaveChanges();
                ShowPharmacy();
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewPharmacy.SelectedItems.Count == 1)
                {
                    Pharmacy Ph = listViewPharmacy.SelectedItems[0].Tag as Pharmacy;
                    Program.PhDB.Pharmacy.Remove(Ph);
                    Program.PhDB.SaveChanges();
                    ShowPharmacy();
                    textBoxName.Text = "";
                    textBoxAddress.Text = "";
                    textBoxEmail.Text = "";
                    textBoxPhone.Text = "";
                }
                else
                {
                    textBoxName.Text = "";
                    textBoxAddress.Text = "";
                    textBoxEmail.Text = "";
                    textBoxPhone.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            labelAttention.Text = "";
        }

        private void listViewPharmacy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPharmacy.SelectedItems.Count == 1)
            {
                Pharmacy Ph = listViewPharmacy.SelectedItems[0].Tag as Pharmacy;
                textBoxName.Text = Ph.PharmacyName;
                textBoxAddress.Text = Ph.Adress;
                textBoxEmail.Text = Ph.Email;
                textBoxPhone.Text = Ph.Phone;
            }
            else
            {
                textBoxName.Text = "";
                textBoxAddress.Text = "";
                textBoxEmail.Text = "";
                textBoxPhone.Text = "";
            }
        }
        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!Char.IsDigit(num) && num != 8 || num == 127)
            {
                e.Handled = true;
            }
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form Menu = Application.OpenForms[0];
            Menu.Show();
            this.Hide();
        }
        private void FormPharmacy_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}