namespace Employee_Application
{
    partial class ManageLeaves
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
            dgvLeaves = new DataGridView();
            label1 = new Label();
            btnDelete = new Button();
            label2 = new Label();
            lblLeaveID = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLeaves).BeginInit();
            SuspendLayout();
            // 
            // dgvLeaves
            // 
            dgvLeaves.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLeaves.Location = new Point(12, 12);
            dgvLeaves.Name = "dgvLeaves";
            dgvLeaves.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLeaves.Size = new Size(776, 314);
            dgvLeaves.TabIndex = 0;
            dgvLeaves.CellContentClick += dgvLeaves_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 354);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 1;
            label1.Text = "Delete Request";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(174, 350);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(339, 371);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Leave ID";
            label2.Click += label2_Click;
            // 
            // lblLeaveID
            // 
            lblLeaveID.AutoSize = true;
            lblLeaveID.Location = new Point(396, 371);
            lblLeaveID.Name = "lblLeaveID";
            lblLeaveID.Size = new Size(0, 15);
            lblLeaveID.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(12, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ManageLeaves
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(lblLeaveID);
            Controls.Add(label2);
            Controls.Add(btnDelete);
            Controls.Add(label1);
            Controls.Add(dgvLeaves);
            Name = "ManageLeaves";
            Text = "ManageLeaves";
            ((System.ComponentModel.ISupportInitialize)dgvLeaves).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvLeaves;
        private Label label1;
        private Button btnDelete;
        private Label label2;
        private Label lblLeaveID;
        private Button button1;
    }
}