using IoT_Casus.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IoT_Casus.Forms
{
    public partial class EmployeeDevices : Form
    {
        DAL ThisDAL = new DAL();
        ThreadingClass tc = new ThreadingClass(0);

        int TogMove;
        int MValX;
        int MValY;

        public string DomoticzID;
        public string DomoticzStatus;

        public EmployeeDevices()
        {
            InitializeComponent();
        }

        public void refresh_DataGridDevices()
        {
            DataTable table = new DataTable();
            //table.Columns.Add("deviceId", typeof(int));
            table.Columns.Add("domoticzId", typeof(string));
            //table.Columns.Add("deviceType", typeof(string));
            table.Columns.Add("deviceName", typeof(string));
            table.Columns.Add("status", typeof(string));
            table.Columns.Add("roomId", typeof(int));
            foreach (Device Device in ThisDAL.AllDevices)
            {
                table.Rows.Add(Device._domoticzId, Device._deviceName, Device._status, Device._roomId);
            }            
            dataGridView1.DataSource = table;
            dataGridView1.Columns["domoticzId"].Width = 75;
            dataGridView1.Columns["deviceName"].Width = 125;
            dataGridView1.Columns["roomId"].Width = 50;
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThisDAL.RetrieveAllDevicesEmploye();
            refresh_DataGridDevices();
            RefreshDataGrid.Enabled = true;
            RefreshDataGridSearch.Enabled = false;
        }

        private void SearchByRoom_Click(object sender, EventArgs e)
        {

            ThisDAL.SearchDeviceByRoom(SearchByRoomTBX.Text, DropDownMenuTypes.Text);
            refresh_DataGridDevices();
            RefreshDataGridSearch.Enabled = true;
            RefreshDataGrid.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView1.CurrentRow.Selected = true;
                    DomoticzID = dataGridView1.Rows[e.RowIndex].Cells["domoticzId"].FormattedValue.ToString();
                    DomoticzStatus = dataGridView1.Rows[e.RowIndex].Cells["status"].FormattedValue.ToString();
                    //MessageBox.Show("Domoticz " + DomoticzID + DomoticzStatus, "message");
                }
            }
            // if its the first row
            catch (Exception)
            {
                Console.WriteLine("Not possible to get info");
            }

        }

        private void SwitchStatusButton_Click(object sender, EventArgs e)
        {
            if (((DomoticzStatus == "Off") || (DomoticzStatus == "Open") || (DomoticzStatus == "Unlocked")) && (DomoticzID != null))
            {
                Thread t1 = new Thread(tc.SwitchStatusDeviceOnThread);
                t1.Start(DomoticzID);
            }
            if (((DomoticzStatus == "On") || (DomoticzStatus == "Closed") || (DomoticzStatus == "Locked")) && (DomoticzID != null))
            {
                Thread t2 = new Thread(tc.SwitchStatusDeviceOffThread);
                t2.Start(DomoticzID);
            }
            if (DomoticzID == null)
            {
                MessageBox.Show("Select device", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteDeviceButton_Click(object sender, EventArgs e)
        {
            if (DomoticzID != null)
            {
                string message = "Device with ID: " + DomoticzID + " wil be deleted";
                DialogResult dialogResult = MessageBox.Show(message, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {                    
                    Thread t3 = new Thread(tc.DeleteDeviceThread);
                    t3.Start(DomoticzID);
                    MessageBox.Show("Delete succesvol", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Delete canceled", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }                
            }
            if (DomoticzID == null)
            {
                MessageBox.Show("Select device", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Allows to move the page --BEGIN--
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }
        //Allows to move the page --END--

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var EmployeSelectionMenu = new EmployeSelectionMenu();
            EmployeSelectionMenu.Show();
            WindowState = FormWindowState.Normal;
            RefreshDataGrid.Enabled = false;
        }

        private void RefreshDataGrid_Tick(object sender, EventArgs e)
        {
            ThisDAL.RetrieveAllDevicesEmploye();
            int index = dataGridView1.CurrentRow.Index;
            refresh_DataGridDevices();
            dataGridView1.FirstDisplayedScrollingRowIndex = index;
        }

        private void RefreshDataGridSearch_Tick_1(object sender, EventArgs e)
        {
            ThisDAL.SearchDeviceByRoom(SearchByRoomTBX.Text, DropDownMenuTypes.Text);
            int index = dataGridView1.CurrentRow.Index;
            refresh_DataGridDevices();
            dataGridView1.FirstDisplayedScrollingRowIndex = index;
        }
    }
}
