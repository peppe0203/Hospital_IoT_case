using IoT_Casus.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IoT_Casus
{
    public partial class Form1 : Form
    {
        DAL ThisDAL = new DAL();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThisDAL.RetrieveAllUsers(textBox1.Text);
            if (ThisDAL.SessionScreen == 1)
            {
                var DeviceManagement = new DeviceManagement();
                DeviceManagement.Show();
            }
            if (ThisDAL.SessionScreen == 2)
            {
                var PatiëntBeheer = new PatiëntBeheer();
                PatiëntBeheer.Show();
            }

        }
    }
}
