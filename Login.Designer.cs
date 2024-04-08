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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txt_username
            // 
            txt_username.Location = new Point(480, 72);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(208, 31);
            txt_username.TabIndex = 0;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(480, 141);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(208, 31);
            txt_password.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(316, 68);
            label1.Name = "label1";
            label1.Size = new Size(122, 25);
            label1.TabIndex = 2;
            label1.Text = "Employee ID :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(316, 144);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 3;
            label2.Text = "Password : ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user_200;
            pictureBox1.Location = new Point(43, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 213);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // button_login
            // 
            button_login.Location = new Point(553, 220);
            button_login.Name = "button_login";
            button_login.Size = new Size(112, 34);
            button_login.TabIndex = 5;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // button_clear
            // 
            button_clear.Location = new Point(370, 220);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(112, 34);
            button_clear.TabIndex = 6;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = true;
            button_clear.Click += button_clear_Click;
            // 
            // DBHandler
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 282);
            Controls.Add(button_clear);
            Controls.Add(button_login);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
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
    }
}
