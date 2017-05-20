using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainary
{
    public class EsercizioSvolto
    {
        private Esercizio _esercizio;
        private List<Attributo> _dati;
        public EsercizioSvolto(Esercizio esercizio)
        {
            if (esercizio == null)
                throw new ArgumentException("esercizio");
            _esercizio = esercizio;
            _dati = new List<Attributo>();
        }
        public void AggiungiDato(Attributo dato)
        {
            if (dato == null)
                throw new ArgumentException("dato");
            if (!_dati.Contains(dato))
                _dati.Add(dato);
        }
        public void RimuoviDato(Attributo dato)
        {
            if(_dati.Contains(dato))
            _dati.Remove(dato);
        }
    }
}
