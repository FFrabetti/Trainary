using System;
using System.Collections.Generic;
using System.Linq;
using Trainary.model.attributi;
using static Trainary.model.attributi.QuantitaFactory;

namespace Trainary.persistence
{
    class AttributiDataManager : IDataManager<Attributo>
    {
        private Random random = new Random();

        private Durata GetRandomDurata()
        {
            return new Durata(random.Next(24), random.Next(60), random.Next(60));
        }

        private NumeroPuro GetRandomNumeroPuro()
        {
            return new NumeroPuro(random.Next(32));
        }

        private Quantita GetRandomUnitValue(TipoQuantita tipo)
        {
            IEnumerable<UnitaDiMisura> units = UnitaFactory.GetAllOfType(tipo);
            UnitaDiMisura unita = units.ElementAt(random.Next(units.Count()));

            return QuantitaFactory.NewQuantita(random.NextDouble() * 100, unita);
        }

        public IEnumerable<Attributo> GetElements()
        {
            List<Attributo> list = new List<Attributo>();

            Attributo a = null;
            for (int i = 0; i<random.Next(4); i++)
            {
                switch (random.Next(4))
                {
                    case 0:
                        a =new Attributo("durata", GetRandomDurata());
                        break;
                    case 1:
                        a = new Attributo("ripetizione", GetRandomNumeroPuro());
                        break;
                    case 2:
                        a = new Attributo("distanza", GetRandomUnitValue(TipoQuantita.LUNGHEZZA));
                        break;
                    case 3:
                        a = new Attributo("peso", GetRandomUnitValue(TipoQuantita.MASSA));
                        break;
                }
                list.Add(a);
            }

            return list;
        }

        public void SaveElements(IEnumerable<Attributo> elements)
        {
            throw new NotImplementedException();
        }
    }
}
