using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trainary
{
    class DiarioPresenter
    {
        private readonly ComboBox _comboBox;
        private readonly Func<IEnumerable<String>> _getNomeFiltri;

        public DiarioPresenter(ComboBox comboBox, Func<IEnumerable<String>> getNomeFiltri)
        {
            if (comboBox == null)
                throw new ArgumentException("comboBox");
            if (getNomeFiltri == null)
                throw new ArgumentException("getNomeFiltri");
            _comboBox = comboBox;
            _getNomeFiltri = getNomeFiltri;
            Populate(_getNomeFiltri());
        }
        
        private void Populate(IEnumerable<String> entities)
        {
            _comboBox.DataSource = entities.ToList<String>();
        }
    }
}

