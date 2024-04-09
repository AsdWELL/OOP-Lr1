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
            InfoLabel = new Label();
            UpdateStationBtn = new Button();
            StationsComboBox = new ComboBox();
            AddNewStationBtn = new Button();
            FieldsLabelsComboBox = new ComboBox();
            FieldValueLabel = new Label();
            DeleteStationBtn = new Button();
            AllStationInfoBtn = new Button();
            StationTypeComboBox = new ComboBox();
            label8 = new Label();
            CalculateTicketPriceBtn = new Button();
            DiscountTextBox = new TextBox();
            label9 = new Label();
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
            label2.Location = new Point(14, 81);
            label2.Name = "label2";
            label2.Size = new Size(178, 25);
            label2.TabIndex = 1;
            label2.Text = "Количество мест";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.Location = new Point(14, 126);
            label3.Name = "label3";
            label3.Size = new Size(175, 25);
            label3.TabIndex = 2;
            label3.Text = "Продано билетов";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.Location = new Point(14, 171);
            label4.Name = "label4";
            label4.Size = new Size(201, 25);
            label4.TabIndex = 3;
            label4.Text = "Телефонный номер";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.Location = new Point(14, 216);
            label5.Name = "label5";
            label5.Size = new Size(238, 25);
            label5.TabIndex = 4;
            label5.Text = "Средняя посещаемость";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F);
            label6.Location = new Point(14, 261);
            label6.Name = "label6";
            label6.Size = new Size(158, 25);
            label6.TabIndex = 5;
            label6.Text = "Дата открытия";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F);
            label7.Location = new Point(14, 306);
            label7.Name = "label7";
            label7.Size = new Size(69, 25);
            label7.TabIndex = 6;
            label7.Text = "Адрес";
            // 
            // AverageAttendace
            // 
            AverageAttendace.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AverageAttendace.Font = new Font("Microsoft Sans Serif", 12F);
            AverageAttendace.Location = new Point(270, 215);
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
            SoldTickets.Location = new Point(270, 127);
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
            Number.Location = new Point(270, 171);
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
            Address.Location = new Point(270, 303);
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
            DateOfOpening.Location = new Point(270, 259);
            DateOfOpening.Margin = new Padding(3, 4, 3, 4);
            DateOfOpening.Name = "DateOfOpening";
            DateOfOpening.Size = new Size(200, 30);
            DateOfOpening.TabIndex = 14;
            DateOfOpening.Value = new DateTime(2024, 2, 12, 0, 0, 0, 0);
            // 
            // InfoLabel
            // 
            InfoLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            InfoLabel.AutoSize = true;
            InfoLabel.Font = new Font("Segoe UI", 12F);
            InfoLabel.Location = new Point(14, 471);
            InfoLabel.Name = "InfoLabel";
            InfoLabel.Size = new Size(46, 28);
            InfoLabel.TabIndex = 18;
            InfoLabel.Text = "info";
            // 
            // UpdateStationBtn
            // 
            UpdateStationBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            UpdateStationBtn.Font = new Font("Segoe UI", 12F);
            UpdateStationBtn.Location = new Point(270, 404);
            UpdateStationBtn.Name = "UpdateStationBtn";
            UpdateStationBtn.Size = new Size(200, 44);
            UpdateStationBtn.TabIndex = 19;
            UpdateStationBtn.Text = "Сохранить";
            UpdateStationBtn.UseVisualStyleBackColor = true;
            UpdateStationBtn.Click += UpdateStationBtn_Click;
            // 
            // StationsComboBox
            // 
            StationsComboBox.Anchor = AnchorStyles.Left;
            StationsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StationsComboBox.Font = new Font("Segoe UI", 12F);
            StationsComboBox.FormattingEnabled = true;
            StationsComboBox.Location = new Point(14, 409);
            StationsComboBox.Name = "StationsComboBox";
            StationsComboBox.Size = new Size(200, 36);
            StationsComboBox.TabIndex = 20;
            StationsComboBox.SelectedIndexChanged += Stations_SelectedIndexChanged;
            // 
            // AddNewStationBtn
            // 
            AddNewStationBtn.Anchor = AnchorStyles.Right;
            AddNewStationBtn.Font = new Font("Segoe UI", 12F);
            AddNewStationBtn.Location = new Point(490, 455);
            AddNewStationBtn.Name = "AddNewStationBtn";
            AddNewStationBtn.Size = new Size(200, 44);
            AddNewStationBtn.TabIndex = 21;
            AddNewStationBtn.Text = "Создать вокзал";
            AddNewStationBtn.UseVisualStyleBackColor = true;
            AddNewStationBtn.Click += AddNewStationBtn_Click;
            // 
            // FieldsLabelsComboBox
            // 
            FieldsLabelsComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FieldsLabelsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            FieldsLabelsComboBox.Font = new Font("Segoe UI", 12F);
            FieldsLabelsComboBox.FormattingEnabled = true;
            FieldsLabelsComboBox.Items.AddRange(new object[] { "Название вокзала", "Количество мест в 16СС", "Продано билетов", "Телефонный номер", "Средняя посещаемость", "Дата открытия", "Адрес" });
            FieldsLabelsComboBox.Location = new Point(14, 839);
            FieldsLabelsComboBox.Name = "FieldsLabelsComboBox";
            FieldsLabelsComboBox.Size = new Size(260, 36);
            FieldsLabelsComboBox.TabIndex = 23;
            FieldsLabelsComboBox.SelectedIndexChanged += FieldsLabels_SelectedIndexChanged;
            // 
            // FieldValueLabel
            // 
            FieldValueLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            FieldValueLabel.AutoSize = true;
            FieldValueLabel.Font = new Font("Segoe UI", 12F);
            FieldValueLabel.Location = new Point(312, 847);
            FieldValueLabel.Name = "FieldValueLabel";
            FieldValueLabel.Size = new Size(46, 28);
            FieldValueLabel.TabIndex = 24;
            FieldValueLabel.Text = "info";
            // 
            // DeleteStationBtn
            // 
            DeleteStationBtn.Anchor = AnchorStyles.Right;
            DeleteStationBtn.Font = new Font("Segoe UI", 12F);
            DeleteStationBtn.Location = new Point(490, 522);
            DeleteStationBtn.Name = "DeleteStationBtn";
            DeleteStationBtn.Size = new Size(200, 44);
            DeleteStationBtn.TabIndex = 25;
            DeleteStationBtn.Text = "Удалить текущий";
            DeleteStationBtn.UseVisualStyleBackColor = true;
            DeleteStationBtn.Click += DeleteStationBtn_Click;
            // 
            // AllStationInfoBtn
            // 
            AllStationInfoBtn.Anchor = AnchorStyles.Right;
            AllStationInfoBtn.Font = new Font("Segoe UI", 12F);
            AllStationInfoBtn.Location = new Point(490, 586);
            AllStationInfoBtn.Name = "AllStationInfoBtn";
            AllStationInfoBtn.Size = new Size(200, 44);
            AllStationInfoBtn.TabIndex = 26;
            AllStationInfoBtn.Text = "Все станции";
            AllStationInfoBtn.UseVisualStyleBackColor = true;
            AllStationInfoBtn.Click += AllStationInfoBtn_Click;
            // 
            // StationTypeComboBox
            // 
            StationTypeComboBox.Anchor = AnchorStyles.Right;
            StationTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StationTypeComboBox.Font = new Font("Segoe UI", 12F);
            StationTypeComboBox.FormattingEnabled = true;
            StationTypeComboBox.Items.AddRange(new object[] { "Автобусный", "Ж/д" });
            StationTypeComboBox.Location = new Point(490, 409);
            StationTypeComboBox.Name = "StationTypeComboBox";
            StationTypeComboBox.Size = new Size(200, 36);
            StationTypeComboBox.TabIndex = 28;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F);
            label8.Location = new Point(528, 373);
            label8.Name = "label8";
            label8.Size = new Size(125, 25);
            label8.TabIndex = 29;
            label8.Text = "Тип вокзала";
            // 
            // CalculateTicketPriceBtn
            // 
            CalculateTicketPriceBtn.Anchor = AnchorStyles.Right;
            CalculateTicketPriceBtn.Font = new Font("Segoe UI", 12F);
            CalculateTicketPriceBtn.Location = new Point(490, 650);
            CalculateTicketPriceBtn.Name = "CalculateTicketPriceBtn";
            CalculateTicketPriceBtn.Size = new Size(200, 44);
            CalculateTicketPriceBtn.TabIndex = 30;
            CalculateTicketPriceBtn.Text = "Цена билета";
            CalculateTicketPriceBtn.UseVisualStyleBackColor = true;
            CalculateTicketPriceBtn.Click += CalculateTicketPriceBtn_Click;
            // 
            // DiscountTextBox
            // 
            DiscountTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DiscountTextBox.Font = new Font("Microsoft Sans Serif", 12F);
            DiscountTextBox.Location = new Point(270, 343);
            DiscountTextBox.Margin = new Padding(3, 4, 3, 4);
            DiscountTextBox.MaxLength = 25;
            DiscountTextBox.Name = "DiscountTextBox";
            DiscountTextBox.Size = new Size(200, 30);
            DiscountTextBox.TabIndex = 32;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F);
            label9.Location = new Point(14, 346);
            label9.Name = "label9";
            label9.Size = new Size(209, 25);
            label9.TabIndex = 31;
            label9.Text = "Действуемая скидка";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 920);
            Controls.Add(DiscountTextBox);
            Controls.Add(label9);
            Controls.Add(CalculateTicketPriceBtn);
            Controls.Add(label8);
            Controls.Add(StationTypeComboBox);
            Controls.Add(AllStationInfoBtn);
            Controls.Add(DeleteStationBtn);
            Controls.Add(FieldValueLabel);
            Controls.Add(FieldsLabelsComboBox);
            Controls.Add(AddNewStationBtn);
            Controls.Add(StationsComboBox);
            Controls.Add(UpdateStationBtn);
            Controls.Add(InfoLabel);
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
            Load += MainForm_Load;
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
        private Label InfoLabel;
        private Button UpdateStationBtn;
        private ComboBox StationsComboBox;
        private Button AddNewStationBtn;
        private ComboBox FieldsLabelsComboBox;
        private Label FieldValueLabel;
        private Button DeleteStationBtn;
        private Button AllStationInfoBtn;
        private ComboBox StationTypeComboBox;
        private Label label8;
        private Button CalculateTicketPriceBtn;
        private TextBox DiscountTextBox;
        private Label label9;
    }
}
