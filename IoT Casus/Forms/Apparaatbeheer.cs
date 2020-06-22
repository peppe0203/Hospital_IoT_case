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

namespace IoT_Casus.Forms
{
    public partial class DeleteDeviceButton : Form
    {
        public DeleteDeviceButton()
        {
            InitializeComponent();
        }

        private void ApparaatBeheerWelkomLbl_Click(object sender, EventArgs e)
        {

        }

        private void Apparaatbeheer_Load(object sender, EventArgs e)
        {

        }

        //aanroepen met dataGridView1.CurrentCell.Value (int)
        private void ToggleDevice(int IDx) 
        {
            using (WebClient webClient = new WebClient())
            {
                string json = webClient.DownloadString($"http://127.0.0.1:8080/json.htm?type=command&param=switchlight&idx={IDx}&switchcmd=Toggle");
            }
        }

        //delete device. aanroepen met dataGridView1.CurrentCell.Value (int)
        private void DeleteDevice(int IDx) 
        {
            // fill/create data gridview
            //string Idx = dataGridView1.CurrentCell.Value.ToString();
            using (WebClient webClient = new WebClient())
            {
                string json = webClient.DownloadString($"http://127.0.0.1:8080//json.htm?type=setused&used=false&idx={IDx}"); ;
            }
        }

        //Add device
        private void AddDevice()
        {
            //IDx Uit database: Max idx + 1
            //Need Domoticz/Database
            string QueryUrl = "";
            using (WebClient webClient = new WebClient())
            {
                string json = webClient.DownloadString(QueryUrl);
                var Room = JsonConvert.DeserializeObject<DeviceList>(json);
            }
        }

        private void ToggleButton_Click(object sender, EventArgs e)
        {

        }

        private void AddDeviceButton_Click(object sender, EventArgs e)
        {

        }

        private void ApparaatPatiëntBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
