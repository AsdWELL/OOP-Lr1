namespace Lr1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            AverageAttendace = new TextBox();
            Title = new TextBox();
            NumberOfSeats = new TextBox();
            SoldTickets = new TextBox();
            Number = new TextBox();
            Address = new TextBox();
            DateOfOpening = new DateTimePicker();
            Info = new Label();
            UpdateStationBtn = new Button();
            Stations = new ComboBox();
            AddNewStationBtn = new Button();
            FieldsLabels = new ComboBox();
            FieldValue = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.Location = new Point(14, 36);
            label1.Name = "label1";
            label1.Size = new Size(178, 25);
            label1.TabIndex = 0;
            label1.Text = "Название вокзала";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.Location = new Point(14, 80);
            label2.Name = "label2";
            label2.Size = new Size(178, 25);
            label2.TabIndex = 1;
            label2.Text = "Количество мест";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.Location = new Point(14, 121);
            label3.Name = "label3";
            label3.Size = new Size(175, 25);
            label3.TabIndex = 2;
            label3.Text = "Продано билетов";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.Location = new Point(14, 165);
            label4.Name = "label4";
            label4.Size = new Size(201, 25);
            label4.TabIndex = 3;
            label4.Text = "Телефонный номер";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.Location = new Point(14, 211);
            label5.Name = "label5";
            label5.Size = new Size(238, 25);
            label5.TabIndex = 4;
            label5.Text = "Средняя посещаемость";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F);
            label6.Location = new Point(14, 257);
            label6.Name = "label6";
            label6.Size = new Size(158, 25);
            label6.TabIndex = 5;
            label6.Text = "Дата открытия";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F);
            label7.Location = new Point(14, 305);
            label7.Name = "label7";
            label7.Size = new Size(69, 25);
            label7.TabIndex = 6;
            label7.Text = "Адрес";
            // 
            // AverageAttendace
            // 
            AverageAttendace.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AverageAttendace.Font = new Font("Microsoft Sans Serif", 12F);
            AverageAttendace.Location = new Point(270, 208);
            AverageAttendace.Margin = new Padding(3, 4, 3, 4);
            AverageAttendace.MaxLength = 9;
            AverageAttendace.Name = "AverageAttendace";
            AverageAttendace.Size = new Size(200, 30);
            AverageAttendace.TabIndex = 13;
            AverageAttendace.TextChanged += CheckField;
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Title.Font = new Font("Microsoft Sans Serif", 12F);
            Title.Location = new Point(270, 39);
            Title.Margin = new Padding(3, 4, 3, 4);
            Title.MaxLength = 25;
            Title.Name = "Title";
            Title.Size = new Size(200, 30);
            Title.TabIndex = 9;
            Title.TextChanged += CheckField;
            // 
            // NumberOfSeats
            // 
            NumberOfSeats.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NumberOfSeats.Font = new Font("Microsoft Sans Serif", 12F);
            NumberOfSeats.Location = new Point(270, 83);
            NumberOfSeats.Margin = new Padding(3, 4, 3, 4);
            NumberOfSeats.MaxLength = 9;
            NumberOfSeats.Name = "NumberOfSeats";
            NumberOfSeats.Size = new Size(200, 30);
            NumberOfSeats.TabIndex = 10;
            NumberOfSeats.TextChanged += CheckField;
            // 
            // SoldTickets
            // 
            SoldTickets.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SoldTickets.Font = new Font("Microsoft Sans Serif", 12F);
            SoldTickets.Location = new Point(270, 124);
            SoldTickets.Margin = new Padding(3, 4, 3, 4);
            SoldTickets.MaxLength = 9;
            SoldTickets.Name = "SoldTickets";
            SoldTickets.Size = new Size(200, 30);
            SoldTickets.TabIndex = 11;
            SoldTickets.TextChanged += CheckField;
            // 
            // Number
            // 
            Number.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Number.Font = new Font("Microsoft Sans Serif", 12F);
            Number.Location = new Point(270, 168);
            Number.Margin = new Padding(3, 4, 3, 4);
            Number.MaxLength = 25;
            Number.Name = "Number";
            Number.Size = new Size(200, 30);
            Number.TabIndex = 12;
            Number.TextChanged += CheckField;
            // 
            // Address
            // 
            Address.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Address.Font = new Font("Microsoft Sans Serif", 12F);
            Address.Location = new Point(270, 308);
            Address.Margin = new Padding(3, 4, 3, 4);
            Address.MaxLength = 25;
            Address.Name = "Address";
            Address.Size = new Size(200, 30);
            Address.TabIndex = 15;
            Address.TextChanged += CheckField;
            // 
            // DateOfOpening
            // 
            DateOfOpening.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DateOfOpening.Font = new Font("Microsoft Sans Serif", 12F);
            DateOfOpening.ImeMode = ImeMode.NoControl;
            DateOfOpening.Location = new Point(270, 257);
            DateOfOpening.Margin = new Padding(3, 4, 3, 4);
            DateOfOpening.Name = "DateOfOpening";
            DateOfOpening.Size = new Size(200, 30);
            DateOfOpening.TabIndex = 14;
            DateOfOpening.Value = new DateTime(2024, 2, 12, 0, 0, 0, 0);
            // 
            // Info
            // 
            Info.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Info.AutoSize = true;
            Info.Font = new Font("Segoe UI", 12F);
            Info.Location = new Point(14, 432);
            Info.Name = "Info";
            Info.Size = new Size(0, 28);
            Info.TabIndex = 18;
            // 
            // UpdateStationBtn
            // 
            UpdateStationBtn.Anchor = AnchorStyles.Left;
            UpdateStationBtn.Font = new Font("Segoe UI", 12F);
            UpdateStationBtn.Location = new Point(14, 365);
            UpdateStationBtn.Name = "UpdateStationBtn";
            UpdateStationBtn.Size = new Size(200, 44);
            UpdateStationBtn.TabIndex = 19;
            UpdateStationBtn.Text = "Сохранить";
            UpdateStationBtn.UseVisualStyleBackColor = true;
            UpdateStationBtn.Click += UpdateStationBtn_Click;
            // 
            // Stations
            // 
            Stations.Anchor = AnchorStyles.Right;
            Stations.DropDownStyle = ComboBoxStyle.DropDownList;
            Stations.Font = new Font("Segoe UI", 12F);
            Stations.FormattingEnabled = true;
            Stations.Location = new Point(490, 370);
            Stations.Name = "Stations";
            Stations.Size = new Size(200, 36);
            Stations.TabIndex = 20;
            Stations.SelectedIndexChanged += Stations_SelectedIndexChanged;
            // 
            // AddNewStationBtn
            // 
            AddNewStationBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            AddNewStationBtn.Font = new Font("Segoe UI", 12F);
            AddNewStationBtn.Location = new Point(270, 365);
            AddNewStationBtn.Name = "AddNewStationBtn";
            AddNewStationBtn.Size = new Size(200, 44);
            AddNewStationBtn.TabIndex = 21;
            AddNewStationBtn.Text = "Добавить новый";
            AddNewStationBtn.UseVisualStyleBackColor = true;
            AddNewStationBtn.Click += AddNewStationBtn_Click;
            // 
            // FieldsLabels
            // 
            FieldsLabels.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FieldsLabels.DropDownStyle = ComboBoxStyle.DropDownList;
            FieldsLabels.Font = new Font("Segoe UI", 12F);
            FieldsLabels.FormattingEnabled = true;
            FieldsLabels.Items.AddRange(new object[] { "Название вокзала", "Количество мест в 16СС", "Продано билетов", "Телефонный номер", "Средняя посещаемость", "Дата открытия", "Адрес" });
            FieldsLabels.Location = new Point(14, 775);
            FieldsLabels.Name = "FieldsLabels";
            FieldsLabels.Size = new Size(260, 36);
            FieldsLabels.TabIndex = 23;
            FieldsLabels.SelectedIndexChanged += FieldsLabels_SelectedIndexChanged;
            // 
            // FieldValue
            // 
            FieldValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            FieldValue.AutoSize = true;
            FieldValue.Font = new Font("Segoe UI", 12F);
            FieldValue.Location = new Point(312, 783);
            FieldValue.Name = "FieldValue";
            FieldValue.Size = new Size(0, 28);
            FieldValue.TabIndex = 24;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 920);
            Controls.Add(FieldValue);
            Controls.Add(FieldsLabels);
            Controls.Add(AddNewStationBtn);
            Controls.Add(Stations);
            Controls.Add(UpdateStationBtn);
            Controls.Add(Info);
            Controls.Add(DateOfOpening);
            Controls.Add(Address);
            Controls.Add(Number);
            Controls.Add(SoldTickets);
            Controls.Add(NumberOfSeats);
            Controls.Add(Title);
            Controls.Add(AverageAttendace);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вокзал";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox AverageAttendace;
        private TextBox Title;
        private TextBox NumberOfSeats;
        private TextBox SoldTickets;
        private TextBox Number;
        private TextBox Address;
        private DateTimePicker DateOfOpening;
        private Label Info;
        private Button UpdateStationBtn;
        private ComboBox Stations;
        private Button AddNewStationBtn;
        private ComboBox FieldsLabels;
        private Label FieldValue;
    }
}
