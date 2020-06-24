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
            this.LoadPatiens = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FloorIdTBX = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PasswordTBX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 23);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(555, 163);
            this.dataGridView1.TabIndex = 0;
            // 
            // SearchName
            // 
            this.SearchName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(176)))));
            this.SearchName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchName.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchName.Location = new System.Drawing.Point(356, 283);
            this.SearchName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.SearchName.Name = "SearchName";
            this.SearchName.Size = new System.Drawing.Size(99, 29);
            this.SearchName.TabIndex = 1;
            this.SearchName.Text = "Search";
            this.SearchName.UseVisualStyleBackColor = false;
            this.SearchName.Click += new System.EventHandler(this.SearchName_Click);
            // 
            // RemovePatient
            // 
            this.RemovePatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(176)))));
            this.RemovePatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RemovePatient.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemovePatient.Location = new System.Drawing.Point(356, 328);
            this.RemovePatient.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.RemovePatient.Name = "RemovePatient";
            this.RemovePatient.Size = new System.Drawing.Size(99, 31);
            this.RemovePatient.TabIndex = 2;
            this.RemovePatient.Text = "Delete";
            this.RemovePatient.UseVisualStyleBackColor = false;
            this.RemovePatient.Click += new System.EventHandler(this.RemovePatient_Click);
            // 
            // AddPatient
            // 
            this.AddPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(176)))));
            this.AddPatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddPatient.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPatient.Location = new System.Drawing.Point(356, 408);
            this.AddPatient.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.AddPatient.Name = "AddPatient";
            this.AddPatient.Size = new System.Drawing.Size(99, 29);
            this.AddPatient.TabIndex = 3;
            this.AddPatient.Text = "Add patient";
            this.AddPatient.UseVisualStyleBackColor = false;
            this.AddPatient.Click += new System.EventHandler(this.AddPatient_Click);
            // 
            // PatiëntSearchTBX
            // 
            this.PatiëntSearchTBX.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PatiëntSearchTBX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PatiëntSearchTBX.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PatiëntSearchTBX.Location = new System.Drawing.Point(139, 283);
            this.PatiëntSearchTBX.Name = "PatiëntSearchTBX";
            this.PatiëntSearchTBX.Size = new System.Drawing.Size(196, 23);
            this.PatiëntSearchTBX.TabIndex = 17;
            // 
            // DeletePatientTBX
            // 
            this.DeletePatientTBX.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.DeletePatientTBX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DeletePatientTBX.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DeletePatientTBX.Location = new System.Drawing.Point(139, 325);
            this.DeletePatientTBX.Name = "DeletePatientTBX";
            this.DeletePatientTBX.Size = new System.Drawing.Size(196, 23);
            this.DeletePatientTBX.TabIndex = 19;
            // 
            // PatientNameTBX
            // 
            this.PatientNameTBX.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PatientNameTBX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PatientNameTBX.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PatientNameTBX.Location = new System.Drawing.Point(139, 408);
            this.PatientNameTBX.Name = "PatientNameTBX";
            this.PatientNameTBX.Size = new System.Drawing.Size(196, 23);
            this.PatientNameTBX.TabIndex = 20;
            // 
            // RoomIdTBX
            // 
            this.RoomIdTBX.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.RoomIdTBX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RoomIdTBX.ForeColor = System.Drawing.SystemColors.WindowText;
            this.RoomIdTBX.Location = new System.Drawing.Point(139, 452);
            this.RoomIdTBX.Name = "RoomIdTBX";
            this.RoomIdTBX.Size = new System.Drawing.Size(196, 23);
            this.RoomIdTBX.TabIndex = 21;
            // 
            // LoadPatiens
            // 
            this.LoadPatiens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(176)))));
            this.LoadPatiens.FlatAppearance.BorderSize = 0;
            this.LoadPatiens.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoadPatiens.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadPatiens.Location = new System.Drawing.Point(10, 194);
            this.LoadPatiens.Name = "LoadPatiens";
            this.LoadPatiens.Size = new System.Drawing.Size(137, 31);
            this.LoadPatiens.TabIndex = 23;
            this.LoadPatiens.Text = "Load Patients";
            this.LoadPatiens.UseVisualStyleBackColor = false;
            this.LoadPatiens.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "ID patient:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "Name patient:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 455);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 27;
            this.label4.Text = "Room ID:";
            // 
            // FloorIdTBX
            // 
            this.FloorIdTBX.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.FloorIdTBX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FloorIdTBX.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FloorIdTBX.Location = new System.Drawing.Point(139, 500);
            this.FloorIdTBX.Name = "FloorIdTBX";
            this.FloorIdTBX.Size = new System.Drawing.Size(196, 23);
            this.FloorIdTBX.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 503);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 19);
            this.label5.TabIndex = 28;
            this.label5.Text = "Floor ID:";
            // 
            // PasswordTBX
            // 
            this.PasswordTBX.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PasswordTBX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTBX.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PasswordTBX.Location = new System.Drawing.Point(139, 542);
            this.PasswordTBX.Name = "PasswordTBX";
            this.PasswordTBX.Size = new System.Drawing.Size(196, 23);
            this.PasswordTBX.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 545);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 19);
            this.label6.TabIndex = 30;
            this.label6.Text = "Password:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.PasswordTBX);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LoadPatiens);
            this.panel1.Controls.Add(this.RoomIdTBX);
            this.panel1.Controls.Add(this.PatientNameTBX);
            this.panel1.Controls.Add(this.DeletePatientTBX);
            this.panel1.Controls.Add(this.FloorIdTBX);
            this.panel1.Controls.Add(this.PatiëntSearchTBX);
            this.panel1.Controls.Add(this.AddPatient);
            this.panel1.Controls.Add(this.RemovePatient);
            this.panel1.Controls.Add(this.SearchName);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(14, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 580);
            this.panel1.TabIndex = 31;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::IoT_Casus.Properties.Resources.Ziekenhuislogo;
            this.pictureBox1.Image = global::IoT_Casus.Properties.Resources.Ziekenhuislogo;
            this.pictureBox1.Location = new System.Drawing.Point(396, 455);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(176)))));
            this.panel3.Location = new System.Drawing.Point(0, 252);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(335, 13);
            this.panel3.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(176)))));
            this.panel2.Location = new System.Drawing.Point(14, 392);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 13);
            this.panel2.TabIndex = 31;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(-2, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(597, 14);
            this.panel4.TabIndex = 32;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown_1);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseMove);
            this.panel4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseUp);
            // 
            // PatiëntBeheer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(596, 606);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "PatiëntBeheer";
            this.Text = "PatiëntBeheer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button LoadPatiens;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FloorIdTBX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PasswordTBX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
    }
}