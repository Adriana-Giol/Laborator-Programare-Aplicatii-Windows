namespace _Com_Ciurea_Seminar5_1046
{
    partial class Form1
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
            this.labelDataCurs = new System.Windows.Forms.Label();
            this.tbDataCurs = new System.Windows.Forms.TextBox();
            this.tbEUR = new System.Windows.Forms.TextBox();
            this.labelEUR = new System.Windows.Forms.Label();
            this.tbUSD = new System.Windows.Forms.TextBox();
            this.labelUSD = new System.Windows.Forms.Label();
            this.tbGBP = new System.Windows.Forms.TextBox();
            this.labelGBP = new System.Windows.Forms.Label();
            this.tbXAU = new System.Windows.Forms.TextBox();
            this.labelXAU = new System.Windows.Forms.Label();
            this.btnParsare = new System.Windows.Forms.Button();
            this.btnGenerare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDataCurs
            // 
            this.labelDataCurs.AutoSize = true;
            this.labelDataCurs.Location = new System.Drawing.Point(132, 74);
            this.labelDataCurs.Name = "labelDataCurs";
            this.labelDataCurs.Size = new System.Drawing.Size(91, 17);
            this.labelDataCurs.TabIndex = 0;
            this.labelDataCurs.Text = "Data cursului";
            // 
            // tbDataCurs
            // 
            this.tbDataCurs.Location = new System.Drawing.Point(287, 71);
            this.tbDataCurs.Name = "tbDataCurs";
            this.tbDataCurs.Size = new System.Drawing.Size(100, 22);
            this.tbDataCurs.TabIndex = 1;
            // 
            // tbEUR
            // 
            this.tbEUR.Location = new System.Drawing.Point(287, 112);
            this.tbEUR.Name = "tbEUR";
            this.tbEUR.Size = new System.Drawing.Size(100, 22);
            this.tbEUR.TabIndex = 3;
            // 
            // labelEUR
            // 
            this.labelEUR.AutoSize = true;
            this.labelEUR.Location = new System.Drawing.Point(132, 115);
            this.labelEUR.Name = "labelEUR";
            this.labelEUR.Size = new System.Drawing.Size(90, 17);
            this.labelEUR.TabIndex = 2;
            this.labelEUR.Text = "Valoare EUR";
            // 
            // tbUSD
            // 
            this.tbUSD.Location = new System.Drawing.Point(287, 151);
            this.tbUSD.Name = "tbUSD";
            this.tbUSD.Size = new System.Drawing.Size(100, 22);
            this.tbUSD.TabIndex = 5;
            // 
            // labelUSD
            // 
            this.labelUSD.AutoSize = true;
            this.labelUSD.Location = new System.Drawing.Point(132, 154);
            this.labelUSD.Name = "labelUSD";
            this.labelUSD.Size = new System.Drawing.Size(90, 17);
            this.labelUSD.TabIndex = 4;
            this.labelUSD.Text = "Valoare USD";
            // 
            // tbGBP
            // 
            this.tbGBP.Location = new System.Drawing.Point(287, 198);
            this.tbGBP.Name = "tbGBP";
            this.tbGBP.Size = new System.Drawing.Size(100, 22);
            this.tbGBP.TabIndex = 7;
            // 
            // labelGBP
            // 
            this.labelGBP.AutoSize = true;
            this.labelGBP.Location = new System.Drawing.Point(132, 201);
            this.labelGBP.Name = "labelGBP";
            this.labelGBP.Size = new System.Drawing.Size(90, 17);
            this.labelGBP.TabIndex = 6;
            this.labelGBP.Text = "Valoare GBP";
            // 
            // tbXAU
            // 
            this.tbXAU.Location = new System.Drawing.Point(287, 246);
            this.tbXAU.Name = "tbXAU";
            this.tbXAU.Size = new System.Drawing.Size(100, 22);
            this.tbXAU.TabIndex = 9;
            // 
            // labelXAU
            // 
            this.labelXAU.AutoSize = true;
            this.labelXAU.Location = new System.Drawing.Point(132, 249);
            this.labelXAU.Name = "labelXAU";
            this.labelXAU.Size = new System.Drawing.Size(89, 17);
            this.labelXAU.TabIndex = 8;
            this.labelXAU.Text = "Valoare XAU";
            // 
            // btnParsare
            // 
            this.btnParsare.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParsare.Location = new System.Drawing.Point(126, 330);
            this.btnParsare.Name = "btnParsare";
            this.btnParsare.Size = new System.Drawing.Size(125, 40);
            this.btnParsare.TabIndex = 10;
            this.btnParsare.Text = "PARSARE";
            this.btnParsare.UseVisualStyleBackColor = true;
            this.btnParsare.Click += new System.EventHandler(this.btnParsare_Click);
            // 
            // btnGenerare
            // 
            this.btnGenerare.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerare.Location = new System.Drawing.Point(307, 330);
            this.btnGenerare.Name = "btnGenerare";
            this.btnGenerare.Size = new System.Drawing.Size(126, 40);
            this.btnGenerare.TabIndex = 11;
            this.btnGenerare.Text = "GENERARE";
            this.btnGenerare.UseVisualStyleBackColor = true;
            this.btnGenerare.Click += new System.EventHandler(this.btnGenerare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGenerare);
            this.Controls.Add(this.btnParsare);
            this.Controls.Add(this.tbXAU);
            this.Controls.Add(this.labelXAU);
            this.Controls.Add(this.tbGBP);
            this.Controls.Add(this.labelGBP);
            this.Controls.Add(this.tbUSD);
            this.Controls.Add(this.labelUSD);
            this.Controls.Add(this.tbEUR);
            this.Controls.Add(this.labelEUR);
            this.Controls.Add(this.tbDataCurs);
            this.Controls.Add(this.labelDataCurs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDataCurs;
        private System.Windows.Forms.TextBox tbDataCurs;
        private System.Windows.Forms.TextBox tbEUR;
        private System.Windows.Forms.Label labelEUR;
        private System.Windows.Forms.TextBox tbUSD;
        private System.Windows.Forms.Label labelUSD;
        private System.Windows.Forms.TextBox tbGBP;
        private System.Windows.Forms.Label labelGBP;
        private System.Windows.Forms.TextBox tbXAU;
        private System.Windows.Forms.Label labelXAU;
        private System.Windows.Forms.Button btnParsare;
        private System.Windows.Forms.Button btnGenerare;
    }
}

