namespace WFAUniMenes
{
    partial class FrmAdatlap
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
            this.cbFajtak = new System.Windows.Forms.ComboBox();
            this.cbTulajok = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nud1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.rbKanca = new System.Windows.Forms.RadioButton();
            this.rbCsodor = new System.Windows.Forms.RadioButton();
            this.pbKep = new System.Windows.Forms.PictureBox();
            this.BtnHozaad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKep)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(80, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fajta:";
            // 
            // cbFajtak
            // 
            this.cbFajtak.FormattingEnabled = true;
            this.cbFajtak.Location = new System.Drawing.Point(170, 63);
            this.cbFajtak.Name = "cbFajtak";
            this.cbFajtak.Size = new System.Drawing.Size(168, 21);
            this.cbFajtak.TabIndex = 1;
            this.cbFajtak.SelectedIndexChanged += new System.EventHandler(this.cbFajtak_SelectedIndexChanged);
            // 
            // cbTulajok
            // 
            this.cbTulajok.FormattingEnabled = true;
            this.cbTulajok.Location = new System.Drawing.Point(170, 107);
            this.cbTulajok.Name = "cbTulajok";
            this.cbTulajok.Size = new System.Drawing.Size(168, 21);
            this.cbTulajok.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(42, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tulajdonos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(80, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Súly: ";
            // 
            // nud1
            // 
            this.nud1.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud1.Location = new System.Drawing.Point(202, 148);
            this.nud1.Maximum = new decimal(new int[] {
            550,
            0,
            0,
            0});
            this.nud1.Name = "nud1";
            this.nud1.Size = new System.Drawing.Size(102, 20);
            this.nud1.TabIndex = 2;
            this.nud1.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(80, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nem: ";
            // 
            // rbKanca
            // 
            this.rbKanca.AutoSize = true;
            this.rbKanca.Checked = true;
            this.rbKanca.Location = new System.Drawing.Point(170, 195);
            this.rbKanca.Name = "rbKanca";
            this.rbKanca.Size = new System.Drawing.Size(55, 17);
            this.rbKanca.TabIndex = 3;
            this.rbKanca.TabStop = true;
            this.rbKanca.Text = "kanca";
            this.rbKanca.UseVisualStyleBackColor = true;
            // 
            // rbCsodor
            // 
            this.rbCsodor.AutoSize = true;
            this.rbCsodor.Location = new System.Drawing.Point(281, 194);
            this.rbCsodor.Name = "rbCsodor";
            this.rbCsodor.Size = new System.Drawing.Size(57, 17);
            this.rbCsodor.TabIndex = 3;
            this.rbCsodor.Text = "csődör";
            this.rbCsodor.UseVisualStyleBackColor = true;
            // 
            // pbKep
            // 
            this.pbKep.Location = new System.Drawing.Point(412, 42);
            this.pbKep.Name = "pbKep";
            this.pbKep.Size = new System.Drawing.Size(206, 254);
            this.pbKep.TabIndex = 4;
            this.pbKep.TabStop = false;
            // 
            // BtnHozaad
            // 
            this.BtnHozaad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnHozaad.Location = new System.Drawing.Point(45, 320);
            this.BtnHozaad.Name = "BtnHozaad";
            this.BtnHozaad.Size = new System.Drawing.Size(573, 76);
            this.BtnHozaad.TabIndex = 5;
            this.BtnHozaad.Text = "Új egyed rögzítése az adatbázisba!";
            this.BtnHozaad.UseVisualStyleBackColor = true;
            this.BtnHozaad.Click += new System.EventHandler(this.BtnHozaad_Click);
            // 
            // FrmAdatlap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 424);
            this.Controls.Add(this.BtnHozaad);
            this.Controls.Add(this.pbKep);
            this.Controls.Add(this.rbCsodor);
            this.Controls.Add(this.rbKanca);
            this.Controls.Add(this.nud1);
            this.Controls.Add(this.cbTulajok);
            this.Controls.Add(this.cbFajtak);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAdatlap";
            this.Text = "FrmAdatlap";
            this.Load += new System.EventHandler(this.FrmAdatlap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFajtak;
        private System.Windows.Forms.ComboBox cbTulajok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbKanca;
        private System.Windows.Forms.RadioButton rbCsodor;
        private System.Windows.Forms.PictureBox pbKep;
        private System.Windows.Forms.Button BtnHozaad;
    }
}