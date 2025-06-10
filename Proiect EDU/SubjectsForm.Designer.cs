namespace Proiect_EDU
{
    partial class SubjectsForm
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
            this.listBoxMaterii = new System.Windows.Forms.ListBox();
            this.btnInapoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Materii
            // 
            this.Materii.AutoSize = true;
            this.Materii.BackColor = System.Drawing.Color.Transparent;
            this.Materii.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Materii.ForeColor = System.Drawing.Color.White;
            this.Materii.Location = new System.Drawing.Point(254, 107);
            this.Materii.Name = "Materii";
            this.Materii.Size = new System.Drawing.Size(127, 39);
            this.Materii.TabIndex = 6;
            this.Materii.Text = "Materii";
            // 
            // listBoxMaterii
            // 
            this.listBoxMaterii.BackColor = System.Drawing.Color.LightSteelBlue;
            this.listBoxMaterii.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxMaterii.FormattingEnabled = true;
            this.listBoxMaterii.ItemHeight = 27;
            this.listBoxMaterii.Location = new System.Drawing.Point(216, 163);
            this.listBoxMaterii.Name = "listBoxMaterii";
            this.listBoxMaterii.Size = new System.Drawing.Size(200, 220);
            this.listBoxMaterii.TabIndex = 8;
            this.listBoxMaterii.SelectedIndexChanged += new System.EventHandler(this.listBoxMaterii_SelectedIndexChanged);
            this.listBoxMaterii.DoubleClick += new System.EventHandler(this.listBoxMaterii_DoubleClick);
            // 
            // btnInapoi
            // 
            this.btnInapoi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnInapoi.Location = new System.Drawing.Point(251, 400);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(130, 51);
            this.btnInapoi.TabIndex = 9;
            this.btnInapoi.Text = "Inapoi";
            this.btnInapoi.UseVisualStyleBackColor = true;
            this.btnInapoi.Click += new System.EventHandler(this.btnInapoi_Click);
            // 
            // SubjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proiect_EDU.Properties.Resources._2304_w061_n005_163B_p15_163;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 537);
            this.Controls.Add(this.btnInapoi);
            this.Controls.Add(this.listBoxMaterii);
            this.Controls.Add(this.Materii);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SubjectsForm";
            this.Text = "SubjectsForm";
            this.Load += new System.EventHandler(this.SubjectsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Materii;
        private System.Windows.Forms.ListBox listBoxMaterii;
        private System.Windows.Forms.Button btnInapoi;
    }
}