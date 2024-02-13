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
                new Station("Пенза 1", 120, 3020, "+79875634543", 78.6, DateTime.Now, "Володарского 12"),
                new Station("Пенза 2", 10, 3020, "+79888888883", 234.9, DateTime.Now, "Володарского 13"),
                new Station("Пенза 3", 12370, 3020, "+71234567890", 13.2, DateTime.Now, "Володарского 14")
            };
            Stations.DataSource = _stations;
            Stations.DisplayMember = "Title";
        }

        /// <summary>
        /// Список станций
        /// </summary>
        private BindingList<Station> _stations;

        /// <summary>
        /// Метод, вызываемый при загрузке формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            DateOfOpening.Format = DateTimePickerFormat.Custom;
            DateOfOpening.CustomFormat = "dd MM yyyy";
            MessageBox.Show("Годов и Поршнев 22ВП1\nВариант 3", "Лабораторная работа №1");
            SetStationInfo();
        }

        /// <summary>
        /// Метод проверяет текстбоксы на пустоту
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
        /// Метод устанавливает отображает информацию в виде строки
        /// </summary>
        private void SetInfo()
        {
            Info.Text = $"Всего станций: {Station.TotalStations}\n{_stations[Stations.SelectedIndex]}";
        }

        /// <summary>
        /// Метод устанавливает в текстбоксы поля выбранного вокзала
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
        /// Метод вызызывается при нажатии на кнопку "Сохранить"
        /// Обновляет поля выбранного вокзала
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
                MessageBox.Show("Неправильные числовые данные", "Ошибка");
            }
            catch (NegativeValueException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
            try
            {
                station.Number = Number.Text;
            }
            catch (WrongNumberFormatException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
            try
            {
                station.DateOfOpening = DateOfOpening.Value;
            }
            catch (InvalidDateOfOpeningException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
            station.Address = Address.Text;
            _stations[Stations.SelectedIndex] = station;
            SetInfo();
            if (FieldsLabels.SelectedIndex >= 0)
                FieldsLabels_SelectedIndexChanged(FieldsLabels, e);
        }

        /// <summary>
        /// Метод вызызывается при нажатии на кнопку "Добавить новый"
        /// Создаёт новый вокзал и добавляет его в список вокзалов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNewStationBtn_Click(object sender, EventArgs e)
        {
            Station station = new Station("Новый вокзал");
            _stations.Add(station);
            Stations.SelectedIndex = _stations.Count - 1;
        }

        private void FieldsLabels_SelectedIndexChanged(object sender, EventArgs e)
        {
            FieldValue.Text = _stations[Stations.SelectedIndex].GetFieldValue((Station.Fields)FieldsLabels.SelectedIndex);
        }
    }
}
