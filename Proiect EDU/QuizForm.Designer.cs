namespace Proiect_EDU
{
    partial class QuizForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizForm));
            this.lblIntrebare = new System.Windows.Forms.Label();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnFinalizare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIntrebare
            // 
            this.lblIntrebare.BackColor = System.Drawing.Color.Transparent;
            this.lblIntrebare.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIntrebare.ForeColor = System.Drawing.Color.White;
            this.lblIntrebare.Location = new System.Drawing.Point(12, 69);
            this.lblIntrebare.Name = "lblIntrebare";
            this.lblIntrebare.Size = new System.Drawing.Size(810, 45);
            this.lblIntrebare.TabIndex = 0;
            this.lblIntrebare.Text = "Intrebare";
            this.lblIntrebare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnA.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnA.Location = new System.Drawing.Point(175, 146);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(171, 89);
            this.btnA.TabIndex = 1;
            this.btnA.Text = "Varianta A";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnB.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnB.Location = new System.Drawing.Point(500, 146);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(171, 89);
            this.btnB.TabIndex = 2;
            this.btnB.Text = "Varianta B";
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnC.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnC.Location = new System.Drawing.Point(175, 260);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(171, 89);
            this.btnC.TabIndex = 3;
            this.btnC.Text = "Varianta C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnD.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnD.Location = new System.Drawing.Point(500, 260);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(171, 89);
            this.btnD.TabIndex = 4;
            this.btnD.Text = "Varianta D";
            this.btnD.UseVisualStyleBackColor = false;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnFinalizare
            // 
            this.btnFinalizare.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizare.Location = new System.Drawing.Point(702, 405);
            this.btnFinalizare.Name = "btnFinalizare";
            this.btnFinalizare.Size = new System.Drawing.Size(142, 46);
            this.btnFinalizare.TabIndex = 5;
            this.btnFinalizare.Text = "Finalizeaza";
            this.btnFinalizare.UseVisualStyleBackColor = true;
            this.btnFinalizare.Click += new System.EventHandler(this.btnFinalizare_Click);
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(856, 480);
            this.Controls.Add(this.lblIntrebare);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnFinalizare);
            this.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.Name = "QuizForm";
            this.Text = "Quiz";
            this.Load += new System.EventHandler(this.QuizForm_Load);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Label lblIntrebare;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnFinalizare;
    }
}