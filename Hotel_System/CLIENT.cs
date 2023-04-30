using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Hotel_System
{
    /*
     * create a class client to add a new client
     *                          edit client data
     *                          remove client
     *                          get all clients
     */
    class CLIENT
    {
        CONNECT conn = new CONNECT();
        //creat a function to insert a new client
        public bool insertClient(String fname, String lname, String phone, String country)
        {
            MySqlCommand command = new MySqlCommand();
            String insertQuery = "INSERT INTO `clients`(`first_name`, `last_name`, `phone`, `country`) VALUES (@fnm,@lnm,@phn,@cnt)";
            command.CommandText = insertQuery;
            command.Connection = conn.getConnection();

            //@fnm,@lnm,@phn,@cnt
            command.Parameters.Add("@fnm", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lnm", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@cnt", MySqlDbType.VarChar).Value = country;

            conn.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {

                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }

        //creat a function to get the clients list 
        public DataTable getClients()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `clients`", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        //create a function to edit a client data
        public bool editClient(int id, String fname, String lname, String phone, String country)
        {
            MySqlCommand command = new MySqlCommand();
            String editQuery = "UPDATE `clients` SET `first_name`=@fnm,`last_name`=@lnm,`phone`=@phn,`country`=@cnt WHERE `id`=@cid";
            command.CommandText = editQuery;
            command.Connection = conn.getConnection();

            // @cid,@fnm,@lnm,@phn,@cnt
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@fnm", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lnm", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@cnt", MySqlDbType.VarChar).Value = country;

            conn.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }

        //create a function to delete the selected client
        //we only need the client id
        public bool removeClient(int id)
        {
            MySqlCommand command = new MySqlCommand();
            String removeQuery = "DELETE FROM `clients` WHERE `id`=@cid";
            command.CommandText = removeQuery;
            command.Connection = conn.getConnection();

            // @cid
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = id;

            conn.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }


    }
}
