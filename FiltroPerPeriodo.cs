using System;
using System.Collections.Generic;
using System.Linq;

namespace Trainary
{
    public static partial class FiltroFactory
    {
        private class FiltroPerPeriodo : IFiltroAllenamenti
        {
            public FiltroPerPeriodo()
            { }

            public IEnumerable<Allenamento> Filtra(IEnumerable<Allenamento> listaAllenamenti, object opzione)
            {
                if (!(opzione is PeriodoDiValidita))
                    throw new ArgumentException("opzione is not Periodo");
                PeriodoDiValidita periodo = (PeriodoDiValidita)opzione;

                return (from Allenamento allenamento in listaAllenamenti
                        where periodo.IsNelPeriodo(allenamento.Data)
                        select allenamento);
            }
        }
    }
}
