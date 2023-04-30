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
    public partial class ManageRoomsForm : Form
    {
        public ManageRoomsForm()
        {
            InitializeComponent();
        }

        ROOM room = new ROOM();

        private void ManageRoomsForm_Load(object sender, EventArgs e)
        {
            comboBoxRoomType.DataSource = room.roomTypeList();
            comboBoxRoomType.DisplayMember = "label";
            comboBoxRoomType.ValueMember = "category_id";

            dataGridView1.DataSource = room.getRooms();
        }

        private void buttonAddRoom_Click(object sender, EventArgs e)
        {
            int type = Convert.ToInt32(comboBoxRoomType.SelectedValue.ToString());
            string phone = textBoxPhone.Text;
            string free = "";

            try
            {
                int number = Convert.ToInt32(textBoxNumber.Text);
                if (radioButtonYES.Checked)
                {
                    free = "Yes";
                }
                else if (radioButtonNO.Checked)
                {
                    free = "No";
                }

                if (room.addRoom(number, type, phone, free))
                {
                    dataGridView1.DataSource = room.getRooms();
                    MessageBox.Show("Room Add Successfully", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Room Not Add", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Room Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonEditRoom_Click(object sender, EventArgs e)
        {
            int type = Convert.ToInt32(comboBoxRoomType.SelectedValue.ToString());
            String phone = textBoxPhone.Text;
            String free = "";
            try
            {
                int number = Convert.ToInt32(textBoxNumber.Text);
                if (radioButtonYES.Checked)
                {
                    free = "Yes";
                }
                else if (radioButtonNO.Checked)
                {
                    free = "No";
                }
                if (room.editRoom(number, type, phone, free))
                {
                    dataGridView1.DataSource = room.getRooms();
                    MessageBox.Show("Room Data Updated", "Edit Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Room Data Not Updated", "Edit Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Room Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRemoveRoom_Click(object sender, EventArgs e)
        {
            try
            {
                int number = Convert.ToInt32(textBoxNumber.Text);

                if (room.removeClient(number))
                {
                    dataGridView1.DataSource = room.getRooms();
                    MessageBox.Show("Room Data Deleted", "Remove Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Room Data Not Deleted", "Remove Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Room Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxNumber.Text = "";
            comboBoxRoomType.SelectedIndex = 0;
            textBoxPhone.Text = "";

            radioButtonYES.Checked = true;
        }

        //display selected row data from datagridview to textboxes
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxNumber.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBoxRoomType.SelectedValue = dataGridView1.CurrentRow.Cells[1].Value;
            textBoxPhone.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            string free = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            if (free.Equals("Yes"))
            {
                radioButtonYES.Checked = true;
            }
            else if (free.Equals("No"))
            {
                radioButtonNO.Checked = true;
            }
        }
    }
}
