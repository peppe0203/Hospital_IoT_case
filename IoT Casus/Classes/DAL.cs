using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using IoT_Casus.Classes;

namespace IoT_Casus
{
    class DAL
    {
        public static string connectionString = "Data Source =.; Initial Catalog = Hospital_B2D4; Integrated Security = True;";
        public List<Device> AllDevices = new List<Device>();
        public List<User> Allusers = new List<User>();

        public DAL()
        {
        }
        public void RetrieveAllDevices()
        {
            AllDevices.Clear();
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    cmd.Connection = cnn;
                    //toevoegen query als database er is
                    cmd.CommandText = "";
                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            //toevoegen variablen als database er is
                            AllDevices.Add(new Device(
                                                               )
                                             );
                        }
                    }
                    cnn.Close();
                }
            }
        }

        public void RetrieveAllUsers()
        {
            Allusers.Clear();

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    cmd.Connection = cnn;
                    cmd.CommandText = "SELECT userId, userName, userRoleId, userRoomId, userFloorId, password FROM Users_table";
                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            Allusers.Add(new User());
                            //Bijvoegen alle waardes van user en user class vullen
                        }
                    }
                }
                cnn.Close();
            }
        }
    }
}
