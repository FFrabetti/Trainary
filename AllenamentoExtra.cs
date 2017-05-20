using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainary
{
    public class AllenamentoExtra : Allenamento
    {
        private string _nome;

        public AllenamentoExtra(DateTime data,EsercizioSvolto[] eserciziSvolti,string nome) : base(data, eserciziSvolti)
        {
            Nome = nome;
        }

        public AllenamentoExtra(DateTime data, EsercizioSvolto[] eserciziSvolti) : this(data, eserciziSvolti, null)
        {

        }

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (value == null)
                   value = "";
                _nome = value;
            }
        }
    }
}
