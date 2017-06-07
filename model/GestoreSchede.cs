using System;
using System.Collections.Generic;
using System.Linq;
using Trainary.model;
using Trainary.persistence;

namespace Trainary
{
    public class GestoreSchede
    {
        private static GestoreSchede _instance;

        private readonly List<Scheda> _schede;

        private GestoreSchede()
        {
            IDataManager<Scheda> dm = new SchedeDataManager();
            _schede = new List<Scheda>(dm.GetElements());
        }

        public static GestoreSchede GetInstance()
        {
            if (_instance == null)
                _instance = new GestoreSchede();

            return _instance;
        }

        public List<Scheda> GetSchede()
        {
            return _schede;
        }

        public IEnumerable<Scheda> GetSchedeValide(DateTime data)
        {
            return _schede.Where(scheda => scheda.isValida(data));
        }
    }
}
