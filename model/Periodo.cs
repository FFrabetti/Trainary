using System;

namespace Trainary.model
{
    public struct Periodo
    {
        public static string ToStringDate(DateTime dateTime)
        {
            return dateTime.ToString("d");
        }

        private readonly DateTime _dataInizio;
        private readonly DateTime _dataFine;

        public Periodo(DateTime dataInizio, DateTime dataFine)
        {
            if (DateTime.Compare(dataFine, dataInizio) < 0)
                throw new ArgumentException("dataFine is before dataInizio");

            _dataInizio = dataInizio.Date;
            _dataFine = dataFine.Date;
        }

        public Periodo(DateTime dataInizio, TimeSpan durata) : this(dataInizio, dataInizio+durata)
        {
        }

        public DateTime DataInizio { get { return _dataInizio; } }

        public DateTime DataFine { get { return _dataFine; } }

        public bool IsNelPeriodo(DateTime data)
        {
            return _dataInizio.CompareTo(data) <= 0 && _dataFine.CompareTo(data) >= 0;
        }

        public TimeSpan GetDurata()
        {
            return DataFine - DataInizio;
        }

        public override string ToString()
        {
            return ToStringDate(_dataInizio) + "-" + ToStringDate(_dataFine);
        }

        public string FullToString()
        {
            return "Periodo di validità: da " +
                ToStringDate(_dataInizio) + " a " +
                ToStringDate(_dataFine);
        }
    }
}