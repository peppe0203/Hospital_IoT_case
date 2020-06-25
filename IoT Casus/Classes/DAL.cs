using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using IoT_Casus.Classes;
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

        //Used when logging in (searches if the name is in de DB and if the user is patient or worker)
        public void RetrieveLoginUsers(string UserName, string Password)
        {
            Allusers.Clear();
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    cmd.Connection = cnn;
                    cmd.CommandText = "SELECT userId, userName, userRoleId, userRoomId, userFloorId, password FROM Users_table WHERE userName = @UserName AND password = @Password";
                    cmd.Parameters.AddWithValue("@userName", UserName);
                    cmd.Parameters.AddWithValue("@password", Password);
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
                        MessageBox.Show("Logged in patiënt","Message");
                        SessionScreen = 1;
                    }
                    if (Allusers[0]._userRoleId == 2)
                    {
                        MessageBox.Show("Logged in worker","Message");
                        SessionScreen = 2;
                    }                    
                }
                catch (Exception)
                {
                    MessageBox.Show("invalide name or password","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        //Used to display al patiens of the hospital in the datagrid
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

        // Used to see if there is a patient whit a specific name
        public void SearchPatient(string UserName)
        {
            Allusers.Clear();
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    cmd.Connection = cnn;
                    cmd.CommandText = "SELECT userId, userName, userRoleId, userRoomId, userFloorId, password FROM Users_table WHERE userRoleId = 1 AND userName LIKE '%' + @UserName + '%'";
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
            }
        }

        public void DeletePatient(string UserId)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    cmd.Connection = cnn;
                    cmd.CommandText = "DELETE FROM Users_table WHERE userId = @UserId";
                    cmd.Parameters.AddWithValue("@userId", UserId);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        string message = "Patient with ID: " + UserId + " Has been deleted";
                        MessageBox.Show(message, "Message");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Invalide ID", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }                    
                }
                cnn.Close();
            }            
        }

        //Adding a patient to the database
        public void AddPatient(string UserName, string UserRoomId, string UserFloorId, string Password)
        {
            SqlConnection cnn = new SqlConnection();
            try
            {
                cnn.ConnectionString = connectionString;
                cnn.Open();
                string sql = "INSERT INTO Users_table (userName, userRoleId, userRoomId, userFloorId, password) VALUES (@userName, 1, @userRoomId, @userFloorId, @password)";
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.AddWithValue("@userName", UserName);
                    cmd.Parameters.AddWithValue("@userRoomId", UserRoomId);
                    cmd.Parameters.AddWithValue("@userFloorId", UserFloorId);
                    cmd.Parameters.AddWithValue("@password", Password);
                    cmd.ExecuteNonQuery();
                }                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            cnn.Close();
        }

        //Retrieving all devices
    }
}
