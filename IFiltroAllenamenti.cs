using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainary
{
    public interface IFiltroAllenamenti
    {
        Allenamento[] Filtra(List<Allenamento> listaAllenamenti, object opzione);
    }
}
