namespace ChatAPP
{
    partial class SignUp
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtUserName = new TextBox();
            txtFullName = new TextBox();
            txtPhone = new TextBox();
            txtPassword = new TextBox();
            btnSignUp = new Button();
            label6 = new Label();
            txtConfirmPassword = new TextBox();
            cmbGroup = new ComboBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(316, 26);
            label1.Name = "label1";
            label1.Size = new Size(126, 38);
            label1.TabIndex = 0;
            label1.Text = "Sign UP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(56, 197);
            label2.Name = "label2";
            label2.Size = new Size(134, 32);
            label2.TabIndex = 1;
            label2.Text = "Full Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(56, 269);
            label3.Name = "label3";
            label3.Size = new Size(87, 32);
            label3.TabIndex = 2;
            label3.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(56, 127);
            label4.Name = "label4";
            label4.Size = new Size(144, 32);
            label4.TabIndex = 3;
            label4.Text = "User Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(56, 339);
            label5.Name = "label5";
            label5.Size = new Size(126, 32);
            label5.TabIndex = 4;
            label5.Text = "Password";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(298, 130);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(367, 31);
            txtUserName.TabIndex = 5;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(298, 197);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(367, 31);
            txtFullName.TabIndex = 6;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(298, 272);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(367, 31);
            txtPhone.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(298, 342);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(367, 31);
            txtPassword.TabIndex = 8;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.MistyRose;
            btnSignUp.Location = new Point(553, 558);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(112, 34);
            btnSignUp.TabIndex = 9;
            btnSignUp.Text = "Sign UP";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(56, 414);
            label6.Name = "label6";
            label6.Size = new Size(227, 32);
            label6.TabIndex = 10;
            label6.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(298, 415);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(367, 31);
            txtConfirmPassword.TabIndex = 11;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // cmbGroup
            // 
            cmbGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGroup.FormattingEnabled = true;
            cmbGroup.Location = new Point(298, 482);
            cmbGroup.Name = "cmbGroup";
            cmbGroup.Size = new Size(367, 33);
            cmbGroup.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(57, 483);
            label7.Name = "label7";
            label7.Size = new Size(86, 32);
            label7.TabIndex = 13;
            label7.Text = "Group";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(746, 642);
            Controls.Add(label7);
            Controls.Add(cmbGroup);
            Controls.Add(txtConfirmPassword);
            Controls.Add(label6);
            Controls.Add(btnSignUp);
            Controls.Add(txtPassword);
            Controls.Add(txtPhone);
            Controls.Add(txtFullName);
            Controls.Add(txtUserName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp";
            Load += SignUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtUserName;
        private TextBox txtFullName;
        private TextBox txtPhone;
        private TextBox txtPassword;
        private Button btnSignUp;
        private Label label6;
        private TextBox txtConfirmPassword;
        private ComboBox cmbGroup;
        private Label label7;
    }
}