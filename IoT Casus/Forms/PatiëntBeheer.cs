using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace IoT_Casus.Forms
{
    public partial class PatiëntBeheer : Form
    {
        static DAL ThisDAL = new DAL();
        static Thread ThreadForDB = new Thread(DBThread);
        static DataTable UserTable = new DataTable();


        public PatiëntBeheer()
        {
            InitializeComponent();
        }

        public static void DBThread()
        {
            List<string> UniqueUserID = new List<string>();
            for (int k = 0; k < ThisDAL.Allusers.Count(); k++)
            {
                if (UniqueUserID.Contains(ThisDAL.Allusers[k].ToString()) == false)
                {
                    UserTable.Rows.Add(
                        ThisDAL.Allusers[k]._userId
                        , ThisDAL.Allusers[k]._password
                        , ThisDAL.Allusers[k]._userFloorId
                        , ThisDAL.Allusers[k]._userName
                        , ThisDAL.Allusers[k]._userRoleId
                        , ThisDAL.Allusers[k]._userRoomId
                        );
                }
                UniqueUserID.Add(ThisDAL.Allusers[k]._userId.ToString());
                Thread.Sleep(20000);
            }
        }

        private void refresh_DataGridPatiens()
        {
            DataTable table = new DataTable();
            table.Columns.Add("userId", typeof(int));
            table.Columns.Add("userName", typeof(string));
            table.Columns.Add("userRoleId", typeof(int));
            table.Columns.Add("userRoomId", typeof(int));
            table.Columns.Add("userFloorId", typeof(int));
            table.Columns.Add("password", typeof(string));
            foreach (User User in ThisDAL.Allusers)
            {
                table.Rows.Add(User._userId, User._userName, User._userRoleId, User._userRoomId ,User._userFloorId, User._password);
            }

            dataGridView1.DataSource = table;
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThisDAL.RetrieveAllPatiens();
            refresh_DataGridPatiens();
        }

        private void PatiëntBeheer_Load(object sender, EventArgs e)
        {
            ThreadForDB.Start();
        }
    }
}
