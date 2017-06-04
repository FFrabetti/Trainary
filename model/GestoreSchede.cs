using System;
using System.Collections.Generic;
using System.Linq;
using Trainary.model;

namespace Trainary
{
    public static class GestoreSchede
    {
        private static readonly List<Scheda> _schede = new List<Scheda>();
        public static IEnumerable<Scheda> GetSchede()
        {
            return _schede;
        }
        public static IEnumerable<Scheda> GetSchedeValide(DateTime data)
        {
            return from Scheda s in _schede
                   where s.isValida(data)
                   select s;
        }
    }
}
