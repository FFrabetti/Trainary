using System;
using System.Collections.Generic;
using System.Linq;
using Trainary.model;
using Trainary.utils;

namespace Trainary
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

                //return (from Allenamento allenamento in listaAllenamenti
                //        where allenamento.GetType().Equals(tipo)
                //        select allenamento);
                return listaAllenamenti.Where(a => a.GetType().Equals(tipo));
            }
        }

    }
}
