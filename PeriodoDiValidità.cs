using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainary
{
    public struct PeriodoDiValidità
    {
        private DateTime _dataInizio, _dataFine;
        public PeriodoDiValidità(DateTime dataInizio, DateTime dataFine)
        {
            // controllo sulle date
            if (dataInizio == null)
                throw new ArgumentNullException("dataInizio");
            if (dataFine == null)
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
        }

        public TimeSpan GetDurata()
        {
            return _dataFine - _dataInizio;

        }
        public override string ToString()
        {
            // da stampare con il locale corrente
            return "da "+_dataInizio+" a "+DataFine;
        }
    }
}
