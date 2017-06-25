using System;
using System.Collections.Generic;

namespace Trainary.model
{
    public class SvolgiVisitor : Visitor
    {
        private EsercizioSvolto _esercizioSvolto = null;

        public void Visit(EsercizioSingolo esercizioSingolo)
        {
            _esercizioSvolto = new EsercizioSingoloSvolto(esercizioSingolo);
        }

        public void Visit(Circuito circuito)
        {
            List<EsercizioSvolto> esSvolti = new List<EsercizioSvolto>();

            foreach (Esercizio e in circuito.Esercizi)
            {
                e.Accept(this);
                esSvolti.Add(EsercizioSvolto);
            }

            _esercizioSvolto = new CircuitoSvolto(circuito, esSvolti.ToArray());
        }

        public void Visit(Esercizio esercizio)
        {
            if (esercizio is EsercizioSingolo)
                Visit((EsercizioSingolo)esercizio);
            else if (esercizio is Circuito)
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
