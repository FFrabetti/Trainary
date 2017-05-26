using System;
using System.Collections.Generic;
using System.Linq;

namespace Trainary
{
    public static partial class FiltroFactory
    {
        private class FiltroPerTipo : IFiltroAllenamenti
        {
            public FiltroPerTipo()
            { }

            public IEnumerable<Allenamento> Filtra(IEnumerable<Allenamento> listaAllenamenti, object opzione)
            {
                if (!(opzione.Equals("Allenamento programmato")) || !(opzione.Equals("Allenamento extra")))
                    throw new ArgumentException("opzione");

                if (opzione.Equals("Allenamento programmato"))
                {
                    return (from Allenamento allenamento in listaAllenamenti
                            where allenamento is AllenamentoProgrammato
                            select allenamento);
                }

                else if (opzione.Equals("Allenamento extra"))
                {
                    return (from Allenamento allenamento in listaAllenamenti
                            where allenamento is AllenamentoExtra
                            select allenamento);
                }

                return null;
            }
        }
    }
}
