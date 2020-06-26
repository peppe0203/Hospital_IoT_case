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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatiëntBeheer));
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            // 
            // SearchName
            // 
            this.SearchName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(176)))));
            resources.ApplyResources(this.SearchName, "SearchName");
            this.SearchName.Name = "SearchName";
            this.SearchName.UseVisualStyleBackColor = false;
            this.SearchName.Click += new System.EventHandler(this.SearchName_Click);
            // 
            // RemovePatient
            // 
            this.RemovePatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(176)))));
            resources.ApplyResources(this.RemovePatient, "RemovePatient");
            this.RemovePatient.Name = "RemovePatient";
            this.RemovePatient.UseVisualStyleBackColor = false;
            this.RemovePatient.Click += new System.EventHandler(this.RemovePatient_Click);
            // 
            // AddPatient
            // 
            this.AddPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(176)))));
            resources.ApplyResources(this.AddPatient, "AddPatient");
            this.AddPatient.Name = "AddPatient";
            this.AddPatient.UseVisualStyleBackColor = false;
            this.AddPatient.Click += new System.EventHandler(this.AddPatient_Click);
            // 
            // PatiëntSearchTBX
            // 
            this.PatiëntSearchTBX.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PatiëntSearchTBX.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.PatiëntSearchTBX, "PatiëntSearchTBX");
            this.PatiëntSearchTBX.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PatiëntSearchTBX.Name = "PatiëntSearchTBX";
            // 
            // DeletePatientTBX
            // 
            this.DeletePatientTBX.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.DeletePatientTBX.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.DeletePatientTBX, "DeletePatientTBX");
            this.DeletePatientTBX.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DeletePatientTBX.Name = "DeletePatientTBX";
            // 
            // PatientNameTBX
            // 
            this.PatientNameTBX.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PatientNameTBX.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.PatientNameTBX, "PatientNameTBX");
            this.PatientNameTBX.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PatientNameTBX.Name = "PatientNameTBX";
            // 
            // RoomIdTBX
            // 
            this.RoomIdTBX.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.RoomIdTBX.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.RoomIdTBX, "RoomIdTBX");
            this.RoomIdTBX.ForeColor = System.Drawing.SystemColors.WindowText;
            this.RoomIdTBX.Name = "RoomIdTBX";
            // 
            // LoadPatiens
            // 
            this.LoadPatiens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(176)))));
            this.LoadPatiens.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.LoadPatiens, "LoadPatiens");
            this.LoadPatiens.Name = "LoadPatiens";
            this.LoadPatiens.UseVisualStyleBackColor = false;
            this.LoadPatiens.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            // 
            // FloorIdTBX
            // 
            this.FloorIdTBX.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.FloorIdTBX.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.FloorIdTBX, "FloorIdTBX");
            this.FloorIdTBX.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FloorIdTBX.Name = "FloorIdTBX";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Name = "label5";
            // 
            // PasswordTBX
            // 
            this.PasswordTBX.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PasswordTBX.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.PasswordTBX, "PasswordTBX");
            this.PasswordTBX.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PasswordTBX.Name = "PasswordTBX";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Name = "label6";
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
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::IoT_Casus.Properties.Resources.Ziekenhuislogo;
            this.pictureBox1.Image = global::IoT_Casus.Properties.Resources.Ziekenhuislogo;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(176)))));
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(176)))));
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.pictureBox2);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown_1);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseMove);
            this.panel4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::IoT_Casus.Properties.Resources.CloseButton1;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            resources.ApplyResources(this.button2, "button2");
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PatiëntBeheer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PatiëntBeheer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
    }
}