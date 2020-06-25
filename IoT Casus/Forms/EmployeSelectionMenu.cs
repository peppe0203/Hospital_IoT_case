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
    public partial class EmployeSelectionMenu : Form
    {
        int TogMove;
        int MValX;
        int MValY;

        public EmployeSelectionMenu()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var PatiëntBeheer = new PatiëntBeheer();
            PatiëntBeheer.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var EmployeeDevices = new EmployeeDevices();
            EmployeeDevices.Show();
        }
    }
}
