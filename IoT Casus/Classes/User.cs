using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoT_Casus.Classes
{
    class User
    {
        public int _userId;
        public string _userName;
        public int _userRoleId;
        public int _userRoomId;
        public int _userFloorId;
        public string _password;

        public List<User> Allusers = new List<User>();

        public User(int userId, string userName, int userRoleId, int userRoomId, int userFloorId, string password)
        {
            _userId = userId;
            _userName = userName;
            _userRoleId = userRoleId;
            _userRoomId = userRoomId;
            _userFloorId = userFloorId;
            _password = password;

        }
    }
}
