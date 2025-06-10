namespace Proiect_EDU
{
    partial class ClassForm
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
            this.listBoxClase = new System.Windows.Forms.ListBox();
            this.btnInapoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(185, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alege clasa ta::";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBoxClase
            // 
            this.listBoxClase.BackColor = System.Drawing.Color.LightSteelBlue;
            this.listBoxClase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxClase.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxClase.FormattingEnabled = true;
            this.listBoxClase.ItemHeight = 27;
            this.listBoxClase.Items.AddRange(new object[] {
            "clasa 1",
            "clasa a 2-a",
            "clasa a 3-a",
            "clasa a 4-a"});
            this.listBoxClase.Location = new System.Drawing.Point(219, 172);
            this.listBoxClase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxClase.Name = "listBoxClase";
            this.listBoxClase.Size = new System.Drawing.Size(170, 218);
            this.listBoxClase.TabIndex = 1;
            this.listBoxClase.SelectedIndexChanged += new System.EventHandler(this.listBoxClase_SelectedIndexChanged);
            // 
            // btnInapoi
            // 
            this.btnInapoi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnInapoi.Location = new System.Drawing.Point(240, 415);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(130, 51);
            this.btnInapoi.TabIndex = 2;
            this.btnInapoi.Text = "Inapoi";
            this.btnInapoi.UseVisualStyleBackColor = true;
            this.btnInapoi.Click += new System.EventHandler(this.btnInapoi_Click);
            // 
            // ClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proiect_EDU.Properties.Resources._2304_w061_n005_163B_p15_163;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 537);
            this.Controls.Add(this.btnInapoi);
            this.Controls.Add(this.listBoxClase);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ClassForm";
            this.Text = "ClassForm";
            this.Load += new System.EventHandler(this.ClassForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxClase;
        private System.Windows.Forms.Button btnInapoi;
    }
}