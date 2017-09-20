namespace NutrySAT
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblNoAcceso = new System.Windows.Forms.Label();
            this.btnLogin = new ReaperTheme.Controls.ReaperButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbUser = new ReaperTheme.Controls.ReaperTextbox();
            this.tbPass = new ReaperTheme.Controls.ReaperTextbox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNoAcceso
            // 
            this.lblNoAcceso.AutoSize = true;
            this.lblNoAcceso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNoAcceso.Location = new System.Drawing.Point(18, 187);
            this.lblNoAcceso.Name = "lblNoAcceso";
            this.lblNoAcceso.Size = new System.Drawing.Size(203, 14);
            this.lblNoAcceso.TabIndex = 0;
            this.lblNoAcceso.Text = "Tengo problemas para acceder";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnLogin.ButtonState = ReaperTheme.ReaperEnums.ReaperButtonState.Normal;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.btnLogin.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLogin.Location = new System.Drawing.Point(8, 132);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.OverrideBackColor = true;
            this.btnLogin.OverrideHoverColor = false;
            this.btnLogin.Size = new System.Drawing.Size(223, 41);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "ENTRAR";
            this.btnLogin.Theme = ReaperTheme.ReaperEnums.ReaperTheme.Dark;
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NutrySAT.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(5, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // tbUser
            // 
            this.tbUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tbUser.Location = new System.Drawing.Point(51, 37);
            this.tbUser.MultiLine = false;
            this.tbUser.Name = "tbUser";
            this.tbUser.NumeralOnly = false;
            this.tbUser.OverrideColorBarColor = false;
            this.tbUser.ReadOnly = false;
            this.tbUser.Size = new System.Drawing.Size(180, 28);
            this.tbUser.TabIndex = 4;
            this.tbUser.Text = "Usuario";
            this.tbUser.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbUser.Theme = ReaperTheme.ReaperEnums.ReaperTheme.Dark;
            this.tbUser.UsePasswordChar = false;
            // 
            // tbPass
            // 
            this.tbPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tbPass.Location = new System.Drawing.Point(51, 83);
            this.tbPass.MultiLine = false;
            this.tbPass.Name = "tbPass";
            this.tbPass.NumeralOnly = false;
            this.tbPass.OverrideColorBarColor = false;
            this.tbPass.ReadOnly = false;
            this.tbPass.Size = new System.Drawing.Size(180, 28);
            this.tbPass.TabIndex = 6;
            this.tbPass.Text = "Contraseña";
            this.tbPass.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbPass.Theme = ReaperTheme.ReaperEnums.ReaperTheme.Dark;
            this.tbPass.UsePasswordChar = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::NutrySAT.Properties.Resources.security;
            this.pictureBox2.Location = new System.Drawing.Point(5, 77);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 213);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblNoAcceso);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login - NutrySAT";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNoAcceso;
        private ReaperTheme.Controls.ReaperButton btnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaperTheme.Controls.ReaperTextbox tbUser;
        private ReaperTheme.Controls.ReaperTextbox tbPass;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}