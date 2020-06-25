using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IoT_Casus.Forms
{
    public partial class EmployeeDevices : Form
    {
        DAL ThisDAL = new DAL();

        public EmployeeDevices()
        {
            InitializeComponent();
        }

        private void refresh_DataGridDevices()
        {
            DataTable table = new DataTable();
            //table.Columns.Add("deviceId", typeof(int));
            //table.Columns.Add("domoticzId", typeof(string));
            //table.Columns.Add("deviceType", typeof(string));
            table.Columns.Add("deviceName", typeof(string));
            table.Columns.Add("status", typeof(string));
            table.Columns.Add("roomId", typeof(int));
            foreach (Device Device in ThisDAL.AllDevices)
            {
                table.Rows.Add(Device._deviceName, Device._status, Device._roomId);
            }            
            dataGridView1.DataSource = table;
            dataGridView1.Columns["deviceName"].Width = 150;
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThisDAL.RetrieveAllDevicesEmploye();
            refresh_DataGridDevices();
        }

        private void SearchByRoom_Click(object sender, EventArgs e)
        {
            ThisDAL.SearchDeviceByRoom(SearchByRoomTBX.Text,DropDownMenuTypes.Text);
            refresh_DataGridDevices();
        }
    }
}
