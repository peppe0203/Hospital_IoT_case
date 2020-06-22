using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace IoT_Casus
{
    class DAL
    {
        public static string connectionString = "Data Source =.; Initial Catalog = DATABASE_NAME; Integrated Security = True;";
        public List<Device> AllDevices = new List<Device>();
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
    }
}
