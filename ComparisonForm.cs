using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lr1
{
    public partial class ComparisonForm : Form
    {
        private const int _Count = 1000000;
        private static Random _random;
        private static StationList _stationList;
        private static Station[] _stationArr;

        public ComparisonForm()
        {
            InitializeComponent();
            int totalStations = Station.TotalStations;
            _stationList = new StationList(_Count);
            _stationArr = new Station[_Count];
            _random = new Random();
            for (int i = 0; i < _Count; i++)
            {
                Station station = new Station()
                {
                    Address = "Адрес",
                    AverageAttendace = _random.Next(1, _Count),
                    DateOfOpening = DateTime.Now,
                    Number = "+79876543212",
                    Title = $"Станция №{_random.Next(1, _Count)}",
                    NumberOfSeats = _random.Next(1, _Count),
                    SoldTickets = _random.Next(1, _Count),
                };
                _stationList.Add(station);
                _stationArr[i] = station;
            }
            Station.TotalStations = totalStations;
        }

        private void TestArray()
        {
            ListViewItem newItem = new ListViewItem("Массив");
            int startTime = Environment.TickCount;
            Station station;
            for (int i = 0; i < _Count; i++)
                station = _stationArr[i];
            newItem.SubItems.Add((Environment.TickCount - startTime).ToString());
            startTime = Environment.TickCount;
            for (int i = 0; i < _Count; i++)
                station = _stationArr[_random.Next(0, _Count - 1)];
            newItem.SubItems.Add((Environment.TickCount - startTime).ToString());
            ListView.Items.Add(newItem);
        }

        private void TestStationList()
        {
            ListViewItem newItem = new ListViewItem("Список");
            int startTime = Environment.TickCount;
            Station station;
            for (int i = 0; i < _Count; i++)
                station = _stationList[i];
            newItem.SubItems.Add((Environment.TickCount - startTime).ToString());
            startTime = Environment.TickCount;
            for (int i = 0; i < _Count; i++)
                station = _stationList[_random.Next(0, _Count - 1)];
            newItem.SubItems.Add((Environment.TickCount - startTime).ToString());
            ListView.Items.Add(newItem);
        }

        private void ComparisonForm_Load(object sender, EventArgs e)
        {
            TestArray();
            TestStationList();
        }
    }
}
