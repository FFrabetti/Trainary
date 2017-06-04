using System;
using System.Collections.Generic;
using System.Linq;
using Trainary.utils;

namespace Trainary.model.filtri
{
    public static partial class FiltroFactory
    {
        [Label("Filtro per tipo")]
        private class FiltroPerTipo : IFiltroAllenamenti
        {
            
            public FiltroPerTipo()
            { }

            public IEnumerable<Allenamento> Filtra(IEnumerable<Allenamento> listaAllenamenti, object opzione)
            {
                if (!(opzione is Type))
                    throw new ArgumentException("opzione is not Type");
                Type tipo = (Type)opzione;
                if (!tipo.IsSubclassOf(typeof(Allenamento)))
                    throw new ArgumentException("opzione is not allenamento");

                return listaAllenamenti.Where(a => a.GetType().Equals(tipo));
            }
        }

    }
}
