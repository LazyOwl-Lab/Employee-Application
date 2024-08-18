namespace Employee_Application
{
    partial class Dashboard
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
            lable1 = new Label();
            lblAnnual = new Label();
            label1 = new Label();
            lblCasual = new Label();
            label2 = new Label();
            lblShort = new Label();
            lblUsername = new Label();
            label3 = new Label();
            btnApply = new Button();
            btnManage = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // lable1
            // 
            lable1.AutoSize = true;
            lable1.Location = new Point(36, 99);
            lable1.Name = "lable1";
            lable1.Size = new Size(136, 15);
            lable1.TabIndex = 0;
            lable1.Text = "Remainin Annual Leaves";
            // 
            // lblAnnual
            // 
            lblAnnual.AutoSize = true;
            lblAnnual.Location = new Point(178, 99);
            lblAnnual.Name = "lblAnnual";
            lblAnnual.Size = new Size(0, 15);
            lblAnnual.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 135);
            label1.Name = "label1";
            label1.Size = new Size(133, 15);
            label1.TabIndex = 0;
            label1.Text = "Remainin Casual Leaves";
            // 
            // lblCasual
            // 
            lblCasual.AutoSize = true;
            lblCasual.Location = new Point(178, 135);
            lblCasual.Name = "lblCasual";
            lblCasual.Size = new Size(0, 15);
            lblCasual.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 168);
            label2.Name = "label2";
            label2.Size = new Size(126, 15);
            label2.TabIndex = 0;
            label2.Text = "Remainin Short Leaves";
            // 
            // lblShort
            // 
            lblShort.AutoSize = true;
            lblShort.Location = new Point(178, 168);
            lblShort.Name = "lblShort";
            lblShort.Size = new Size(0, 15);
            lblShort.TabIndex = 1;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(66, 46);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(38, 15);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "label3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(504, 40);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 3;
            label3.Text = "Apply For a Leave";
            // 
            // btnApply
            // 
            btnApply.Location = new Point(610, 38);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(75, 23);
            btnApply.TabIndex = 4;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // btnManage
            // 
            btnManage.Location = new Point(613, 81);
            btnManage.Name = "btnManage";
            btnManage.Size = new Size(75, 23);
            btnManage.TabIndex = 5;
            btnManage.Text = "Manage";
            btnManage.UseVisualStyleBackColor = true;
            btnManage.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(504, 85);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 6;
            label4.Text = "Manage Leaves";
            label4.Click += label4_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(btnManage);
            Controls.Add(btnApply);
            Controls.Add(label3);
            Controls.Add(lblUsername);
            Controls.Add(lblShort);
            Controls.Add(lblCasual);
            Controls.Add(lblAnnual);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lable1);
            Name = "Dashboard";
            Text = "Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lable1;
        private Label lblAnnual;
        private Label label1;
        private Label lblCasual;
        private Label label2;
        private Label lblShort;
        private Label lblUsername;
        private Label label3;
        private Button btnApply;
        private Button btnManage;
        private Label label4;
    }
}