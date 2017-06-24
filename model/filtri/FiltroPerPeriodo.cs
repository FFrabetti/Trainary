using System;
using System.Collections.Generic;
using System.Linq;
using Trainary.utils;

namespace Trainary.model.filtri
{
    public static partial class FiltroFactory
    {
        [Label("Filtro per periodo")]
        private class FiltroPerPeriodo : IFiltroAllenamenti
        {
            public FiltroPerPeriodo()
            { }

            public IEnumerable<Allenamento> Filtra(IEnumerable<Allenamento> listaAllenamenti, object opzione)
            {
                if (!(opzione is Periodo))
                    throw new ArgumentException("opzione is not periodo");
                
                Periodo periodo = (Periodo)opzione;
                if (periodo.Equals(default(Periodo)))
                    throw new ArgumentException("periodo vuoto");

                return listaAllenamenti.Where(all => periodo.IsNelPeriodo(all.Data));
            }
        }
    }
}
