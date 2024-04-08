namespace PTOv4
{
    partial class DBHandler
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
            txt_username = new TextBox();
            txt_password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            button_login = new Button();
            button_clear = new Button();
            checkedListBox1 = new CheckedListBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txt_username
            // 
            txt_username.Location = new Point(384, 58);
            txt_username.Margin = new Padding(2, 2, 2, 2);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(167, 27);
            txt_username.TabIndex = 0;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(384, 113);
            txt_password.Margin = new Padding(2, 2, 2, 2);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(167, 27);
            txt_password.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(253, 54);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 2;
            label1.Text = "Employee ID :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(253, 115);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 3;
            label2.Text = "Password : ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user_200;
            pictureBox1.Location = new Point(34, 33);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 170);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // button_login
            // 
            button_login.Location = new Point(443, 350);
            button_login.Margin = new Padding(2, 2, 2, 2);
            button_login.Name = "button_login";
            button_login.Size = new Size(90, 27);
            button_login.TabIndex = 5;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // button_clear
            // 
            button_clear.Location = new Point(297, 350);
            button_clear.Margin = new Padding(2, 2, 2, 2);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(90, 27);
            button_clear.TabIndex = 6;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = true;
            button_clear.Click += button_clear_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(375, 189);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(176, 92);
            checkedListBox1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(253, 189);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 8;
            label3.Text = "label3";
            // 
            // DBHandler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 412);
            Controls.Add(label3);
            Controls.Add(checkedListBox1);
            Controls.Add(button_clear);
            Controls.Add(button_login);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Margin = new Padding(2, 2, 2, 2);
            Name = "DBHandler";
            Text = "DB Handler";
            Load += DBHandler_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_username;
        private TextBox txt_password;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button button_login;
        private Button button_clear;
        private CheckedListBox checkedListBox1;
        private Label label3;
    }
}
