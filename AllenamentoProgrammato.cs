using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainary
{
    public class AllenamentoProgrammato : Allenamento
    {
        private Seduta _seduta;
        public AllenamentoProgrammato(DateTime data,EsercizioSvolto[] eserciziSvolti,Seduta seduta) : base(data,eserciziSvolti)
        {
            if (seduta == null)
                throw new ArgumentException("seduta");
            _seduta = seduta;
        }
        public Seduta Seduta
        {
            get
            {
                return _seduta;
            }
        }
    }
}
