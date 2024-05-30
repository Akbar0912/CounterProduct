namespace CounterProduct
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            Time = new Label();
            labelCounter = new Label();
            labelPlan = new Label();
            Actual = new Label();
            LabelCountdown = new Label();
            Date = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.33512F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.6648788F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 48F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 94F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 111F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(778, 59);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(2, 7);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(302, 45);
            label1.TabIndex = 0;
            label1.Text = "LAUNDRY SYSTEM";
            // 
            // Time
            // 
            Time.Anchor = AnchorStyles.None;
            Time.AutoSize = true;
            Time.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Time.Location = new Point(694, 4);
            Time.Margin = new Padding(2, 0, 2, 0);
            Time.Name = "Time";
            Time.Size = new Size(55, 25);
            Time.TabIndex = 1;
            Time.Text = "Time";
            // 
            // labelCounter
            // 
            labelCounter.Anchor = AnchorStyles.None;
            labelCounter.AutoSize = true;
            labelCounter.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            labelCounter.Location = new Point(322, 0);
            labelCounter.Margin = new Padding(2, 0, 2, 0);
            labelCounter.Name = "labelCounter";
            labelCounter.Size = new Size(33, 34);
            labelCounter.TabIndex = 2;
            labelCounter.Text = "0";
            // 
            // labelPlan
            // 
            labelPlan.Anchor = AnchorStyles.None;
            labelPlan.AutoSize = true;
            labelPlan.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPlan.Location = new Point(202, 0);
            labelPlan.Margin = new Padding(2, 0, 2, 0);
            labelPlan.Name = "labelPlan";
            labelPlan.Size = new Size(33, 34);
            labelPlan.TabIndex = 3;
            labelPlan.Text = "0";
            // 
            // Actual
            // 
            Actual.Anchor = AnchorStyles.None;
            Actual.AutoSize = true;
            Actual.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Actual.Location = new Point(424, 0);
            Actual.Margin = new Padding(2, 0, 2, 0);
            Actual.Name = "Actual";
            Actual.Size = new Size(33, 34);
            Actual.TabIndex = 3;
            Actual.Text = "0";
            // 
            // LabelCountdown
            // 
            LabelCountdown.Anchor = AnchorStyles.None;
            LabelCountdown.AutoSize = true;
            LabelCountdown.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelCountdown.Location = new Point(508, 0);
            LabelCountdown.Margin = new Padding(2, 0, 2, 0);
            LabelCountdown.Name = "LabelCountdown";
            LabelCountdown.Size = new Size(127, 34);
            LabelCountdown.TabIndex = 3;
            LabelCountdown.Text = "00:00:00";
            // 
            // Date
            // 
            Date.Anchor = AnchorStyles.None;
            Date.AutoSize = true;
            Date.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Date.Location = new Point(55, 4);
            Date.Margin = new Padding(2, 0, 2, 0);
            Date.Name = "Date";
            Date.Size = new Size(53, 25);
            Date.TabIndex = 0;
            Date.Text = "Date";
            Date.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.7444077F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.2555923F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 129F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 75F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 188F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 111F));
            tableLayoutPanel2.Controls.Add(Time, 5, 0);
            tableLayoutPanel2.Controls.Add(Date, 0, 0);
            tableLayoutPanel2.Controls.Add(LabelCountdown, 4, 0);
            tableLayoutPanel2.Controls.Add(labelPlan, 1, 0);
            tableLayoutPanel2.Controls.Add(Actual, 3, 0);
            tableLayoutPanel2.Controls.Add(labelCounter, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 59);
            tableLayoutPanel2.Margin = new Padding(2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(778, 34);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(dataGridView1, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(0, 93);
            tableLayoutPanel3.Margin = new Padding(2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(778, 90);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(2, 2);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(774, 86);
            dataGridView1.TabIndex = 0;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 270);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2);
            Name = "Home";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label Date;
        private Label Time;
        private TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private Label labelCounter;
        private Label labelPlan;
        private Label Actual;
        private Label LabelCountdown;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel3;
        private DataGridView dataGridView1;
    }
}
