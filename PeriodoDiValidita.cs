using System;

namespace Trainary
{
    public struct PeriodoDiValidita
    {
        private readonly DateTime _dataInizio;
        private readonly DateTime _dataFine;

        public PeriodoDiValidita(DateTime dataInizio, DateTime dataFine)
        {
            if (DateTime.Compare(dataFine, dataInizio) < 0)
                throw new ArgumentException("dataFine is before dataInizio");

            _dataInizio = dataInizio.Date;
            _dataFine = dataFine.Date;
        }

        public PeriodoDiValidita(DateTime dataInizio, TimeSpan durata) : this(dataInizio, dataInizio+durata)
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
            return FormatUtils.ToStringDate(_dataInizio) + "-" + FormatUtils.ToStringDate(_dataFine);
        }

        public string FullToString()
        {
            return "Periodo di validità: da " +
                FormatUtils.ToStringDate(_dataInizio) + " a " +
                FormatUtils.ToStringDate(_dataFine);
        }
    }
}