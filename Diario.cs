﻿using System;
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

        public Allenamento[] FiltraAllenamenti(IFiltroAllenamenti filtro, object opzione)
        {
            if (filtro == null)
                throw new ArgumentNullException("filtro");
            if (opzione == null)
                throw new ArgumentNullException("opzione");
            return filtro.Filtra(_allenamenti, opzione);
        }
    }
}
