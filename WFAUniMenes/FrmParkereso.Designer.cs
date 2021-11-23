namespace WFAUniMenes
{
    partial class FrmParkereso
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbSuly = new System.Windows.Forms.TextBox();
            this.tbFajta = new System.Windows.Forms.TextBox();
            this.tbVaros = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvParok = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fajta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tulajdonos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Súly = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParok)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbSuly);
            this.groupBox1.Controls.Add(this.tbFajta);
            this.groupBox1.Controls.Add(this.tbVaros);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiválasztott unikornis tulajdonságai";
            // 
            // tbSuly
            // 
            this.tbSuly.Enabled = false;
            this.tbSuly.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbSuly.Location = new System.Drawing.Point(428, 37);
            this.tbSuly.Name = "tbSuly";
            this.tbSuly.Size = new System.Drawing.Size(136, 22);
            this.tbSuly.TabIndex = 1;
            // 
            // tbFajta
            // 
            this.tbFajta.Enabled = false;
            this.tbFajta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbFajta.Location = new System.Drawing.Point(248, 37);
            this.tbFajta.Name = "tbFajta";
            this.tbFajta.Size = new System.Drawing.Size(136, 22);
            this.tbFajta.TabIndex = 1;
            // 
            // tbVaros
            // 
            this.tbVaros.Enabled = false;
            this.tbVaros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbVaros.Location = new System.Drawing.Point(67, 38);
            this.tbVaros.Name = "tbVaros";
            this.tbVaros.Size = new System.Drawing.Size(136, 22);
            this.tbVaros.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(390, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Súly:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(209, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fajta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(15, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Város:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Lehetséges párok:";
            // 
            // dgvParok
            // 
            this.dgvParok.AllowUserToAddRows = false;
            this.dgvParok.AllowUserToDeleteRows = false;
            this.dgvParok.AllowUserToResizeColumns = false;
            this.dgvParok.AllowUserToResizeRows = false;
            this.dgvParok.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvParok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Fajta,
            this.Tulajdonos,
            this.Súly});
            this.dgvParok.Location = new System.Drawing.Point(15, 168);
            this.dgvParok.Name = "dgvParok";
            this.dgvParok.Size = new System.Drawing.Size(585, 213);
            this.dgvParok.TabIndex = 2;
            // 
            // id
            // 
            this.id.FillWeight = 40F;
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // Fajta
            // 
            this.Fajta.HeaderText = "Fajta";
            this.Fajta.Name = "Fajta";
            // 
            // Tulajdonos
            // 
            this.Tulajdonos.HeaderText = "Tulajdonos";
            this.Tulajdonos.Name = "Tulajdonos";
            // 
            // Súly
            // 
            this.Súly.FillWeight = 60F;
            this.Súly.HeaderText = "Súly";
            this.Súly.Name = "Súly";
            // 
            // FrmParkereso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 393);
            this.Controls.Add(this.dgvParok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmParkereso";
            this.Text = "FrmParkereso";
            this.Load += new System.EventHandler(this.FrmParkereso_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbSuly;
        private System.Windows.Forms.TextBox tbFajta;
        private System.Windows.Forms.TextBox tbVaros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvParok;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fajta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tulajdonos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Súly;
    }
}