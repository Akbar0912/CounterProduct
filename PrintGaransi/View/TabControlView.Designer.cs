﻿namespace PrintGaransi.View
{
    partial class TabControlView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabPage2 = new TabPage();
            tableLayoutPanel9 = new TableLayoutPanel();
            dataGridView2 = new DataGridView();
            tableLayoutPanel10 = new TableLayoutPanel();
            textBoxSearch = new TextBox();
            label11 = new Label();
            btnSearch = new Button();
            tabPage1 = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            textBoxJP = new TextBox();
            label5 = new Label();
            textBoxRegister = new TextBox();
            label4 = new Label();
            textBoxModelNumber = new TextBox();
            textBoxCode = new TextBox();
            label6 = new Label();
            label7 = new Label();
            textBoxSerial = new TextBox();
            label8 = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            btnPrint = new Button();
            tabControl1 = new TabControl();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label3 = new Label();
            label9 = new Label();
            textBox5 = new TextBox();
            label10 = new Label();
            tableLayoutPanel8 = new TableLayoutPanel();
            button1 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tabPage2.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tableLayoutPanel10.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tabControl1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tableLayoutPanel9);
            tabPage2.Location = new Point(4, 27);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(885, 445);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Search";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 1;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Controls.Add(dataGridView2, 0, 2);
            tableLayoutPanel9.Controls.Add(tableLayoutPanel10, 0, 1);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(3, 3);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 3;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 92F));
            tableLayoutPanel9.Size = new Size(879, 439);
            tableLayoutPanel9.TabIndex = 8;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.Location = new Point(3, 84);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.Size = new Size(873, 352);
            dataGridView2.TabIndex = 4;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 4;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.8181839F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.4545479F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.7272739F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel10.Controls.Add(textBoxSearch, 0, 0);
            tableLayoutPanel10.Controls.Add(label11, 0, 0);
            tableLayoutPanel10.Controls.Add(btnSearch, 2, 0);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(3, 53);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.Size = new Size(873, 25);
            tableLayoutPanel10.TabIndex = 3;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Dock = DockStyle.Fill;
            textBoxSearch.Font = new Font("Microsoft Sans Serif", 18F);
            textBoxSearch.Location = new Point(233, 3);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(322, 35);
            textBoxSearch.TabIndex = 11;
            textBoxSearch.KeyDown += textBoxSearch_KeyDown;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            label11.Location = new Point(3, 0);
            label11.Name = "label11";
            label11.Size = new Size(178, 25);
            label11.TabIndex = 10;
            label11.Text = "Search Serial Number";
            // 
            // btnSearch
            // 
            btnSearch.Dock = DockStyle.Fill;
            btnSearch.Location = new Point(560, 2);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(160, 21);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel2);
            tabPage1.Location = new Point(4, 27);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(885, 445);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Home";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(dataGridView1, 0, 2);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel2.Size = new Size(879, 439);
            tableLayoutPanel2.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(3, 208);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(873, 228);
            dataGridView1.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.92308F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.07692F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel6, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 53);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(873, 149);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.6087F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.4782524F));
            tableLayoutPanel5.Controls.Add(textBoxJP, 1, 4);
            tableLayoutPanel5.Controls.Add(label5, 0, 4);
            tableLayoutPanel5.Controls.Add(textBoxRegister, 1, 3);
            tableLayoutPanel5.Controls.Add(label4, 0, 0);
            tableLayoutPanel5.Controls.Add(textBoxModelNumber, 1, 2);
            tableLayoutPanel5.Controls.Add(textBoxCode, 1, 1);
            tableLayoutPanel5.Controls.Add(label6, 0, 3);
            tableLayoutPanel5.Controls.Add(label7, 0, 1);
            tableLayoutPanel5.Controls.Add(textBoxSerial, 1, 0);
            tableLayoutPanel5.Controls.Add(label8, 0, 2);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 5;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.Size = new Size(550, 143);
            tableLayoutPanel5.TabIndex = 7;
            // 
            // textBoxJP
            // 
            textBoxJP.Dock = DockStyle.Fill;
            textBoxJP.Font = new Font("Microsoft Sans Serif", 18F);
            textBoxJP.Location = new Point(238, 115);
            textBoxJP.Name = "textBoxJP";
            textBoxJP.Size = new Size(309, 35);
            textBoxJP.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            label5.Location = new Point(3, 112);
            label5.Name = "label5";
            label5.Size = new Size(165, 29);
            label5.TabIndex = 9;
            label5.Text = "Jenis Produk";
            // 
            // textBoxRegister
            // 
            textBoxRegister.Dock = DockStyle.Fill;
            textBoxRegister.Font = new Font("Microsoft Sans Serif", 18F);
            textBoxRegister.Location = new Point(238, 87);
            textBoxRegister.Name = "textBoxRegister";
            textBoxRegister.Size = new Size(309, 35);
            textBoxRegister.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(137, 28);
            label4.TabIndex = 5;
            label4.Text = "No. Serial ";
            // 
            // textBoxModelNumber
            // 
            textBoxModelNumber.Dock = DockStyle.Fill;
            textBoxModelNumber.Font = new Font("Microsoft Sans Serif", 18F);
            textBoxModelNumber.Location = new Point(238, 59);
            textBoxModelNumber.Name = "textBoxModelNumber";
            textBoxModelNumber.Size = new Size(309, 35);
            textBoxModelNumber.TabIndex = 1;
            // 
            // textBoxCode
            // 
            textBoxCode.Dock = DockStyle.Fill;
            textBoxCode.Font = new Font("Microsoft Sans Serif", 18F);
            textBoxCode.Location = new Point(238, 31);
            textBoxCode.Name = "textBoxCode";
            textBoxCode.Size = new Size(309, 35);
            textBoxCode.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            label6.Location = new Point(3, 84);
            label6.Name = "label6";
            label6.Size = new Size(160, 28);
            label6.TabIndex = 8;
            label6.Text = "No. Register";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            label7.Location = new Point(3, 28);
            label7.Name = "label7";
            label7.Size = new Size(156, 28);
            label7.TabIndex = 6;
            label7.Text = "Model Code";
            // 
            // textBoxSerial
            // 
            textBoxSerial.Dock = DockStyle.Fill;
            textBoxSerial.Font = new Font("Microsoft Sans Serif", 18F);
            textBoxSerial.Location = new Point(238, 3);
            textBoxSerial.Name = "textBoxSerial";
            textBoxSerial.Size = new Size(309, 35);
            textBoxSerial.TabIndex = 1;
            textBoxSerial.TextChanged += textBoxSerial_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            label8.Location = new Point(3, 56);
            label8.Name = "label8";
            label8.Size = new Size(186, 28);
            label8.TabIndex = 7;
            label8.Text = "Model Number";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(btnPrint, 0, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(559, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tableLayoutPanel6.Size = new Size(160, 143);
            tableLayoutPanel6.TabIndex = 8;
            // 
            // btnPrint
            // 
            btnPrint.Dock = DockStyle.Fill;
            btnPrint.Location = new Point(2, 37);
            btnPrint.Margin = new Padding(2);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(156, 104);
            btnPrint.TabIndex = 5;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(893, 476);
            tabControl1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.92308F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.07692F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel7, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel8, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(194, 188);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.6087F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.4782524F));
            tableLayoutPanel7.Controls.Add(textBox1, 1, 4);
            tableLayoutPanel7.Controls.Add(label1, 0, 4);
            tableLayoutPanel7.Controls.Add(textBox2, 1, 3);
            tableLayoutPanel7.Controls.Add(label2, 0, 0);
            tableLayoutPanel7.Controls.Add(textBox3, 1, 2);
            tableLayoutPanel7.Controls.Add(textBox4, 1, 1);
            tableLayoutPanel7.Controls.Add(label3, 0, 3);
            tableLayoutPanel7.Controls.Add(label9, 0, 1);
            tableLayoutPanel7.Controls.Add(textBox5, 1, 0);
            tableLayoutPanel7.Controls.Add(label10, 0, 2);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 5;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel7.Size = new Size(27, 182);
            tableLayoutPanel7.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Microsoft Sans Serif", 18F);
            textBox1.Location = new Point(14, 147);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(10, 35);
            textBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            label1.Location = new Point(3, 144);
            label1.Name = "label1";
            label1.Size = new Size(5, 38);
            label1.TabIndex = 9;
            label1.Text = "Jenis Produk";
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Font = new Font("Microsoft Sans Serif", 18F);
            textBox2.Location = new Point(14, 111);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(10, 35);
            textBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(5, 36);
            label2.TabIndex = 5;
            label2.Text = "No. Serial ";
            // 
            // textBox3
            // 
            textBox3.Dock = DockStyle.Fill;
            textBox3.Font = new Font("Microsoft Sans Serif", 18F);
            textBox3.Location = new Point(14, 75);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(10, 35);
            textBox3.TabIndex = 1;
            // 
            // textBox4
            // 
            textBox4.Dock = DockStyle.Fill;
            textBox4.Font = new Font("Microsoft Sans Serif", 18F);
            textBox4.Location = new Point(14, 39);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(10, 35);
            textBox4.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            label3.Location = new Point(3, 108);
            label3.Name = "label3";
            label3.Size = new Size(5, 36);
            label3.TabIndex = 8;
            label3.Text = "No. Register";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            label9.Location = new Point(3, 36);
            label9.Name = "label9";
            label9.Size = new Size(5, 36);
            label9.TabIndex = 6;
            label9.Text = "Model Code";
            // 
            // textBox5
            // 
            textBox5.Dock = DockStyle.Fill;
            textBox5.Font = new Font("Microsoft Sans Serif", 18F);
            textBox5.Location = new Point(14, 3);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(10, 35);
            textBox5.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            label10.Location = new Point(3, 72);
            label10.Name = "label10";
            label10.Size = new Size(5, 36);
            label10.TabIndex = 7;
            label10.Text = "Model Number";
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Controls.Add(button1, 0, 1);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(36, 3);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tableLayoutPanel8.Size = new Size(4, 182);
            tableLayoutPanel8.TabIndex = 8;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(2, 47);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(1, 133);
            button1.TabIndex = 5;
            button1.Text = "Print";
            button1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // TabControlView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Name = "TabControlView";
            Size = new Size(893, 476);
            Load += TabControlView_Load;
            tabPage2.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            tabPage1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel9;
        private TabPage tabPage1;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel5;
        private TextBox textBoxJP;
        private Label label5;
        private TextBox textBoxRegister;
        private Label label4;
        private TextBox textBoxModelNumber;
        private TextBox textBoxCode;
        private Label label6;
        private Label label7;
        private TextBox textBoxSerial;
        private Label label8;
        private TableLayoutPanel tableLayoutPanel6;
        private Button btnPrint;
        private TabControl tabControl1;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel7;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label3;
        private Label label9;
        private TextBox textBox5;
        private Label label10;
        private TableLayoutPanel tableLayoutPanel8;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel10;
        private Button btnSearch;
        private Label label11;
        private TextBox textBoxSearch;
        private DataGridView dataGridView2;
    }
}
