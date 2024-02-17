using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr1
{
    public delegate void ChangeStationsHandler(Station station);
    public delegate void UpdateStationHandler(Station station, int index);

    /// <summary>
    /// Представляет исключение, возникающее при отсутствии указанной станции в списке
    /// </summary>
    public class StationNotInListException : Exception
    {
        public StationNotInListException(string title) : base($"Станции с названием {title} нет в списке") { }
    }

    /// <summary>
    /// Представляет коллекцию станций
    /// </summary>
    public class StationList : IEnumerable
    {
        private List<Station> _stations;

        /// <summary>
        /// Событие на добавление станций в коллекцию
        /// </summary>
        public event ChangeStationsHandler? OnAdd;

        /// <summary>
        /// Событие на удаление станций из коллекции
        /// </summary>
        public event ChangeStationsHandler? OnRemove;

        /// <summary>
        /// Событие на изменение станции в коллекции
        /// </summary>
        public event UpdateStationHandler? OnUpdate;

        /// <summary>
        /// Количество элементов
        /// </summary>
        public int Count
        {
            get => _stations.Count;
        }

        /// <summary>
        /// Индексатор
        /// </summary>
        /// <param name="index">Индекс станции</param>
        /// <returns>Станция по текущему индексу</returns>
        public Station this[int index]
        {
            get
            {
                if (index >= Count || index < 0)
                    throw new IndexOutOfRangeException();
                return _stations[index];
            }
            set
            {
                OnUpdate?.Invoke(value, index);
                _stations[index] = value;
            }
        }

        /// <summary>
        /// Индексатор
        /// </summary>
        /// <param name="title">Название станции</param>
        /// <returns>Станция с указанным названием</returns>
        /// <exception cref="StationNotInListException"></exception>
        public Station this[string title]
        {
            get
            {
                Station? station = _stations.Find(s => s.Title == title);
                return station ??
                    throw new StationNotInListException(title);
            }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        public StationList()
        {
            _stations = new List<Station>();
        }

        /// <summary>
        /// Добавляет новую станцию
        /// </summary>
        /// <param name="station">Станция</param>
        public void Add(Station station)
        {
            _stations.Add(station);
            OnAdd?.Invoke(station);
        }

        /// <summary>
        /// Добавляет несколько станций
        /// </summary>
        /// <param name="stations">Набор станций</param>
        public void AddRange(params Station[] stations)
        {
            foreach (Station station in stations)
                Add(station);
        }

        /// <summary>
        /// Удаляет станцию по индексу
        /// </summary>
        /// <param name="index">Индекс станции</param>
        public void RemoveAt(int index)
        {
            Station station = _stations[index];
            _stations.RemoveAt(index);
            Station.TotalStations--;
            OnRemove?.Invoke(station);
        }

        /// <summary>
        /// Удаляет станцию по названию
        /// </summary>
        /// <param name="title">Название станции</param>
        public void Remove(string title) 
        {
            Station? station = _stations.Find(s => s.Title == title) ??
                throw new StationNotInListException(title);
            _stations.Remove(station);
            Station.TotalStations--;
            OnRemove?.Invoke(station);
        }

        private class StationEnumerator : IEnumerator
        {
            private List<Station> _list;
            private int pos = -1;
            
            public StationEnumerator(List<Station> list) => _list = list;

            public object Current
            {
                get
                {
                    try
                    {
                        return _list[pos];
                    }
                    catch
                    {
                        throw new InvalidOperationException();
                    }
                }
            }

            public bool MoveNext() => ++pos < _list.Count;

            public void Reset() => pos = -1;
        }

        public IEnumerator GetEnumerator()
        {
            return new StationEnumerator(_stations);
        }
    }
}
