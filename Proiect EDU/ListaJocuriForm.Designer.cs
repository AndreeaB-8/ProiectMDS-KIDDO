namespace Proiect_EDU
{
    partial class ListaJocuriForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaJocuriForm));
            this.listBoxJocuri = new System.Windows.Forms.ListBox();
            this.Materii = new System.Windows.Forms.Label();
            this.btnInapoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxJocuri
            // 
            this.listBoxJocuri.BackColor = System.Drawing.Color.LightSteelBlue;
            this.listBoxJocuri.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxJocuri.FormattingEnabled = true;
            this.listBoxJocuri.ItemHeight = 27;
            this.listBoxJocuri.Location = new System.Drawing.Point(150, 116);
            this.listBoxJocuri.Name = "listBoxJocuri";
            this.listBoxJocuri.Size = new System.Drawing.Size(323, 301);
            this.listBoxJocuri.TabIndex = 0;
            this.listBoxJocuri.SelectedIndexChanged += new System.EventHandler(this.listBoxJocuri_SelectedIndexChanged);
            this.listBoxJocuri.DoubleClick += new System.EventHandler(this.listBoxJocuri_DoubleClick);
            // 
            // Materii
            // 
            this.Materii.AutoSize = true;
            this.Materii.BackColor = System.Drawing.Color.Transparent;
            this.Materii.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Materii.ForeColor = System.Drawing.Color.White;
            this.Materii.Location = new System.Drawing.Point(242, 64);
            this.Materii.Name = "Materii";
            this.Materii.Size = new System.Drawing.Size(114, 39);
            this.Materii.TabIndex = 7;
            this.Materii.Text = "Jocuri";
            // 
            // btnInapoi
            // 
            this.btnInapoi.Location = new System.Drawing.Point(249, 432);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(96, 32);
            this.btnInapoi.TabIndex = 8;
            this.btnInapoi.Text = "Inapoi";
            this.btnInapoi.UseVisualStyleBackColor = true;
            this.btnInapoi.Click += new System.EventHandler(this.btnInapoi_Click);
            // 
            // ListaJocuriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 534);
            this.Controls.Add(this.btnInapoi);
            this.Controls.Add(this.Materii);
            this.Controls.Add(this.listBoxJocuri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaJocuriForm";
            this.Text = "ListaJocuriForm";
            this.Load += new System.EventHandler(this.ListaJocuriForm_Load);
            this.DoubleClick += new System.EventHandler(this.listBoxJocuri_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxJocuri;
        private System.Windows.Forms.Label Materii;
        private System.Windows.Forms.Button btnInapoi;
    }
}