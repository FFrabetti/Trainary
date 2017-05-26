using System;
using System.Collections.Generic;
using System.Linq;

namespace Trainary
{
    public static partial class FiltroFactory
    {
        private class FiltroPerScopo : IFiltroAllenamenti
        {
            public FiltroPerScopo() //Filtro per scopo di una scheda
            { }

            public IEnumerable<Allenamento> Filtra(IEnumerable<Allenamento> listaAllenamenti, object opzione)
            {
                if (!(opzione is ScopoDellaScheda))
                    throw new ArgumentException("opzione");
                ScopoDellaScheda scopo = (ScopoDellaScheda)opzione;

                List<Allenamento> allenamentiFiltrati = new List<Allenamento>();

                IEnumerable<Seduta> sedute = (from Scheda scheda in GestoreSchede.GetSchede()
                                       where scheda.Scopo.Equals(scopo)
                                       select scheda.Sedute);

                IEnumerable<Allenamento> allenamentiProgrammati =   (from allenamento in listaAllenamenti
                                                                    where allenamento is AllenamentoProgrammato
                                                                    select allenamento);

                foreach (AllenamentoProgrammato allenamento in allenamentiProgrammati)
                    {
                        foreach (Seduta seduta in sedute)
                        {
                            if (seduta.Equals(allenamento.Seduta))
                                allenamentiFiltrati.Add(allenamento);
                        }
                    }

                return allenamentiFiltrati;
            }
        }
    }
}
