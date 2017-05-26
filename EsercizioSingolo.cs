using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trainary.attributi;

namespace Trainary
{
    public class EsercizioSingolo : Esercizio
    {
        public EsercizioSingolo(Attivita attivita, Attributo[] targets) : base(attivita, targets)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
    
}
