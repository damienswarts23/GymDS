using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gymApp
{
    internal class DBConnection
    {
        private readonly string connectionString =//Telling my program where the database is and giving it the details to connect to the db
        "Server= localhost;Database = gymApp; User= root; Pwd= #Chelsea4life;";

        public MySqlConnection Connect()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);//Creating a connection object and giving it the variable that holds the location and details of our db
            conn.Open();//This is the part where we open the connection to the db, if it is succesfull then nothing happens but if the wrong info is passad then it will give an error message
            return conn;//Returning the connecion wheather it was succesfull or not so that other classes can use this connection for their purpose of connecting to the db
        }
    }
}
