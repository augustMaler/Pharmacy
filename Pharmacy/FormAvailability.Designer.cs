namespace Pharmacy
{
    partial class FormAvailability
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAvailability));
            this.labelAttention = new System.Windows.Forms.Label();
            this.labelNameLogo = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelValue = new System.Windows.Forms.Label();
            this.labelNamePh = new System.Windows.Forms.Label();
            this.labelNameDrugs = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.listViewAvailib = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PharmacyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DrugsName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelLogo = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.comboBoxPharmacy = new System.Windows.Forms.ComboBox();
            this.comboBoxDrugs = new System.Windows.Forms.ComboBox();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAttention
            // 
            this.labelAttention.Font = new System.Drawing.Font("Calibri", 16.25F);
            this.labelAttention.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelAttention.Location = new System.Drawing.Point(734, 115);
            this.labelAttention.Name = "labelAttention";
            this.labelAttention.Size = new System.Drawing.Size(242, 27);
            this.labelAttention.TabIndex = 33;
            this.labelAttention.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNameLogo
            // 
            this.labelNameLogo.AutoSize = true;
            this.labelNameLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.labelNameLogo.Font = new System.Drawing.Font("Calibri", 40F);
            this.labelNameLogo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelNameLogo.Location = new System.Drawing.Point(379, 26);
            this.labelNameLogo.Name = "labelNameLogo";
            this.labelNameLogo.Size = new System.Drawing.Size(226, 66);
            this.labelNameLogo.TabIndex = 32;
            this.labelNameLogo.Text = "Наличие";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Calibri", 15.25F);
            this.labelPrice.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelPrice.Location = new System.Drawing.Point(832, 362);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(56, 26);
            this.labelPrice.TabIndex = 31;
            this.labelPrice.Text = "Цена";
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Font = new System.Drawing.Font("Calibri", 15.25F);
            this.labelValue.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelValue.Location = new System.Drawing.Point(803, 293);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(114, 26);
            this.labelValue.TabIndex = 30;
            this.labelValue.Text = "Количество";
            // 
            // labelNamePh
            // 
            this.labelNamePh.AutoSize = true;
            this.labelNamePh.Font = new System.Drawing.Font("Calibri", 15.25F);
            this.labelNamePh.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelNamePh.Location = new System.Drawing.Point(779, 224);
            this.labelNamePh.Name = "labelNamePh";
            this.labelNamePh.Size = new System.Drawing.Size(161, 26);
            this.labelNamePh.TabIndex = 29;
            this.labelNamePh.Text = "Название аптеки";
            // 
            // labelNameDrugs
            // 
            this.labelNameDrugs.AutoSize = true;
            this.labelNameDrugs.Font = new System.Drawing.Font("Calibri", 15.25F);
            this.labelNameDrugs.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelNameDrugs.Location = new System.Drawing.Point(765, 155);
            this.labelNameDrugs.Name = "labelNameDrugs";
            this.labelNameDrugs.Size = new System.Drawing.Size(190, 26);
            this.labelNameDrugs.TabIndex = 28;
            this.labelNameDrugs.Text = "Название лекарства";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxPrice.Location = new System.Drawing.Point(785, 393);
            this.textBoxPrice.MaxLength = 11;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(151, 31);
            this.textBoxPrice.TabIndex = 27;
            this.textBoxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // textBoxValue
            // 
            this.textBoxValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxValue.Location = new System.Drawing.Point(751, 324);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(218, 31);
            this.textBoxValue.TabIndex = 26;
            this.textBoxValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonDelete.Location = new System.Drawing.Point(773, 515);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(174, 32);
            this.buttonDelete.TabIndex = 23;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonAdd.Location = new System.Drawing.Point(773, 439);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(174, 32);
            this.buttonAdd.TabIndex = 22;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.buttonEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonEdit.Location = new System.Drawing.Point(773, 477);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(174, 32);
            this.buttonEdit.TabIndex = 21;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // listViewAvailib
            // 
            this.listViewAvailib.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewAvailib.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listViewAvailib.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewAvailib.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.PharmacyName,
            this.DrugsName,
            this.Value,
            this.Price});
            this.listViewAvailib.Font = new System.Drawing.Font("Calibri", 12F);
            this.listViewAvailib.FullRowSelect = true;
            this.listViewAvailib.GridLines = true;
            this.listViewAvailib.HideSelection = false;
            this.listViewAvailib.Location = new System.Drawing.Point(9, 156);
            this.listViewAvailib.Name = "listViewAvailib";
            this.listViewAvailib.Size = new System.Drawing.Size(728, 391);
            this.listViewAvailib.TabIndex = 20;
            this.listViewAvailib.UseCompatibleStateImageBehavior = false;
            this.listViewAvailib.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 25;
            // 
            // PharmacyName
            // 
            this.PharmacyName.Text = "Название Аптеки";
            this.PharmacyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PharmacyName.Width = 200;
            // 
            // DrugsName
            // 
            this.DrugsName.Text = "Название лекарства";
            this.DrugsName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DrugsName.Width = 200;
            // 
            // Value
            // 
            this.Value.Text = "Количество";
            this.Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Value.Width = 150;
            // 
            // Price
            // 
            this.Price.Text = "Цена";
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Price.Width = 153;
            // 
            // labelLogo
            // 
            this.labelLogo.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelLogo.Location = new System.Drawing.Point(147, 26);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(87, 92);
            this.labelLogo.TabIndex = 19;
            this.labelLogo.Text = "Аптеки\r\nМира\r\nСего";
            this.labelLogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 13);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(126, 119);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 18;
            this.pictureBoxLogo.TabStop = false;
            // 
            // comboBoxPharmacy
            // 
            this.comboBoxPharmacy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBoxPharmacy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPharmacy.FormattingEnabled = true;
            this.comboBoxPharmacy.ItemHeight = 23;
            this.comboBoxPharmacy.Location = new System.Drawing.Point(751, 253);
            this.comboBoxPharmacy.Name = "comboBoxPharmacy";
            this.comboBoxPharmacy.Size = new System.Drawing.Size(219, 31);
            this.comboBoxPharmacy.TabIndex = 34;
            // 
            // comboBoxDrugs
            // 
            this.comboBoxDrugs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBoxDrugs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDrugs.FormattingEnabled = true;
            this.comboBoxDrugs.ItemHeight = 23;
            this.comboBoxDrugs.Location = new System.Drawing.Point(751, 184);
            this.comboBoxDrugs.Name = "comboBoxDrugs";
            this.comboBoxDrugs.Size = new System.Drawing.Size(219, 31);
            this.comboBoxDrugs.TabIndex = 35;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.buttonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonBack.Location = new System.Drawing.Point(798, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(174, 32);
            this.buttonBack.TabIndex = 36;
            this.buttonBack.Text = "Вернуться назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.comboBoxDrugs);
            this.Controls.Add(this.comboBoxPharmacy);
            this.Controls.Add(this.labelAttention);
            this.Controls.Add(this.labelNameLogo);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.labelNamePh);
            this.Controls.Add(this.labelNameDrugs);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.listViewAvailib);
            this.Controls.Add(this.labelLogo);
            this.Controls.Add(this.pictureBoxLogo);
            this.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FormAvailability";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Наличие";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAttention;
        private System.Windows.Forms.Label labelNameLogo;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Label labelNamePh;
        private System.Windows.Forms.Label labelNameDrugs;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.ListView listViewAvailib;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader PharmacyName;
        private System.Windows.Forms.ColumnHeader DrugsName;
        private System.Windows.Forms.ColumnHeader Value;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.ComboBox comboBoxPharmacy;
        private System.Windows.Forms.ComboBox comboBoxDrugs;
        private System.Windows.Forms.Button buttonBack;
    }
}