namespace Proiect_EDU
{
    partial class AccountForm
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.Cont = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnLogin.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(335, 226);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(213, 88);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Conectare";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnRegister.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRegister.ForeColor = System.Drawing.Color.Black;
            this.btnRegister.Location = new System.Drawing.Point(83, 226);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(213, 88);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Creare cont";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // Cont
            // 
            this.Cont.AutoSize = true;
            this.Cont.BackColor = System.Drawing.Color.Transparent;
            this.Cont.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Cont.ForeColor = System.Drawing.Color.White;
            this.Cont.Location = new System.Drawing.Point(268, 145);
            this.Cont.Name = "Cont";
            this.Cont.Size = new System.Drawing.Size(90, 45);
            this.Cont.TabIndex = 3;
            this.Cont.Text = "Cont";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.button1.Location = new System.Drawing.Point(261, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "Inapoi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnInapoi_Click);
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proiect_EDU.Properties.Resources.Register_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 534);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Cont);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnRegister);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountForm";
            this.Text = "AccountForm";
            this.Load += new System.EventHandler(this.AccountForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label Cont;
        private System.Windows.Forms.Button button1;
    }
}