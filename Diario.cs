using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainary
{
    public class Diario
    {
        private readonly List<Allenamento> _allenamenti;

        private static Diario _instance;

        private Diario()
        { }

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

        public Allenamento[] FiltraAllenamenti(FiltroAllenamenti filtro)
        {
            if (filtro == null)
                throw new ArgumentNullException("filtro");
            return filtro.Filtra(_allenamenti);
        }
    }
}
