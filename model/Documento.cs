using System.Collections.Generic;
using System.Linq;
using Trainary.model.attributi;
using Trainary.persistence;

namespace Trainary.model
{
    class Documento
    {
        private static Documento _instance;

        private IDataManager<Categoria> _categorieDM;
        private IDataManager<Attributo> _attributiDM;
        private IDataManager<Esercizio> _eserciziDM;
        private IDataManager<Scheda> _schedeDM;
        private IDataManager<Seduta> _seduteDM;

        public static Documento GetInstance()
        {
            if (_instance == null)
                _instance = new Documento();

            return _instance;
        }

        private Documento()
        {
            _categorieDM = new CategorieDataManager();
            _attributiDM = new AttributiDataManager();
            _eserciziDM = new EserciziDataManager(_categorieDM, _attributiDM);
            _schedeDM = new SchedeDataManager();
            _seduteDM = new SeduteDataManager(_schedeDM, _eserciziDM);
        }

        public Categoria GetCategoriaRadice()
        {
            return _categorieDM.GetElements().ElementAt(0);
        }


        // testing
        public IEnumerable<Attributo> GetAttributi()
        {
            return _attributiDM.GetElements();
        }

        public IEnumerable<Esercizio> GetEsercizi()
        {
            return _eserciziDM.GetElements();
        }

        public IEnumerable<Scheda> GetSchede()
        {
            return _schedeDM.GetElements();
        }

        public IEnumerable<Seduta> GetSedute()
        {
            return _seduteDM.GetElements();
        }
    }
}
