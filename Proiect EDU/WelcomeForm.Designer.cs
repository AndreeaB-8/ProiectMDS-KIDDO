namespace Proiect_EDU
{
    partial class WelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            this.panelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnDespreNoi = new System.Windows.Forms.Button();
            this.btnAdministrare = new System.Windows.Forms.Button();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.panelStart = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBoxMouse = new System.Windows.Forms.PictureBox();
            this.lblKIDDO = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.mainpanel.SuspendLayout();
            this.panelStart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMouse)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Controls.Add(this.button3);
            this.panelMenu.Controls.Add(this.btnDespreNoi);
            this.panelMenu.Controls.Add(this.btnAdministrare);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(198, 537);
            this.panelMenu.TabIndex = 2;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelLogo.Controls.Add(this.lblKIDDO);
            this.panelLogo.Location = new System.Drawing.Point(3, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(195, 80);
            this.panelLogo.TabIndex = 3;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SteelBlue;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(3, 89);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(195, 86);
            this.button3.TabIndex = 3;
            this.button3.Text = "Cont";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnDespreNoi
            // 
            this.btnDespreNoi.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDespreNoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDespreNoi.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.btnDespreNoi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDespreNoi.Location = new System.Drawing.Point(3, 181);
            this.btnDespreNoi.Name = "btnDespreNoi";
            this.btnDespreNoi.Size = new System.Drawing.Size(195, 86);
            this.btnDespreNoi.TabIndex = 4;
            this.btnDespreNoi.Text = "Despre noi";
            this.btnDespreNoi.UseVisualStyleBackColor = false;
            this.btnDespreNoi.Click += new System.EventHandler(this.btnDespreNoi_Click);
            // 
            // btnAdministrare
            // 
            this.btnAdministrare.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAdministrare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministrare.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.btnAdministrare.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdministrare.Location = new System.Drawing.Point(3, 273);
            this.btnAdministrare.Name = "btnAdministrare";
            this.btnAdministrare.Size = new System.Drawing.Size(195, 86);
            this.btnAdministrare.TabIndex = 4;
            this.btnAdministrare.Text = "Administrare";
            this.btnAdministrare.UseVisualStyleBackColor = false;
            this.btnAdministrare.Visible = false;
            this.btnAdministrare.Click += new System.EventHandler(this.btnAdministrare_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.mainpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainpanel.Controls.Add(this.panelStart);
            this.mainpanel.Location = new System.Drawing.Point(197, 3);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(634, 534);
            this.mainpanel.TabIndex = 3;
            this.mainpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainpanel_Paint);
            // 
            // panelStart
            // 
            this.panelStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelStart.BackgroundImage")));
            this.panelStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelStart.Controls.Add(this.label1);
            this.panelStart.Controls.Add(this.label2);
            this.panelStart.Controls.Add(this.button4);
            this.panelStart.Controls.Add(this.pictureBoxMouse);
            this.panelStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStart.Location = new System.Drawing.Point(0, 0);
            this.panelStart.Name = "panelStart";
            this.panelStart.Size = new System.Drawing.Size(634, 534);
            this.panelStart.TabIndex = 0;
            this.panelStart.Paint += new System.Windows.Forms.PaintEventHandler(this.panelStart_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(206, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bine ai venit!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(110, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(415, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hai sa invatam impreuna!";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(267, 258);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 54);
            this.button4.TabIndex = 2;
            this.button4.Text = "START";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pictureBoxMouse
            // 
            this.pictureBoxMouse.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMouse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxMouse.BackgroundImage")));
            this.pictureBoxMouse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxMouse.Location = new System.Drawing.Point(-9, 193);
            this.pictureBoxMouse.Name = "pictureBoxMouse";
            this.pictureBoxMouse.Size = new System.Drawing.Size(338, 344);
            this.pictureBoxMouse.TabIndex = 3;
            this.pictureBoxMouse.TabStop = false;
            this.pictureBoxMouse.Click += new System.EventHandler(this.pictureBoxMouse_Click);
            // 
            // lblKIDDO
            // 
            this.lblKIDDO.AutoSize = true;
            this.lblKIDDO.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKIDDO.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKIDDO.Location = new System.Drawing.Point(31, 17);
            this.lblKIDDO.Name = "lblKIDDO";
            this.lblKIDDO.Size = new System.Drawing.Size(123, 46);
            this.lblKIDDO.TabIndex = 0;
            this.lblKIDDO.Text = "KIDDO";
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(219)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(831, 537);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.mainpanel);
            this.Name = "WelcomeForm";
            this.Text = "WelcomeForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.mainpanel.ResumeLayout(false);
            this.panelStart.ResumeLayout(false);
            this.panelStart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMouse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.Panel mainpanel;
        public System.Windows.Forms.Panel panelStart;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBoxMouse;
        private System.Windows.Forms.Button btnDespreNoi;
        private System.Windows.Forms.Button btnAdministrare;
        private System.Windows.Forms.Label lblKIDDO;
    }
}

