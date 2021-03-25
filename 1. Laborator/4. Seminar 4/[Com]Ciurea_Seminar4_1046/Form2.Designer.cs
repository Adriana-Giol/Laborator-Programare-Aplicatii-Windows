namespace _Com_Ciurea_Seminar4_1046
{
    partial class Form2
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
            this.tbAfisareStudent2 = new System.Windows.Forms.TextBox();
            this.btnAfisare2 = new System.Windows.Forms.Button();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnRestaurare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbAfisareStudent2
            // 
            this.tbAfisareStudent2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbAfisareStudent2.Location = new System.Drawing.Point(0, 0);
            this.tbAfisareStudent2.Multiline = true;
            this.tbAfisareStudent2.Name = "tbAfisareStudent2";
            this.tbAfisareStudent2.Size = new System.Drawing.Size(800, 178);
            this.tbAfisareStudent2.TabIndex = 0;
            // 
            // btnAfisare2
            // 
            this.btnAfisare2.Location = new System.Drawing.Point(114, 277);
            this.btnAfisare2.Name = "btnAfisare2";
            this.btnAfisare2.Size = new System.Drawing.Size(121, 51);
            this.btnAfisare2.TabIndex = 1;
            this.btnAfisare2.Text = "Afisare";
            this.btnAfisare2.UseVisualStyleBackColor = true;
            this.btnAfisare2.Click += new System.EventHandler(this.btnAfisare2_Click);
            // 
            // btnSalvare
            // 
            this.btnSalvare.Location = new System.Drawing.Point(329, 277);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(114, 51);
            this.btnSalvare.TabIndex = 2;
            this.btnSalvare.Text = "Salvare in Fisier";
            this.btnSalvare.UseVisualStyleBackColor = true;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // btnRestaurare
            // 
            this.btnRestaurare.Location = new System.Drawing.Point(540, 277);
            this.btnRestaurare.Name = "btnRestaurare";
            this.btnRestaurare.Size = new System.Drawing.Size(111, 51);
            this.btnRestaurare.TabIndex = 3;
            this.btnRestaurare.Text = "Restaurare din Fisier";
            this.btnRestaurare.UseVisualStyleBackColor = true;
            this.btnRestaurare.Click += new System.EventHandler(this.btnRestaurare_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRestaurare);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.btnAfisare2);
            this.Controls.Add(this.tbAfisareStudent2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAfisareStudent2;
        private System.Windows.Forms.Button btnAfisare2;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnRestaurare;
    }
}