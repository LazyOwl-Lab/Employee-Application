namespace Employee_Application
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            btnExit = new Button();
            bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(106, 142);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(219, 23);
            txtUserName.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(106, 201);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(219, 23);
            txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(134, 267);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login!";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 145);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 3;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 204);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(224, 267);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += button1_Click;
            // 
            // bunifuGradientPanel1
            // 
            bunifuGradientPanel1.BackColor = Color.Transparent;
            bunifuGradientPanel1.BackgroundImage = (Image)resources.GetObject("bunifuGradientPanel1.BackgroundImage");
            bunifuGradientPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            bunifuGradientPanel1.BorderRadius = 1;
            bunifuGradientPanel1.Dock = DockStyle.Fill;
            bunifuGradientPanel1.GradientBottomLeft = Color.FromArgb(236, 92, 188);
            bunifuGradientPanel1.GradientBottomRight = Color.DeepPink;
            bunifuGradientPanel1.GradientTopLeft = Color.DodgerBlue;
            bunifuGradientPanel1.GradientTopRight = Color.FromArgb(198, 60, 212);
            bunifuGradientPanel1.Location = new Point(0, 0);
            bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            bunifuGradientPanel1.Quality = 10;
            bunifuGradientPanel1.Size = new Size(343, 613);
            bunifuGradientPanel1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 613);
            Controls.Add(btnExit);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(bunifuGradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "User";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label label1;
        private Label label2;
        private Button btnExit;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
    }
}
