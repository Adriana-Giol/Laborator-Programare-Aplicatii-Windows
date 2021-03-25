namespace _Com_Ciurea_Seminar5_1046
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
            this.tbSumaCredit = new System.Windows.Forms.TextBox();
            this.labelSumaCredit = new System.Windows.Forms.Label();
            this.labelVenit = new System.Windows.Forms.Label();
            this.tbVenit = new System.Windows.Forms.TextBox();
            this.labelPerioada = new System.Windows.Forms.Label();
            this.tbPerioada = new System.Windows.Forms.TextBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.checkBoxAngajat = new System.Windows.Forms.CheckBox();
            this.rbCasatorit = new System.Windows.Forms.RadioButton();
            this.rbNecasatorit = new System.Windows.Forms.RadioButton();
            this.gbStareCivila = new System.Windows.Forms.GroupBox();
            this.tbRataCredit = new System.Windows.Forms.TextBox();
            this.labelRataCredit = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.setariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procentDobandaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradIndatorareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbStareCivila.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSumaCredit
            // 
            this.tbSumaCredit.Location = new System.Drawing.Point(209, 87);
            this.tbSumaCredit.Name = "tbSumaCredit";
            this.tbSumaCredit.Size = new System.Drawing.Size(100, 22);
            this.tbSumaCredit.TabIndex = 0;
            // 
            // labelSumaCredit
            // 
            this.labelSumaCredit.AutoSize = true;
            this.labelSumaCredit.Location = new System.Drawing.Point(77, 87);
            this.labelSumaCredit.Name = "labelSumaCredit";
            this.labelSumaCredit.Size = new System.Drawing.Size(85, 17);
            this.labelSumaCredit.TabIndex = 1;
            this.labelSumaCredit.Text = "Suma Credit";
            // 
            // labelVenit
            // 
            this.labelVenit.AutoSize = true;
            this.labelVenit.Location = new System.Drawing.Point(77, 140);
            this.labelVenit.Name = "labelVenit";
            this.labelVenit.Size = new System.Drawing.Size(94, 17);
            this.labelVenit.TabIndex = 3;
            this.labelVenit.Text = "Venit Aplicant";
            // 
            // tbVenit
            // 
            this.tbVenit.Location = new System.Drawing.Point(209, 140);
            this.tbVenit.Name = "tbVenit";
            this.tbVenit.Size = new System.Drawing.Size(100, 22);
            this.tbVenit.TabIndex = 2;
            // 
            // labelPerioada
            // 
            this.labelPerioada.AutoSize = true;
            this.labelPerioada.Location = new System.Drawing.Point(77, 238);
            this.labelPerioada.Name = "labelPerioada";
            this.labelPerioada.Size = new System.Drawing.Size(106, 17);
            this.labelPerioada.TabIndex = 5;
            this.labelPerioada.Text = "Perioada Credit";
            // 
            // tbPerioada
            // 
            this.tbPerioada.Location = new System.Drawing.Point(237, 210);
            this.tbPerioada.Name = "tbPerioada";
            this.tbPerioada.Size = new System.Drawing.Size(72, 22);
            this.tbPerioada.TabIndex = 4;
            this.tbPerioada.TextChanged += new System.EventHandler(this.tbPerioada_TextChanged);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.LargeChange = 1;
            this.vScrollBar1.Location = new System.Drawing.Point(209, 200);
            this.vScrollBar1.Maximum = 30;
            this.vScrollBar1.Minimum = 1;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 100);
            this.vScrollBar1.TabIndex = 6;
            this.vScrollBar1.Value = 1;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // checkBoxAngajat
            // 
            this.checkBoxAngajat.AutoSize = true;
            this.checkBoxAngajat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAngajat.ForeColor = System.Drawing.Color.Red;
            this.checkBoxAngajat.Location = new System.Drawing.Point(80, 329);
            this.checkBoxAngajat.Name = "checkBoxAngajat";
            this.checkBoxAngajat.Size = new System.Drawing.Size(135, 21);
            this.checkBoxAngajat.TabIndex = 7;
            this.checkBoxAngajat.Text = "Angajat Banca";
            this.checkBoxAngajat.UseVisualStyleBackColor = true;
            // 
            // rbCasatorit
            // 
            this.rbCasatorit.AutoSize = true;
            this.rbCasatorit.Checked = true;
            this.rbCasatorit.Location = new System.Drawing.Point(19, 33);
            this.rbCasatorit.Name = "rbCasatorit";
            this.rbCasatorit.Size = new System.Drawing.Size(85, 21);
            this.rbCasatorit.TabIndex = 8;
            this.rbCasatorit.TabStop = true;
            this.rbCasatorit.Text = "Casatorit";
            this.rbCasatorit.UseVisualStyleBackColor = true;
            // 
            // rbNecasatorit
            // 
            this.rbNecasatorit.AutoSize = true;
            this.rbNecasatorit.Location = new System.Drawing.Point(19, 60);
            this.rbNecasatorit.Name = "rbNecasatorit";
            this.rbNecasatorit.Size = new System.Drawing.Size(101, 21);
            this.rbNecasatorit.TabIndex = 9;
            this.rbNecasatorit.TabStop = true;
            this.rbNecasatorit.Text = "Necasatorit";
            this.rbNecasatorit.UseVisualStyleBackColor = true;
            // 
            // gbStareCivila
            // 
            this.gbStareCivila.Controls.Add(this.rbCasatorit);
            this.gbStareCivila.Controls.Add(this.rbNecasatorit);
            this.gbStareCivila.Location = new System.Drawing.Point(80, 366);
            this.gbStareCivila.Name = "gbStareCivila";
            this.gbStareCivila.Size = new System.Drawing.Size(200, 100);
            this.gbStareCivila.TabIndex = 10;
            this.gbStareCivila.TabStop = false;
            this.gbStareCivila.Text = "Stare Civila";
            // 
            // tbRataCredit
            // 
            this.tbRataCredit.Location = new System.Drawing.Point(581, 79);
            this.tbRataCredit.Name = "tbRataCredit";
            this.tbRataCredit.ReadOnly = true;
            this.tbRataCredit.Size = new System.Drawing.Size(100, 22);
            this.tbRataCredit.TabIndex = 11;
            // 
            // labelRataCredit
            // 
            this.labelRataCredit.AutoSize = true;
            this.labelRataCredit.Location = new System.Drawing.Point(466, 82);
            this.labelRataCredit.Name = "labelRataCredit";
            this.labelRataCredit.Size = new System.Drawing.Size(79, 17);
            this.labelRataCredit.TabIndex = 12;
            this.labelRataCredit.Text = "Rata Credit";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setariToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(791, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // setariToolStripMenuItem
            // 
            this.setariToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.procentDobandaToolStripMenuItem,
            this.gradIndatorareToolStripMenuItem});
            this.setariToolStripMenuItem.Name = "setariToolStripMenuItem";
            this.setariToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.setariToolStripMenuItem.Text = "Setari";
            // 
            // procentDobandaToolStripMenuItem
            // 
            this.procentDobandaToolStripMenuItem.Name = "procentDobandaToolStripMenuItem";
            this.procentDobandaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.procentDobandaToolStripMenuItem.Text = "Procent Dobanda";
            this.procentDobandaToolStripMenuItem.Click += new System.EventHandler(this.procentDobandaToolStripMenuItem_Click);
            // 
            // gradIndatorareToolStripMenuItem
            // 
            this.gradIndatorareToolStripMenuItem.Name = "gradIndatorareToolStripMenuItem";
            this.gradIndatorareToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.gradIndatorareToolStripMenuItem.Text = "Grad Indatorare";
            this.gradIndatorareToolStripMenuItem.Click += new System.EventHandler(this.gradIndatorareToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(791, 478);
            this.Controls.Add(this.labelRataCredit);
            this.Controls.Add(this.tbRataCredit);
            this.Controls.Add(this.gbStareCivila);
            this.Controls.Add(this.checkBoxAngajat);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.labelPerioada);
            this.Controls.Add(this.tbPerioada);
            this.Controls.Add(this.labelVenit);
            this.Controls.Add(this.tbVenit);
            this.Controls.Add(this.labelSumaCredit);
            this.Controls.Add(this.tbSumaCredit);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.gbStareCivila.ResumeLayout(false);
            this.gbStareCivila.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSumaCredit;
        private System.Windows.Forms.Label labelSumaCredit;
        private System.Windows.Forms.Label labelVenit;
        private System.Windows.Forms.TextBox tbVenit;
        private System.Windows.Forms.Label labelPerioada;
        private System.Windows.Forms.TextBox tbPerioada;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.CheckBox checkBoxAngajat;
        private System.Windows.Forms.RadioButton rbCasatorit;
        private System.Windows.Forms.RadioButton rbNecasatorit;
        private System.Windows.Forms.GroupBox gbStareCivila;
        private System.Windows.Forms.TextBox tbRataCredit;
        private System.Windows.Forms.Label labelRataCredit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procentDobandaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradIndatorareToolStripMenuItem;
    }
}