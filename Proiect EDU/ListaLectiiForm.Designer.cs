namespace Proiect_EDU
{
    partial class ListaLectiiForm
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
            this.Materii = new System.Windows.Forms.Label();
            this.listBoxLectii = new System.Windows.Forms.ListBox();
            this.btnInapoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Materii
            // 
            this.Materii.AutoSize = true;
            this.Materii.BackColor = System.Drawing.Color.Transparent;
            this.Materii.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Materii.ForeColor = System.Drawing.Color.White;
            this.Materii.Location = new System.Drawing.Point(271, 108);
            this.Materii.Name = "Materii";
            this.Materii.Size = new System.Drawing.Size(100, 39);
            this.Materii.TabIndex = 8;
            this.Materii.Text = "Lectii";
            // 
            // listBoxLectii
            // 
            this.listBoxLectii.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxLectii.FormattingEnabled = true;
            this.listBoxLectii.ItemHeight = 27;
            this.listBoxLectii.Location = new System.Drawing.Point(99, 162);
            this.listBoxLectii.Name = "listBoxLectii";
            this.listBoxLectii.Size = new System.Drawing.Size(441, 247);
            this.listBoxLectii.TabIndex = 9;
            this.listBoxLectii.SelectedIndexChanged += new System.EventHandler(this.listBoxLectii_SelectedIndexChanged);
            this.listBoxLectii.DoubleClick += new System.EventHandler(this.listBoxLectii_DoubleClick);
            // 
            // btnInapoi
            // 
            this.btnInapoi.Location = new System.Drawing.Point(278, 438);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(101, 36);
            this.btnInapoi.TabIndex = 10;
            this.btnInapoi.Text = "Inapoi";
            this.btnInapoi.UseVisualStyleBackColor = true;
            this.btnInapoi.Click += new System.EventHandler(this.btnInapoi_Click);
            // 
            // ListaLectiiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proiect_EDU.Properties.Resources._2304_w061_n005_163B_p15_163;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 537);
            this.Controls.Add(this.btnInapoi);
            this.Controls.Add(this.listBoxLectii);
            this.Controls.Add(this.Materii);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaLectiiForm";
            this.Text = "ListaLectiiForm";
            this.Load += new System.EventHandler(this.ListaLectiiForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Materii;
        private System.Windows.Forms.ListBox listBoxLectii;
        private System.Windows.Forms.Button btnInapoi;
    }
}