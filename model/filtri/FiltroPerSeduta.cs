using System;
using System.Collections.Generic;
using System.Linq;
using Trainary.utils;

namespace Trainary.model.filtri
{
    
    public static partial class FiltroFactory
    {
        [Label("Filtro per seduta")]
        private class FiltroPerSeduta : IFiltroAllenamenti
        {
            public FiltroPerSeduta()
            { }

            public IEnumerable<Allenamento> Filtra(IEnumerable<Allenamento> listaAllenamenti, object opzione)
            {
                if (!(opzione is Seduta))
                    throw new ArgumentException("opzione is not Seduta");
                Seduta seduta = (Seduta) opzione;

                return listaAllenamenti.OfType<AllenamentoProgrammato>().Where(all => all.Seduta == seduta);
                //return
                //    from AllenamentoProgrammato allenamento in listaAllenamenti.OfType<AllenamentoProgrammato>()
                //    where seduta.Equals(allenamento.Seduta)
                //    select allenamento;
            }
        }
    }
}
