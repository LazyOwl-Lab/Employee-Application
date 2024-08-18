namespace Employee_Application
{
    partial class LeaveForm
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
            label1 = new Label();
            rbAnnual = new RadioButton();
            rbCasual = new RadioButton();
            rbShort = new RadioButton();
            label2 = new Label();
            dtpStart = new DateTimePicker();
            label3 = new Label();
            dtpEnd = new DateTimePicker();
            label4 = new Label();
            dtpDuration = new DateTimePicker();
            btnRequest = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 54);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "Leave Type";
            label1.Click += label1_Click;
            // 
            // rbAnnual
            // 
            rbAnnual.AutoSize = true;
            rbAnnual.Location = new Point(116, 54);
            rbAnnual.Name = "rbAnnual";
            rbAnnual.Size = new Size(96, 19);
            rbAnnual.TabIndex = 1;
            rbAnnual.TabStop = true;
            rbAnnual.Text = "Annual Leave";
            rbAnnual.UseVisualStyleBackColor = true;
            rbAnnual.CheckedChanged += rbAnnual_CheckedChanged;
            // 
            // rbCasual
            // 
            rbCasual.AutoSize = true;
            rbCasual.Location = new Point(216, 54);
            rbCasual.Name = "rbCasual";
            rbCasual.Size = new Size(93, 19);
            rbCasual.TabIndex = 1;
            rbCasual.TabStop = true;
            rbCasual.Text = "Casual Leave";
            rbCasual.UseVisualStyleBackColor = true;
            rbCasual.CheckedChanged += rbCasual_CheckedChanged;
            // 
            // rbShort
            // 
            rbShort.AutoSize = true;
            rbShort.Location = new Point(316, 54);
            rbShort.Name = "rbShort";
            rbShort.Size = new Size(86, 19);
            rbShort.TabIndex = 1;
            rbShort.TabStop = true;
            rbShort.Text = "Short Leave";
            rbShort.UseVisualStyleBackColor = true;
            rbShort.CheckedChanged += rbShort_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 178);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 3;
            label2.Text = "Starting Date";
            // 
            // dtpStart
            // 
            dtpStart.CustomFormat = "yyyy-MM-dd";
            dtpStart.Format = DateTimePickerFormat.Custom;
            dtpStart.Location = new Point(109, 172);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(200, 23);
            dtpStart.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 207);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 3;
            label3.Text = "End Date";
            // 
            // dtpEnd
            // 
            dtpEnd.CustomFormat = "yyyy-MM-dd";
            dtpEnd.Format = DateTimePickerFormat.Custom;
            dtpEnd.Location = new Point(109, 201);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(200, 23);
            dtpEnd.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 236);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 3;
            label4.Text = "Duration";
            // 
            // dtpDuration
            // 
            dtpDuration.CustomFormat = "H:mm:ss";
            dtpDuration.Format = DateTimePickerFormat.Custom;
            dtpDuration.Location = new Point(109, 230);
            dtpDuration.Name = "dtpDuration";
            dtpDuration.Size = new Size(200, 23);
            dtpDuration.TabIndex = 4;
            // 
            // btnRequest
            // 
            btnRequest.Location = new Point(109, 321);
            btnRequest.Name = "btnRequest";
            btnRequest.Size = new Size(75, 23);
            btnRequest.TabIndex = 5;
            btnRequest.Text = "Request";
            btnRequest.UseVisualStyleBackColor = true;
            btnRequest.Click += button1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // LeaveForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnRequest);
            Controls.Add(dtpDuration);
            Controls.Add(label4);
            Controls.Add(dtpEnd);
            Controls.Add(label3);
            Controls.Add(dtpStart);
            Controls.Add(label2);
            Controls.Add(rbShort);
            Controls.Add(rbCasual);
            Controls.Add(rbAnnual);
            Controls.Add(label1);
            Name = "LeaveForm";
            Text = "LeaveForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton rbAnnual;
        private RadioButton rbCasual;
        private RadioButton rbShort;
        private Label label2;
        private DateTimePicker dtpStart;
        private Label label3;
        private DateTimePicker dtpEnd;
        private Label label4;
        private DateTimePicker dtpDuration;
        private Button btnRequest;
        private Button button1;
    }
}