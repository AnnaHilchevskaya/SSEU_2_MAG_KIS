namespace Student
{
    partial class FormStudent
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
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.labelFIO = new System.Windows.Forms.Label();
            this.labelNstud = new System.Windows.Forms.Label();
            this.textBoxNstud = new System.Windows.Forms.TextBox();
            this.labelKurs = new System.Windows.Forms.Label();
            this.numericUpDownKurs = new System.Windows.Forms.NumericUpDown();
            this.labelGruppa = new System.Windows.Forms.Label();
            this.textBoxGruppa = new System.Windows.Forms.TextBox();
            this.labelBudget = new System.Windows.Forms.Label();
            this.radioButtonBudget = new System.Windows.Forms.RadioButton();
            this.radioButtonCommerce = new System.Windows.Forms.RadioButton();
            this.textBoxStudentInfo = new System.Windows.Forms.TextBox();
            this.comboBoxSemestr = new System.Windows.Forms.ComboBox();
            this.numericUpDownEkz1 = new System.Windows.Forms.NumericUpDown();
            this.groupBoxOzenki = new System.Windows.Forms.GroupBox();
            this.numericUpDownEkz5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEkz4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEkz3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEkz2 = new System.Windows.Forms.NumericUpDown();
            this.checkBoxEkz1 = new System.Windows.Forms.CheckBox();
            this.checkBoxEkz1neyavka = new System.Windows.Forms.CheckBox();
            this.checkBoxEkz2neyavka = new System.Windows.Forms.CheckBox();
            this.checkBoxEkz2 = new System.Windows.Forms.CheckBox();
            this.checkBoxEkz3neyavka = new System.Windows.Forms.CheckBox();
            this.checkBoxEkz3 = new System.Windows.Forms.CheckBox();
            this.checkBoxEkz4neyavka = new System.Windows.Forms.CheckBox();
            this.checkBoxEkz4 = new System.Windows.Forms.CheckBox();
            this.checkBoxEkz5neyavka = new System.Windows.Forms.CheckBox();
            this.checkBoxEkz5 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEkz1)).BeginInit();
            this.groupBoxOzenki.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEkz5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEkz4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEkz3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEkz2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(52, 6);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(228, 20);
            this.textBoxFIO.TabIndex = 0;
            this.textBoxFIO.TextChanged += new System.EventHandler(this.textBoxFIO_TextChanged);
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(12, 9);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(34, 13);
            this.labelFIO.TabIndex = 1;
            this.labelFIO.Text = "���";
            // 
            // labelNstud
            // 
            this.labelNstud.AutoSize = true;
            this.labelNstud.Location = new System.Drawing.Point(13, 38);
            this.labelNstud.Name = "labelNstud";
            this.labelNstud.Size = new System.Drawing.Size(133, 13);
            this.labelNstud.TabIndex = 2;
            this.labelNstud.Text = "� ������������� ������";
            // 
            // textBoxNstud
            // 
            this.textBoxNstud.Location = new System.Drawing.Point(154, 36);
            this.textBoxNstud.MaxLength = 6;
            this.textBoxNstud.Name = "textBoxNstud";
            this.textBoxNstud.Size = new System.Drawing.Size(126, 20);
            this.textBoxNstud.TabIndex = 3;
            this.textBoxNstud.Text = "000000";
            this.textBoxNstud.TextChanged += new System.EventHandler(this.textBoxNstud_TextChanged);
            // 
            // labelKurs
            // 
            this.labelKurs.AutoSize = true;
            this.labelKurs.Location = new System.Drawing.Point(13, 67);
            this.labelKurs.Name = "labelKurs";
            this.labelKurs.Size = new System.Drawing.Size(31, 13);
            this.labelKurs.TabIndex = 4;
            this.labelKurs.Text = "����";
            // 
            // numericUpDownKurs
            // 
            this.numericUpDownKurs.Location = new System.Drawing.Point(50, 65);
            this.numericUpDownKurs.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownKurs.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownKurs.Name = "numericUpDownKurs";
            this.numericUpDownKurs.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownKurs.TabIndex = 5;
            this.numericUpDownKurs.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownKurs.ValueChanged += new System.EventHandler(this.numericUpDownKurs_ValueChanged);
            // 
            // labelGruppa
            // 
            this.labelGruppa.AutoSize = true;
            this.labelGruppa.Location = new System.Drawing.Point(136, 66);
            this.labelGruppa.Name = "labelGruppa";
            this.labelGruppa.Size = new System.Drawing.Size(42, 13);
            this.labelGruppa.TabIndex = 6;
            this.labelGruppa.Text = "������";
            // 
            // textBoxGruppa
            // 
            this.textBoxGruppa.Location = new System.Drawing.Point(181, 64);
            this.textBoxGruppa.Name = "textBoxGruppa";
            this.textBoxGruppa.Size = new System.Drawing.Size(99, 20);
            this.textBoxGruppa.TabIndex = 7;
            this.textBoxGruppa.TextChanged += new System.EventHandler(this.textGruppa_TextChanged);
            // 
            // labelBudget
            // 
            this.labelBudget.AutoSize = true;
            this.labelBudget.Location = new System.Drawing.Point(15, 92);
            this.labelBudget.Name = "labelBudget";
            this.labelBudget.Size = new System.Drawing.Size(75, 13);
            this.labelBudget.TabIndex = 8;
            this.labelBudget.Text = "��������� ��";
            // 
            // radioButtonBudget
            // 
            this.radioButtonBudget.AutoSize = true;
            this.radioButtonBudget.Checked = true;
            this.radioButtonBudget.Location = new System.Drawing.Point(99, 91);
            this.radioButtonBudget.Name = "radioButtonBudget";
            this.radioButtonBudget.Size = new System.Drawing.Size(121, 17);
            this.radioButtonBudget.TabIndex = 9;
            this.radioButtonBudget.TabStop = true;
            this.radioButtonBudget.Text = "��������� ������";
            this.radioButtonBudget.UseVisualStyleBackColor = true;
            this.radioButtonBudget.CheckedChanged += new System.EventHandler(this.radioButtonBudget_CheckedChanged);
            // 
            // radioButtonCommerce
            // 
            this.radioButtonCommerce.AutoSize = true;
            this.radioButtonCommerce.Location = new System.Drawing.Point(99, 114);
            this.radioButtonCommerce.Name = "radioButtonCommerce";
            this.radioButtonCommerce.Size = new System.Drawing.Size(139, 17);
            this.radioButtonCommerce.TabIndex = 10;
            this.radioButtonCommerce.Text = "������������ ������";
            this.radioButtonCommerce.UseVisualStyleBackColor = true;
            // 
            // textBoxStudentInfo
            // 
            this.textBoxStudentInfo.Location = new System.Drawing.Point(16, 136);
            this.textBoxStudentInfo.Multiline = true;
            this.textBoxStudentInfo.Name = "textBoxStudentInfo";
            this.textBoxStudentInfo.ReadOnly = true;
            this.textBoxStudentInfo.Size = new System.Drawing.Size(264, 121);
            this.textBoxStudentInfo.TabIndex = 11;
            // 
            // comboBoxSemestr
            // 
            this.comboBoxSemestr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSemestr.FormattingEnabled = true;
            this.comboBoxSemestr.Items.AddRange(new object[] {
            "1 �������",
            "2 �������"});
            this.comboBoxSemestr.Location = new System.Drawing.Point(56, 19);
            this.comboBoxSemestr.Name = "comboBoxSemestr";
            this.comboBoxSemestr.Size = new System.Drawing.Size(166, 21);
            this.comboBoxSemestr.TabIndex = 12;
            this.comboBoxSemestr.SelectedIndexChanged += new System.EventHandler(this.comboBoxSemestr_SelectedIndexChanged);
            // 
            // numericUpDownEkz1
            // 
            this.numericUpDownEkz1.Location = new System.Drawing.Point(107, 51);
            this.numericUpDownEkz1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownEkz1.Name = "numericUpDownEkz1";
            this.numericUpDownEkz1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownEkz1.TabIndex = 13;
            // 
            // groupBoxOzenki
            // 
            this.groupBoxOzenki.Controls.Add(this.checkBoxEkz5neyavka);
            this.groupBoxOzenki.Controls.Add(this.checkBoxEkz5);
            this.groupBoxOzenki.Controls.Add(this.checkBoxEkz4neyavka);
            this.groupBoxOzenki.Controls.Add(this.checkBoxEkz4);
            this.groupBoxOzenki.Controls.Add(this.checkBoxEkz3neyavka);
            this.groupBoxOzenki.Controls.Add(this.checkBoxEkz3);
            this.groupBoxOzenki.Controls.Add(this.checkBoxEkz2neyavka);
            this.groupBoxOzenki.Controls.Add(this.checkBoxEkz2);
            this.groupBoxOzenki.Controls.Add(this.checkBoxEkz1neyavka);
            this.groupBoxOzenki.Controls.Add(this.checkBoxEkz1);
            this.groupBoxOzenki.Controls.Add(this.comboBoxSemestr);
            this.groupBoxOzenki.Controls.Add(this.numericUpDownEkz5);
            this.groupBoxOzenki.Controls.Add(this.numericUpDownEkz4);
            this.groupBoxOzenki.Controls.Add(this.numericUpDownEkz3);
            this.groupBoxOzenki.Controls.Add(this.numericUpDownEkz2);
            this.groupBoxOzenki.Controls.Add(this.numericUpDownEkz1);
            this.groupBoxOzenki.Location = new System.Drawing.Point(16, 263);
            this.groupBoxOzenki.Name = "groupBoxOzenki";
            this.groupBoxOzenki.Size = new System.Drawing.Size(264, 245);
            this.groupBoxOzenki.TabIndex = 14;
            this.groupBoxOzenki.TabStop = false;
            this.groupBoxOzenki.Text = "������ �� ��������";
            // 
            // numericUpDownEkz5
            // 
            this.numericUpDownEkz5.Location = new System.Drawing.Point(107, 180);
            this.numericUpDownEkz5.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownEkz5.Name = "numericUpDownEkz5";
            this.numericUpDownEkz5.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownEkz5.TabIndex = 17;
            this.numericUpDownEkz5.ValueChanged += new System.EventHandler(this.numericUpDownEkz5_ValueChanged);
            // 
            // numericUpDownEkz4
            // 
            this.numericUpDownEkz4.Location = new System.Drawing.Point(107, 148);
            this.numericUpDownEkz4.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownEkz4.Name = "numericUpDownEkz4";
            this.numericUpDownEkz4.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownEkz4.TabIndex = 16;
            this.numericUpDownEkz4.ValueChanged += new System.EventHandler(this.numericUpDownEkz4_ValueChanged);
            // 
            // numericUpDownEkz3
            // 
            this.numericUpDownEkz3.Location = new System.Drawing.Point(107, 115);
            this.numericUpDownEkz3.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownEkz3.Name = "numericUpDownEkz3";
            this.numericUpDownEkz3.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownEkz3.TabIndex = 15;
            this.numericUpDownEkz3.ValueChanged += new System.EventHandler(this.numericUpDownEkz3_ValueChanged);
            // 
            // numericUpDownEkz2
            // 
            this.numericUpDownEkz2.Location = new System.Drawing.Point(107, 83);
            this.numericUpDownEkz2.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownEkz2.Name = "numericUpDownEkz2";
            this.numericUpDownEkz2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownEkz2.TabIndex = 14;
            this.numericUpDownEkz2.ValueChanged += new System.EventHandler(this.numericUpDownEkz2_ValueChanged);
            // 
            // checkBoxEkz1
            // 
            this.checkBoxEkz1.AutoSize = true;
            this.checkBoxEkz1.Checked = true;
            this.checkBoxEkz1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEkz1.Location = new System.Drawing.Point(16, 46);
            this.checkBoxEkz1.Name = "checkBoxEkz1";
            this.checkBoxEkz1.Size = new System.Drawing.Size(77, 17);
            this.checkBoxEkz1.TabIndex = 18;
            this.checkBoxEkz1.Text = "�������1";
            this.checkBoxEkz1.UseVisualStyleBackColor = true;
            this.checkBoxEkz1.CheckedChanged += new System.EventHandler(this.checkBoxEkz1_CheckedChanged);
            // 
            // checkBoxEkz1neyavka
            // 
            this.checkBoxEkz1neyavka.AutoSize = true;
            this.checkBoxEkz1neyavka.Location = new System.Drawing.Point(16, 62);
            this.checkBoxEkz1neyavka.Name = "checkBoxEkz1neyavka";
            this.checkBoxEkz1neyavka.Size = new System.Drawing.Size(62, 17);
            this.checkBoxEkz1neyavka.TabIndex = 19;
            this.checkBoxEkz1neyavka.Text = "������";
            this.checkBoxEkz1neyavka.UseVisualStyleBackColor = true;
            this.checkBoxEkz1neyavka.CheckedChanged += new System.EventHandler(this.checkBoxEkz1neyavka_CheckedChanged);
            // 
            // checkBoxEkz2neyavka
            // 
            this.checkBoxEkz2neyavka.AutoSize = true;
            this.checkBoxEkz2neyavka.Location = new System.Drawing.Point(16, 93);
            this.checkBoxEkz2neyavka.Name = "checkBoxEkz2neyavka";
            this.checkBoxEkz2neyavka.Size = new System.Drawing.Size(62, 17);
            this.checkBoxEkz2neyavka.TabIndex = 21;
            this.checkBoxEkz2neyavka.Text = "������";
            this.checkBoxEkz2neyavka.UseVisualStyleBackColor = true;
            this.checkBoxEkz2neyavka.CheckedChanged += new System.EventHandler(this.checkBoxEkz2neyavka_CheckedChanged);
            // 
            // checkBoxEkz2
            // 
            this.checkBoxEkz2.AutoSize = true;
            this.checkBoxEkz2.Checked = true;
            this.checkBoxEkz2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEkz2.Location = new System.Drawing.Point(16, 77);
            this.checkBoxEkz2.Name = "checkBoxEkz2";
            this.checkBoxEkz2.Size = new System.Drawing.Size(77, 17);
            this.checkBoxEkz2.TabIndex = 20;
            this.checkBoxEkz2.Text = "�������1";
            this.checkBoxEkz2.UseVisualStyleBackColor = true;
            this.checkBoxEkz2.CheckedChanged += new System.EventHandler(this.checkBoxEkz2_CheckedChanged);
            // 
            // checkBoxEkz3neyavka
            // 
            this.checkBoxEkz3neyavka.AutoSize = true;
            this.checkBoxEkz3neyavka.Location = new System.Drawing.Point(17, 126);
            this.checkBoxEkz3neyavka.Name = "checkBoxEkz3neyavka";
            this.checkBoxEkz3neyavka.Size = new System.Drawing.Size(62, 17);
            this.checkBoxEkz3neyavka.TabIndex = 23;
            this.checkBoxEkz3neyavka.Text = "������";
            this.checkBoxEkz3neyavka.UseVisualStyleBackColor = true;
            this.checkBoxEkz3neyavka.CheckedChanged += new System.EventHandler(this.checkBoxEkz3neyavka_CheckedChanged);
            // 
            // checkBoxEkz3
            // 
            this.checkBoxEkz3.AutoSize = true;
            this.checkBoxEkz3.Checked = true;
            this.checkBoxEkz3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEkz3.Location = new System.Drawing.Point(17, 110);
            this.checkBoxEkz3.Name = "checkBoxEkz3";
            this.checkBoxEkz3.Size = new System.Drawing.Size(77, 17);
            this.checkBoxEkz3.TabIndex = 22;
            this.checkBoxEkz3.Text = "�������1";
            this.checkBoxEkz3.UseVisualStyleBackColor = true;
            this.checkBoxEkz3.CheckedChanged += new System.EventHandler(this.checkBoxEkz3_CheckedChanged);
            // 
            // checkBoxEkz4neyavka
            // 
            this.checkBoxEkz4neyavka.AutoSize = true;
            this.checkBoxEkz4neyavka.Location = new System.Drawing.Point(17, 158);
            this.checkBoxEkz4neyavka.Name = "checkBoxEkz4neyavka";
            this.checkBoxEkz4neyavka.Size = new System.Drawing.Size(62, 17);
            this.checkBoxEkz4neyavka.TabIndex = 25;
            this.checkBoxEkz4neyavka.Text = "������";
            this.checkBoxEkz4neyavka.UseVisualStyleBackColor = true;
            this.checkBoxEkz4neyavka.CheckedChanged += new System.EventHandler(this.checkBoxEkz4neyavka_CheckedChanged);
            // 
            // checkBoxEkz4
            // 
            this.checkBoxEkz4.AutoSize = true;
            this.checkBoxEkz4.Checked = true;
            this.checkBoxEkz4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEkz4.Location = new System.Drawing.Point(17, 142);
            this.checkBoxEkz4.Name = "checkBoxEkz4";
            this.checkBoxEkz4.Size = new System.Drawing.Size(77, 17);
            this.checkBoxEkz4.TabIndex = 24;
            this.checkBoxEkz4.Text = "�������1";
            this.checkBoxEkz4.UseVisualStyleBackColor = true;
            this.checkBoxEkz4.CheckedChanged += new System.EventHandler(this.checkBoxEkz4_CheckedChanged);
            // 
            // checkBoxEkz5neyavka
            // 
            this.checkBoxEkz5neyavka.AutoSize = true;
            this.checkBoxEkz5neyavka.Location = new System.Drawing.Point(17, 190);
            this.checkBoxEkz5neyavka.Name = "checkBoxEkz5neyavka";
            this.checkBoxEkz5neyavka.Size = new System.Drawing.Size(62, 17);
            this.checkBoxEkz5neyavka.TabIndex = 27;
            this.checkBoxEkz5neyavka.Text = "������";
            this.checkBoxEkz5neyavka.UseVisualStyleBackColor = true;
            this.checkBoxEkz5neyavka.CheckedChanged += new System.EventHandler(this.checkBoxEkz5neyavka_CheckedChanged);
            // 
            // checkBoxEkz5
            // 
            this.checkBoxEkz5.AutoSize = true;
            this.checkBoxEkz5.Checked = true;
            this.checkBoxEkz5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEkz5.Location = new System.Drawing.Point(17, 174);
            this.checkBoxEkz5.Name = "checkBoxEkz5";
            this.checkBoxEkz5.Size = new System.Drawing.Size(77, 17);
            this.checkBoxEkz5.TabIndex = 26;
            this.checkBoxEkz5.Text = "�������1";
            this.checkBoxEkz5.UseVisualStyleBackColor = true;
            this.checkBoxEkz5.CheckedChanged += new System.EventHandler(this.checkBoxEkz5_CheckedChanged);
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 520);
            this.Controls.Add(this.groupBoxOzenki);
            this.Controls.Add(this.textBoxStudentInfo);
            this.Controls.Add(this.radioButtonCommerce);
            this.Controls.Add(this.radioButtonBudget);
            this.Controls.Add(this.labelBudget);
            this.Controls.Add(this.textBoxGruppa);
            this.Controls.Add(this.labelGruppa);
            this.Controls.Add(this.numericUpDownKurs);
            this.Controls.Add(this.labelKurs);
            this.Controls.Add(this.textBoxNstud);
            this.Controls.Add(this.labelNstud);
            this.Controls.Add(this.labelFIO);
            this.Controls.Add(this.textBoxFIO);
            this.Name = "FormStudent";
            this.Text = "�������";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEkz1)).EndInit();
            this.groupBoxOzenki.ResumeLayout(false);
            this.groupBoxOzenki.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEkz5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEkz4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEkz3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEkz2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Label labelNstud;
        private System.Windows.Forms.TextBox textBoxNstud;
        private System.Windows.Forms.Label labelKurs;
        private System.Windows.Forms.NumericUpDown numericUpDownKurs;
        private System.Windows.Forms.Label labelGruppa;
        private System.Windows.Forms.TextBox textBoxGruppa;
        private System.Windows.Forms.Label labelBudget;
        private System.Windows.Forms.RadioButton radioButtonBudget;
        private System.Windows.Forms.RadioButton radioButtonCommerce;
        private System.Windows.Forms.TextBox textBoxStudentInfo;
        private System.Windows.Forms.ComboBox comboBoxSemestr;
        private System.Windows.Forms.NumericUpDown numericUpDownEkz1;
        private System.Windows.Forms.GroupBox groupBoxOzenki;
        private System.Windows.Forms.NumericUpDown numericUpDownEkz5;
        private System.Windows.Forms.NumericUpDown numericUpDownEkz4;
        private System.Windows.Forms.NumericUpDown numericUpDownEkz3;
        private System.Windows.Forms.NumericUpDown numericUpDownEkz2;
        private System.Windows.Forms.CheckBox checkBoxEkz5neyavka;
        private System.Windows.Forms.CheckBox checkBoxEkz5;
        private System.Windows.Forms.CheckBox checkBoxEkz4neyavka;
        private System.Windows.Forms.CheckBox checkBoxEkz4;
        private System.Windows.Forms.CheckBox checkBoxEkz3neyavka;
        private System.Windows.Forms.CheckBox checkBoxEkz3;
        private System.Windows.Forms.CheckBox checkBoxEkz2neyavka;
        private System.Windows.Forms.CheckBox checkBoxEkz2;
        private System.Windows.Forms.CheckBox checkBoxEkz1neyavka;
        private System.Windows.Forms.CheckBox checkBoxEkz1;

    }
}

