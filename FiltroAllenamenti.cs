﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainary
{
    public interface FiltroAllenamenti
    {
        Allenamento[] Filtra(List<Allenamento> listaAllenamenti);
    }
}
