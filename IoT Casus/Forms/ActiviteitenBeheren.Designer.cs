namespace IoT_Casus.Forms
{
    partial class ActiviteitenBeheren
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
            this.ApparaatBeheerWelkomLbl = new System.Windows.Forms.Label();
            this.ApparaatZoekenTbx = new System.Windows.Forms.TextBox();
            this.ApparaatZoeken = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ApparaatToggelenBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ApparaatBeheerWelkomLbl
            // 
            this.ApparaatBeheerWelkomLbl.AutoSize = true;
            this.ApparaatBeheerWelkomLbl.Location = new System.Drawing.Point(12, 11);
            this.ApparaatBeheerWelkomLbl.Name = "ApparaatBeheerWelkomLbl";
            this.ApparaatBeheerWelkomLbl.Size = new System.Drawing.Size(233, 13);
            this.ApparaatBeheerWelkomLbl.TabIndex = 35;
            this.ApparaatBeheerWelkomLbl.Text = "Hier kunt u de patiënten in het systeem beheren";
            // 
            // ApparaatZoekenTbx
            // 
            this.ApparaatZoekenTbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ApparaatZoekenTbx.Location = new System.Drawing.Point(340, 26);
            this.ApparaatZoekenTbx.Margin = new System.Windows.Forms.Padding(2);
            this.ApparaatZoekenTbx.Name = "ApparaatZoekenTbx";
            this.ApparaatZoekenTbx.Size = new System.Drawing.Size(192, 20);
            this.ApparaatZoekenTbx.TabIndex = 34;
            // 
            // ApparaatZoeken
            // 
            this.ApparaatZoeken.Location = new System.Drawing.Point(340, 51);
            this.ApparaatZoeken.Name = "ApparaatZoeken";
            this.ApparaatZoeken.Size = new System.Drawing.Size(75, 23);
            this.ApparaatZoeken.TabIndex = 33;
            this.ApparaatZoeken.Text = "Zoeken";
            this.ApparaatZoeken.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(323, 426);
            this.dataGridView1.TabIndex = 32;
            // 
            // ApparaatToggelenBtn
            // 
            this.ApparaatToggelenBtn.Location = new System.Drawing.Point(340, 108);
            this.ApparaatToggelenBtn.Name = "ApparaatToggelenBtn";
            this.ApparaatToggelenBtn.Size = new System.Drawing.Size(75, 23);
            this.ApparaatToggelenBtn.TabIndex = 36;
            this.ApparaatToggelenBtn.Text = "Aanzetten";
            this.ApparaatToggelenBtn.UseVisualStyleBackColor = true;
            // 
            // ActiviteitenBeheren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 466);
            this.Controls.Add(this.ApparaatToggelenBtn);
            this.Controls.Add(this.ApparaatBeheerWelkomLbl);
            this.Controls.Add(this.ApparaatZoekenTbx);
            this.Controls.Add(this.ApparaatZoeken);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ActiviteitenBeheren";
            this.Text = "ActiviteitenBeheren";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ApparaatBeheerWelkomLbl;
        private System.Windows.Forms.TextBox ApparaatZoekenTbx;
        private System.Windows.Forms.Button ApparaatZoeken;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ApparaatToggelenBtn;
    }
}