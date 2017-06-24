using System;
using System.Collections.Generic;
using System.Text;
using Trainary.model;

namespace Trainary.persistence
{
    class SchedeDataManager : IDataManager<Scheda>
    {
        private Random random = new Random();
        private IEnumerable<Scheda> _schede;

        private ScopoDellaScheda GetRandomScopo()
        {
            ScopoDellaScheda[] scopi = (ScopoDellaScheda[])Enum.GetValues(typeof(ScopoDellaScheda));

            return scopi[random.Next(scopi.Length)];
        }

        private string GetRandomDesc()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < random.Next(5); i++)
                sb.Append("descrizione ");

            return sb.ToString();
        }

        private Periodo GetRandomPeriodo()
        {
            // max 30 giorni prima e dopo il giorno corrente
            DateTime start = DateTime.Today.AddDays(-random.Next(31));
            return new Periodo(
                start,
                start.AddDays(random.Next(31))
            );
        }

        public IEnumerable<Scheda> GetElements()
        {
            if (_schede == null)
                _schede = NewElements();
            return _schede;
        }

        private IEnumerable<Scheda> NewElements()
        {
            List<Scheda> list = new List<Scheda>();

            for (int i = 0; i < random.Next(4) + 4; i++)
                list.Add(new Scheda(
                    "Scheda" + i,
                    GetRandomScopo(),
                    GetRandomDesc(),
                    GetRandomPeriodo()
                ));

            return list;
        }

        public void SaveElements(IEnumerable<Scheda> elements)
        {
            throw new NotImplementedException();
        }
    }
}
