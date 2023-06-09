﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;



namespace Hotel_System
{
    /*
    in this class will make the conection between our app and mysql database 
    */
    class CONNECT
    {
        private MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=hotel_syst");

        //create a function to return our connection
        public MySqlConnection getConnection()
        {
            return connection;
        }

        //create a function to open the connection
        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        //create a function to close the connection
        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

    }
}
