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
            IDataManager<Scheda> dataManager = new SchedeDataManager();
            IDataManager<Seduta> sedute = new SeduteDataManager(
                dataManager, 
                new EserciziDataManager(new CategorieDataManager(), new AttributiDataManager())
            );
            sedute.GetElements(); // "riempie" le schede

            _schede = new List<Scheda>(dataManager.GetElements());
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
