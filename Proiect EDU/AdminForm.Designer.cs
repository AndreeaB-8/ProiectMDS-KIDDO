namespace Proiect_EDU
{
    partial class AdminForm
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
            this.dataGridViewUtilizatori = new System.Windows.Forms.DataGridView();
            this.btnAdaugaUtilizator = new System.Windows.Forms.Button();
            this.btnEditeazaUtilizator = new System.Windows.Forms.Button();
            this.btnStergeUtilizator = new System.Windows.Forms.Button();
            this.lblNume = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.lblParola = new System.Windows.Forms.Label();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnGenereazaRaport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUtilizatori)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUtilizatori
            // 
            this.dataGridViewUtilizatori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUtilizatori.Location = new System.Drawing.Point(84, 12);
            this.dataGridViewUtilizatori.Name = "dataGridViewUtilizatori";
            this.dataGridViewUtilizatori.RowHeadersWidth = 51;
            this.dataGridViewUtilizatori.RowTemplate.Height = 24;
            this.dataGridViewUtilizatori.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUtilizatori.Size = new System.Drawing.Size(620, 208);
            this.dataGridViewUtilizatori.TabIndex = 0;
            this.dataGridViewUtilizatori.SelectionChanged += new System.EventHandler(this.dataGridViewUtilizatori_SelectionChanged);
            // 
            // btnAdaugaUtilizator
            // 
            this.btnAdaugaUtilizator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdaugaUtilizator.Location = new System.Drawing.Point(362, 244);
            this.btnAdaugaUtilizator.Name = "btnAdaugaUtilizator";
            this.btnAdaugaUtilizator.Size = new System.Drawing.Size(164, 89);
            this.btnAdaugaUtilizator.TabIndex = 1;
            this.btnAdaugaUtilizator.Text = "Adauga utilizator";
            this.btnAdaugaUtilizator.UseVisualStyleBackColor = true;
            this.btnAdaugaUtilizator.Click += new System.EventHandler(this.btnAdaugaUtilizator_Click);
            // 
            // btnEditeazaUtilizator
            // 
            this.btnEditeazaUtilizator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEditeazaUtilizator.Location = new System.Drawing.Point(362, 339);
            this.btnEditeazaUtilizator.Name = "btnEditeazaUtilizator";
            this.btnEditeazaUtilizator.Size = new System.Drawing.Size(164, 82);
            this.btnEditeazaUtilizator.TabIndex = 2;
            this.btnEditeazaUtilizator.Text = "Editeaza Utilizator";
            this.btnEditeazaUtilizator.UseVisualStyleBackColor = true;
            this.btnEditeazaUtilizator.Click += new System.EventHandler(this.btnEditeazaUtilizator_Click);
            // 
            // btnStergeUtilizator
            // 
            this.btnStergeUtilizator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStergeUtilizator.Location = new System.Drawing.Point(532, 339);
            this.btnStergeUtilizator.Name = "btnStergeUtilizator";
            this.btnStergeUtilizator.Size = new System.Drawing.Size(172, 82);
            this.btnStergeUtilizator.TabIndex = 3;
            this.btnStergeUtilizator.Text = "Sterge Utilizator";
            this.btnStergeUtilizator.UseVisualStyleBackColor = true;
            this.btnStergeUtilizator.Click += new System.EventHandler(this.btnStergeUtilizator_Click);
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNume.Location = new System.Drawing.Point(85, 256);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(53, 20);
            this.lblNume.TabIndex = 4;
            this.lblNume.Text = "Nume";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(148, 254);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(136, 22);
            this.txtNume.TabIndex = 5;
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblParola.Location = new System.Drawing.Point(85, 299);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(57, 20);
            this.lblParola.TabIndex = 4;
            this.lblParola.Text = "Parola";
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(148, 295);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(136, 22);
            this.txtParola.TabIndex = 5;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRol.Location = new System.Drawing.Point(85, 382);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(34, 20);
            this.lblRol.TabIndex = 4;
            this.lblRol.Text = "Rol";
            // 
            // cbRol
            // 
            this.cbRol.DisplayMember = "user";
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Items.AddRange(new object[] {
            "user",
            "admin"});
            this.cbRol.Location = new System.Drawing.Point(148, 378);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(136, 24);
            this.cbRol.TabIndex = 6;
            this.cbRol.Text = "user";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmail.Location = new System.Drawing.Point(85, 341);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 20);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(148, 339);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(136, 22);
            this.txtEmail.TabIndex = 5;
            // 
            // btnGenereazaRaport
            // 
            this.btnGenereazaRaport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGenereazaRaport.Location = new System.Drawing.Point(532, 244);
            this.btnGenereazaRaport.Name = "btnGenereazaRaport";
            this.btnGenereazaRaport.Size = new System.Drawing.Size(172, 89);
            this.btnGenereazaRaport.TabIndex = 1;
            this.btnGenereazaRaport.Text = "Genereaza raport";
            this.btnGenereazaRaport.UseVisualStyleBackColor = true;
            this.btnGenereazaRaport.Click += new System.EventHandler(this.btnGenereazaRaport_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbRol);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.btnStergeUtilizator);
            this.Controls.Add(this.btnEditeazaUtilizator);
            this.Controls.Add(this.btnGenereazaRaport);
            this.Controls.Add(this.btnAdaugaUtilizator);
            this.Controls.Add(this.dataGridViewUtilizatori);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUtilizatori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUtilizatori;
        private System.Windows.Forms.Button btnAdaugaUtilizator;
        private System.Windows.Forms.Button btnEditeazaUtilizator;
        private System.Windows.Forms.Button btnStergeUtilizator;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cbRol;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnGenereazaRaport;
    }
}