using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using IoT_Casus.Classes;
using System.Threading;

namespace IoT_Casus.Forms
{
    public partial class PatientDevice : Form
    {
        DAL ThisDAL = new DAL();
        Form1 form1 = new Form1();
        ThreadingClass tc = new ThreadingClass(0);

        public string DomoticzID;
        public string DomoticzStatus;
        
        int TogMove;
        int MValX;
        int MValY;

        public PatientDevice()
        {
            InitializeComponent();
            TextBoxName.Text = ThisDAL.PatienntNameView;
            TextBoxName.ReadOnly = true;
        }

        private void ApparaatBeheerWelkomLbl_Click(object sender, EventArgs e)
        {

        }

        private void Apparaatbeheer_Load(object sender, EventArgs e)
        {

        }


        private void ToggleButton_Click(object sender, EventArgs e)
        {

        }

        private void DeviceDeleteButton_Click(object sender, EventArgs e)
        {

        }

        //Giuseppe From here
        private void refresh_DataGridDevicesPatient()
        {
            DataTable table = new DataTable();
            //table.Columns.Add("deviceId", typeof(int));
            table.Columns.Add("domoticzId", typeof(string));
            //table.Columns.Add("deviceType", typeof(string));
            table.Columns.Add("deviceName", typeof(string));
            table.Columns.Add("status", typeof(string));
            //table.Columns.Add("roomId", typeof(int));
            foreach (Device Device in ThisDAL.AllDevices)
            {
                table.Rows.Add(Device._domoticzId, Device._deviceName, Device._status);
            }
            dataGridView1.DataSource = table;
            dataGridView1.Columns["domoticzId"].Width = 75;
            dataGridView1.Columns["deviceName"].Width = 132;
            dataGridView1.Columns["status"].Width = 80;
            dataGridView1.Refresh();
        }

        private void LoadDevicesPatient_Click(object sender, EventArgs e)
        {            
            ThisDAL.RetrieveAllDevicesPatient();
            refresh_DataGridDevicesPatient();
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

        private void SwitchStatusDevicePatient_Click(object sender, EventArgs e)
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

        //Closing button in corner to stop application
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var MainPage = new Form1();
            MainPage.Show();
            WindowState = FormWindowState.Normal;
        }
    }
}
