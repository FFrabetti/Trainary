using System.Collections.Generic;

namespace Trainary.persistence
{
    interface IDataManager<T>
    {

        IEnumerable<T> GetElements();

        void SaveElements(IEnumerable<T> elements);

    }
}
