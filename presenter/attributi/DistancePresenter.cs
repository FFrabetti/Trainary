using System.Collections.Generic;
using System.Windows.Forms;
using Trainary.model.attributi;
using Trainary.utils;

namespace Trainary.presenter.attributi
{
    [Label("Distanza")]
    public class DistancePresenter : UnitValuePresenter
    {
        private IList<UnitaDiMisura> _unitaList;

        public DistancePresenter()
        {
            _unitaList = new List<UnitaDiMisura>(UnitaFactory.GetAllOfType(TipoQuantita.LENGTH));
        }

        protected override IList<UnitaDiMisura> UnitaDiMisura
        {
            get { return _unitaList; }
        }
    }
}
