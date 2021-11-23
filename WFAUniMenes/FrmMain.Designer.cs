namespace WFAUniMenes
{
    partial class Unikornis
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tenyésztőkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.párkeresőToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BejelentesTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.mainDGV = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fajta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tulajdonos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Város = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Súly = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tenyésztőkToolStripMenuItem,
            this.párkeresőToolStripMenuItem,
            this.BejelentesTSMI});
            this.menuStrip1.Location = new System.Drawing.Point(13, 13);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(226, 73);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tenyésztőkToolStripMenuItem
            // 
            this.tenyésztőkToolStripMenuItem.Image = global::WFAUniMenes.Properties.Resources.wizard;
            this.tenyésztőkToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tenyésztőkToolStripMenuItem.Name = "tenyésztőkToolStripMenuItem";
            this.tenyésztőkToolStripMenuItem.Size = new System.Drawing.Size(76, 69);
            this.tenyésztőkToolStripMenuItem.Text = "Tenyésztők";
            this.tenyésztőkToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // párkeresőToolStripMenuItem
            // 
            this.párkeresőToolStripMenuItem.Image = global::WFAUniMenes.Properties.Resources.love;
            this.párkeresőToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.párkeresőToolStripMenuItem.Name = "párkeresőToolStripMenuItem";
            this.párkeresőToolStripMenuItem.Size = new System.Drawing.Size(70, 69);
            this.párkeresőToolStripMenuItem.Text = "Párkereső";
            this.párkeresőToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // BejelentesTSMI
            // 
            this.BejelentesTSMI.Image = global::WFAUniMenes.Properties.Resources.unicorn;
            this.BejelentesTSMI.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BejelentesTSMI.Name = "BejelentesTSMI";
            this.BejelentesTSMI.Size = new System.Drawing.Size(72, 69);
            this.BejelentesTSMI.Text = "Bejelentés";
            this.BejelentesTSMI.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BejelentesTSMI.Click += new System.EventHandler(this.BejelentesTSMI_Click);
            // 
            // mainDGV
            // 
            this.mainDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Fajta,
            this.Tulajdonos,
            this.Város,
            this.Súly,
            this.Nem});
            this.mainDGV.Location = new System.Drawing.Point(12, 89);
            this.mainDGV.Name = "mainDGV";
            this.mainDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainDGV.Size = new System.Drawing.Size(750, 402);
            this.mainDGV.TabIndex = 1;
            this.mainDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mainDGV_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.FillWeight = 40F;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
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
            // Város
            // 
            this.Város.HeaderText = "Város";
            this.Város.Name = "Város";
            // 
            // Súly
            // 
            this.Súly.FillWeight = 50F;
            this.Súly.HeaderText = "Súly";
            this.Súly.Name = "Súly";
            // 
            // Nem
            // 
            this.Nem.FillWeight = 50F;
            this.Nem.HeaderText = "Nem";
            this.Nem.Name = "Nem";
            // 
            // Unikornis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 503);
            this.Controls.Add(this.mainDGV);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Unikornis";
            this.Text = "Unikornis Ménes Manager 2021";
            this.Load += new System.EventHandler(this.Unikornis_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tenyésztőkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem párkeresőToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BejelentesTSMI;
        private System.Windows.Forms.DataGridView mainDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fajta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tulajdonos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Város;
        private System.Windows.Forms.DataGridViewTextBoxColumn Súly;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nem;
    }
}

