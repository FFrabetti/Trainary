using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trainary.model;

namespace Trainary.persistence
{
    class AllenamentiDataManager : IDataManager<Allenamento>
    {
        private Random random = new Random();
        private IDataManager<Esercizio> _eserciziDM;
        private IDataManager<Seduta> _seduteDM;

        public AllenamentiDataManager()
        {
            _eserciziDM = new EserciziDataManager(new CategorieDataManager(), new AttributiDataManager());
            _seduteDM = new SeduteDataManager(new SchedeDataManager(), _eserciziDM);
        }

        private List<EsercizioSvolto> GetEserciziSvolti()
        {
            List<EsercizioSvolto> lista = new List<EsercizioSvolto>();

            foreach (Esercizio es in _eserciziDM.GetElements())
            {
                SvolgiVisitor visitor = new SvolgiVisitor();
                es.Accept(visitor);
                lista.Add(visitor.EsercizioSvolto);
            }

            return lista;
        }

        private List<EsercizioSvolto> GetEserciziSvolti(Seduta s)
        {
            List<EsercizioSvolto> lista = new List<EsercizioSvolto>();

            foreach (Esercizio es in s.Esercizi)
            {
                if (random.NextDouble() >= 0.5)
                    continue;

                SvolgiVisitor visitor = new SvolgiVisitor();
                es.Accept(visitor);
                lista.Add(visitor.EsercizioSvolto);
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
                    "AllExtra " + i
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
