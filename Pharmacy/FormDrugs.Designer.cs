namespace Pharmacy
{
    partial class FormDrugs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDrugs));
            this.labelNameLogo = new System.Windows.Forms.Label();
            this.labelLogo = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.listViewDrugs = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DrugName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FormRel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Man = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateOfMan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelPDateOfMame = new System.Windows.Forms.Label();
            this.labelMan = new System.Windows.Forms.Label();
            this.labelDos = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxDateOfMan = new System.Windows.Forms.TextBox();
            this.textBoxMan = new System.Windows.Forms.TextBox();
            this.textBoxDos = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelFormRel = new System.Windows.Forms.Label();
            this.comboBoxFormRel = new System.Windows.Forms.ComboBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.IdPh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NamePh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelValue = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNameLogo
            // 
            this.labelNameLogo.AutoSize = true;
            this.labelNameLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.labelNameLogo.Font = new System.Drawing.Font("Calibri", 40F);
            this.labelNameLogo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelNameLogo.Location = new System.Drawing.Point(511, 33);
            this.labelNameLogo.Name = "labelNameLogo";
            this.labelNameLogo.Size = new System.Drawing.Size(262, 66);
            this.labelNameLogo.TabIndex = 19;
            this.labelNameLogo.Text = "Лекарства";
            // 
            // labelLogo
            // 
            this.labelLogo.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelLogo.Location = new System.Drawing.Point(150, 28);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(87, 92);
            this.labelLogo.TabIndex = 18;
            this.labelLogo.Text = "Аптеки\r\nМира\r\nСего";
            this.labelLogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(15, 15);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(126, 119);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 17;
            this.pictureBoxLogo.TabStop = false;
            // 
            // listViewDrugs
            // 
            this.listViewDrugs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listViewDrugs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewDrugs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.DrugName,
            this.FormRel,
            this.Dos,
            this.Man,
            this.DateOfMan});
            this.listViewDrugs.Font = new System.Drawing.Font("Calibri", 12F);
            this.listViewDrugs.FullRowSelect = true;
            this.listViewDrugs.GridLines = true;
            this.listViewDrugs.HideSelection = false;
            this.listViewDrugs.Location = new System.Drawing.Point(12, 158);
            this.listViewDrugs.Name = "listViewDrugs";
            this.listViewDrugs.Size = new System.Drawing.Size(804, 391);
            this.listViewDrugs.TabIndex = 20;
            this.listViewDrugs.UseCompatibleStateImageBehavior = false;
            this.listViewDrugs.View = System.Windows.Forms.View.Details;
            this.listViewDrugs.SelectedIndexChanged += new System.EventHandler(this.listViewDrugs_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 25;
            // 
            // DrugName
            // 
            this.DrugName.Text = "Название Лекарства";
            this.DrugName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DrugName.Width = 200;
            // 
            // FormRel
            // 
            this.FormRel.Text = "Форма выпуска";
            this.FormRel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FormRel.Width = 150;
            // 
            // Dos
            // 
            this.Dos.Text = "Дозировка";
            this.Dos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Dos.Width = 100;
            // 
            // Man
            // 
            this.Man.Text = "Производитель";
            this.Man.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Man.Width = 150;
            // 
            // DateOfMan
            // 
            this.DateOfMan.Text = "Дата выпуска";
            this.DateOfMan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DateOfMan.Width = 179;
            // 
            // labelPDateOfMame
            // 
            this.labelPDateOfMame.AutoSize = true;
            this.labelPDateOfMame.Font = new System.Drawing.Font("Calibri", 15.25F);
            this.labelPDateOfMame.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelPDateOfMame.Location = new System.Drawing.Point(1099, 373);
            this.labelPDateOfMame.Name = "labelPDateOfMame";
            this.labelPDateOfMame.Size = new System.Drawing.Size(133, 26);
            this.labelPDateOfMame.TabIndex = 31;
            this.labelPDateOfMame.Text = "Дата выпуска";
            // 
            // labelMan
            // 
            this.labelMan.AutoSize = true;
            this.labelMan.Font = new System.Drawing.Font("Calibri", 15.25F);
            this.labelMan.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelMan.Location = new System.Drawing.Point(1090, 308);
            this.labelMan.Name = "labelMan";
            this.labelMan.Size = new System.Drawing.Size(149, 26);
            this.labelMan.TabIndex = 30;
            this.labelMan.Text = "Производитель";
            // 
            // labelDos
            // 
            this.labelDos.AutoSize = true;
            this.labelDos.Font = new System.Drawing.Font("Calibri", 15.25F);
            this.labelDos.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelDos.Location = new System.Drawing.Point(1110, 243);
            this.labelDos.Name = "labelDos";
            this.labelDos.Size = new System.Drawing.Size(109, 26);
            this.labelDos.TabIndex = 29;
            this.labelDos.Text = "Дозировка";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Calibri", 15.25F);
            this.labelName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelName.Location = new System.Drawing.Point(1069, 113);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(190, 26);
            this.labelName.TabIndex = 28;
            this.labelName.Text = "Название лекарства";
            // 
            // textBoxDateOfMan
            // 
            this.textBoxDateOfMan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxDateOfMan.Location = new System.Drawing.Point(1090, 403);
            this.textBoxDateOfMan.MaxLength = 11;
            this.textBoxDateOfMan.Name = "textBoxDateOfMan";
            this.textBoxDateOfMan.Size = new System.Drawing.Size(151, 31);
            this.textBoxDateOfMan.TabIndex = 27;
            this.textBoxDateOfMan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMan
            // 
            this.textBoxMan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxMan.Location = new System.Drawing.Point(1055, 338);
            this.textBoxMan.Name = "textBoxMan";
            this.textBoxMan.Size = new System.Drawing.Size(218, 31);
            this.textBoxMan.TabIndex = 26;
            this.textBoxMan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDos
            // 
            this.textBoxDos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxDos.Location = new System.Drawing.Point(1055, 273);
            this.textBoxDos.Name = "textBoxDos";
            this.textBoxDos.Size = new System.Drawing.Size(218, 31);
            this.textBoxDos.TabIndex = 25;
            this.textBoxDos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxName.Location = new System.Drawing.Point(1055, 143);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(218, 31);
            this.textBoxName.TabIndex = 24;
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.buttonDelete.Location = new System.Drawing.Point(1077, 517);
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
            this.buttonAdd.Location = new System.Drawing.Point(1077, 441);
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
            this.buttonEdit.Location = new System.Drawing.Point(1077, 479);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(174, 32);
            this.buttonEdit.TabIndex = 21;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // labelFormRel
            // 
            this.labelFormRel.AutoSize = true;
            this.labelFormRel.Font = new System.Drawing.Font("Calibri", 15.25F);
            this.labelFormRel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelFormRel.Location = new System.Drawing.Point(1089, 178);
            this.labelFormRel.Name = "labelFormRel";
            this.labelFormRel.Size = new System.Drawing.Size(152, 26);
            this.labelFormRel.TabIndex = 33;
            this.labelFormRel.Text = "Форма выпуска";
            // 
            // comboBoxFormRel
            // 
            this.comboBoxFormRel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboBoxFormRel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFormRel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxFormRel.FormattingEnabled = true;
            this.comboBoxFormRel.Items.AddRange(new object[] {
            "Таблетки",
            "Капсулы",
            "Ампулы",
            "Сироп",
            "Крем"});
            this.comboBoxFormRel.Location = new System.Drawing.Point(1090, 208);
            this.comboBoxFormRel.Name = "comboBoxFormRel";
            this.comboBoxFormRel.Size = new System.Drawing.Size(151, 31);
            this.comboBoxFormRel.TabIndex = 34;
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
            this.buttonBack.Location = new System.Drawing.Point(1098, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(174, 32);
            this.buttonBack.TabIndex = 35;
            this.buttonBack.Text = "Вернуться назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdPh,
            this.NamePh});
            this.listView1.Font = new System.Drawing.Font("Calibri", 12F);
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(21, 144);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(182, 391);
            this.listView1.TabIndex = 36;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // IdPh
            // 
            this.IdPh.Text = "Id";
            this.IdPh.Width = 28;
            // 
            // NamePh
            // 
            this.NamePh.Text = "Название аптеки";
            this.NamePh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NamePh.Width = 150;
            // 
            // textBoxValue
            // 
            this.textBoxValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxValue.Location = new System.Drawing.Point(41, 43);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.ReadOnly = true;
            this.textBoxValue.Size = new System.Drawing.Size(144, 31);
            this.textBoxValue.TabIndex = 37;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxPrice.Location = new System.Drawing.Point(41, 108);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(144, 31);
            this.textBoxPrice.TabIndex = 38;
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Font = new System.Drawing.Font("Calibri", 15.25F);
            this.labelValue.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelValue.Location = new System.Drawing.Point(48, 14);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(131, 26);
            this.labelValue.TabIndex = 40;
            this.labelValue.Text = "Общее колво";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Calibri", 15.25F);
            this.labelPrice.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelPrice.Location = new System.Drawing.Point(46, 79);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(134, 26);
            this.labelPrice.TabIndex = 39;
            this.labelPrice.Text = "Средняя цена";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelValue);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.labelPrice);
            this.panel1.Controls.Add(this.textBoxPrice);
            this.panel1.Controls.Add(this.textBoxValue);
            this.panel1.Location = new System.Drawing.Point(822, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 535);
            this.panel1.TabIndex = 41;
            // 
            // FormDrugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1284, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.comboBoxFormRel);
            this.Controls.Add(this.labelFormRel);
            this.Controls.Add(this.labelPDateOfMame);
            this.Controls.Add(this.labelMan);
            this.Controls.Add(this.labelDos);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxDateOfMan);
            this.Controls.Add(this.textBoxMan);
            this.Controls.Add(this.textBoxDos);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.listViewDrugs);
            this.Controls.Add(this.labelNameLogo);
            this.Controls.Add(this.labelLogo);
            this.Controls.Add(this.pictureBoxLogo);
            this.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(1300, 600);
            this.MinimumSize = new System.Drawing.Size(1300, 600);
            this.Name = "FormDrugs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDrugs";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDrugs_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNameLogo;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.ListView listViewDrugs;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader DrugName;
        private System.Windows.Forms.ColumnHeader FormRel;
        private System.Windows.Forms.ColumnHeader Dos;
        private System.Windows.Forms.ColumnHeader Man;
        private System.Windows.Forms.ColumnHeader DateOfMan;
        private System.Windows.Forms.Label labelPDateOfMame;
        private System.Windows.Forms.Label labelMan;
        private System.Windows.Forms.Label labelDos;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxDateOfMan;
        private System.Windows.Forms.TextBox textBoxMan;
        private System.Windows.Forms.TextBox textBoxDos;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelFormRel;
        private System.Windows.Forms.ComboBox comboBoxFormRel;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader IdPh;
        private System.Windows.Forms.ColumnHeader NamePh;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Panel panel1;
    }
}