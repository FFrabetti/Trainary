using System;
using System.Collections.Generic;
using System.Linq;
using Trainary.utils;

namespace Trainary.model.filtri
{
    public static partial class FiltroFactory
    {
        [Label("Filtro per scheda")]
        private class FiltroPerScheda : IFiltroAllenamenti
        {
            public FiltroPerScheda()
            { }

            public IEnumerable<Allenamento> Filtra(IEnumerable<Allenamento> listaAllenamenti, object opzione)
            {
                if (!(opzione is Scheda))
                    throw new ArgumentException("opzione is not Scheda");
                Scheda scheda = (Scheda)opzione;

                return listaAllenamenti.OfType<AllenamentoProgrammato>().Where(all => all.Seduta.Scheda == scheda);
                //return (from AllenamentoProgrammato allenamento in listaAllenamenti.OfType<AllenamentoProgrammato>()
                //        where allenamento.Seduta.Scheda.Equals(scheda)
                //        select allenamento);
            }
        }
    }
}
