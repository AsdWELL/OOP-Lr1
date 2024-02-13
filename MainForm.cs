using static System.Collections.Specialized.BitVector32;
using System.Linq;
using System.ComponentModel;
using static Lr1.Station;

namespace Lr1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            _stations = new BindingList<Station>() {
                new Station("����� 1", 120, 3020, "+79875634543", 78.6, DateTime.Now, "������������ 12"),
                new Station("����� 2", 10, 3020, "+79888888883", 234.9, DateTime.Now, "������������ 13"),
                new Station("����� 3", 12370, 3020, "+71234567890", 13.2, DateTime.Now, "������������ 14")
            };
            Stations.DataSource = _stations;
            Stations.DisplayMember = "Title";
        }

        /// <summary>
        /// ������ �������
        /// </summary>
        private BindingList<Station> _stations;

        /// <summary>
        /// �����, ���������� ��� �������� �����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            DateOfOpening.Format = DateTimePickerFormat.Custom;
            DateOfOpening.CustomFormat = "dd MM yyyy";
            MessageBox.Show("����� � ������� 22��1\n������� 3", "������������ ������ �1");
            SetStationInfo();
        }

        /// <summary>
        /// ����� ��������� ���������� �� �������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckField(object sender, EventArgs e)
        {
            foreach (var i in Controls.OfType<TextBox>())
                if (i.Text.Length == 0)
                {
                    UpdateStationBtn.Enabled = false;
                    AddNewStationBtn.Enabled = false;
                    Stations.Enabled = false;
                    return;
                }
            UpdateStationBtn.Enabled = true;
            AddNewStationBtn.Enabled = true;
            Stations.Enabled = true;
        }

        /// <summary>
        /// ����� ������������� ���������� ���������� � ���� ������
        /// </summary>
        private void SetInfo()
        {
            Info.Text = $"����� �������: {Station.TotalStations}\n{_stations[Stations.SelectedIndex]}";
        }

        /// <summary>
        /// ����� ������������� � ���������� ���� ���������� �������
        /// </summary>
        private void SetStationInfo()
        {
            Station station = _stations[Stations.SelectedIndex];
            Title.Text = station.Title;
            NumberOfSeats.Text = station.NumberOfSeats.ToString();
            SoldTickets.Text = station.SoldTickets.ToString();
            Number.Text = station.Number;
            AverageAttendace.Text = station.AverageAttendace.ToString();
            DateOfOpening.Value = station.DateOfOpening;
            Address.Text = station.Address;
            SetInfo();
        }

        private void Stations_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetStationInfo();
        }

        /// <summary>
        /// ����� ������������ ��� ������� �� ������ "���������"
        /// ��������� ���� ���������� �������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateStationBtn_Click(object sender, EventArgs e)
        {
            Station station = _stations[Stations.SelectedIndex];
            station.Title = Title.Text;
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
            try
            {
                station.Number = Number.Text;
            }
            catch (WrongNumberFormatException ex)
            {
                MessageBox.Show(ex.Message, "������");
            }
            try
            {
                station.DateOfOpening = DateOfOpening.Value;
            }
            catch (InvalidDateOfOpeningException ex)
            {
                MessageBox.Show(ex.Message, "������");
            }
            station.Address = Address.Text;
            _stations[Stations.SelectedIndex] = station;
            SetInfo();
            if (FieldsLabels.SelectedIndex >= 0)
                FieldsLabels_SelectedIndexChanged(FieldsLabels, e);
        }

        /// <summary>
        /// ����� ������������ ��� ������� �� ������ "�������� �����"
        /// ������ ����� ������ � ��������� ��� � ������ ��������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNewStationBtn_Click(object sender, EventArgs e)
        {
            Station station = new Station("����� ������");
            _stations.Add(station);
            Stations.SelectedIndex = _stations.Count - 1;
        }

        private void FieldsLabels_SelectedIndexChanged(object sender, EventArgs e)
        {
            FieldValue.Text = _stations[Stations.SelectedIndex].GetFieldValue((Station.Fields)FieldsLabels.SelectedIndex);
        }
    }
}
