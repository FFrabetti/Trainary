using System;
using System.Collections.Generic;
using Trainary.model.filtri;

namespace Trainary.model
{
    public class Diario
    {
        private readonly List<Allenamento> _allenamenti;

        private static Diario _instance;

        private Diario()
        {
            _allenamenti = new List<Allenamento>();
        }

        public static Diario GetInstance()
        {
            if (_instance == null)
                _instance = new Diario();
            return _instance;
        }

        public List<Allenamento> Allenamenti
        {
            get
            {
                return _allenamenti;
            }
        }

        public IEnumerable<Allenamento> FiltraAllenamenti(IFiltroAllenamenti filtro, object opzione)
        {
            if (filtro == null)
                throw new ArgumentNullException("filtro");
            if (opzione == null)
                throw new ArgumentNullException("opzione");
            return filtro.Filtra(_allenamenti, opzione);
        }
    }
}
