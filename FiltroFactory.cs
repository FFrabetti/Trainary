using System;
using System.Collections.Generic;

namespace Trainary
{
    public static partial class FiltroFactory
    {
        private static readonly Dictionary<string, IFiltroAllenamenti> _dictionary;

        static FiltroFactory()
        {
            _dictionary = new Dictionary<string, IFiltroAllenamenti>();
            _dictionary.Add("Filtro per scheda", new FiltroPerScheda());
            _dictionary.Add("Filtro per periodo", new FiltroPerPeriodo());
            _dictionary.Add("Filtro per Tipo", new FiltroPerTipo());
        }

        public static IFiltroAllenamenti GetFiltroAllenamento(string nomeFiltro)
        {
            if (!_dictionary.ContainsKey(nomeFiltro))
                throw new ArgumentException("nomeFiltro");
            return _dictionary[nomeFiltro];
        }

        public static IEnumerable<String> GetNomeFiltri()
        {
            return _dictionary.Keys;
        }
    }
}
