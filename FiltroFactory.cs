using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainary
{
    public static class FiltroFactory
    {
        private static readonly Dictionary<string, IFiltroAllenamenti> _dictionary;

        static FiltroFactory()
        {
            _dictionary = new Dictionary<string, IFiltroAllenamenti>();
            _dictionary.Add("Filtro per scheda", new FiltroPerScheda());

        }

        public static IFiltroAllenamenti GetFiltroAllenamento(string nomeFiltro)
        {
            if (!_dictionary.ContainsKey(nomeFiltro))
                throw new ArgumentException("nomeFiltro");
            return _dictionary[nomeFiltro];
        }

        private class FiltroPerScheda : IFiltroAllenamenti
        {
            private Scheda _scheda;

            public FiltroPerScheda()
            { }

            public Allenamento[] Filtra(List<Allenamento> listaAllenamenti, object opzione)
            {
                if (!(opzione is Scheda))
                    throw new ArgumentException("opzione");

                Allenamento[] allenamentiFiltrati;
                int count = 0;

                foreach (Allenamento allenamento in listaAllenamenti)
                {
                    if (allenamento is AllenamentoProgrammato)
                    {
                        AllenamentoProgrammato allenamentoProgrammato = (AllenamentoProgrammato)allenamento;
                        Seduta sedutaAllenamento = allenamentoProgrammato.Seduta;
                        if (_scheda.Sedute.Contains(sedutaAllenamento))
                        {
                            count++;
                        }
                    }
                }

                allenamentiFiltrati = new Allenamento[count];

                foreach (Allenamento allenamento in listaAllenamenti)
                {
                    if (allenamento is AllenamentoProgrammato)
                    {
                        int i = 0;
                        AllenamentoProgrammato allenamentoProgrammato = (AllenamentoProgrammato)allenamento;
                        Seduta sedutaAllenamento = allenamentoProgrammato.Seduta;
                        if (_scheda.Sedute.Contains(sedutaAllenamento))
                        {
                            allenamentiFiltrati[i] = allenamento;
                            i++;
                        }
                    }
                }
                return allenamentiFiltrati;
            }
        }
    }
}
