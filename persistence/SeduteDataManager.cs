using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trainary.model;

namespace Trainary.persistence
{
    class SeduteDataManager : IDataManager<Seduta>
    {
        private IDataManager<Esercizio> _eserciziDM;
        private IDataManager<Scheda> _schedeDM;
        private Random random = new Random();

        public SeduteDataManager(IDataManager<Scheda> schedeDM, IDataManager<Esercizio> eserciziDM)
        {
            _schedeDM = schedeDM;
            _eserciziDM = eserciziDM;
        }

        private Scheda GetRandomScheda()
        {
            IEnumerable<Scheda> schede = _schedeDM.GetElements();
            int n = schede.Count();
            int i = random.Next(n);

            try
            {
                return schede.ElementAt(i);
            }
            catch (ArgumentOutOfRangeException e)
            {
                throw new ArgumentOutOfRangeException("n=" + n + ", i=" + i);
            }
        }

        public IEnumerable<Seduta> GetElements()
        {
            List<Seduta> list = new List<Seduta>();

            for(int i=0; i< random.Next(8) + 8; i++)
            {
                list.Add(
                    GetRandomScheda().AggiungiSeduta((IList<Esercizio>)_eserciziDM.GetElements())
                );
            }

            return list;
        }

        public void SaveElements(IEnumerable<Seduta> elements)
        {
            throw new NotImplementedException();
        }
    }
}
