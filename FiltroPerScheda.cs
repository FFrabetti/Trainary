﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Trainary
{
    public static partial class FiltroFactory
    {
        private class FiltroPerScheda : IFiltroAllenamenti
        {
            public FiltroPerScheda()
            { }

            public IEnumerable<Allenamento> Filtra(IEnumerable<Allenamento> listaAllenamenti, object opzione)
            {
                if (!(opzione is Scheda))
                    throw new ArgumentException("opzione is not Scheda");
                Scheda scheda = (Scheda)opzione;

                return (from Allenamento allenamento in listaAllenamenti
                        where allenamento is AllenamentoProgrammato
                        where scheda.Sedute.Contains((allenamento as AllenamentoProgrammato).Seduta)
                        select allenamento);
            }
        }
    }
}
