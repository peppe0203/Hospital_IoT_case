using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IoT_Casus
{
    class DAL
    {
        public static string connectionString = "Data Source =.; Initial Catalog =Hospital_B2D4; Integrated Security = True;";
        public List<Device> AllDevices = new List<Device>();
        public List<User> Allusers = new List<User>();
        public int SessionScreen = 0;

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

        public void RetrieveLoginUsers(string UserName)
        {
            Allusers.Clear();
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    cmd.Connection = cnn;
                    cmd.CommandText = "SELECT userId, userName, userRoleId, userRoomId, userFloorId, password FROM Users_table WHERE userName = @UserName";
                    cmd.Parameters.AddWithValue("@userName", UserName);                    
                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            Allusers.Add(new User(Int32.Parse(dataReader[0].ToString()),
                                dataReader[1].ToString(),
                                Int32.Parse(dataReader[2].ToString()),
                                Int32.Parse(dataReader[3].ToString()),
                                Int32.Parse(dataReader[4].ToString()),
                                dataReader[5].ToString()));
                        }
                    }
                }                
                cnn.Close();
                try
                {
                    var message = string.Join(Environment.NewLine, Allusers[0]);                    
                    if (Allusers[0]._userRoleId == 1)
                    {
                        MessageBox.Show("Logged in patiënt");
                        SessionScreen = 1;
                    }
                    if (Allusers[0]._userRoleId == 2)
                    {
                        MessageBox.Show("Logged in worker");
                        SessionScreen = 2;
                    }                    
                }
                catch (Exception)
                {
                    MessageBox.Show("invalide name");
                }
            }
        }

        public void RetrieveAllPatiens()
        {
            Allusers.Clear();
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    cmd.Connection = cnn;
                    cmd.CommandText = "SELECT userId, userName, userRoleId, userRoomId, userFloorId, password FROM Users_table WHERE userRoleId = 1";
                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            Allusers.Add(new User(Int32.Parse(dataReader[0].ToString()),
                                dataReader[1].ToString(),
                                Int32.Parse(dataReader[2].ToString()),
                                Int32.Parse(dataReader[3].ToString()),
                                Int32.Parse(dataReader[4].ToString()),
                                dataReader[5].ToString()));
                        }
                    }
                }
                cnn.Close();            
            }
        }


    }
}
