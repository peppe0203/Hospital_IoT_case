namespace IoT_Casus.Forms
{
    partial class PatientDevice
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
            this.components = new System.ComponentModel.Container();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LoadDevicesPatient = new System.Windows.Forms.Button();
            this.SwitchStatusDevicePatient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.RefreshDataGrid = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxName
            // 
            this.TextBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.TextBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextBoxName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxName.ForeColor = System.Drawing.Color.White;
            this.TextBoxName.Location = new System.Drawing.Point(324, 214);
            this.TextBoxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(118, 15);
            this.TextBoxName.TabIndex = 26;
            this.TextBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(358, 104);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // LoadDevicesPatient
            // 
            this.LoadDevicesPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(176)))));
            this.LoadDevicesPatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoadDevicesPatient.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadDevicesPatient.ForeColor = System.Drawing.Color.Black;
            this.LoadDevicesPatient.Location = new System.Drawing.Point(2, 130);
            this.LoadDevicesPatient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoadDevicesPatient.Name = "LoadDevicesPatient";
            this.LoadDevicesPatient.Size = new System.Drawing.Size(112, 26);
            this.LoadDevicesPatient.TabIndex = 33;
            this.LoadDevicesPatient.Text = "Show all";
            this.LoadDevicesPatient.UseVisualStyleBackColor = false;
            this.LoadDevicesPatient.Click += new System.EventHandler(this.LoadDevicesPatient_Click);
            // 
            // SwitchStatusDevicePatient
            // 
            this.SwitchStatusDevicePatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(176)))));
            this.SwitchStatusDevicePatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SwitchStatusDevicePatient.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwitchStatusDevicePatient.ForeColor = System.Drawing.Color.Black;
            this.SwitchStatusDevicePatient.Location = new System.Drawing.Point(146, 130);
            this.SwitchStatusDevicePatient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SwitchStatusDevicePatient.Name = "SwitchStatusDevicePatient";
            this.SwitchStatusDevicePatient.Size = new System.Drawing.Size(112, 26);
            this.SwitchStatusDevicePatient.TabIndex = 34;
            this.SwitchStatusDevicePatient.Text = "Switch status";
            this.SwitchStatusDevicePatient.UseVisualStyleBackColor = false;
            this.SwitchStatusDevicePatient.Click += new System.EventHandler(this.SwitchStatusDevicePatient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(350, 188);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 14);
            this.label1.TabIndex = 35;
            this.label1.Text = "Welcome back:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.SwitchStatusDevicePatient);
            this.panel1.Controls.Add(this.LoadDevicesPatient);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TextBoxName);
            this.panel1.Location = new System.Drawing.Point(12, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 245);
            this.panel1.TabIndex = 36;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(0, -3);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(470, 20);
            this.panel2.TabIndex = 37;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(2, -2);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 24);
            this.button3.TabIndex = 38;
            this.button3.Text = "<---- Log out";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::IoT_Casus.Properties.Resources.CloseButton1;
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(436, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 18);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // RefreshDataGrid
            // 
            this.RefreshDataGrid.Interval = 5000;
            this.RefreshDataGrid.Tick += new System.EventHandler(this.RefreshDataGrid_Tick);
            // 
            // PatientDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(471, 273);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(85, 80);
            this.Name = "PatientDevice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Apparaatbeheer";
            this.Load += new System.EventHandler(this.Apparaatbeheer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button LoadDevicesPatient;
        private System.Windows.Forms.Button SwitchStatusDevicePatient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer RefreshDataGrid;
    }
}