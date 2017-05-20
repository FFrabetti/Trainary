using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainary
{
   public abstract class Allenamento
    {
        private readonly DateTime _data;
        private readonly EsercizioSvolto[] _eserciziSvolti;
        public Allenamento(DateTime data,EsercizioSvolto[] eserciziSvolti)
        {
            if (data == null)
                throw new ArgumentException("data");
            if (eserciziSvolti == null || eserciziSvolti.Length == 0)
                throw new ArgumentException("esercizi svolti");
            _data = data;
            _eserciziSvolti = eserciziSvolti;
        }
        public DateTime Data
        {
            get
            {
                return _data;
            }
        }
        public EsercizioSvolto[] EserciziSvolti
        {
            get
            {
                return _eserciziSvolti;
            }
        }
     }
}
