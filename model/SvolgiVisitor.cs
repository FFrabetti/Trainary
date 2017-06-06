using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainary.model
{
    public class SvolgiVisitor : Visitor
    {
        private EsercizioSvolto _esercizioSvolto = null ;
        public void Visit(EsercizioSingolo esercizioSingolo)
        {
            _esercizioSvolto = new EsercizioSingoloSvolto(esercizioSingolo);
        }

        public void Visit(Circuito circuito)
        {
            CircuitoSvolto circuitoSvolto = new CircuitoSvolto(circuito);
            foreach (Esercizio e in circuito.Esercizi)
            {
                e.Accept(this);
                EsercizioSvolto esercizioSvolto = this.EsercizioSvolto;
                circuitoSvolto.SottoEserciziSvolti.Add(esercizioSvolto);
            }
            _esercizioSvolto = circuitoSvolto;
        }

        public void Visit(Esercizio esercizio)
        {
            //Type type = esercizio.GetType();
            //switch (type)
            //{
            //    case typeof(EsercizioSingolo):
            //        Visit((EsercizioSingolo)esercizio);
            //        break;
            //    case typeof(Circuito):
            //        Visit((Circuito)esercizio);
            //        break;
            //    default:
            //        throw new ArgumentException("esercizio");

            //}

            if (esercizio.GetType().Equals(typeof(EsercizioSingolo)))
                Visit((EsercizioSingolo)esercizio);
            else if (esercizio.GetType().Equals(typeof(Circuito)))
                Visit((Circuito)esercizio);
            else throw new ArgumentException("esercizio");
        }

        public EsercizioSvolto EsercizioSvolto
        {
            get
            {
                if (_esercizioSvolto == null)
                    throw new Exception("è necessario eseguire prima la accept");
                return _esercizioSvolto;
            }
        }
    }
}
