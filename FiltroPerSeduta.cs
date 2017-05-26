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

                return (from Allenamento allenamento in listaAllenamenti
                        where allenamento is AllenamentoProgrammato
                        && (allenamento as AllenamentoProgrammato).Seduta.Equals(seduta)
                        select allenamento);
            }
        }
    }
}
