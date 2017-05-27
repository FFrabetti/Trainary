using System;
using System.Collections.Generic;
using System.Linq;

namespace Trainary
{
    public static partial class FiltroFactory
    {
        private class FiltroPerSeduta : IFiltroAllenamenti
        {
            public FiltroPerSeduta()
            { }

            public IEnumerable<Allenamento> Filtra(IEnumerable<Allenamento> listaAllenamenti, object opzione)
            {
                if (!(opzione is Seduta))
                    throw new ArgumentException("opzione is not Seduta");
                Seduta seduta = (Seduta) opzione;

                return
                    from AllenamentoProgrammato allenamento in listaAllenamenti.OfType<AllenamentoProgrammato>()
                    where seduta.Equals(allenamento.Seduta)
                    select allenamento;
            }
        }
    }
}
