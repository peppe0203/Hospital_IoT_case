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

        int TogMove;
        int MValX;
        int MValY;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThisDAL.RetrieveLoginUsers(textBox1.Text,textBox2.Text);
            if (ThisDAL.SessionScreen == 1)
            {
                this.Hide();
                var DeviceManagement = new DeviceManagement();
                DeviceManagement.Show();
            }
            if (ThisDAL.SessionScreen == 2)
            {
                this.Hide();
                var EmployeSelectionMenu = new EmployeSelectionMenu();
                EmployeSelectionMenu.Show();
            }

        }

        //Allows to move the page --BEGIN--
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
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
        
    }
}
