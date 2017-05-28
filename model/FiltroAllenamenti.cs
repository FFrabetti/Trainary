using System.Collections.Generic;

namespace Trainary.model
{
    public interface FiltroAllenamenti
    {
        Allenamento[] Filtra(List<Allenamento> listaAllenamenti);
    }
}
