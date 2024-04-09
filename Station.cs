using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Lr1
{
    /// <summary>
    /// Представляет вокзал
    /// </summary>
    public abstract class Station
    {
        public enum Fields
        {
            Title,
            NumberOfSeats,
            SoldTickets,
            Number,
            AverageAttendace,   
            DateOfOpening,
            Address
        }

        /// <summary>
        /// Год открытия первого вокзала
        /// </summary>
        public const int FirstStationYearOfOpening = 1931;

        /// <summary>
        /// Название вокзала
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Количество мест
        /// </summary>
        private int? _numberOfSeats;
        public int? NumberOfSeats
        {
            get => _numberOfSeats;
            set
            {
                if (value < 0)
                    throw new NegativeValueException("Число сидений");
                _numberOfSeats = value;
            }
        }

        /// <summary>
        /// Количество проданных билетов
        /// </summary>
        private int? _soldTickets;
        public int? SoldTickets
        {
            get => _soldTickets;
            set
            {
                if (value < 0)
                    throw new NegativeValueException("Количество проданных билетов");
                _soldTickets = value;
            }
        }

        /// <summary>
        /// Проверяет формат телефонного номера и сохраняет его, если он корректный
        /// </summary>
        /// <param name="rawNumber">Номер телефона</param>
        /// <returns>True, если номер корректный, иначе False</returns>
        public bool CheckAndSetPhoneNumber(string rawNumber)
        {
            if (!Regex.IsMatch(rawNumber, @"^((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{10}$"))
                return false;
            PhoneNumber = rawNumber;
            return true;
        }

        /// <summary>
        /// Телефонный номер вокзала
        /// </summary>
        private string _phoneNumber;
        public string PhoneNumber
        {
            get => _phoneNumber;
            private set => _phoneNumber = value;
        }

        /// <summary>
        /// Средняя посещаемость
        /// </summary>
        private double? _averageAttendace;
        public double? AverageAttendace
        {
            get => _averageAttendace;
            set
            {
                if (value < 0)
                    throw new NegativeValueException("Средняя посещаемость");
                _averageAttendace = value;
            }
        }

        /// <summary>
        /// Проверяет корректность даты и, если она корректна, сохраняет её
        /// </summary>
        /// <param name="dateOfOpening">Дата открытия вокзала</param>
        /// <returns>True, если дата корректная, иначе False</returns>
        public bool CheckAndSetDateOtOpening(DateTime dateOfOpening)
        {
            DateTime currentDate = DateTime.Now;
            if (dateOfOpening.Year < FirstStationYearOfOpening || dateOfOpening > currentDate)
                return false;
            DateOfOpening = dateOfOpening;
            return true;
        }

        /// <summary>
        /// Дата открытия
        /// </summary>
        private DateTime _dateOfOpening;
        public DateTime DateOfOpening
        {
            get => _dateOfOpening;
            private set => _dateOfOpening = value;
        }

        /// <summary>
        /// Адрес вокзала
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Количество созданных вокзалов
        /// </summary>
        public static int TotalStations { get; set; }

        public abstract double TicketCost { get; }

        /// <summary>
        /// Конструктор бзе параметров
        /// </summary>
        public Station()
        {
            TotalStations++;
            DateOfOpening = DateTime.Now;
        }

        /// <summary>
        /// Конструктор, принимающий название возкала
        /// </summary>
        /// <param name="title">Название вокзала</param>
        public Station(string title) : this()
        {
            Title = title;
        }

        /// <summary>
        /// Конструктор принимающий название вокзала и количестов мест
        /// </summary>
        /// <param name="title">Название вокзала</param>
        /// <param name="numberOfSeats">Количество мест</param>
        public Station(string title, int numberOfSeats) : this(title)
        {
            NumberOfSeats = numberOfSeats;
        }

        /// <summary>
        /// Конструктор со всемии параметрами
        /// </summary>
        /// <param name="title">Название вокзала</param>
        /// <param name="numberOfSeats">Количество мест</param>
        /// <param name="soldTickets">Количество проданных билетов</param>
        /// <param name="number">Номер вокзала</param>
        /// <param name="averageAttendace">Средняя посещаемость</param>
        /// <param name="dateOfOpening">Дата открытия</param>
        /// <param name="address">Адрес вокзала</param>
        public Station(string title, int numberOfSeats, int soldTickets,
            string number, double averageAttendace, DateTime dateOfOpening, string address) : this(title, numberOfSeats)
        {
            SoldTickets = soldTickets;
            PhoneNumber = number;
            AverageAttendace = averageAttendace;
            DateOfOpening = dateOfOpening;
            Address = address;
        }

        public Station(Station station)
        {
            Title = station.Title;
            NumberOfSeats = station.NumberOfSeats;
            SoldTickets = station.SoldTickets;
            PhoneNumber = station.PhoneNumber;
            AverageAttendace = station.AverageAttendace;
            DateOfOpening = station.DateOfOpening;
            Address = station.Address;
        }

        /// <summary>
        /// Метод возращает количеств мест в 16 СС
        /// </summary>
        /// <returns></returns>
        public string NumberOfSeatsToHex()
        {
            if (NumberOfSeats == null)
                return string.Empty;
            return Convert.ToString((int)NumberOfSeats, 16);
        }

        /// <summary>
        /// Метод возвращает значение поля по его названию
        /// </summary>
        /// <param name="fieldName">Название поля</param>
        /// <returns></returns>
        public string? GetFieldValue(Fields fieldName) =>
            fieldName switch
            {
                Fields.Title => Title,
                Fields.NumberOfSeats => NumberOfSeatsToHex(),
                Fields.Number => PhoneNumber,
                Fields.SoldTickets => SoldTickets.ToString(),
                Fields.AverageAttendace => AverageAttendace.ToString(),
                Fields.DateOfOpening => DateOfOpening.ToString("d"),
                Fields.Address => Address,
                _ => "",
            };

        /// <summary>
        /// Метод возвращает строковое представление вокзала
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (Title != null) sb.Append($"Название вокзала: {Title}\n");
            if (NumberOfSeats != null) sb.Append($"Количество мест: {NumberOfSeats}\n");
            if (SoldTickets != null) sb.Append($"Продано билетов: {SoldTickets}\n");
            if (PhoneNumber != null) sb.Append($"Номер: {PhoneNumber}\n");
            if (AverageAttendace != null) sb.Append($"Средняя посещаемость: {AverageAttendace}\n");
            if (DateOfOpening.Year != 1) sb.Append($"Дата открытия: {DateOfOpening.ToString("d")}\n");
            if (Address != null) sb.Append($"Адрес: {Address}\n");
            return sb.ToString();
        }
    }

    /// <summary>
    /// Представляет исключение, возникающее при отрицательном значении числового поля 
    /// </summary>
    public class NegativeValueException : Exception
    {
        public NegativeValueException(string msg) : base($"{msg} не может быть отрицательнным числом") { }
    }
}
