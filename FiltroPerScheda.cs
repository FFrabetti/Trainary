using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainary
{
    class FiltroPerScheda : FiltroAllenamenti
    {
        private Scheda _scheda;

        public FiltroPerScheda(Scheda scheda)
        {
			if (scheda == null)
				throw new ArgumentNullException("scheda");
            _scheda = scheda;
        }

        public Allenamento[] Filtra(List<Allenamento> listaAllenamenti)
        {
            int count = 0;

            foreach (Allenamento allenamento in listaAllenamenti)
            {
                if (allenamento.GetType().Equals("AllenamentoProgrammato"))
                {
                    Seduta sedutaAllenamento = allenamento.GetType().Seduta;
                    if (_scheda.Sedute.Contains(sedutaAllenamento))
                    {
                        count++;
                    }
                }
            }
			
			Allenamento[] allenamentiFiltrati = new Allenamento[count];

            foreach (Allenamento allenamento in listaAllenamenti)
            {
                if (allenamento.GetType().Equals("AllenamentoProgrammato"))
                {
                    int i = 0;
                    Seduta sedutaAllenamento = allenamento.GetType().Seduta;
                    if (_scheda.Sedute.Contains(sedutaAllenamento))
                    {
                        allenamentiFiltrati[i] = allenamento;
                        i++;
                    }
                }
            }
            return allenamentiFiltrati;
        }
    }
}
