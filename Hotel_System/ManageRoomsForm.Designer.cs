namespace Hotel_System
{
    partial class ManageRoomsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonRemoveRoom = new System.Windows.Forms.Button();
            this.buttonEditRoom = new System.Windows.Forms.Button();
            this.buttonAddRoom = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxRoomType = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButtonNO = new System.Windows.Forms.RadioButton();
            this.radioButtonYES = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.comboBoxRoomType);
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Controls.Add(this.buttonRemoveRoom);
            this.panel1.Controls.Add(this.buttonEditRoom);
            this.panel1.Controls.Add(this.buttonAddRoom);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxPhone);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxNumber);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 449);
            this.panel1.TabIndex = 1;
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.buttonClear.Location = new System.Drawing.Point(23, 384);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(353, 42);
            this.buttonClear.TabIndex = 15;
            this.buttonClear.Text = "Clear Fields";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonRemoveRoom
            // 
            this.buttonRemoveRoom.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.buttonRemoveRoom.Location = new System.Drawing.Point(288, 334);
            this.buttonRemoveRoom.Name = "buttonRemoveRoom";
            this.buttonRemoveRoom.Size = new System.Drawing.Size(88, 32);
            this.buttonRemoveRoom.TabIndex = 14;
            this.buttonRemoveRoom.Text = "Remove";
            this.buttonRemoveRoom.UseVisualStyleBackColor = true;
            this.buttonRemoveRoom.Click += new System.EventHandler(this.buttonRemoveRoom_Click);
            // 
            // buttonEditRoom
            // 
            this.buttonEditRoom.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.buttonEditRoom.Location = new System.Drawing.Point(183, 334);
            this.buttonEditRoom.Name = "buttonEditRoom";
            this.buttonEditRoom.Size = new System.Drawing.Size(90, 32);
            this.buttonEditRoom.TabIndex = 13;
            this.buttonEditRoom.Text = "Edit";
            this.buttonEditRoom.UseVisualStyleBackColor = true;
            this.buttonEditRoom.Click += new System.EventHandler(this.buttonEditRoom_Click);
            // 
            // buttonAddRoom
            // 
            this.buttonAddRoom.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.buttonAddRoom.Location = new System.Drawing.Point(23, 334);
            this.buttonAddRoom.Name = "buttonAddRoom";
            this.buttonAddRoom.Size = new System.Drawing.Size(137, 32);
            this.buttonAddRoom.TabIndex = 12;
            this.buttonAddRoom.Text = "Add New Room";
            this.buttonAddRoom.UseVisualStyleBackColor = true;
            this.buttonAddRoom.Click += new System.EventHandler(this.buttonAddRoom_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(382, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(469, 357);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(96, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Free :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(78, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Phone :";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBoxPhone.Location = new System.Drawing.Point(159, 185);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(181, 30);
            this.textBoxPhone.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(29, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Room Type :";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBoxNumber.Location = new System.Drawing.Point(159, 113);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(77, 30);
            this.textBoxNumber.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(50, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room N° :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.Color.Crimson;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(863, 77);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 32.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(863, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Rooms";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoomType.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Location = new System.Drawing.Point(159, 149);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(181, 30);
            this.comboBoxRoomType.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.radioButtonNO);
            this.panel3.Controls.Add(this.radioButtonYES);
            this.panel3.Location = new System.Drawing.Point(166, 227);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(155, 37);
            this.panel3.TabIndex = 20;
            // 
            // radioButtonNO
            // 
            this.radioButtonNO.AutoSize = true;
            this.radioButtonNO.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNO.ForeColor = System.Drawing.Color.Red;
            this.radioButtonNO.Location = new System.Drawing.Point(90, 6);
            this.radioButtonNO.Name = "radioButtonNO";
            this.radioButtonNO.Size = new System.Drawing.Size(57, 26);
            this.radioButtonNO.TabIndex = 1;
            this.radioButtonNO.Text = "NO";
            this.radioButtonNO.UseVisualStyleBackColor = true;
            // 
            // radioButtonYES
            // 
            this.radioButtonYES.AutoSize = true;
            this.radioButtonYES.Checked = true;
            this.radioButtonYES.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonYES.ForeColor = System.Drawing.Color.Green;
            this.radioButtonYES.Location = new System.Drawing.Point(6, 6);
            this.radioButtonYES.Name = "radioButtonYES";
            this.radioButtonYES.Size = new System.Drawing.Size(65, 26);
            this.radioButtonYES.TabIndex = 0;
            this.radioButtonYES.TabStop = true;
            this.radioButtonYES.Text = "YES";
            this.radioButtonYES.UseVisualStyleBackColor = true;
            // 
            // ManageRoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 449);
            this.Controls.Add(this.panel1);
            this.Name = "ManageRoomsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageRoomsForm";
            this.Load += new System.EventHandler(this.ManageRoomsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonRemoveRoom;
        private System.Windows.Forms.Button buttonEditRoom;
        private System.Windows.Forms.Button buttonAddRoom;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxRoomType;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButtonNO;
        private System.Windows.Forms.RadioButton radioButtonYES;
    }
}