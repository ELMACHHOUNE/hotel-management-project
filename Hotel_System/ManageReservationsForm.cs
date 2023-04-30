using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_System
{
    public partial class ManageReservationsForm : Form
    {
        public ManageReservationsForm()
        {
            InitializeComponent();
        }

        ROOM room = new ROOM();
        RESERVATION reservation = new RESERVATION();

        private void ManageReservationsForm_Load(object sender, EventArgs e)
        {
            //display room's type
            comboBoxRoomType.DataSource = room.roomTypeList();
            comboBoxRoomType.DisplayMember = "label";
            comboBoxRoomType.ValueMember = "category_id";
  
            //display free room's number depending on the selected type
            int type = Convert.ToInt32(comboBoxRoomType.SelectedValue.ToString());
            comboBoxRoomNumber.DataSource = room.roomByType(type);
            comboBoxRoomNumber.DisplayMember = "number";
            comboBoxRoomNumber.ValueMember = "number";

            //show all reservations in the datagridview
            dataGridView1.DataSource = reservation.getAllReserv();

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxReservId.Text = "";
            textBoxClientID.Text = "";
            comboBoxRoomType.SelectedIndex = 0;
            dateTimePickerIN.Value = DateTime.Now;
            dateTimePickerOUT.Value = DateTime.Now;
        }

        private void comboBoxRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //display room's number depending on the selected type
                int type = Convert.ToInt32(comboBoxRoomType.SelectedValue.ToString());
                comboBoxRoomNumber.DataSource = room.roomByType(type);
                comboBoxRoomNumber.DisplayMember = "number";
                comboBoxRoomNumber.ValueMember = "number";
            }
            catch (Exception)
            {
                //do nothing
            }
        }

        private void buttonAddReserv_Click(object sender, EventArgs e)
        {
            try
            {
                int clientID = Convert.ToInt32(textBoxClientID.Text);
                int roomNumber = Convert.ToInt32(comboBoxRoomNumber.SelectedValue);
                DateTime dateIn = dateTimePickerIN.Value;
                DateTime dateOut = dateTimePickerOUT.Value;

                //date in must be = or > today date
                //date out must be = or > date in
                if(DateTime.Compare(dateIn.Date, DateTime.Now.Date) < 0 )
                {
                    MessageBox.Show("The Date In Must Be = or > To Today Date", "Invalid Date In", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (DateTime.Compare(dateOut.Date, dateIn.Date) < 0 )
                {
                    MessageBox.Show(dateOut.Day + " - " + dateIn.Day);
                    MessageBox.Show("The Date Out Must Be = or > To Date In", "Invalid Date Out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (reservation.addReservation(roomNumber, clientID, dateIn, dateOut))
                    {
                        //set the room free column to NO
                        //you can add a message if the room is edited
                        room.setRoomFree(roomNumber, "No");
                        dataGridView1.DataSource = reservation.getAllReserv();
                        MessageBox.Show("New Reservation Added", "Add Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Reservation Not Added", "Add Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Add Reservation Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void buttonEditReserv_Click(object sender, EventArgs e)
        {

            try
            {
                int reservID = Convert.ToInt32(textBoxReservId.Text);
                int clientID = Convert.ToInt32(textBoxClientID.Text);
                int roomNumber = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                DateTime dateIn = dateTimePickerIN.Value;
                DateTime dateOut = dateTimePickerOUT.Value;

                //date in must be = or > today date
                //date out must be = or > date in
                if (dateIn < DateTime.Now)
                {
                    MessageBox.Show("The Date In Must Be = or > To Today Date", "Invalid Date In", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (dateOut < dateIn)
                {
                    MessageBox.Show("The Date Out Must Be = or > To Date In", "Invalid Date Out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //reservId
                    if (reservation.editReserv(reservID, roomNumber, clientID, dateIn, dateOut))
                    {
                        //set the room free column to NO
                        //you can add a message if the room is edited
                        room.setRoomFree(roomNumber, "No");
                        dataGridView1.DataSource = reservation.getAllReserv();
                        MessageBox.Show("Reservation Date Updated", "Edit Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Reservation Not Added", "Add Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Reservation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxReservId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //we need to select the combo of room's type
            //we need first to know the type of the room

            //get the room id
            int roomId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());

            //select the room type from the combobox
            comboBoxRoomType.SelectedValue = room.getRoomType(roomId);

            //select the room number from the combobox
            comboBoxRoomNumber.SelectedValue = roomId;


            textBoxClientID.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            dateTimePickerIN.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value);
            dateTimePickerOUT.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value);
        }

        private void buttonRemoveReserv_Click(object sender, EventArgs e)
        {
            try
            {
                int reservId = Convert.ToInt32(textBoxReservId.Text);
                int roomNumber = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                if (reservation.removeReserv(reservId))
                {
                    dataGridView1.DataSource = reservation.getAllReserv();
                    //after to deleting a reservation we need to set free colomn to 'Yes' 

                    room.setRoomFree(roomNumber, "Yes");
                    MessageBox.Show("Reservation Deleted", "Delete Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Reservation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

// -> add the forgein keys for the client & the room

//ALTER TABLE rooms add CONSTRAINT fk_type_id FOREIGN KEY (type) REFERENCES rooms_category(category_id) on UPDATE CASCADE on DELETE CASCADE; 
//ALTER TABLE reservations add CONSTRAINT fk_room_number FOREIGN KEY (roomNumber) REFERENCES rooms(number) on UPDATE CASCADE on DELETE CASCADE;
//ALTER TABLE reservations add CONSTRAINT fk_client_id FOREIGN KEY (clientId) REFERENCES clients(id) on UPDATE CASCADE on DELETE CASCADE;


//when you delete a room or a client, all reservation associated with them will also be deleted

