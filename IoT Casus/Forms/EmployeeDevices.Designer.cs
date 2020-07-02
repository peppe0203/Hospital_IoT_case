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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.SearchByRoomTBX = new System.Windows.Forms.TextBox();
            this.SearchByRoom = new System.Windows.Forms.Button();
            this.DropDownMenuTypes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(560, 142);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load devices";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchByRoomTBX
            // 
            this.SearchByRoomTBX.Location = new System.Drawing.Point(385, 360);
            this.SearchByRoomTBX.Name = "SearchByRoomTBX";
            this.SearchByRoomTBX.Size = new System.Drawing.Size(168, 22);
            this.SearchByRoomTBX.TabIndex = 2;
            // 
            // SearchByRoom
            // 
            this.SearchByRoom.Location = new System.Drawing.Point(478, 388);
            this.SearchByRoom.Name = "SearchByRoom";
            this.SearchByRoom.Size = new System.Drawing.Size(75, 23);
            this.SearchByRoom.TabIndex = 3;
            this.SearchByRoom.Text = "Search";
            this.SearchByRoom.UseVisualStyleBackColor = true;
            this.SearchByRoom.Click += new System.EventHandler(this.SearchByRoom_Click);
            // 
            // DropDownMenuTypes
            // 
            this.DropDownMenuTypes.FormattingEnabled = true;
            this.DropDownMenuTypes.Items.AddRange(new object[] {
            "lamp",
            "motion",
            "rolluik",
            "deurslot",
            " "});
            this.DropDownMenuTypes.Location = new System.Drawing.Point(432, 330);
            this.DropDownMenuTypes.Name = "DropDownMenuTypes";
            this.DropDownMenuTypes.Size = new System.Drawing.Size(121, 24);
            this.DropDownMenuTypes.TabIndex = 4;
            // 
            // EmployeeDevices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 675);
            this.Controls.Add(this.DropDownMenuTypes);
            this.Controls.Add(this.SearchByRoom);
            this.Controls.Add(this.SearchByRoomTBX);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EmployeeDevices";
            this.Text = "EmployeeDevices";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SearchByRoomTBX;
        private System.Windows.Forms.Button SearchByRoom;
        private System.Windows.Forms.ComboBox DropDownMenuTypes;
    }
}