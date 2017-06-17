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
            _dataInizio = dataInizio.Date;
            _dataFine = dataFine.Date;

            if (_dataFine < _dataInizio)
                throw new ArgumentException("dataFine is before dataInizio");
        }

        public Periodo(DateTime dataInizio, TimeSpan durata)
            : this(dataInizio, dataInizio+durata) { }

        public DateTime DataInizio
        {
            get { return _dataInizio; }
        }

        public DateTime DataFine
        {
            get { return _dataFine; }
        }

        public TimeSpan Durata
        {
            get { return DataFine - DataInizio; }
        }

        public bool IsNelPeriodo(DateTime data)
        {
            return _dataInizio <= data && _dataFine >= data;
        }

        public override string ToString()
        {
            return ToStringDate(_dataInizio) + "-" + ToStringDate(_dataFine);
        }

        internal string ToFullString()
        {
            return "Periodo: da " +
                ToStringDate(_dataInizio) + " a " +
                ToStringDate(_dataFine);
        }
    }
}