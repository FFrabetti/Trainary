using System;
using System.Collections.Generic;
using System.Text;
using Trainary.model.attributi;

namespace Trainary.model
{
    public abstract class EsercizioSvolto
    {
        private readonly Esercizio _esercizio;
        private readonly List<Attributo> _dati;

        public EsercizioSvolto(Esercizio esercizio)
        {
            if (esercizio == null)
                throw new ArgumentNullException("esercizio");

            _esercizio = esercizio;
            _dati = new List<Attributo>();
        }

        public Esercizio Esercizio
        {
            get { return _esercizio; }
        }

        public List<Attributo> Dati
        {
            get { return _dati; }
        }

        public abstract List<EsercizioSvolto> SottoEserciziSvolti
        { get; }
       
             public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Esercizio.ToString());
            //sb.Append(" ");
            
            //foreach (Attributo dato in _dati)
            //{
            //    sb.Append(dato);
            //    sb.Append(" ");
            //}
            //foreach(EsercizioSvolto es in SottoEserciziSvolti)
            //{
            //    sb.Append(es);
            //}
            return sb.ToString();
        }
    
    }
}
