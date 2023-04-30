using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Hotel_System
{

    class RESERVATION
    {
        CONNECT conn = new CONNECT();
        
        //get all reservations
        public DataTable getAllReserv()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `reservations`", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        //create a function to add a new reservation
        public bool addReservation(int number, int clientId, DateTime dateIn, DateTime dateOut)
        {
            CONNECT conn = new CONNECT();
            MySqlCommand command = new MySqlCommand();
            String insertQuery = "INSERT INTO `reservations`(`roomNumber`, `clientId`, `DateIn`, `DateOut`) VALUES (@rnm,@cid,@din,@dout)";
            command.CommandText = insertQuery;
            command.Connection = conn.getConnection();

            //@rnm,@cid,@din,@dout
            command.Parameters.Add("@rnm", MySqlDbType.Int32).Value = number;
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = clientId;
            command.Parameters.Add("@din", MySqlDbType.VarChar).Value = dateIn;
            command.Parameters.Add("@dout", MySqlDbType.VarChar).Value = dateOut;

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

        //create a function to edit the selected reservation
        public bool editReserv(int reservId, int number, int clientId, DateTime dateIn, DateTime dateOut)
        {
            CONNECT conn = new CONNECT();
            MySqlCommand command = new MySqlCommand();
            String editQuery = "UPDATE `reservations` SET `roomNumber`=@rnm,`clientId`=@cid,`DateIn`=@din,`DateOut`=@dout WHERE `reservId`=@rvid";
            command.CommandText = editQuery;
            command.Connection = conn.getConnection();

            // @rnm,@cid,@din,@dout,@rvid
            command.Parameters.Add("@rvid", MySqlDbType.Int32).Value = reservId;
            command.Parameters.Add("@rnm", MySqlDbType.Int32).Value = number;
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = clientId;
            command.Parameters.Add("@din", MySqlDbType.VarChar).Value = dateIn;
            command.Parameters.Add("@dout", MySqlDbType.VarChar).Value = dateOut;

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

        //create a function to delete the selected reservation
        //we only need the reservation id
        public bool removeReserv(int rsv_id)
        {
            CONNECT conn = new CONNECT();
            MySqlCommand command = new MySqlCommand();
            String removeQuery = "DELETE FROM `reservations` WHERE `reservId`=@rvid";
            command.CommandText = removeQuery;
            command.Connection = conn.getConnection();

            // @rvid
            command.Parameters.Add("@rvid", MySqlDbType.Int32).Value = rsv_id;

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
