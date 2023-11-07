using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509.Qualified;

namespace Elevator_.Data
{
    internal class Connection
    {
        public static MySqlConnection connMaster = new MySqlConnection();

        static string server = "127.0.0.1;";
        static string myDatabase = "elevatorsystem;";
        static string Uid = "root;";
        static string password = ";";
      
        public static MySqlConnection dataSource()
        {
            connMaster = new MySqlConnection($"server={server} database={myDatabase} Uid={Uid} password={password}");
            return connMaster;
        }
        public void connOpen()
        {
            dataSource();
            connMaster.Open();
        }
        public void connClose()
        {
            dataSource();
            connMaster.Close();
        }
        public void insertData(string action) //command to insert data in database in each tables
        {
            dataSource();
            connMaster.Open();
            var stm = "insert into elevatorlog(Action,Date,Time) values(@action,@date,@time)";
            DateTime date = DateTime.Now;
            string time = DateTime.Now.ToLongTimeString();
            var cmd = new MySqlCommand(stm, connMaster);
            cmd.Parameters.AddWithValue("@action", action);
            cmd.Parameters.AddWithValue("@time", time);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            connClose();
          
        }

        public DataTable ViewData()
        {
            DataTable dt = new DataTable();

            try
            {
                dataSource();
                connMaster.Open();
                string query = "SELECT * FROM elevatorlog";
                using (MySqlCommand command = new MySqlCommand(query, connMaster))
                {
                    using (MySqlDataAdapter adpt = new MySqlDataAdapter(command))
                    {
                        adpt.Fill(dt);
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Handle exceptions or logging here
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connClose();
            }

            return dt;
        }

       
    }

    }
