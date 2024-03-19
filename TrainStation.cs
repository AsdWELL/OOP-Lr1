﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr1
{
    public class TrainStation : Station
    {
        /// <summary>
        /// Конструктор бзе параметров
        /// </summary>
        public TrainStation() : base() { }

        /// <summary>
        /// Конструктор, принимающий название возкала
        /// </summary>
        /// <param name="title">Название вокзала</param>
        public TrainStation(string title) : base(title) { }

        /// <summary>
        /// Конструктор принимающий название вокзала и количестов мест
        /// </summary>
        /// <param name="title">Название вокзала</param>
        /// <param name="numberOfSeats">Количество мест</param>
        public TrainStation(string title, int numberOfSeats) : base(title, numberOfSeats) { }

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
        public TrainStation(string title, int numberOfSeats, int soldTickets,
            string number, double averageAttendace, DateTime dateOfOpening, string address)
            : base(title, numberOfSeats, soldTickets, number, averageAttendace, dateOfOpening, address) { }

        public override string ToString()
        {
            return "Ж/д вокзал\n" + base.ToString();
        }
    }
}