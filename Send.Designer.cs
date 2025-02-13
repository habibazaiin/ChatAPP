namespace ChatAPP
{
    partial class Send
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
            lstUsers = new ListBox();
            label1 = new Label();
            label2 = new Label();
            btnSend = new Button();
            txtSubject = new TextBox();
            txtBody = new TextBox();
            SuspendLayout();
            // 
            // lstUsers
            // 
            lstUsers.BackColor = Color.MistyRose;
            lstUsers.ForeColor = SystemColors.InactiveCaptionText;
            lstUsers.FormattingEnabled = true;
            lstUsers.ItemHeight = 25;
            lstUsers.Location = new Point(665, 46);
            lstUsers.Name = "lstUsers";
            lstUsers.SelectionMode = SelectionMode.MultiSimple;
            lstUsers.Size = new Size(197, 479);
            lstUsers.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(23, 91);
            label1.Name = "label1";
            label1.Size = new Size(99, 32);
            label1.TabIndex = 1;
            label1.Text = "Subject";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(23, 160);
            label2.Name = "label2";
            label2.Size = new Size(74, 32);
            label2.TabIndex = 2;
            label2.Text = "Body";
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.MistyRose;
            btnSend.Location = new Point(750, 559);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(112, 34);
            btnSend.TabIndex = 3;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(146, 94);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(470, 31);
            txtSubject.TabIndex = 4;
            // 
            // txtBody
            // 
            txtBody.Location = new Point(146, 163);
            txtBody.Multiline = true;
            txtBody.Name = "txtBody";
            txtBody.Size = new Size(470, 362);
            txtBody.TabIndex = 5;
            // 
            // Send
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(892, 623);
            Controls.Add(txtBody);
            Controls.Add(txtSubject);
            Controls.Add(btnSend);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstUsers);
            Name = "Send";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Send";
            Load += Send_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstUsers;
        private Label label1;
        private Label label2;
        private Button btnSend;
        private TextBox txtSubject;
        private TextBox txtBody;
    }
}