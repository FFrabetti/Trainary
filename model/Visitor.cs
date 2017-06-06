using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainary.model
{
    public interface Visitor
    {
        void Visit(EsercizioSingolo esercizioSingolo);
        void Visit(Circuito circuito);
        void Visit(Esercizio esercizio);
    }
}
