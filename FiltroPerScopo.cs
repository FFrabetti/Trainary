using System;
using System.Collections.Generic;
using System.Linq;

namespace Trainary
{
    public static partial class FiltroFactory
    {
        private class FiltroPerScopo : IFiltroAllenamenti
        {
            public FiltroPerScopo() //Filtro per scopo di una scheda
            { }

            public IEnumerable<Allenamento> Filtra(IEnumerable<Allenamento> listaAllenamenti, object opzione)
            {
                if (!(opzione is ScopoDellaScheda))
                    throw new ArgumentException("opzione");
                ScopoDellaScheda scopo = (ScopoDellaScheda)opzione;

                IEnumerable<Seduta> sedute = (from Scheda scheda in GestoreSchede.GetSchede()
                                       where scheda.Scopo.Equals(scopo)
                                       select scheda.Sedute);

                return
                    from AllenamentoProgrammato allenamento in listaAllenamenti.OfType<AllenamentoProgrammato>()
                    where sedute.Contains<Seduta>(allenamento.Seduta)
                    select allenamento;

            }
        }
    }
}
