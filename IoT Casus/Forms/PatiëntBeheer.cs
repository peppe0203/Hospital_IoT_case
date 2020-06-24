using IoT_Casus.Classes;
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
    public partial class PatiëntBeheer : Form
    {
        DAL ThisDAL = new DAL();

        public PatiëntBeheer()
        {
            InitializeComponent();
        }

        private void refresh_DataGridPatiens()
        {
            DataTable table = new DataTable();
            table.Columns.Add("userId", typeof(int));
            table.Columns.Add("userName", typeof(string));
            table.Columns.Add("userRoleId", typeof(int));
            table.Columns.Add("userRoomId", typeof(int));
            //table.Columns.Add("userFloorId", typeof(int));
            table.Columns.Add("password", typeof(string));
            foreach (User User in ThisDAL.Allusers)
            {
                table.Rows.Add(User._userId, User._userName, User._userRoleId, User._userRoomId, User._password);
            }
            dataGridView1.DataSource = table;
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThisDAL.RetrieveAllPatiens();
            refresh_DataGridPatiens();
            PatiëntSearchTBX.Text = "";
        }

        private void SearchName_Click(object sender, EventArgs e)
        {
            ThisDAL.SearchPatient(PatiëntSearchTBX.Text);
            refresh_DataGridPatiens();
        }

        private void RemovePatient_Click(object sender, EventArgs e)
        {
            ThisDAL.DeletePatient(DeletePatientTBX.Text);
            ThisDAL.RetrieveAllPatiens();
            refresh_DataGridPatiens();
        }

        private void AddPatient_Click(object sender, EventArgs e)
        {
            ThisDAL.AddPatient(PatientNameTBX.Text, RoomIdTBX.Text, FloorIdTBX.Text, PasswordTBX.Text);
            ThisDAL.RetrieveAllPatiens();
            refresh_DataGridPatiens();
            PatientNameTBX.Text = "";
            RoomIdTBX.Text = "";
            FloorIdTBX.Text = "";
            PasswordTBX.Text = "";
        }
    }
}
