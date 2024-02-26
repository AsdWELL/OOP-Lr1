using static System.Collections.Specialized.BitVector32;
using System.Linq;
using System.ComponentModel;
using static Lr1.Station;
using System.Drawing.Text;
using System.Text;

namespace Lr1
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Список станций
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
        /// Метод, вызываемый при загрузке формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            _stations.OnAdd += s => StationsComboBox.Items.Add(s.Title);
            _stations.OnRemove += s => StationsComboBox.Items.Remove(s.Title);
            _stations.OnUpdate += (s, i) => StationsComboBox.Items[i] = s.Title;
            _stations.AddRange(
                new Station("Пенза 1", 120, 3020, "+79875634543", 78.6, DateTime.Now, "Володарского 12"),
                new Station("Пенза 2", 10, 3020, "+79888888883", 234.9, DateTime.Now, "Володарского 13"),
                new Station("Пенза 3", 12370, 3020, "+71234567890", 13.2, DateTime.Now, "Володарского 14")
            );
            StationsComboBox.SelectedIndex = 0;
            FieldsLabelsComboBox.SelectedIndex = 0;
            DateOfOpening.Format = DateTimePickerFormat.Custom;
            DateOfOpening.CustomFormat = "dd MM yyyy";
            _stations.OnAdd += s => _messageForm.Show("Добавлена новая станция");
            _stations.OnRemove += s => _messageForm.Show($"Станция {s.Title} удалена");
            //MessageBox.Show("Годов и Поршнев 22ВП1\nВариант 3", "Лабораторная работа №2");
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
                    StationsComboBox.Enabled = false;
                    return;
                }
            UpdateStationBtn.Enabled = true;
            AddNewStationBtn.Enabled = true;
            StationsComboBox.Enabled = true;
        }

        /// <summary>
        /// Метод устанавливает отображает информацию в виде строки
        /// </summary>
        private void SetInfoLabel()
        {
            InfoLabel.Text = $"Всего станций: {Station.TotalStations}\n" +
                $"{_stations[StationsComboBox.SelectedIndex]}";
        }

        /// <summary>
        /// Метод устанавливает в текстбоксы поля выбранного вокзала
        /// </summary>
        private void SetStationInfo()
        {
            Station station = _stations[StationsComboBox.SelectedIndex];
            Title.Text = station.Title;
            NumberOfSeats.Text = station.NumberOfSeats.ToString();
            SoldTickets.Text = station.SoldTickets.ToString();
            Number.Text = station.Number;
            AverageAttendace.Text = station.AverageAttendace.ToString();
            DateOfOpening.Value = station.DateOfOpening;
            Address.Text = station.Address;
            SetInfoLabel();
        }

        private void Stations_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetStationInfo();
            FieldsLabels_SelectedIndexChanged(sender, e);
        }

        /// <summary>
        /// Метод вызызывается при нажатии на кнопку "Сохранить"
        /// Обновляет поля выбранного вокзала
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateStationBtn_Click(object sender, EventArgs e)
        {
            Station station = _stations[StationsComboBox.SelectedIndex];
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
            _stations[StationsComboBox.SelectedIndex] = station;
            SetInfoLabel();
            if (FieldsLabelsComboBox.SelectedIndex >= 0)
                FieldsLabels_SelectedIndexChanged(FieldsLabelsComboBox, e);
        }

        /// <summary>
        /// Метод вызызывается при нажатии на кнопку "Добавить новый"
        /// Создаёт новый вокзал и добавляет его в список вокзалов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNewStationBtn_Click(object sender, EventArgs e)
        {
            UpdateStationBtn_Click(sender, e);
            DeleteStationBtn.Enabled = true;
            Station station = new Station("Новый вокзал");
            _stations.Add(station);
            StationsComboBox.SelectedIndex = _stations.Count - 1;
        }

        /// <summary>
        /// Метод вызызывается при нажатии на кнопку "Удалить текущий"
        /// Удаляет выбранный вокзал
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

        private void ComparisonBtn_Click(object sender, EventArgs e)
        {
            ComparisonForm comparisonForm = new ComparisonForm();
            comparisonForm.Show();
        }
    }
}
