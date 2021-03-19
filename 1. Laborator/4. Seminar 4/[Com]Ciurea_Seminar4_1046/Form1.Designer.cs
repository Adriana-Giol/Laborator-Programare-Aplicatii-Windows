namespace _Com_Ciurea_Seminar4_1046
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
            this.labelCod = new System.Windows.Forms.Label();
            this.labelSex = new System.Windows.Forms.Label();
            this.labelVarsta = new System.Windows.Forms.Label();
            this.labelNume = new System.Windows.Forms.Label();
            this.tbCod = new System.Windows.Forms.TextBox();
            this.tbVarsta = new System.Windows.Forms.TextBox();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.labelNote = new System.Windows.Forms.Label();
            this.btnCreareStudent = new System.Windows.Forms.Button();
            this.tbAfisareStudent = new System.Windows.Forms.TextBox();
            this.btnAfisare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCod
            // 
            this.labelCod.AutoSize = true;
            this.labelCod.Location = new System.Drawing.Point(49, 28);
            this.labelCod.Name = "labelCod";
            this.labelCod.Size = new System.Drawing.Size(37, 17);
            this.labelCod.TabIndex = 0;
            this.labelCod.Text = "Cod:";
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Location = new System.Drawing.Point(49, 86);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(35, 17);
            this.labelSex.TabIndex = 1;
            this.labelSex.Text = "Sex:";
            // 
            // labelVarsta
            // 
            this.labelVarsta.AutoSize = true;
            this.labelVarsta.Location = new System.Drawing.Point(49, 151);
            this.labelVarsta.Name = "labelVarsta";
            this.labelVarsta.Size = new System.Drawing.Size(53, 17);
            this.labelVarsta.TabIndex = 2;
            this.labelVarsta.Text = "Varsta:";
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Location = new System.Drawing.Point(49, 221);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(49, 17);
            this.labelNume.TabIndex = 3;
            this.labelNume.Text = "Nume:";
            // 
            // tbCod
            // 
            this.tbCod.Location = new System.Drawing.Point(157, 28);
            this.tbCod.Name = "tbCod";
            this.tbCod.Size = new System.Drawing.Size(121, 22);
            this.tbCod.TabIndex = 4;
            // 
            // tbVarsta
            // 
            this.tbVarsta.Location = new System.Drawing.Point(157, 151);
            this.tbVarsta.Name = "tbVarsta";
            this.tbVarsta.Size = new System.Drawing.Size(121, 22);
            this.tbVarsta.TabIndex = 5;
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(157, 221);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(121, 22);
            this.tbNume.TabIndex = 6;
            // 
            // cbSex
            // 
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbSex.Location = new System.Drawing.Point(157, 86);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(121, 24);
            this.cbSex.TabIndex = 7;
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(157, 279);
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(121, 22);
            this.tbNote.TabIndex = 8;
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Location = new System.Drawing.Point(49, 279);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(42, 17);
            this.labelNote.TabIndex = 9;
            this.labelNote.Text = "Note:";
            // 
            // btnCreareStudent
            // 
            this.btnCreareStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCreareStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreareStudent.Location = new System.Drawing.Point(52, 344);
            this.btnCreareStudent.Name = "btnCreareStudent";
            this.btnCreareStudent.Size = new System.Drawing.Size(226, 43);
            this.btnCreareStudent.TabIndex = 10;
            this.btnCreareStudent.Text = "Creare Student";
            this.btnCreareStudent.UseVisualStyleBackColor = false;
            this.btnCreareStudent.Click += new System.EventHandler(this.btnCreareStudent_Click);
            // 
            // tbAfisareStudent
            // 
            this.tbAfisareStudent.Location = new System.Drawing.Point(356, 64);
            this.tbAfisareStudent.Multiline = true;
            this.tbAfisareStudent.Name = "tbAfisareStudent";
            this.tbAfisareStudent.Size = new System.Drawing.Size(562, 174);
            this.tbAfisareStudent.TabIndex = 11;
            // 
            // btnAfisare
            // 
            this.btnAfisare.Location = new System.Drawing.Point(597, 311);
            this.btnAfisare.Name = "btnAfisare";
            this.btnAfisare.Size = new System.Drawing.Size(127, 52);
            this.btnAfisare.TabIndex = 12;
            this.btnAfisare.Text = "Afisare";
            this.btnAfisare.UseVisualStyleBackColor = true;
            this.btnAfisare.Click += new System.EventHandler(this.btnAfisare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 513);
            this.Controls.Add(this.btnAfisare);
            this.Controls.Add(this.tbAfisareStudent);
            this.Controls.Add(this.btnCreareStudent);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.tbVarsta);
            this.Controls.Add(this.tbCod);
            this.Controls.Add(this.labelNume);
            this.Controls.Add(this.labelVarsta);
            this.Controls.Add(this.labelSex);
            this.Controls.Add(this.labelCod);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCod;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.Label labelVarsta;
        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.TextBox tbCod;
        private System.Windows.Forms.TextBox tbVarsta;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.Button btnCreareStudent;
        private System.Windows.Forms.TextBox tbAfisareStudent;
        private System.Windows.Forms.Button btnAfisare;
    }
}