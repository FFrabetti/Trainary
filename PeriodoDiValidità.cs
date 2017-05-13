using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainary
{
    public struct PeriodoDiValidità
    {
        private readonly DateTime _dataInizio;
        private readonly DateTime _dataFine;

        public PeriodoDiValidità(DateTime dataInizio, DateTime dataFine)
        {
            if (dataInizio == null || (DateTime.Compare(dataInizio, DateTime.Today) < 0))
                throw new ArgumentNullException("dataInizio");
            if (dataFine == null || (DateTime.Compare(dataFine, dataInizio) <= 0))
                throw new ArgumentNullException("dataFine");

            _dataInizio = dataInizio;
            _dataFine = dataFine;
        }

        public PeriodoDiValidità(DateTime dataInizio, TimeSpan durata) : this(dataInizio, dataInizio+durata)
        {

        }

        public DateTime DataInizio { get { return _dataInizio; } }

        public DateTime DataFine { get { return _dataFine; } }

        public bool IsNelPeriodo(DateTime data)
        {
            return data.CompareTo(_dataInizio) >= 0 && data.CompareTo(_dataFine) <= 0;

            //return (DateTime.Compare(data, _dataInizio) >= 0) && (DateTime.Compare(data, _dataFine) <= 0);
        }

        public TimeSpan GetDurata()
        {
            return DataFine - DataInizio;
        }

        public override string ToString()
        {
            return "Periodo di validità:\nda " + _dataInizio.ToLocalTime().ToString() + " a " + _dataFine.ToLocalTime().ToString();
        }
    }
}