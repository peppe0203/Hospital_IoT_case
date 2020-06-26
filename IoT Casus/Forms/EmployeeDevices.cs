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
        }

        private void SearchByRoom_Click(object sender, EventArgs e)
        {
            ThisDAL.SearchDeviceByRoom(SearchByRoomTBX.Text,DropDownMenuTypes.Text);
            refresh_DataGridDevices();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                string test = dataGridView1.Rows[e.RowIndex].Cells["domoticzId"].FormattedValue.ToString();
                MessageBox.Show("Domoticz " + test, "message");
            }
        }
    }
}
