using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace adatbesinheritance
{
    public class databasehandler
    {
        MySqlConnection connection;
        public databasehandler()
        {
            string username = "root";
            string password = "";
            string host = "localhost";
            string dbName = "trabant";
            string connectionString = $"user={username}; password={password}; host={host}; database={dbName}";
            connection = new MySqlConnection(connectionString);

        }
        public void ReadAll()
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM trabant";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    int id = read.GetInt32(read.GetOrdinal("id"));
                    string model = read.GetString(read.GetOrdinal("model"));
                    string make = read.GetString(read.GetOrdinal("make"));
                    string color = read.GetString(read.GetOrdinal("color"));
                    int year = read.GetInt32(read.GetOrdinal("year"));
                    int power = read.GetInt32(read.GetOrdinal("power"));
                    Car oneCar = new Car();
                    oneCar.id = id;
                    oneCar.hp=power;
                    oneCar.make= make;
                    oneCar.model= model;
                    oneCar.color= color;
                    Car.cars.Add(oneCar);

                }
                read.Close();
                command.Dispose();
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,"Error:");
                throw;
            }
        }
    }
}
