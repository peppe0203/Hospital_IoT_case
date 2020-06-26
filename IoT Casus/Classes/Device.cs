using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoT_Casus
{
    class Device
    {
        public int _deviceId;
        public int _domoticzId;
        public string _deviceType;
        public string _deviceName;
        public string _status;
        public int _roomId;

        public List<Device> AllDevices = new List<Device>();

        public Device(int deviceId, int domoticzId, string deviceType, string deviceName, string status, int roomId)
        {
            _deviceId = deviceId;
            _domoticzId = domoticzId;
            _deviceType = deviceType;
            _deviceName = deviceName;
            _status = status;
            _roomId = roomId;
        }
    }
}
