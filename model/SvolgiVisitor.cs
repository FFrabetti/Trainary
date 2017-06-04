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
