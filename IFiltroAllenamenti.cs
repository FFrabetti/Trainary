using System.Collections.Generic;

namespace Trainary
{
    public interface IFiltroAllenamenti
    {
        IEnumerable<Allenamento> Filtra(IEnumerable<Allenamento> listaAllenamenti, object opzione);
    }
}
