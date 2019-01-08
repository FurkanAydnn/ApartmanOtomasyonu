namespace ApartmanOtomasyonu2
{
    partial class Operations
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpIncomes = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddIncome = new System.Windows.Forms.Button();
            this.dtpIncomeDate = new System.Windows.Forms.DateTimePicker();
            this.nudRoomNo = new System.Windows.Forms.NumericUpDown();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.lblDaire = new System.Windows.Forms.Label();
            this.tpExpenses = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.rbtnClean = new System.Windows.Forms.RadioButton();
            this.rbtnElevator = new System.Windows.Forms.RadioButton();
            this.rbtnSu = new System.Windows.Forms.RadioButton();
            this.rbtnElectricity = new System.Windows.Forms.RadioButton();
            this.dtpExpenseDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudIncomeAmount = new System.Windows.Forms.NumericUpDown();
            this.nudExpenseAmount = new System.Windows.Forms.NumericUpDown();
            this.dgvExpenses = new System.Windows.Forms.DataGridView();
            this.dgvIncomes = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tpIncomes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRoomNo)).BeginInit();
            this.tpExpenses.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIncomeAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExpenseAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncomes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpIncomes);
            this.tabControl1.Controls.Add(this.tpExpenses);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(320, 355);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.Operations_Load);
            // 
            // tpIncomes
            // 
            this.tpIncomes.Controls.Add(this.dgvIncomes);
            this.tpIncomes.Controls.Add(this.groupBox1);
            this.tpIncomes.Location = new System.Drawing.Point(4, 22);
            this.tpIncomes.Name = "tpIncomes";
            this.tpIncomes.Padding = new System.Windows.Forms.Padding(3);
            this.tpIncomes.Size = new System.Drawing.Size(312, 329);
            this.tpIncomes.TabIndex = 0;
            this.tpIncomes.Text = "Gelirler";
            this.tpIncomes.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudIncomeAmount);
            this.groupBox1.Controls.Add(this.btnAddIncome);
            this.groupBox1.Controls.Add(this.dtpIncomeDate);
            this.groupBox1.Controls.Add(this.nudRoomNo);
            this.groupBox1.Controls.Add(this.lblTarih);
            this.groupBox1.Controls.Add(this.lblTutar);
            this.groupBox1.Controls.Add(this.lblDaire);
            this.groupBox1.Location = new System.Drawing.Point(8, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 147);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Aidat Ekle";
            // 
            // btnAddIncome
            // 
            this.btnAddIncome.Location = new System.Drawing.Point(184, 92);
            this.btnAddIncome.Name = "btnAddIncome";
            this.btnAddIncome.Size = new System.Drawing.Size(106, 23);
            this.btnAddIncome.TabIndex = 6;
            this.btnAddIncome.Text = "Ekle";
            this.btnAddIncome.UseVisualStyleBackColor = true;
            this.btnAddIncome.Click += new System.EventHandler(this.btnAddIncome_Click);
            // 
            // dtpIncomeDate
            // 
            this.dtpIncomeDate.CustomFormat = "";
            this.dtpIncomeDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIncomeDate.Location = new System.Drawing.Point(184, 43);
            this.dtpIncomeDate.Name = "dtpIncomeDate";
            this.dtpIncomeDate.Size = new System.Drawing.Size(106, 20);
            this.dtpIncomeDate.TabIndex = 5;
            // 
            // nudRoomNo
            // 
            this.nudRoomNo.Location = new System.Drawing.Point(85, 43);
            this.nudRoomNo.Name = "nudRoomNo";
            this.nudRoomNo.Size = new System.Drawing.Size(43, 20);
            this.nudRoomNo.TabIndex = 3;
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(144, 45);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(34, 13);
            this.lblTarih.TabIndex = 2;
            this.lblTarih.Text = "Tarih:";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(27, 98);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(35, 13);
            this.lblTutar.TabIndex = 1;
            this.lblTutar.Text = "Tutar:";
            // 
            // lblDaire
            // 
            this.lblDaire.AutoSize = true;
            this.lblDaire.Location = new System.Drawing.Point(27, 45);
            this.lblDaire.Name = "lblDaire";
            this.lblDaire.Size = new System.Drawing.Size(52, 13);
            this.lblDaire.TabIndex = 0;
            this.lblDaire.Text = "Daire No:";
            // 
            // tpExpenses
            // 
            this.tpExpenses.Controls.Add(this.dgvExpenses);
            this.tpExpenses.Controls.Add(this.groupBox2);
            this.tpExpenses.Location = new System.Drawing.Point(4, 22);
            this.tpExpenses.Name = "tpExpenses";
            this.tpExpenses.Padding = new System.Windows.Forms.Padding(3);
            this.tpExpenses.Size = new System.Drawing.Size(312, 329);
            this.tpExpenses.TabIndex = 1;
            this.tpExpenses.Text = "Giderler";
            this.tpExpenses.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudExpenseAmount);
            this.groupBox2.Controls.Add(this.btnAddExpense);
            this.groupBox2.Controls.Add(this.rbtnClean);
            this.groupBox2.Controls.Add(this.rbtnElevator);
            this.groupBox2.Controls.Add(this.rbtnSu);
            this.groupBox2.Controls.Add(this.rbtnElectricity);
            this.groupBox2.Controls.Add(this.dtpExpenseDate);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(8, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 147);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yeni Gider Ekle";
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.Location = new System.Drawing.Point(184, 102);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(106, 23);
            this.btnAddExpense.TabIndex = 11;
            this.btnAddExpense.Text = "Ekle";
            this.btnAddExpense.UseVisualStyleBackColor = true;
            this.btnAddExpense.Click += new System.EventHandler(this.btnAddExpense_Click);
            // 
            // rbtnClean
            // 
            this.rbtnClean.AutoSize = true;
            this.rbtnClean.Location = new System.Drawing.Point(23, 105);
            this.rbtnClean.Name = "rbtnClean";
            this.rbtnClean.Size = new System.Drawing.Size(63, 17);
            this.rbtnClean.TabIndex = 10;
            this.rbtnClean.TabStop = true;
            this.rbtnClean.Text = "Temizlik";
            this.rbtnClean.UseVisualStyleBackColor = true;
            // 
            // rbtnElevator
            // 
            this.rbtnElevator.AutoSize = true;
            this.rbtnElevator.Location = new System.Drawing.Point(23, 82);
            this.rbtnElevator.Name = "rbtnElevator";
            this.rbtnElevator.Size = new System.Drawing.Size(63, 17);
            this.rbtnElevator.TabIndex = 9;
            this.rbtnElevator.TabStop = true;
            this.rbtnElevator.Text = "Asansör";
            this.rbtnElevator.UseVisualStyleBackColor = true;
            // 
            // rbtnSu
            // 
            this.rbtnSu.AutoSize = true;
            this.rbtnSu.Location = new System.Drawing.Point(23, 59);
            this.rbtnSu.Name = "rbtnSu";
            this.rbtnSu.Size = new System.Drawing.Size(38, 17);
            this.rbtnSu.TabIndex = 8;
            this.rbtnSu.TabStop = true;
            this.rbtnSu.Text = "Su";
            this.rbtnSu.UseVisualStyleBackColor = true;
            // 
            // rbtnElectricity
            // 
            this.rbtnElectricity.AutoSize = true;
            this.rbtnElectricity.Location = new System.Drawing.Point(23, 36);
            this.rbtnElectricity.Name = "rbtnElectricity";
            this.rbtnElectricity.Size = new System.Drawing.Size(60, 17);
            this.rbtnElectricity.TabIndex = 7;
            this.rbtnElectricity.TabStop = true;
            this.rbtnElectricity.Text = "Elektrik";
            this.rbtnElectricity.UseVisualStyleBackColor = true;
            // 
            // dtpExpenseDate
            // 
            this.dtpExpenseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpenseDate.Location = new System.Drawing.Point(189, 69);
            this.dtpExpenseDate.Name = "dtpExpenseDate";
            this.dtpExpenseDate.Size = new System.Drawing.Size(101, 20);
            this.dtpExpenseDate.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tarih:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tutar:";
            // 
            // nudIncomeAmount
            // 
            this.nudIncomeAmount.Location = new System.Drawing.Point(68, 95);
            this.nudIncomeAmount.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudIncomeAmount.Name = "nudIncomeAmount";
            this.nudIncomeAmount.Size = new System.Drawing.Size(60, 20);
            this.nudIncomeAmount.TabIndex = 7;
            // 
            // nudExpenseAmount
            // 
            this.nudExpenseAmount.Location = new System.Drawing.Point(189, 36);
            this.nudExpenseAmount.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudExpenseAmount.Name = "nudExpenseAmount";
            this.nudExpenseAmount.Size = new System.Drawing.Size(101, 20);
            this.nudExpenseAmount.TabIndex = 12;
            // 
            // dgvExpenses
            // 
            this.dgvExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpenses.Location = new System.Drawing.Point(8, 154);
            this.dgvExpenses.Name = "dgvExpenses";
            this.dgvExpenses.RowHeadersVisible = false;
            this.dgvExpenses.Size = new System.Drawing.Size(296, 167);
            this.dgvExpenses.TabIndex = 5;
            // 
            // dgvIncomes
            // 
            this.dgvIncomes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncomes.Location = new System.Drawing.Point(8, 154);
            this.dgvIncomes.Name = "dgvIncomes";
            this.dgvIncomes.RowHeadersVisible = false;
            this.dgvIncomes.RowHeadersWidth = 10;
            this.dgvIncomes.Size = new System.Drawing.Size(296, 167);
            this.dgvIncomes.TabIndex = 8;
            // 
            // Operations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 355);
            this.Controls.Add(this.tabControl1);
            this.Name = "Operations";
            this.Text = "İşlemler";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Operations_FormClosed);
            this.Load += new System.EventHandler(this.Operations_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpIncomes.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRoomNo)).EndInit();
            this.tpExpenses.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIncomeAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExpenseAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncomes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpIncomes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddIncome;
        private System.Windows.Forms.DateTimePicker dtpIncomeDate;
        private System.Windows.Forms.NumericUpDown nudRoomNo;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label lblDaire;
        private System.Windows.Forms.TabPage tpExpenses;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.RadioButton rbtnClean;
        private System.Windows.Forms.RadioButton rbtnElevator;
        private System.Windows.Forms.RadioButton rbtnSu;
        private System.Windows.Forms.RadioButton rbtnElectricity;
        private System.Windows.Forms.DateTimePicker dtpExpenseDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudIncomeAmount;
        private System.Windows.Forms.NumericUpDown nudExpenseAmount;
        private System.Windows.Forms.DataGridView dgvExpenses;
        private System.Windows.Forms.DataGridView dgvIncomes;
    }
}