using System;
using System.Collections.Generic;
using Trainary.model;

namespace Trainary.persistence
{
    class CategorieDataManager : IDataManager<Categoria>
    {
        public IEnumerable<Categoria> GetElements()
        {
            List<Categoria> result = new List<Categoria>();
            Categoria root = new Categoria("Generale");

            Attivita corsa = new Attivita("Corsa", "Descrizione corsa");
            Attivita saltoInAlto = new Attivita("Salto in alto", "Desc salto in alto",
                new string[] { "asta", "materasso" });
            Attivita saltoInLungo = new Attivita("Salto in lungo", new string[] { "pedana" });
            Categoria atletica = new Categoria("Atletica",
                new Attivita[] { saltoInLungo, corsa, saltoInAlto });

            IList<Attivita> listNuoto = new List<Attivita>();
            listNuoto.Add(new Attivita("Rana", "Descrizione rana"));
            listNuoto.Add(new Attivita("Dorso"));
            listNuoto.Add(new Attivita("Stile libero"));
            Categoria nuoto = new Categoria("Nuoto", listNuoto);

            root.SottoCategorie.Add(nuoto);
            root.SottoCategorie.Add(atletica);

            result.Add(root);
            return result;
        }

        public void SaveElements(IEnumerable<Categoria> elements)
        {
            throw new NotImplementedException();
        }
    }
}
