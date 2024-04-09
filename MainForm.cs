using System.Text;

namespace Lr1
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// ������ �������
        /// </summary>
        private static StationList _stations;

        private static MessageForm _messageForm;

        public MainForm()
        {
            InitializeComponent();
            _stations = new StationList();
            _messageForm = new MessageForm();
        }

        /// <summary>
        /// �����, ���������� ��� �������� �����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            _stations.OnAdd += s => StationsComboBox.Items.Add(s.Title);
            _stations.OnRemove += s => StationsComboBox.Items.Remove(s.Title);
            _stations.OnUpdate += (s, i) => StationsComboBox.Items[i] = s.Title;

            _stations.AddRange(
                new BusStation("����� 1", 120, 3020, "+79875634543", 78.6, DateTime.Now, "������������ 12"),
                new DiscountDecorator(new TrainStation("����� 2", 10, 3020, "+79888888883", 234.9, DateTime.Now, "������������ 13"), 15),
                new TrainStation("����� 3", 12370, 3020, "+71234567890", 13.2, DateTime.Now, "������������ 14")
            );

            StationsComboBox.SelectedIndex = 0;
            StationTypeComboBox.SelectedIndex = 0;
            FieldsLabelsComboBox.SelectedIndex = 0;

            DateOfOpening.Format = DateTimePickerFormat.Custom;
            DateOfOpening.CustomFormat = "dd MM yyyy";

            _stations.OnAdd += s => _messageForm.Show($"�������� ����� " +
                $"{StationTypeComboBox.SelectedItem.ToString().ToLower()} ������");
            _stations.OnRemove += s => _messageForm.Show($"{StationTypeComboBox.SelectedItem} ������ {s.Title} ������");

            MessageBox.Show("����� � ������� 22��1\n������� 10", "������������ ������ �3");

            SetStationInfo();
        }

        /// <summary>
        /// ����� ��������� ���������� �� �������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckField(object sender, EventArgs e)
        {
            bool isEnabled = true;

            foreach (var i in Controls.OfType<TextBox>())
                if (!i.Name.Equals("DiscountTextBox") && string.IsNullOrWhiteSpace(i.Text))
                {
                    isEnabled = false;
                    break;
                }

            UpdateStationBtn.Enabled = isEnabled;
            AddNewStationBtn.Enabled = isEnabled;
            StationsComboBox.Enabled = isEnabled;
        }

        /// <summary>
        /// ����� ������������� ���������� ���������� � ���� ������
        /// </summary>
        private void SetInfoLabel()
        {
            InfoLabel.Text = $"����� �������: {Station.TotalStations}\n" +
                $"{_stations[StationsComboBox.SelectedIndex]}";
        }

        /// <summary>
        /// ���������, ��� ��������� ������ �� ������� �� ������� �������
        /// </summary>
        /// <returns>������ �� ���������� �������</returns>
        /// <exception cref="IndexOutOfRangeException">��������� � ������ ������ �� �������</exception>
        private Station CheckAndGetSelectedStation()
        {
            if (StationsComboBox.SelectedIndex < 0 || StationsComboBox.SelectedIndex > _stations.Count)
                throw new IndexOutOfRangeException();
            return _stations[StationsComboBox.SelectedIndex];
        }

        /// <summary>
        /// ����� ������������� � ���������� ���� ���������� �������
        /// </summary>
        private void SetStationInfo()
        {
            Station station = CheckAndGetSelectedStation();

            Title.Text = station.Title;
            NumberOfSeats.Text = station.NumberOfSeats.ToString();
            SoldTickets.Text = station.SoldTickets.ToString();
            Number.Text = station.PhoneNumber;
            AverageAttendace.Text = station.AverageAttendace.ToString();
            DateOfOpening.Value = station.DateOfOpening;
            Address.Text = station.Address;

            if (station is DiscountDecorator discountStation)
                DiscountTextBox.Text = discountStation.Discount.ToString();
            else
                DiscountTextBox.Text = string.Empty;

            SetInfoLabel();
        }

        private void Stations_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SetStationInfo();
                FieldsLabels_SelectedIndexChanged(sender, e);
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("������ � ������ �������", "��������");
            }
        }

        /// <summary>
        /// ����� ������������ ��� ������� �� ������ "���������"
        /// ��������� ���� ���������� �������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateStationBtn_Click(object sender, EventArgs e)
        {
            Station station;

            try
            {
                station = CheckAndGetSelectedStation();
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("������ � ������ �������", "��������");
                return;
            }

            station.Title = Title.Text;
            station.Address = Address.Text;

            try
            {
                station.NumberOfSeats = Convert.ToInt32(NumberOfSeats.Text);
                station.SoldTickets = Convert.ToInt32(SoldTickets.Text);
                station.AverageAttendace = Convert.ToDouble(AverageAttendace.Text.Replace('.', ','));
            }
            catch (FormatException)
            {
                MessageBox.Show("������������ �������� ������", "������");
            }
            catch (NegativeValueException ex)
            {
                MessageBox.Show(ex.Message, "������");
            }

            if (!station.CheckAndSetPhoneNumber(Number.Text))
            {
                MessageBox.Show("�������� ������ ������", "������");
                return;
            }

            if (!station.CheckAndSetDateOtOpening(DateOfOpening.Value))
            {
                MessageBox.Show("������� ������������ ����", "������");
                return;
            }

            try
            {
                if (!string.IsNullOrWhiteSpace(DiscountTextBox.Text))
                {
                    double discount = Convert.ToDouble(DiscountTextBox.Text);
                    if (station is DiscountDecorator)
                        ((DiscountDecorator)station).Discount = discount;
                    else
                        station = new DiscountDecorator(station, discount);
                }
                else
                    if (station is DiscountDecorator)
                        ((DiscountDecorator)station).Discount = 0;
            }
            catch
            {
                MessageBox.Show("������ ������ ������ ���� ������", "��������");
                return;
            }

            _stations[StationsComboBox.SelectedIndex] = station;
            SetInfoLabel();
            SetStationInfo();

            if (FieldsLabelsComboBox.SelectedIndex >= 0)
                FieldsLabels_SelectedIndexChanged(FieldsLabelsComboBox, e);
        }

        /// <summary>
        /// ����� ������������ ��� ������� �� ������ "�������� �����"
        /// ������ ����� ������ � ��������� ��� � ������ ��������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNewStationBtn_Click(object sender, EventArgs e)
        {
            UpdateStationBtn_Click(sender, e);

            DeleteStationBtn.Enabled = true;

            _stations.Add(StationTypeComboBox.SelectedIndex switch
            {
                0 => new BusStation("����� ������"),
                1 => new TrainStation("����� ������")
            });
            StationsComboBox.SelectedIndex = _stations.Count - 1;
        }

        /// <summary>
        /// ����� ������������ ��� ������� �� ������ "������� �������"
        /// ������� ��������� ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteStationBtn_Click(object sender, EventArgs e)
        {
            int index = StationsComboBox.SelectedIndex;
            _stations.RemoveAt(index);
            if (index == _stations.Count)
                StationsComboBox.SelectedIndex = _stations.Count - 1;
            else
                StationsComboBox.SelectedIndex++;
            if (StationsComboBox.Items.Count < 2)
                DeleteStationBtn.Enabled = false;
        }

        private void FieldsLabels_SelectedIndexChanged(object sender, EventArgs e)
        {
            FieldValueLabel.Text = _stations[StationsComboBox.SelectedIndex]
                .GetFieldValue((Station.Fields)FieldsLabelsComboBox.SelectedIndex);
        }

        private void AllStationInfoBtn_Click(object sender, EventArgs e)
        {
            StationsInfoForm stationsInfoForm = new StationsInfoForm();
            stationsInfoForm.Show();
            StringBuilder sb = new StringBuilder();
            foreach (Station station in _stations)
                sb.Append($"{station}\n");
            stationsInfoForm.StationsInfoTextBox.Text = sb.ToString().Replace("\n", Environment.NewLine);
        }

        private void CalculateTicketPriceBtn_Click(object sender, EventArgs e)
        {
            Station selectedStation;

            try
            {
                selectedStation = CheckAndGetSelectedStation();
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("������ � ������ �������", "��������");
                return;
            }

            _messageForm.Show($"���� ������ {selectedStation.TicketCost:C}");
        }
    }
}
