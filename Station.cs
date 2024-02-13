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

        public class NegativeValueException : Exception
        {
            public NegativeValueException(string msg) : base($"{msg} не может быть отрицательнным числом") { }
        }

        public class WrongNumberFormatException : Exception
        {
            public WrongNumberFormatException() : base("Неверный формат номера") { }
        }

        public class InvalidDateOfOpeningException : Exception
        {
            public InvalidDateOfOpeningException() : base("Некорректная дата") { }
        }

        public string Title { get; set; }

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

        private DateTime _dateOfOpening;
        public DateTime DateOfOpening
        {
            get => _dateOfOpening;
            set
            {
                DateTime currentDate = DateTime.Now;
                if (value.Year < 1931 || value > currentDate)
                    throw new InvalidDateOfOpeningException();
                _dateOfOpening = value;
            }
        }

        public string Address { get; set; }

        public static int TotalStations { get; private set; }

        public Station()
        {
            TotalStations++;
            DateOfOpening = DateTime.Now;
        }

        public Station(string title) : this()
        {
            Title = title;
        }

        public Station(string title, int numberOfSeats) : this()
        {
            Title = title;
            NumberOfSeats = numberOfSeats;
        }

        public Station(string title, int numberOfSeats, int soldTickets,
            string number, double averageAttendace, DateTime yearOfOpening, string address) : this()
        {
            Title = title;
            NumberOfSeats = numberOfSeats;
            SoldTickets = soldTickets;
            Number = number;
            AverageAttendace = averageAttendace;
            DateOfOpening = yearOfOpening;
            Address = address;
        }

        public string NumberOfSeatsToHex()
        {
            if (NumberOfSeats == null)
                return "";
            return Convert.ToString((int)NumberOfSeats, 16);
        }

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
}
