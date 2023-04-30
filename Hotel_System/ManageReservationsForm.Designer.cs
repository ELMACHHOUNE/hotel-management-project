namespace Hotel_System
{
    partial class ManageReservationsForm
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
            this.dateTimePickerOUT = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerIN = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxRoomNumber = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxRoomType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxClientID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonRemoveReserv = new System.Windows.Forms.Button();
            this.buttonEditReserv = new System.Windows.Forms.Button();
            this.buttonAddReserv = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxReservId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel1.Controls.Add(this.textBoxReservId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateTimePickerOUT);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dateTimePickerIN);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.comboBoxRoomNumber);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboBoxRoomType);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxClientID);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Controls.Add(this.buttonRemoveReserv);
            this.panel1.Controls.Add(this.buttonEditReserv);
            this.panel1.Controls.Add(this.buttonAddReserv);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 449);
            this.panel1.TabIndex = 2;
            // 
            // dateTimePickerOUT
            // 
            this.dateTimePickerOUT.CalendarFont = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerOUT.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerOUT.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerOUT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerOUT.Location = new System.Drawing.Point(155, 309);
            this.dateTimePickerOUT.Name = "dateTimePickerOUT";
            this.dateTimePickerOUT.Size = new System.Drawing.Size(221, 30);
            this.dateTimePickerOUT.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 23);
            this.label7.TabIndex = 35;
            this.label7.Text = "Date Out :";
            // 
            // dateTimePickerIN
            // 
            this.dateTimePickerIN.CalendarFont = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerIN.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerIN.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerIN.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerIN.Location = new System.Drawing.Point(155, 272);
            this.dateTimePickerIN.Name = "dateTimePickerIN";
            this.dateTimePickerIN.Size = new System.Drawing.Size(221, 30);
            this.dateTimePickerIN.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 23);
            this.label6.TabIndex = 33;
            this.label6.Text = "Date IN :";
            // 
            // comboBoxRoomNumber
            // 
            this.comboBoxRoomNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoomNumber.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRoomNumber.FormattingEnabled = true;
            this.comboBoxRoomNumber.Location = new System.Drawing.Point(155, 234);
            this.comboBoxRoomNumber.Name = "comboBoxRoomNumber";
            this.comboBoxRoomNumber.Size = new System.Drawing.Size(221, 30);
            this.comboBoxRoomNumber.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-1, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 23);
            this.label5.TabIndex = 31;
            this.label5.Text = "Room Number :";
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoomType.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Location = new System.Drawing.Point(155, 195);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(221, 30);
            this.comboBoxRoomType.TabIndex = 30;
            this.comboBoxRoomType.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoomType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 23);
            this.label3.TabIndex = 29;
            this.label3.Text = "Room Type :";
            // 
            // textBoxClientID
            // 
            this.textBoxClientID.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClientID.Location = new System.Drawing.Point(155, 157);
            this.textBoxClientID.Name = "textBoxClientID";
            this.textBoxClientID.Size = new System.Drawing.Size(77, 30);
            this.textBoxClientID.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 23);
            this.label4.TabIndex = 27;
            this.label4.Text = "Client ID :";
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.buttonClear.Location = new System.Drawing.Point(23, 399);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(353, 42);
            this.buttonClear.TabIndex = 15;
            this.buttonClear.Text = "Clear Fields";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonRemoveReserv
            // 
            this.buttonRemoveReserv.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.buttonRemoveReserv.Location = new System.Drawing.Point(288, 361);
            this.buttonRemoveReserv.Name = "buttonRemoveReserv";
            this.buttonRemoveReserv.Size = new System.Drawing.Size(88, 32);
            this.buttonRemoveReserv.TabIndex = 14;
            this.buttonRemoveReserv.Text = "Remove";
            this.buttonRemoveReserv.UseVisualStyleBackColor = true;
            this.buttonRemoveReserv.Click += new System.EventHandler(this.buttonRemoveReserv_Click);
            // 
            // buttonEditReserv
            // 
            this.buttonEditReserv.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.buttonEditReserv.Location = new System.Drawing.Point(183, 361);
            this.buttonEditReserv.Name = "buttonEditReserv";
            this.buttonEditReserv.Size = new System.Drawing.Size(90, 32);
            this.buttonEditReserv.TabIndex = 13;
            this.buttonEditReserv.Text = "Edit";
            this.buttonEditReserv.UseVisualStyleBackColor = true;
            this.buttonEditReserv.Click += new System.EventHandler(this.buttonEditReserv_Click);
            // 
            // buttonAddReserv
            // 
            this.buttonAddReserv.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.buttonAddReserv.Location = new System.Drawing.Point(23, 361);
            this.buttonAddReserv.Name = "buttonAddReserv";
            this.buttonAddReserv.Size = new System.Drawing.Size(137, 32);
            this.buttonAddReserv.TabIndex = 12;
            this.buttonAddReserv.Text = "Add Reservation";
            this.buttonAddReserv.UseVisualStyleBackColor = true;
            this.buttonAddReserv.Click += new System.EventHandler(this.buttonAddReserv_Click);
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
            this.label1.Text = "Manage Reservations";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxReservId
            // 
            this.textBoxReservId.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReservId.Location = new System.Drawing.Point(156, 117);
            this.textBoxReservId.Name = "textBoxReservId";
            this.textBoxReservId.Size = new System.Drawing.Size(77, 30);
            this.textBoxReservId.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 37;
            this.label2.Text = "Reserv ID :";
            // 
            // ManageReservationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 449);
            this.Controls.Add(this.panel1);
            this.Name = "ManageReservationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageReservationsForm";
            this.Load += new System.EventHandler(this.ManageReservationsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePickerOUT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerIN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxRoomNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxRoomType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxClientID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonRemoveReserv;
        private System.Windows.Forms.Button buttonEditReserv;
        private System.Windows.Forms.Button buttonAddReserv;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxReservId;
        private System.Windows.Forms.Label label2;
    }
}