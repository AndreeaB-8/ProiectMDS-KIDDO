namespace Proiect_EDU
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.Creare_cont = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUsernameR = new System.Windows.Forms.TextBox();
            this.txtPasswordR = new System.Windows.Forms.TextBox();
            this.txtConfirmPasswordR = new System.Windows.Forms.TextBox();
            this.txtEmailR = new System.Windows.Forms.TextBox();
            this.btnSterge = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnInapoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Creare_cont
            // 
            this.Creare_cont.AutoSize = true;
            this.Creare_cont.BackColor = System.Drawing.Color.Transparent;
            this.Creare_cont.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Creare_cont.ForeColor = System.Drawing.Color.White;
            this.Creare_cont.Location = new System.Drawing.Point(215, 60);
            this.Creare_cont.Name = "Creare_cont";
            this.Creare_cont.Size = new System.Drawing.Size(214, 48);
            this.Creare_cont.TabIndex = 6;
            this.Creare_cont.Text = "Creare cont";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(126, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "Username";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(126, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Parola";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(126, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Confirmare parola";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(127, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 29);
            this.label8.TabIndex = 6;
            this.label8.Text = "Email";
            // 
            // txtUsernameR
            // 
            this.txtUsernameR.Location = new System.Drawing.Point(324, 155);
            this.txtUsernameR.Name = "txtUsernameR";
            this.txtUsernameR.Size = new System.Drawing.Size(203, 22);
            this.txtUsernameR.TabIndex = 7;
            // 
            // txtPasswordR
            // 
            this.txtPasswordR.Location = new System.Drawing.Point(324, 212);
            this.txtPasswordR.Name = "txtPasswordR";
            this.txtPasswordR.Size = new System.Drawing.Size(203, 22);
            this.txtPasswordR.TabIndex = 7;
            // 
            // txtConfirmPasswordR
            // 
            this.txtConfirmPasswordR.Location = new System.Drawing.Point(324, 269);
            this.txtConfirmPasswordR.Name = "txtConfirmPasswordR";
            this.txtConfirmPasswordR.Size = new System.Drawing.Size(203, 22);
            this.txtConfirmPasswordR.TabIndex = 7;
            // 
            // txtEmailR
            // 
            this.txtEmailR.Location = new System.Drawing.Point(324, 328);
            this.txtEmailR.Name = "txtEmailR";
            this.txtEmailR.Size = new System.Drawing.Size(203, 22);
            this.txtEmailR.TabIndex = 7;
            // 
            // btnSterge
            // 
            this.btnSterge.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSterge.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.btnSterge.Location = new System.Drawing.Point(60, 422);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(118, 48);
            this.btnSterge.TabIndex = 13;
            this.btnSterge.Text = "Sterge";
            this.btnSterge.UseVisualStyleBackColor = false;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click_1);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRegister.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.btnRegister.Location = new System.Drawing.Point(256, 407);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(143, 63);
            this.btnRegister.TabIndex = 12;
            this.btnRegister.Text = "Conectare";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnInapoi
            // 
            this.btnInapoi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnInapoi.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.btnInapoi.Location = new System.Drawing.Point(470, 422);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(118, 48);
            this.btnInapoi.TabIndex = 12;
            this.btnInapoi.Text = "Inapoi";
            this.btnInapoi.UseVisualStyleBackColor = false;
            this.btnInapoi.Click += new System.EventHandler(this.btnInapoi_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 534);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnInapoi);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtEmailR);
            this.Controls.Add(this.txtConfirmPasswordR);
            this.Controls.Add(this.txtPasswordR);
            this.Controls.Add(this.txtUsernameR);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Creare_cont);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label Creare_cont;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUsernameR;
        private System.Windows.Forms.TextBox txtPasswordR;
        private System.Windows.Forms.TextBox txtConfirmPasswordR;
        private System.Windows.Forms.TextBox txtEmailR;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnInapoi;
    }
}