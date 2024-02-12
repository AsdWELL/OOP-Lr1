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
        public class NegativeValueException : Exception
        {
            public NegativeValueException(string msg) : base($"{msg} не может быть отрицательнным числом") { }
        }

        public class WrongNumberFormatException : Exception
        {
            public WrongNumberFormatException() : base("Неверный формат номера") { }
        }

        public class InvalidYearOfOpeningException : Exception
        {
            public InvalidYearOfOpeningException(int year) : base($"Год открытия не может быть меньше 1931 и больше {year}") { }
        }

        public string Title { get; set; }
        private int _numberOfSeats;
        public int NumberOfSeats
        {
            get => _numberOfSeats;
            set
            {
                if (value < 0)
                    throw new NegativeValueException("Число сидений");
                _numberOfSeats = value;
            }
        }
        private int _soldTickets;
        public int SoldTickets
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
                if (!Regex.IsMatch(value, @"^((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}$"))
                    throw new WrongNumberFormatException();
                _number = value;
            }
        }
        private double _averageAttendace;
        public double AverageAttendace
        {
            get => _averageAttendace;
            set
            {
                if (value < 0)
                    throw new NegativeValueException("Средняя посещаемость");
                _averageAttendace = value;
            }
        }
        private double _yearOfOpening;
        public double YearOfOpening
        {
            get => _yearOfOpening;
            set
            {
                int currentYear = DateTime.Now.Year;
                if (value < 1931 || value > currentYear)
                    throw new InvalidYearOfOpeningException(currentYear);
                _yearOfOpening = value;
            }
        }
        public string Address { get; set; }
        public static int TotalStations { get; private set; }
        public Station() => TotalStations++;

        public Station(string title, int numberOfSeats) : this()
        {
            Title = title;
            NumberOfSeats = numberOfSeats;
        }

        public Station(string title, int numberOfSeats, int soldTickets,
            string number, double averageAttendace, double yearOfOpening, string address) : this()
        {
            NumberOfSeats = numberOfSeats;
            _soldTickets = soldTickets;
            SoldTickets = soldTickets;
            _number = number;
            Number = number;
            _averageAttendace = averageAttendace;
            AverageAttendace = averageAttendace;
            _yearOfOpening = yearOfOpening;
            YearOfOpening = yearOfOpening;
            Address = address;
        }

       
    }
}
