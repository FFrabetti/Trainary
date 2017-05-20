using System;
using System.Collections.Generic;

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

                List<Allenamento> allenamentiFiltrati = new List<Allenamento>();
                Scheda scheda = (Scheda)opzione;

                foreach (Allenamento allenamento in listaAllenamenti)
                {
                    if (allenamento is AllenamentoProgrammato)
                    {
                        AllenamentoProgrammato allenamentoProgrammato = (AllenamentoProgrammato)allenamento;
                        Seduta sedutaAllenamento = allenamentoProgrammato.Seduta;
                        if (scheda.Sedute.Contains(sedutaAllenamento))
                            allenamentiFiltrati.Add(allenamento);
                    }
                }
                return allenamentiFiltrati;
            }
        }
    }
}
