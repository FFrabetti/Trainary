using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using Trainary.persistence;

namespace Trainary.model
{
    public class Diario
    {
        private readonly ObservableCollection<Allenamento> _allenamenti;

        private static Diario _instance;

        public event EventHandler DiarioChanged;

        private Diario()
        {
            IDataManager<Esercizio> eserciziDM = new EserciziDataManager(
                new CategorieDataManager(),
                new AttributiDataManager()
            );
            IDataManager<Allenamento> allenamentiDM = new AllenamentiDataManager(
                eserciziDM,
                new SeduteAdapterDM(),
                new AttributiDataManager()
            );

            _allenamenti = new ObservableCollection<Allenamento>(allenamentiDM.GetElements());
            _allenamenti.CollectionChanged += OnDiarioChanged;
        }

        private void OnDiarioChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (DiarioChanged != null)
                DiarioChanged(this, EventArgs.Empty);
        }

        public static Diario GetInstance()
        {
            if (_instance == null)
                _instance = new Diario();
            return _instance;
        }

        public Collection<Allenamento> Allenamenti
        {
            get
            {
                return _allenamenti;
            }
        }

        private class SeduteAdapterDM : IDataManager<Seduta>
        {
            public IEnumerable<Seduta> GetElements()
            {
                List<Seduta> sedute = new List<Seduta>();
                foreach (Scheda s in GestoreSchede.GetInstance().GetSchede())
                    sedute.AddRange(s.Sedute);

                return sedute;
            }

            public void SaveElements(IEnumerable<Seduta> elements)
            {
                throw new NotImplementedException();
            }
        }

    }
}
