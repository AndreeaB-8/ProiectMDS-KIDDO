namespace Proiect_EDU
{
    partial class LectiiJocuri
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnLectii = new System.Windows.Forms.Button();
            this.btnJocuri = new System.Windows.Forms.Button();
            this.btnInapoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(90, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cum doresti sa invatam azi?";
            // 
            // btnLectii
            // 
            this.btnLectii.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLectii.Location = new System.Drawing.Point(138, 232);
            this.btnLectii.Margin = new System.Windows.Forms.Padding(4);
            this.btnLectii.Name = "btnLectii";
            this.btnLectii.Size = new System.Drawing.Size(163, 66);
            this.btnLectii.TabIndex = 2;
            this.btnLectii.Text = "Lectii";
            this.btnLectii.UseVisualStyleBackColor = true;
            this.btnLectii.Click += new System.EventHandler(this.btnLectii_Click);
            // 
            // btnJocuri
            // 
            this.btnJocuri.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnJocuri.Location = new System.Drawing.Point(348, 232);
            this.btnJocuri.Margin = new System.Windows.Forms.Padding(4);
            this.btnJocuri.Name = "btnJocuri";
            this.btnJocuri.Size = new System.Drawing.Size(163, 66);
            this.btnJocuri.TabIndex = 2;
            this.btnJocuri.Text = "Jocuri";
            this.btnJocuri.UseVisualStyleBackColor = true;
            this.btnJocuri.Click += new System.EventHandler(this.btnJocuri_Click);
            // 
            // btnInapoi
            // 
            this.btnInapoi.Location = new System.Drawing.Point(258, 329);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(136, 45);
            this.btnInapoi.TabIndex = 3;
            this.btnInapoi.Text = "Inapoi";
            this.btnInapoi.UseVisualStyleBackColor = true;
            this.btnInapoi.Click += new System.EventHandler(this.btnInapoi_Click);
            // 
            // LectiiJocuri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proiect_EDU.Properties.Resources._2304_w061_n005_163B_p15_163;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 537);
            this.Controls.Add(this.btnInapoi);
            this.Controls.Add(this.btnJocuri);
            this.Controls.Add(this.btnLectii);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LectiiJocuri";
            this.Text = "LectiiJocuri";
            this.Load += new System.EventHandler(this.LectiiJocuri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLectii;
        private System.Windows.Forms.Button btnJocuri;
        private System.Windows.Forms.Button btnInapoi;
    }
}