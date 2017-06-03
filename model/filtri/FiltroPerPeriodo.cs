using System;
using System.Collections.Generic;
using System.Linq;
using Trainary.model;
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

                return (from Allenamento allenamento in listaAllenamenti
                        where periodo.IsNelPeriodo(allenamento.Data)
                        select allenamento);
            }
        }
    }
}
