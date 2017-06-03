using System;
using System.Collections.Generic;
using System.Linq;
using Trainary.model;
using Trainary.utils;

namespace Trainary
{
    public static partial class FiltroFactory
    {
        [Label("Filtro per scopo")]
        private class FiltroPerScopo : IFiltroAllenamenti
        {
            public FiltroPerScopo() //Filtro per scopo di una scheda
            { }

            public IEnumerable<Allenamento> Filtra(IEnumerable<Allenamento> listaAllenamenti, object opzione)
            {
                if (!(opzione is ScopoDellaScheda))
                    throw new ArgumentException("opzione");
                ScopoDellaScheda scopo = (ScopoDellaScheda)opzione;

                IList<Seduta> sedute = new List<Seduta>();
                
                foreach (Scheda scheda in GestoreSchede.GetSchede())
                {
                    foreach (Seduta seduta in scheda.Sedute)
                    {
                        if (scheda.Scopo.Equals(scopo))
                            sedute.Add(seduta);
                    }
                }
                
                return
                    from AllenamentoProgrammato allenamento in listaAllenamenti.OfType<AllenamentoProgrammato>()
                    where sedute.Contains<Seduta>(allenamento.Seduta)
                    select allenamento;
            }
        }
    }
}
