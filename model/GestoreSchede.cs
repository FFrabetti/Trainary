using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using Trainary.model;
using Trainary.persistence;

namespace Trainary
{
    public class GestoreSchede
    {
        private static GestoreSchede _instance;

        private readonly ObservableCollection<Scheda> _schede;

        public event EventHandler SchedeChanged;

        private GestoreSchede()
        {
            IDataManager<Scheda> dataManager = new SchedeDataManager();
            IDataManager<Seduta> sedute = new SeduteDataManager(
                dataManager, 
                new EserciziDataManager(new CategorieDataManager(), new AttributiDataManager())
            );
            sedute.GetElements(); // "riempie" le schede

            _schede = new ObservableCollection<Scheda>(dataManager.GetElements());
            _schede.CollectionChanged += OnSchedeChanged;
        }

        private void OnSchedeChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (SchedeChanged != null)
                SchedeChanged(this, EventArgs.Empty);
        }

        public static GestoreSchede GetInstance()
        {
            if (_instance == null)
                _instance = new GestoreSchede();

            return _instance;
        }

        public Collection<Scheda> GetSchede()
        {
            return _schede;
        }

        public IEnumerable<Scheda> GetSchedeValide(DateTime data)
        {
            return _schede.Where(scheda => scheda.isValida(data));
        }
    }
}
