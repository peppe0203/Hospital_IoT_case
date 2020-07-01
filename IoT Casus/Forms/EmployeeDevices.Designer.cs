namespace IoT_Casus.Forms
{
    partial class EmployeeDevices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDevices));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.SearchByRoomTBX = new System.Windows.Forms.TextBox();
            this.SearchByRoom = new System.Windows.Forms.Button();
            this.DropDownMenuTypes = new System.Windows.Forms.ComboBox();
            this.SwitchStatusButton = new System.Windows.Forms.Button();
            this.DeleteDeviceButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RefreshDataGrid = new System.Windows.Forms.Timer(this.components);
            this.RefreshDataGridSearch = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 22);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(420, 115);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(176)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(344, 132);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "Show all";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchByRoomTBX
            // 
            this.SearchByRoomTBX.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.SearchByRoomTBX.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.SearchByRoomTBX.Location = new System.Drawing.Point(111, 180);
            this.SearchByRoomTBX.Margin = new System.Windows.Forms.Padding(2);
            this.SearchByRoomTBX.Name = "SearchByRoomTBX";
            this.SearchByRoomTBX.Size = new System.Drawing.Size(96, 24);
            this.SearchByRoomTBX.TabIndex = 2;
            // 
            // SearchByRoom
            // 
            this.SearchByRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(176)))));
            this.SearchByRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchByRoom.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByRoom.Location = new System.Drawing.Point(218, 144);
            this.SearchByRoom.Margin = new System.Windows.Forms.Padding(2);
            this.SearchByRoom.Name = "SearchByRoom";
            this.SearchByRoom.Size = new System.Drawing.Size(68, 42);
            this.SearchByRoom.TabIndex = 3;
            this.SearchByRoom.Text = "Search";
            this.SearchByRoom.UseVisualStyleBackColor = false;
            this.SearchByRoom.Click += new System.EventHandler(this.SearchByRoom_Click);
            // 
            // DropDownMenuTypes
            // 
            this.DropDownMenuTypes.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.DropDownMenuTypes.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.DropDownMenuTypes.FormattingEnabled = true;
            this.DropDownMenuTypes.Items.AddRange(new object[] {
            "lamp",
            "motion",
            "rolluik",
            "deurslot",
            " "});
            this.DropDownMenuTypes.Location = new System.Drawing.Point(111, 137);
            this.DropDownMenuTypes.Margin = new System.Windows.Forms.Padding(2);
            this.DropDownMenuTypes.Name = "DropDownMenuTypes";
            this.DropDownMenuTypes.Size = new System.Drawing.Size(96, 27);
            this.DropDownMenuTypes.TabIndex = 4;
            // 
            // SwitchStatusButton
            // 
            this.SwitchStatusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(176)))));
            this.SwitchStatusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SwitchStatusButton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwitchStatusButton.Location = new System.Drawing.Point(344, 276);
            this.SwitchStatusButton.Margin = new System.Windows.Forms.Padding(2);
            this.SwitchStatusButton.Name = "SwitchStatusButton";
            this.SwitchStatusButton.Size = new System.Drawing.Size(77, 52);
            this.SwitchStatusButton.TabIndex = 5;
            this.SwitchStatusButton.Text = "Switch Status";
            this.SwitchStatusButton.UseVisualStyleBackColor = false;
            this.SwitchStatusButton.Click += new System.EventHandler(this.SwitchStatusButton_Click);
            // 
            // DeleteDeviceButton
            // 
            this.DeleteDeviceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(176)))));
            this.DeleteDeviceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteDeviceButton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteDeviceButton.Location = new System.Drawing.Point(236, 276);
            this.DeleteDeviceButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteDeviceButton.Name = "DeleteDeviceButton";
            this.DeleteDeviceButton.Size = new System.Drawing.Size(77, 52);
            this.DeleteDeviceButton.TabIndex = 6;
            this.DeleteDeviceButton.Text = "Delete device";
            this.DeleteDeviceButton.UseVisualStyleBackColor = false;
            this.DeleteDeviceButton.Click += new System.EventHandler(this.DeleteDeviceButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.DropDownMenuTypes);
            this.panel1.Controls.Add(this.SwitchStatusButton);
            this.panel1.Controls.Add(this.SearchByRoomTBX);
            this.panel1.Controls.Add(this.SearchByRoom);
            this.panel1.Controls.Add(this.DeleteDeviceButton);
            this.panel1.Location = new System.Drawing.Point(9, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 347);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::IoT_Casus.Properties.Resources.Ziekenhuislogo;
            this.pictureBox1.Image = global::IoT_Casus.Properties.Resources.Ziekenhuislogo;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(1, 252);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(274, 257);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 27;
            this.label3.Text = "Select a device";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(2, 185);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Room name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(2, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "Type:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(0, -68);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(451, 81);
            this.panel2.TabIndex = 8;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(9, 62);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 24);
            this.button2.TabIndex = 35;
            this.button2.Text = "<---- Back ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.pictureBox2.Image = global::IoT_Casus.Properties.Resources.CloseButton1;
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(423, 67);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 18);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(176)))));
            this.panel3.Location = new System.Drawing.Point(9, 252);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(430, 11);
            this.panel3.TabIndex = 33;
            // 
            // RefreshDataGrid
            // 
            this.RefreshDataGrid.Interval = 5000;
            this.RefreshDataGrid.Tick += new System.EventHandler(this.RefreshDataGrid_Tick);
            // 
            // RefreshDataGridSearch
            // 
            this.RefreshDataGridSearch.Interval = 5000;
            this.RefreshDataGridSearch.Tick += new System.EventHandler(this.RefreshDataGridSearch_Tick_1);
            // 
            // EmployeeDevices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(451, 367);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(85, 80);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EmployeeDevices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "EmployeeDevices";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SearchByRoomTBX;
        private System.Windows.Forms.Button SearchByRoom;
        private System.Windows.Forms.ComboBox DropDownMenuTypes;
        private System.Windows.Forms.Button SwitchStatusButton;
        private System.Windows.Forms.Button DeleteDeviceButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer RefreshDataGrid;
        private System.Windows.Forms.Timer RefreshDataGridSearch;
    }
}