namespace Proiect_EDU
{
    partial class LectieForm
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
            this.lblTitlu = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelContinut = new System.Windows.Forms.Panel();
            this.btnFinalizare = new System.Windows.Forms.Button();
            this.txtContinut = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelContinut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Bookman Old Style", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitlu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(175)))), ((int)(((byte)(125)))));
            this.lblTitlu.Location = new System.Drawing.Point(12, 9);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(121, 40);
            this.lblTitlu.TabIndex = 0;
            this.lblTitlu.Text = "TITLU";
            this.lblTitlu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitlu.Click += new System.EventHandler(this.lblTitlu_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(32)))), ((int)(((byte)(20)))));
            this.panelHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelHeader.Controls.Add(this.lblTitlu);
            this.panelHeader.Controls.Add(this.pictureBox2);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(703, 66);
            this.panelHeader.TabIndex = 2;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Proiect_EDU.Properties.Resources.close;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(639, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 62);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panelContinut
            // 
            this.panelContinut.BackColor = System.Drawing.Color.Transparent;
            this.panelContinut.BackgroundImage = global::Proiect_EDU.Properties.Resources.lose;
            this.panelContinut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelContinut.Controls.Add(this.btnFinalizare);
            this.panelContinut.Controls.Add(this.txtContinut);
            this.panelContinut.Controls.Add(this.pictureBox1);
            this.panelContinut.Location = new System.Drawing.Point(-73, 35);
            this.panelContinut.Name = "panelContinut";
            this.panelContinut.Padding = new System.Windows.Forms.Padding(20);
            this.panelContinut.Size = new System.Drawing.Size(795, 724);
            this.panelContinut.TabIndex = 1;
            this.panelContinut.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContinut_Paint);
            // 
            // btnFinalizare
            // 
            this.btnFinalizare.Location = new System.Drawing.Point(161, 650);
            this.btnFinalizare.Name = "btnFinalizare";
            this.btnFinalizare.Size = new System.Drawing.Size(165, 30);
            this.btnFinalizare.TabIndex = 3;
            this.btnFinalizare.Text = "Finalizare";
            this.btnFinalizare.UseVisualStyleBackColor = true;
            this.btnFinalizare.Click += new System.EventHandler(this.btnFinalizare_Click);
            // 
            // txtContinut
            // 
            this.txtContinut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(175)))), ((int)(((byte)(125)))));
            this.txtContinut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContinut.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtContinut.Location = new System.Drawing.Point(161, 119);
            this.txtContinut.Name = "txtContinut";
            this.txtContinut.ReadOnly = true;
            this.txtContinut.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtContinut.Size = new System.Drawing.Size(471, 525);
            this.txtContinut.TabIndex = 1;
            this.txtContinut.Text = "";
            this.txtContinut.TextChanged += new System.EventHandler(this.txtContinut_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Proiect_EDU.Properties.Resources.lectieAdunare;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(534, 375);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 343);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // LectieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 743);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelContinut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LectieForm";
            this.Text = "LectieForm";
            this.Load += new System.EventHandler(this.LectieForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelContinut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox txtContinut;
        private System.Windows.Forms.Panel panelContinut;
        private System.Windows.Forms.Button btnFinalizare;
    }
}