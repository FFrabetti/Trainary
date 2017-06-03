using System.Collections.Generic;

namespace Trainary.model.filtri
{
    public interface IFiltroAllenamenti
    {
        IEnumerable<Allenamento> Filtra(IEnumerable<Allenamento> listaAllenamenti, object opzione);
    }
}
