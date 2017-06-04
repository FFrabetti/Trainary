using System;
using System.Collections.Generic;
using System.Linq;
using Trainary.utils;

namespace Trainary.model.filtri
{
    public static partial class FiltroFactory
    {
        [Label("Filtro per scopo")]
        private class FiltroPerScopo : IFiltroAllenamenti
        {
            
            public FiltroPerScopo() //Filtro per scopo di una scheda
            { }

            public IEnumerable<Allenamento> Filtra(IEnumerable<Allenamento> listaAllenamenti, object opzione)
            {
                if (!(opzione is ScopoDellaScheda))
                    throw new ArgumentException("opzione");
                ScopoDellaScheda scopo = (ScopoDellaScheda)opzione;

                return
                    from AllenamentoProgrammato allenamento in listaAllenamenti.OfType<AllenamentoProgrammato>()
                    where allenamento.Seduta.Scheda.Scopo.Equals(scopo)
                    select allenamento;
            }
        }
    }
}
