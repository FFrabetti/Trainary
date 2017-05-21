using System;
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

                return (from AllenamentoProgrammato allenamento in listaAllenamenti
                        where scheda.Sedute.Contains(allenamento.Seduta)
                        select allenamento);

                /*
                List<Allenamento> allenamentiFiltrati = new List<Allenamento>();

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
                */
            }
        }
    }
}
