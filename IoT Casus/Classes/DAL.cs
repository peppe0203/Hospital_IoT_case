using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using IoT_Casus.Classes;
using System.Windows.Forms;
using NUnit.Framework.Internal;
using DocumentFormat.OpenXml.Wordprocessing;

namespace IoT_Casus
{
    class DAL
    {
        public static string connectionString = "Data Source =.; Initial Catalog =Hospital_B2D4; Integrated Security = True;";
        public List<Device> AllDevices = new List<Device>();
        public List<User> Allusers = new List<User>();

        //So the program knows which view to open (1 patient, 2 worker, 0 none)
        public int SessionScreen = 0;
        public static string PatientName;

        //So it can be used in PatientDeviceView
        public string PatienntNameView = PatientName;


        public DAL()
        {
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
                        //Turned off because of testing
                        //MessageBox.Show("Logged in patiënt","Message");
                        SessionScreen = 1;
                        PatientName = Allusers[0]._userName;
                    }
                    if (Allusers[0]._userRoleId == 2)
                    {
                        //Turned off because of testing
                        //MessageBox.Show("Logged in worker","Message");
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
                        string message = "Patient with ID: " + UserId + " wil be deleted";
                        DialogResult dialogResult = MessageBox.Show(message,"Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                        if (dialogResult == DialogResult.Yes)
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Delete succesvol", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            MessageBox.Show("Delete canceled", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        
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
        public void RetrieveAllDevicesEmploye()
        {
            AllDevices.Clear();
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    cmd.Connection = cnn;
                    cmd.CommandText = "SELECT deviceId, domoticzId, deviceType, deviceName, status, roomId FROM Devices_table ORDER BY deviceName";
                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            AllDevices.Add(new Device(Int32.Parse(dataReader[0].ToString()),
                                Int32.Parse(dataReader[1].ToString()),
                                dataReader[2].ToString(),
                                dataReader[3].ToString(),
                                dataReader[4].ToString(),
                                Int32.Parse(dataReader[5].ToString())));
                        }
                    }
                }
                cnn.Close();
            }
        }

        // Used to see if there is a patient whit a specific name
        public void SearchDeviceByRoom(string RoomName,string RoomNameType)
        {
            AllDevices.Clear();
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    cmd.Connection = cnn;
                    cmd.CommandText = "select * from Devices_table inner join Rooms_table on Devices_table.roomId = Rooms_table.roomId where roomName like '%' + @roomName + '%' and deviceName like '%' + @roomNameType + '%'"; 
                    cmd.Parameters.AddWithValue("@roomName", RoomName);
                    cmd.Parameters.AddWithValue("@roomNameType", RoomNameType);
                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            AllDevices.Add(new Device(Int32.Parse(dataReader[0].ToString()),
                                Int32.Parse(dataReader[1].ToString()),
                                dataReader[2].ToString(),
                                dataReader[3].ToString(),
                                dataReader[4].ToString(),
                                Int32.Parse(dataReader[5].ToString())));
                        }
                    }
                }
                cnn.Close();
            }
        }

        // Used to display all devices of the patient
        public void RetrieveAllDevicesPatient()
        {
            AllDevices.Clear();
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    cmd.Connection = cnn;
                    cmd.CommandText = "Select * From Devices_table Inner join Rooms_table On Devices_table.roomId = Rooms_table.roomId " +
                        "Inner join Users_table On Rooms_table.roomId = Users_table.userRoomId Where Users_table.userName = @UserName";
                    cmd.Parameters.AddWithValue("@UserName", PatientName);
                    using (SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            AllDevices.Add(new Device(Int32.Parse(dataReader[0].ToString()),
                                Int32.Parse(dataReader[1].ToString()),
                                dataReader[2].ToString(),
                                dataReader[3].ToString(),
                                dataReader[4].ToString(),
                                Int32.Parse(dataReader[5].ToString())));
                        }
                    }
                }
                cnn.Close();
            }
        }

        public void DeleteDevice(object DeviceID)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cnn.ConnectionString = connectionString;
                    cnn.Open();
                    cmd.Connection = cnn;
                    cmd.CommandText = "DELETE FROM Devices_table WHERE domoticzId = @DomoticzId";
                    cmd.Parameters.AddWithValue("@DomoticzId", DeviceID);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                    }
                }
                cnn.Close();
            }
        }
    }
}
