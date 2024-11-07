namespace GenericCompany
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtID_employeers = new TextBox();
            txtName_employeers = new TextBox();
            txtFirstName = new TextBox();
            txtSecondName = new TextBox();
            txtEmail = new TextBox();
            txtDepartment = new TextBox();
            button_examine_employeers = new Button();
            button_add_employeers = new Button();
            button_modify_employeers = new Button();
            button_delete_employeers = new Button();
            button_cancel_employeers = new Button();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(241, 92);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(402, 92);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(241, 187);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 2;
            label3.Text = "First name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(457, 187);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 3;
            label4.Text = "Second name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(241, 269);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(241, 347);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 5;
            label6.Text = "Department";
            // 
            // txtID_employeers
            // 
            txtID_employeers.Location = new Point(241, 116);
            txtID_employeers.Margin = new Padding(3, 4, 3, 4);
            txtID_employeers.Name = "txtID_employeers";
            txtID_employeers.Size = new Size(114, 27);
            txtID_employeers.TabIndex = 6;
            txtID_employeers.TextChanged += txtID_employeers_TextChanged;
            // 
            // txtName_employeers
            // 
            txtName_employeers.Location = new Point(402, 116);
            txtName_employeers.Margin = new Padding(3, 4, 3, 4);
            txtName_employeers.Name = "txtName_employeers";
            txtName_employeers.Size = new Size(114, 27);
            txtName_employeers.TabIndex = 7;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(241, 211);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(205, 27);
            txtFirstName.TabIndex = 8;
            // 
            // txtSecondName
            // 
            txtSecondName.Location = new Point(457, 211);
            txtSecondName.Margin = new Padding(3, 4, 3, 4);
            txtSecondName.Name = "txtSecondName";
            txtSecondName.Size = new Size(187, 27);
            txtSecondName.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(241, 293);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(403, 27);
            txtEmail.TabIndex = 10;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(241, 371);
            txtDepartment.Margin = new Padding(3, 4, 3, 4);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(403, 27);
            txtDepartment.TabIndex = 11;
            // 
            // button_examine_employeers
            // 
            button_examine_employeers.Location = new Point(72, 323);
            button_examine_employeers.Margin = new Padding(3, 4, 3, 4);
            button_examine_employeers.Name = "button_examine_employeers";
            button_examine_employeers.Size = new Size(86, 31);
            button_examine_employeers.TabIndex = 12;
            button_examine_employeers.Text = "Examine...";
            button_examine_employeers.UseVisualStyleBackColor = true;
            button_examine_employeers.Click += button1_Click;
            // 
            // button_add_employeers
            // 
            button_add_employeers.Location = new Point(241, 433);
            button_add_employeers.Margin = new Padding(3, 4, 3, 4);
            button_add_employeers.Name = "button_add_employeers";
            button_add_employeers.Size = new Size(86, 31);
            button_add_employeers.TabIndex = 13;
            button_add_employeers.Text = "Add";
            button_add_employeers.UseVisualStyleBackColor = true;
            button_add_employeers.Click += button_add_employeers_Click;
            // 
            // button_modify_employeers
            // 
            button_modify_employeers.Location = new Point(379, 433);
            button_modify_employeers.Margin = new Padding(3, 4, 3, 4);
            button_modify_employeers.Name = "button_modify_employeers";
            button_modify_employeers.Size = new Size(86, 31);
            button_modify_employeers.TabIndex = 14;
            button_modify_employeers.Text = "Modify";
            button_modify_employeers.UseVisualStyleBackColor = true;
            button_modify_employeers.Click += button_modify_employeers_Click;
            // 
            // button_delete_employeers
            // 
            button_delete_employeers.Location = new Point(511, 433);
            button_delete_employeers.Margin = new Padding(3, 4, 3, 4);
            button_delete_employeers.Name = "button_delete_employeers";
            button_delete_employeers.Size = new Size(86, 31);
            button_delete_employeers.TabIndex = 15;
            button_delete_employeers.Text = "Delete";
            button_delete_employeers.UseVisualStyleBackColor = true;
            button_delete_employeers.Click += button_delete_employeers_Click;
            // 
            // button_cancel_employeers
            // 
            button_cancel_employeers.Location = new Point(637, 433);
            button_cancel_employeers.Margin = new Padding(3, 4, 3, 4);
            button_cancel_employeers.Name = "button_cancel_employeers";
            button_cancel_employeers.Size = new Size(86, 31);
            button_cancel_employeers.TabIndex = 16;
            button_cancel_employeers.Text = "Cancel";
            button_cancel_employeers.UseVisualStyleBackColor = true;
            button_cancel_employeers.Click += button_cancel_employeers_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(30, 92);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 209);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 536);
            label7.Name = "label7";
            label7.Size = new Size(358, 20);
            label7.TabIndex = 18;
            label7.Text = "Notes: * Employeers are modified and deleted by ID.";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(48, 556);
            label8.Name = "label8";
            label8.Size = new Size(186, 20);
            label8.TabIndex = 19;
            label8.Text = "* Second name is optional.";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(48, 576);
            label9.Name = "label9";
            label9.Size = new Size(189, 20);
            label9.TabIndex = 20;
            label9.Text = "* ID is added automatically";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(button_cancel_employeers);
            Controls.Add(button_delete_employeers);
            Controls.Add(button_modify_employeers);
            Controls.Add(button_add_employeers);
            Controls.Add(button_examine_employeers);
            Controls.Add(txtDepartment);
            Controls.Add(txtEmail);
            Controls.Add(txtSecondName);
            Controls.Add(txtFirstName);
            Controls.Add(txtName_employeers);
            Controls.Add(txtID_employeers);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtID_employeers;
        private TextBox txtName_employeers;
        private TextBox txtFirstName;
        private TextBox txtSecondName;
        private TextBox txtEmail;
        private TextBox txtDepartment;
        private Button button_examine_employeers;
        private Button button_add_employeers;
        private Button button_modify_employeers;
        private Button button_delete_employeers;
        private Button button_cancel_employeers;
        private PictureBox pictureBox1;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}