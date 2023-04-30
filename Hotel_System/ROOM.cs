using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Hotel_System
{
    /*
     *in this class we will manage rooms
     * we need first to create a table room_type & rooms 
     */
    class ROOM
    {
        CONNECT conn = new CONNECT();
        //create a function to get a list of room's type
        public DataTable roomTypeList()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `rooms_category`", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        //create a function to get a list of rooms by type
        public DataTable roomByType(int type)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `rooms` WHERE `type`=@typ and free='Yes'", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            //@typ
            command.Parameters.Add("@typ", MySqlDbType.Int32).Value = type;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

         
        //create a function to return the room type id
        public int getRoomType(int number)
        {
            MySqlCommand command = new MySqlCommand("SELECT `type` FROM `rooms` WHERE `number`=@num", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            //@num
            command.Parameters.Add("@num", MySqlDbType.Int32).Value = number;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return Convert.ToInt32(table.Rows[0][0].ToString());
        }


        //create a function to set room free column to NO or YES
        public bool setRoomFree(int number,String YES_or_NO)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `rooms` SET `free`=@yes_no WHERE `number`=@num", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            //@num,@yes_no
            command.Parameters.Add("@num", MySqlDbType.Int32).Value = number;
            command.Parameters.Add("@yes_no", MySqlDbType.VarChar).Value = YES_or_NO;

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


        //create a function to add a new room
        public bool addRoom(int number, int type, String phone, String free)
        {
            MySqlCommand command = new MySqlCommand();
            String insertQuery = "INSERT INTO `rooms`(`number`, `type`, `phone`, `free`) VALUES (@num,@tp,@phn,@fr)";
            command.CommandText = insertQuery;
            command.Connection = conn.getConnection();

            // @num,@tp,@phn,@fr
            command.Parameters.Add("@num", MySqlDbType.Int32).Value = number;
            command.Parameters.Add("@tp", MySqlDbType.Int32).Value = type;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@fr", MySqlDbType.VarChar).Value = free;

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

        //create a function to get a list of all rooms
        public DataTable getRooms()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `rooms`", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        //create a function to edit the selected room
        public bool editRoom(int number, int type, String phone, String free)
        {
            MySqlCommand command = new MySqlCommand();
            String editQuery = "UPDATE `rooms` SET `type`=@tp,`phone`=@phn,`free`=@fr WHERE `number`=@num";
            command.CommandText = editQuery;
            command.Connection = conn.getConnection();

            // @num,@tp,@phn,@fr
            command.Parameters.Add("@num", MySqlDbType.Int32).Value = number;
            command.Parameters.Add("@tp", MySqlDbType.Int32).Value = type;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@fr", MySqlDbType.VarChar).Value = free;

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


        //create a function to delete the selected room
        //we only need the room number
        public bool removeClient(int number)
        {
            MySqlCommand command = new MySqlCommand();
            String removeQuery = "DELETE FROM `rooms` WHERE `number`=@num";
            command.CommandText = removeQuery;
            command.Connection = conn.getConnection();

            // @num
            command.Parameters.Add("@num", MySqlDbType.Int32).Value = number;

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
