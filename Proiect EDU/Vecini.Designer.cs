namespace Proiect_EDU
{
    partial class Vecini
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
            this.lblText = new System.Windows.Forms.Label();
            this.txtVecinStanga = new System.Windows.Forms.TextBox();
            this.txtVecinDreapta = new System.Windows.Forms.TextBox();
            this.btnVerifica = new System.Windows.Forms.Button();
            this.lblNumar = new System.Windows.Forms.Label();
            this.btnFinalizare = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.BackColor = System.Drawing.Color.Transparent;
            this.lblText.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblText.ForeColor = System.Drawing.Color.White;
            this.lblText.Location = new System.Drawing.Point(222, 86);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(448, 48);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Gaseste vecinii numarului:";
            // 
            // txtVecinStanga
            // 
            this.txtVecinStanga.Location = new System.Drawing.Point(220, 201);
            this.txtVecinStanga.Name = "txtVecinStanga";
            this.txtVecinStanga.Size = new System.Drawing.Size(122, 22);
            this.txtVecinStanga.TabIndex = 1;
            // 
            // txtVecinDreapta
            // 
            this.txtVecinDreapta.Location = new System.Drawing.Point(551, 200);
            this.txtVecinDreapta.Name = "txtVecinDreapta";
            this.txtVecinDreapta.Size = new System.Drawing.Size(100, 22);
            this.txtVecinDreapta.TabIndex = 2;
            // 
            // btnVerifica
            // 
            this.btnVerifica.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnVerifica.Location = new System.Drawing.Point(379, 293);
            this.btnVerifica.Name = "btnVerifica";
            this.btnVerifica.Size = new System.Drawing.Size(121, 47);
            this.btnVerifica.TabIndex = 3;
            this.btnVerifica.Text = "Verifica";
            this.btnVerifica.UseVisualStyleBackColor = true;
            this.btnVerifica.Click += new System.EventHandler(this.btnVerifica_Click);
            // 
            // lblNumar
            // 
            this.lblNumar.AutoSize = true;
            this.lblNumar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblNumar.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNumar.ForeColor = System.Drawing.Color.White;
            this.lblNumar.Location = new System.Drawing.Point(426, 189);
            this.lblNumar.Name = "lblNumar";
            this.lblNumar.Size = new System.Drawing.Size(41, 48);
            this.lblNumar.TabIndex = 5;
            this.lblNumar.Text = "0";
            // 
            // btnFinalizare
            // 
            this.btnFinalizare.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFinalizare.Location = new System.Drawing.Point(673, 402);
            this.btnFinalizare.Name = "btnFinalizare";
            this.btnFinalizare.Size = new System.Drawing.Size(137, 41);
            this.btnFinalizare.TabIndex = 6;
            this.btnFinalizare.Text = "Finalizare";
            this.btnFinalizare.UseVisualStyleBackColor = true;
            this.btnFinalizare.Click += new System.EventHandler(this.btnFinalizare_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(349, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 52);
            this.label1.TabIndex = 7;
            this.label1.Text = "<";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(508, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 52);
            this.label2.TabIndex = 8;
            this.label2.Text = "<";
            // 
            // Vecini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proiect_EDU.Properties.Resources.completareNumarBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(856, 480);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFinalizare);
            this.Controls.Add(this.lblNumar);
            this.Controls.Add(this.btnVerifica);
            this.Controls.Add(this.txtVecinDreapta);
            this.Controls.Add(this.txtVecinStanga);
            this.Controls.Add(this.lblText);
            this.Name = "Vecini";
            this.Text = "Vecini";
            this.Load += new System.EventHandler(this.Vecini_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox txtVecinStanga;
        private System.Windows.Forms.TextBox txtVecinDreapta;
        private System.Windows.Forms.Button btnVerifica;
        private System.Windows.Forms.Label lblNumar;
        private System.Windows.Forms.Button btnFinalizare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}