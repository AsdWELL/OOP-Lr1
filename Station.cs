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
    public class Station
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
        /// Номер вокзала
        /// </summary>
        private string _number;
        public string Number
        {
            get => _number;
            set
            {
                if (!Regex.IsMatch(value, @"^((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{10}$"))
                    throw new WrongNumberFormatException();
                _number = value;
            }
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
        /// Дата открытия
        /// </summary>
        private DateTime _dateOfOpening;
        public DateTime DateOfOpening
        {
            get => _dateOfOpening;
            set
            {
                DateTime currentDate = DateTime.Now;
                if (value.Year < FirstStationYearOfOpening || value > currentDate)
                    throw new InvalidDateOfOpeningException();
                _dateOfOpening = value;
            }
        }

        /// <summary>
        /// Адрес вокзала
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Количество созданных вокзалов
        /// </summary>
        public static int TotalStations { get; set; }

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
            Number = number;
            AverageAttendace = averageAttendace;
            DateOfOpening = dateOfOpening;
            Address = address;
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
                Fields.Number => Number,
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
            if (Number != null) sb.Append($"Номер: {Number}\n");
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

    /// <summary>
    /// Представляет исключение, возникающее при неверном формате номера
    /// </summary>
    public class WrongNumberFormatException : Exception
    {
        public WrongNumberFormatException() : base("Неверный формат номера") { }
    }

    /// <summary>
    /// Представляет исключение, возникающее при некорректной дате открытия
    /// </summary>
    public class InvalidDateOfOpeningException : Exception
    {
        public InvalidDateOfOpeningException() : base("Некорректная дата") { }
    }
}
