using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr1
{
    public class BusStation : Station
    {
        /// <summary>
        /// Конструктор бзе параметров
        /// </summary>
        public BusStation() : base() { }

        /// <summary>
        /// Конструктор, принимающий название возкала
        /// </summary>
        /// <param name="title">Название вокзала</param>
        public BusStation(string title) : base(title) { }

        /// <summary>
        /// Конструктор принимающий название вокзала и количестов мест
        /// </summary>
        /// <param name="title">Название вокзала</param>
        /// <param name="numberOfSeats">Количество мест</param>
        public BusStation(string title, int numberOfSeats) : base(title, numberOfSeats) { }

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
        public BusStation(string title, int numberOfSeats, int soldTickets,
            string number, double averageAttendace, DateTime dateOfOpening, string address) 
            : base(title, numberOfSeats, soldTickets, number, averageAttendace, dateOfOpening, address) { }

        public override double TicketCost { get; } = 1500;

        public override string ToString()
        {
            return "Автобусный вокзал\n" + base.ToString();
        }
    }
}
