using static System.Collections.Specialized.BitVector32;
using System.Linq;
using System.ComponentModel;

namespace Lr1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private BindingList<Station> _stations;

        private void Form1_Load(object sender, EventArgs e)
        {
            DateOfOpening.Format = DateTimePickerFormat.Custom;
            DateOfOpening.CustomFormat = "dd MM yyyy";
            _stations = new BindingList<Station>() {
                new Station("����� 1", 120, 3020, "+79875634543", 78.6, DateTime.Now, "������������ 12"),
                new Station("����� 2", 10, 3020, "+79888888883", 234.9, DateTime.Now, "������������ 13"),
                new Station("����� 3", 12370, 3020, "+71234567890", 13.2, DateTime.Now, "������������ 14")
            };
            //MessageBox.Show("����� � ������� 22��1\n������� 10", "������������ ������ �1");
            Stations.DataSource = _stations;
            Stations.DisplayMember = "Title";
            SetStationInfo();
        }

        private void CheckField(object sender, EventArgs e)
        {
            foreach (var i in Controls.OfType<TextBox>())
                if (i.Text.Length == 0)
                {
                    UpdateStationBtn.Enabled = false;
                    return;
                }
            UpdateStationBtn.Enabled = true;
        }

        private void SetInfo()
        {
            Info.Text = $"����� �������: {Station.TotalStations}\n{_stations[Stations.SelectedIndex]}";
        }

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

        private void UpdateStationBtn_Click(object sender, EventArgs e)
        {
            Station station = _stations[Stations.SelectedIndex];
            station.Title = Title.Text;
            station.NumberOfSeats = Convert.ToInt32(NumberOfSeats.Text);
            station.SoldTickets = Convert.ToInt32(SoldTickets.Text);
            station.AverageAttendace = Convert.ToDouble(AverageAttendace.Text);
            station.Number = Number.Text;
            station.DateOfOpening = DateOfOpening.Value;
            station.Address = Address.Text;
            _stations[Stations.SelectedIndex] = station;
            SetInfo();
        }

        private void AddNewStationBtn_Click(object sender, EventArgs e)
        {
            Station station = new Station("����� ������");
            _stations.Add(station);
            Stations.SelectedIndex = _stations.Count - 1;
        }
    }
}
