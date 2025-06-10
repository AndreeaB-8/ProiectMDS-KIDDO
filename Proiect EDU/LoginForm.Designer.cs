namespace Proiect_EDU
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.Conectare = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnInapoi = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Conectare
            // 
            this.Conectare.AutoSize = true;
            this.Conectare.BackColor = System.Drawing.Color.Transparent;
            this.Conectare.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Conectare.ForeColor = System.Drawing.Color.White;
            this.Conectare.Location = new System.Drawing.Point(228, 59);
            this.Conectare.Name = "Conectare";
            this.Conectare.Size = new System.Drawing.Size(183, 48);
            this.Conectare.TabIndex = 5;
            this.Conectare.Text = "Conectare";
            this.Conectare.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(111, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Parola";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(111, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nume utilizator";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPassword.Location = new System.Drawing.Point(289, 263);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(226, 30);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtUsername.Location = new System.Drawing.Point(289, 183);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(226, 30);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogin.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.btnLogin.Location = new System.Drawing.Point(251, 377);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(143, 63);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Conectare";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnInapoi
            // 
            this.btnInapoi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnInapoi.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.btnInapoi.Location = new System.Drawing.Point(448, 392);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(118, 48);
            this.btnInapoi.TabIndex = 11;
            this.btnInapoi.Text = "Inapoi";
            this.btnInapoi.UseVisualStyleBackColor = false;
            this.btnInapoi.Click += new System.EventHandler(this.btnInapoi_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSterge.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.btnSterge.Location = new System.Drawing.Point(87, 392);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(118, 48);
            this.btnSterge.TabIndex = 11;
            this.btnSterge.Text = "Sterge";
            this.btnSterge.UseVisualStyleBackColor = false;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 534);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnInapoi);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.Conectare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Conectare;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnInapoi;
        private System.Windows.Forms.Button btnSterge;
    }
}