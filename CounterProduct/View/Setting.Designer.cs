namespace CounterProduct.View
{
    partial class Setting
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
            textBoxIP = new TextBox();
            textBoxPort = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnRefresh = new Button();
            SuspendLayout();
            // 
            // textBoxIP
            // 
            textBoxIP.Font = new Font("Segoe UI", 14.25F);
            textBoxIP.Location = new Point(320, 124);
            textBoxIP.Name = "textBoxIP";
            textBoxIP.Size = new Size(206, 33);
            textBoxIP.TabIndex = 0;
            // 
            // textBoxPort
            // 
            textBoxPort.Font = new Font("Segoe UI", 14.25F);
            textBoxPort.Location = new Point(320, 188);
            textBoxPort.Name = "textBoxPort";
            textBoxPort.Size = new Size(206, 33);
            textBoxPort.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(194, 128);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 2;
            label1.Text = "IP Camera";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(194, 192);
            label2.Name = "label2";
            label2.Size = new Size(46, 25);
            label2.TabIndex = 3;
            label2.Text = "Port";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(307, 64);
            label3.Name = "label3";
            label3.Size = new Size(112, 32);
            label3.TabIndex = 4;
            label3.Text = "SETTING";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(320, 261);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Referesh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // Setting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 344);
            Controls.Add(btnRefresh);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPort);
            Controls.Add(textBoxIP);
            Name = "Setting";
            Text = "Setting";
            Load += Setting_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxIP;
        private TextBox textBoxPort;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnRefresh;
    }
}