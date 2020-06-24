namespace IoT_Casus.Forms
{
    partial class PatiëntBeheer
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SearchName = new System.Windows.Forms.Button();
            this.RemovePatient = new System.Windows.Forms.Button();
            this.VeranderenPatiëntGegevensBtn = new System.Windows.Forms.Button();
            this.PatiëntSearchTBX = new System.Windows.Forms.TextBox();
            this.VeranderPatiëntGegeven4Tbx = new System.Windows.Forms.TextBox();
            this.DeletePatientTBX = new System.Windows.Forms.TextBox();
            this.VeranderPatiëntGegeven2Tbx = new System.Windows.Forms.TextBox();
            this.VeranderPatiëntGegeven3Tbx = new System.Windows.Forms.TextBox();
            this.PatiëntBeheerWelkomLbl = new System.Windows.Forms.Label();
            this.LoadPatiens = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 31);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(800, 153);
            this.dataGridView1.TabIndex = 0;
            // 
            // SearchName
            // 
            this.SearchName.Location = new System.Drawing.Point(334, 268);
            this.SearchName.Margin = new System.Windows.Forms.Padding(4);
            this.SearchName.Name = "SearchName";
            this.SearchName.Size = new System.Drawing.Size(100, 28);
            this.SearchName.TabIndex = 1;
            this.SearchName.Text = "Search";
            this.SearchName.UseVisualStyleBackColor = true;
            this.SearchName.Click += new System.EventHandler(this.SearchName_Click);
            // 
            // RemovePatient
            // 
            this.RemovePatient.Location = new System.Drawing.Point(334, 332);
            this.RemovePatient.Margin = new System.Windows.Forms.Padding(4);
            this.RemovePatient.Name = "RemovePatient";
            this.RemovePatient.Size = new System.Drawing.Size(100, 28);
            this.RemovePatient.TabIndex = 2;
            this.RemovePatient.Text = "Delete";
            this.RemovePatient.UseVisualStyleBackColor = true;
            this.RemovePatient.Click += new System.EventHandler(this.RemovePatient_Click);
            // 
            // VeranderenPatiëntGegevensBtn
            // 
            this.VeranderenPatiëntGegevensBtn.Location = new System.Drawing.Point(716, 527);
            this.VeranderenPatiëntGegevensBtn.Margin = new System.Windows.Forms.Padding(4);
            this.VeranderenPatiëntGegevensBtn.Name = "VeranderenPatiëntGegevensBtn";
            this.VeranderenPatiëntGegevensBtn.Size = new System.Drawing.Size(100, 28);
            this.VeranderenPatiëntGegevensBtn.TabIndex = 3;
            this.VeranderenPatiëntGegevensBtn.Text = "Veranderen";
            this.VeranderenPatiëntGegevensBtn.UseVisualStyleBackColor = true;
            // 
            // PatiëntSearchTBX
            // 
            this.PatiëntSearchTBX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PatiëntSearchTBX.Location = new System.Drawing.Point(118, 271);
            this.PatiëntSearchTBX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PatiëntSearchTBX.Name = "PatiëntSearchTBX";
            this.PatiëntSearchTBX.Size = new System.Drawing.Size(196, 22);
            this.PatiëntSearchTBX.TabIndex = 17;
            // 
            // VeranderPatiëntGegeven4Tbx
            // 
            this.VeranderPatiëntGegeven4Tbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.VeranderPatiëntGegeven4Tbx.Location = new System.Drawing.Point(453, 530);
            this.VeranderPatiëntGegeven4Tbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VeranderPatiëntGegeven4Tbx.Name = "VeranderPatiëntGegeven4Tbx";
            this.VeranderPatiëntGegeven4Tbx.Size = new System.Drawing.Size(255, 22);
            this.VeranderPatiëntGegeven4Tbx.TabIndex = 18;
            // 
            // DeletePatientTBX
            // 
            this.DeletePatientTBX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DeletePatientTBX.Location = new System.Drawing.Point(118, 335);
            this.DeletePatientTBX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeletePatientTBX.Name = "DeletePatientTBX";
            this.DeletePatientTBX.Size = new System.Drawing.Size(196, 22);
            this.DeletePatientTBX.TabIndex = 19;
            // 
            // VeranderPatiëntGegeven2Tbx
            // 
            this.VeranderPatiëntGegeven2Tbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.VeranderPatiëntGegeven2Tbx.Location = new System.Drawing.Point(453, 471);
            this.VeranderPatiëntGegeven2Tbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VeranderPatiëntGegeven2Tbx.Name = "VeranderPatiëntGegeven2Tbx";
            this.VeranderPatiëntGegeven2Tbx.Size = new System.Drawing.Size(255, 22);
            this.VeranderPatiëntGegeven2Tbx.TabIndex = 20;
            // 
            // VeranderPatiëntGegeven3Tbx
            // 
            this.VeranderPatiëntGegeven3Tbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.VeranderPatiëntGegeven3Tbx.Location = new System.Drawing.Point(453, 501);
            this.VeranderPatiëntGegeven3Tbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VeranderPatiëntGegeven3Tbx.Name = "VeranderPatiëntGegeven3Tbx";
            this.VeranderPatiëntGegeven3Tbx.Size = new System.Drawing.Size(255, 22);
            this.VeranderPatiëntGegeven3Tbx.TabIndex = 21;
            // 
            // PatiëntBeheerWelkomLbl
            // 
            this.PatiëntBeheerWelkomLbl.AutoSize = true;
            this.PatiëntBeheerWelkomLbl.Location = new System.Drawing.Point(16, 11);
            this.PatiëntBeheerWelkomLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PatiëntBeheerWelkomLbl.Name = "PatiëntBeheerWelkomLbl";
            this.PatiëntBeheerWelkomLbl.Size = new System.Drawing.Size(312, 17);
            this.PatiëntBeheerWelkomLbl.TabIndex = 22;
            this.PatiëntBeheerWelkomLbl.Text = "Hier kunt u de patiënten in het systeem beheren";
            // 
            // LoadPatiens
            // 
            this.LoadPatiens.Location = new System.Drawing.Point(16, 203);
            this.LoadPatiens.Name = "LoadPatiens";
            this.LoadPatiens.Size = new System.Drawing.Size(137, 29);
            this.LoadPatiens.TabIndex = 23;
            this.LoadPatiens.Text = "Load Patients";
            this.LoadPatiens.UseVisualStyleBackColor = true;
            this.LoadPatiens.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Delete patient";
            // 
            // PatiëntBeheer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 570);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoadPatiens);
            this.Controls.Add(this.PatiëntBeheerWelkomLbl);
            this.Controls.Add(this.VeranderPatiëntGegeven3Tbx);
            this.Controls.Add(this.VeranderPatiëntGegeven2Tbx);
            this.Controls.Add(this.DeletePatientTBX);
            this.Controls.Add(this.VeranderPatiëntGegeven4Tbx);
            this.Controls.Add(this.PatiëntSearchTBX);
            this.Controls.Add(this.VeranderenPatiëntGegevensBtn);
            this.Controls.Add(this.RemovePatient);
            this.Controls.Add(this.SearchName);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PatiëntBeheer";
            this.Text = "PatiëntBeheer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SearchName;
        private System.Windows.Forms.Button RemovePatient;
        private System.Windows.Forms.Button VeranderenPatiëntGegevensBtn;
        private System.Windows.Forms.TextBox PatiëntSearchTBX;
        private System.Windows.Forms.TextBox VeranderPatiëntGegeven4Tbx;
        private System.Windows.Forms.TextBox DeletePatientTBX;
        private System.Windows.Forms.TextBox VeranderPatiëntGegeven2Tbx;
        private System.Windows.Forms.TextBox VeranderPatiëntGegeven3Tbx;
        private System.Windows.Forms.Label PatiëntBeheerWelkomLbl;
        private System.Windows.Forms.Button LoadPatiens;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}