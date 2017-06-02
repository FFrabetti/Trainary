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

            Attivita corsa = new Attivita("corsa", "descrizione corsa");
            Attivita saltoInAlto = new Attivita("salto in alto", "desc salto in alto",
                new string[] { "asta", "materasso" });
            Attivita saltoInLungo = new Attivita("salto in lungo", new string[] { "pedana" });
            Categoria atletica = new Categoria("Atletica",
                new Attivita[] { saltoInLungo, corsa, saltoInAlto });

            IList<Attivita> listNuoto = new List<Attivita>();
            listNuoto.Add(new Attivita("rana", "descrizione rana"));
            listNuoto.Add(new Attivita("dorso"));
            listNuoto.Add(new Attivita("stile libero"));
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
