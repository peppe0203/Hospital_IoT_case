using DocumentFormat.OpenXml.Drawing.ChartDrawing;
using IoT_Casus.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IoT_Casus.Classes
{
    class ThreadingClass
    {
        static int NumerOfThreads;
        DAL ThisDAL = new DAL();

        public ThreadingClass(int numberOfThreads)
        {
            NumerOfThreads = 0;
        }

        public void SwitchStatusDeviceOnThread(object DomoticzId)
        {
            HttpWebRequest request =
                    WebRequest.Create("http://127.0.0.1:8080/json.htm?type=command&param=switchlight&idx="+DomoticzId+"&switchcmd=On") as HttpWebRequest;
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            response.Close();
        }

        public void SwitchStatusDeviceOffThread(object DomoticzId)
        {
            HttpWebRequest request =
                    WebRequest.Create("http://127.0.0.1:8080/json.htm?type=command&param=switchlight&idx=" + DomoticzId + "&switchcmd=Off") as HttpWebRequest;
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            response.Close();
        }

        public void DeleteDeviceThread(object DomoticzId)
        {
            //Delete device from db (so there wil be no conflicts between de 2 applications)
            ThisDAL.DeleteDevice(DomoticzId);
            HttpWebRequest request =
                    WebRequest.Create("http://127.0.0.1:8080/json.htm?type=deletedevice&idx=" + DomoticzId) as HttpWebRequest;
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            response.Close();        
        }

        public void GetDataThread()
        {
            ThisDAL.RetrieveAllDevicesEmploye();
        }
    }
}
