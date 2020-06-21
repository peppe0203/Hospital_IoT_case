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
    public partial class Apparaatbeheer : Form
    {
        public Apparaatbeheer()
        {
            InitializeComponent();
        }

        private void ApparaatBeheerWelkomLbl_Click(object sender, EventArgs e)
        {

        }

        private void Apparaatbeheer_Load(object sender, EventArgs e)
        {

        }

        //Add device
        private void ToevoegenApparaatBtn_Click(object sender, EventArgs e)
        {
            //Need Domoticz/Database
            string QueryUrl = "";
            using (WebClient webClient = new WebClient())
            {
                string json = webClient.DownloadString(QueryUrl);
                var Room = JsonConvert.DeserializeObject<DeviceList>(json);
            }
        }
        //delete device
        private void ApparaatPatiëntBtn_Click(object sender, EventArgs e)
        {
            // fill/create data gridview
            //string Idx = dataGridView1.CurrentCell.Value.ToString();
            using (WebClient webClient = new WebClient())
            {
                string json = webClient.DownloadString($"http://127.0.0.1:8080//json.htm?type=setused&used=false&idx={Idx}"); ;
            }
        }
    }
}
