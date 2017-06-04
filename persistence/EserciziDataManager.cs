using System;
using System.Collections.Generic;
using System.Linq;
using Trainary.model;
using Trainary.model.attributi;

namespace Trainary.persistence
{
    class EserciziDataManager : IDataManager<Esercizio>
    {
        private Random random;
        private IDataManager<Attributo> _attributiDM;
        private List<Attivita> attivita;

        public EserciziDataManager(IDataManager<Categoria> categorieDM, IDataManager<Attributo> attributiDM)
        {
            random = new Random();
            _attributiDM = attributiDM;
            attivita = new List<Attivita>();

            AddAttivitaRic(attivita, categorieDM.GetElements().ElementAt(0));
        }

        private void AddAttivitaRic(List<Attivita> attivita, Categoria categoria)
        {
            if (categoria.SottoCategorie.Count == 0)
                attivita.AddRange(categoria.Attivita);

            else
                foreach (Categoria c in categoria.SottoCategorie)
                    AddAttivitaRic(attivita, c);
        }

        private Attivita GetRandomAttivita()
        {
            return attivita.ElementAt(random.Next(attivita.Count));
        }

        private Esercizio GetRandomEsercizio()
        {
            // esercizio singolo
            if (random.NextDouble() > 0.1)
                return new EsercizioSingolo(GetRandomAttivita(), _attributiDM.GetElements().ToArray());

            // circuito (deve contenere almeno 2 es)
            List<Esercizio> esercizi = new List<Esercizio>();
            for(int i=0; i<random.Next(4) + 2; i++)
            {
                esercizi.Add(GetRandomEsercizio());
            }
            return new Circuito(esercizi.ToArray());
        }

        public IEnumerable<Esercizio> GetElements()
        {
            List<Esercizio> list = new List<Esercizio>();

            for (int i = 0; i < random.Next(4) + 8; i++)
                list.Add(GetRandomEsercizio());

            return list;
        }

        public void SaveElements(IEnumerable<Esercizio> elements)
        {
            throw new NotImplementedException();
        }
    }
}
