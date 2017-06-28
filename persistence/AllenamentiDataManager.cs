using System;
using System.Collections.Generic;
using System.Linq;
using Trainary.model;
using Trainary.model.attributi;

namespace Trainary.persistence
{
    class AllenamentiDataManager : IDataManager<Allenamento>
    {
        private Random random = new Random();
        private IDataManager<Esercizio> _eserciziDM;
        private IDataManager<Seduta> _seduteDM;
        private IDataManager<Attributo> _attributiDM;

        public AllenamentiDataManager(IDataManager<Esercizio> eserciziDM, IDataManager<Seduta> seduteDM, IDataManager<Attributo> attributiDM)
        {
            _eserciziDM = eserciziDM;
            _seduteDM = seduteDM;
            _attributiDM = attributiDM;
        }

        private EsercizioSvolto SvolgiEsercizio(Esercizio es)
        {
            SvolgiVisitor visitor = new SvolgiVisitor();
            es.Accept(visitor);
            AggiungiDati(visitor.EsercizioSvolto);
            return visitor.EsercizioSvolto;
        }

        private void AggiungiDati(EsercizioSvolto es)
        {
            es.Dati.AddRange(_attributiDM.GetElements());
        }

        private List<EsercizioSvolto> GetEserciziSvolti()
        {
            List<EsercizioSvolto> lista = new List<EsercizioSvolto>();

            foreach (Esercizio es in _eserciziDM.GetElements())
            {
                lista.Add(SvolgiEsercizio(es));
            }
            return lista;
        }

        private List<EsercizioSvolto> GetEserciziSvolti(Seduta s)
        {
            List<EsercizioSvolto> lista = new List<EsercizioSvolto>();

            foreach (Esercizio es in s.Esercizi)
            {
                if (random.NextDouble() < 0.7) // alcuni es non vengono svolti
                    lista.Add(SvolgiEsercizio(es));
            }
            return lista;
        }

        private Seduta GetRandomSeduta()
        {
            IEnumerable<Seduta> sedute = _seduteDM.GetElements();
            return sedute.ElementAt(random.Next(sedute.Count()));
        }

        public IEnumerable<Allenamento> GetElements()
        {
            List<Allenamento> lista = new List<Allenamento>();

            for(int i=0; i<random.Next(10)+10; i++)
            {
                lista.Add(new AllenamentoExtra(
                    DateTime.Today.AddDays(-random.Next(31)),
                    GetEserciziSvolti().ToArray(),
                    // proviamo anche allenamenti senza nome
                    ((random.NextDouble()>0.7) ? "" : "AllExtra " + i)
                ));
            }

            for (int i = 0; i < random.Next(10) + 10; i++)
            {
                try
                {
                    Seduta s = GetRandomSeduta();
                    lista.Add(new AllenamentoProgrammato(
                        DateTime.Today.AddDays(-random.Next(31)),
                        GetEserciziSvolti(s).ToArray(),
                        s
                    ));
                }
                catch { }
            }

            return lista;
        }

        public void SaveElements(IEnumerable<Allenamento> elements)
        {
            throw new NotImplementedException();
        }
    }
}
