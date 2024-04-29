namespace WinFormsApp5
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            panel1 = new Panel();
            lblTitle = new Label();
            btnClose = new Button();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lnkNewaccount = new LinkLabel();
            lnkPassword = new LinkLabel();
            btnLogin = new Button();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUsuario = new TextBox();
            lblUsername = new Label();
            lblLogin = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(660, 27);
            panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = SystemColors.ButtonFace;
            lblTitle.Location = new Point(3, 2);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(118, 20);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "IEM Technology";
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = SystemColors.ActiveCaptionText;
            btnClose.Location = new Point(633, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(27, 27);
            btnClose.TabIndex = 0;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(lnkNewaccount);
            panel2.Controls.Add(lnkPassword);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(lblPassword);
            panel2.Controls.Add(txtUsuario);
            panel2.Controls.Add(lblUsername);
            panel2.Controls.Add(lblLogin);
            panel2.Location = new Point(12, 73);
            panel2.Name = "panel2";
            panel2.Size = new Size(227, 351);
            panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Location = new Point(3, 172);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(23, 22);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(3, 111);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(23, 22);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // lnkNewaccount
            // 
            lnkNewaccount.AutoSize = true;
            lnkNewaccount.BackColor = Color.Transparent;
            lnkNewaccount.LinkColor = Color.White;
            lnkNewaccount.Location = new Point(50, 273);
            lnkNewaccount.Name = "lnkNewaccount";
            lnkNewaccount.Size = new Size(116, 15);
            lnkNewaccount.TabIndex = 7;
            lnkNewaccount.TabStop = true;
            lnkNewaccount.Text = "Create New Account";
            // 
            // lnkPassword
            // 
            lnkPassword.AutoSize = true;
            lnkPassword.BackColor = Color.Transparent;
            lnkPassword.LinkColor = Color.White;
            lnkPassword.Location = new Point(45, 213);
            lnkPassword.Name = "lnkPassword";
            lnkPassword.Size = new Size(127, 15);
            lnkPassword.TabIndex = 6;
            lnkPassword.TabStop = true;
            lnkPassword.Text = "Forgot your password?";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.FlatAppearance.BorderColor = Color.White;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = SystemColors.ButtonFace;
            btnLogin.Location = new Point(71, 242);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(29, 172);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(159, 23);
            txtPassword.TabIndex = 4;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.ForeColor = SystemColors.ButtonFace;
            lblPassword.Location = new Point(29, 154);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(29, 111);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(159, 23);
            txtUsuario.TabIndex = 2;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.ForeColor = SystemColors.ButtonFace;
            lblUsername.Location = new Point(29, 93);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(60, 15);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogin.ForeColor = SystemColors.ButtonFace;
            lblLogin.Location = new Point(71, 15);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(74, 32);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(660, 450);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnClose;
        private Label lblTitle;
        private Panel panel2;
        private Label lblLogin;
        private LinkLabel lnkNewaccount;
        private LinkLabel lnkPassword;
        private Button btnLogin;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtUsuario;
        private Label lblUsername;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}
