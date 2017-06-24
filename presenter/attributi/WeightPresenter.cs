﻿using System.Collections.Generic;
using System.Windows.Forms;
using Trainary.model.attributi;
using Trainary.utils;

namespace Trainary.presenter.attributi
{
    [Label("Peso")]
    public class WeightPresenter : UnitValuePresenter
    {
        private IList<UnitaDiMisura> _unitaList;

        public WeightPresenter()
        {
            _unitaList = new List<UnitaDiMisura>(UnitaFactory.GetAllOfType(TipoQuantita.MASSA));
        }

        protected override IList<UnitaDiMisura> UnitaDiMisura
        {
            get { return _unitaList; }
        }
    }
}
