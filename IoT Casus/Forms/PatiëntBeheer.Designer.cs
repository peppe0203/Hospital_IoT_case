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
            this.AddPatient = new System.Windows.Forms.Button();
            this.PatiëntSearchTBX = new System.Windows.Forms.TextBox();
            this.DeletePatientTBX = new System.Windows.Forms.TextBox();
            this.PatientNameTBX = new System.Windows.Forms.TextBox();
            this.RoomIdTBX = new System.Windows.Forms.TextBox();
            this.PatiëntBeheerWelkomLbl = new System.Windows.Forms.Label();
            this.LoadPatiens = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FloorIdTBX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PasswordTBX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
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
            this.RemovePatient.Location = new System.Drawing.Point(334, 310);
            this.RemovePatient.Margin = new System.Windows.Forms.Padding(4);
            this.RemovePatient.Name = "RemovePatient";
            this.RemovePatient.Size = new System.Drawing.Size(100, 28);
            this.RemovePatient.TabIndex = 2;
            this.RemovePatient.Text = "Delete";
            this.RemovePatient.UseVisualStyleBackColor = true;
            this.RemovePatient.Click += new System.EventHandler(this.RemovePatient_Click);
            // 
            // AddPatient
            // 
            this.AddPatient.Location = new System.Drawing.Point(334, 470);
            this.AddPatient.Margin = new System.Windows.Forms.Padding(4);
            this.AddPatient.Name = "AddPatient";
            this.AddPatient.Size = new System.Drawing.Size(100, 28);
            this.AddPatient.TabIndex = 3;
            this.AddPatient.Text = "Add patient";
            this.AddPatient.UseVisualStyleBackColor = true;
            this.AddPatient.Click += new System.EventHandler(this.AddPatient_Click);
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
            // DeletePatientTBX
            // 
            this.DeletePatientTBX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DeletePatientTBX.Location = new System.Drawing.Point(118, 313);
            this.DeletePatientTBX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeletePatientTBX.Name = "DeletePatientTBX";
            this.DeletePatientTBX.Size = new System.Drawing.Size(196, 22);
            this.DeletePatientTBX.TabIndex = 19;
            // 
            // PatientNameTBX
            // 
            this.PatientNameTBX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PatientNameTBX.Location = new System.Drawing.Point(118, 408);
            this.PatientNameTBX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PatientNameTBX.Name = "PatientNameTBX";
            this.PatientNameTBX.Size = new System.Drawing.Size(196, 22);
            this.PatientNameTBX.TabIndex = 20;
            // 
            // RoomIdTBX
            // 
            this.RoomIdTBX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RoomIdTBX.Location = new System.Drawing.Point(118, 450);
            this.RoomIdTBX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RoomIdTBX.Name = "RoomIdTBX";
            this.RoomIdTBX.Size = new System.Drawing.Size(196, 22);
            this.RoomIdTBX.TabIndex = 21;
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
            this.label1.Location = new System.Drawing.Point(16, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "ID patient:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Name patient:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 455);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Room ID:";
            // 
            // FloorIdTBX
            // 
            this.FloorIdTBX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FloorIdTBX.Location = new System.Drawing.Point(118, 494);
            this.FloorIdTBX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FloorIdTBX.Name = "FloorIdTBX";
            this.FloorIdTBX.Size = new System.Drawing.Size(196, 22);
            this.FloorIdTBX.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 497);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Floor ID:";
            // 
            // PasswordTBX
            // 
            this.PasswordTBX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTBX.Location = new System.Drawing.Point(118, 533);
            this.PasswordTBX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordTBX.Name = "PasswordTBX";
            this.PasswordTBX.Size = new System.Drawing.Size(196, 22);
            this.PasswordTBX.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 538);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "Password:";
            // 
            // PatiëntBeheer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 570);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PasswordTBX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoadPatiens);
            this.Controls.Add(this.PatiëntBeheerWelkomLbl);
            this.Controls.Add(this.RoomIdTBX);
            this.Controls.Add(this.PatientNameTBX);
            this.Controls.Add(this.DeletePatientTBX);
            this.Controls.Add(this.FloorIdTBX);
            this.Controls.Add(this.PatiëntSearchTBX);
            this.Controls.Add(this.AddPatient);
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
        private System.Windows.Forms.Button AddPatient;
        private System.Windows.Forms.TextBox PatiëntSearchTBX;
        private System.Windows.Forms.TextBox DeletePatientTBX;
        private System.Windows.Forms.TextBox PatientNameTBX;
        private System.Windows.Forms.TextBox RoomIdTBX;
        private System.Windows.Forms.Label PatiëntBeheerWelkomLbl;
        private System.Windows.Forms.Button LoadPatiens;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FloorIdTBX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PasswordTBX;
        private System.Windows.Forms.Label label6;
    }
}