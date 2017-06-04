using System.Linq;
using Trainary.persistence;

namespace Trainary.model
{
    class Documento
    {
        private static Documento _instance;

        private IDataManager<Categoria> _categorieDM;

        public static Documento GetInstance()
        {
            if (_instance == null)
                _instance = new Documento();

            return _instance;
        }

        private Documento()
        {
            _categorieDM = new CategorieDataManager();
        }

        public Categoria GetCategoriaRadice()
        {
            return _categorieDM.GetElements().ElementAt(0);
        }
    }
}
