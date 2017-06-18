using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trainary.Presentation;

namespace Trainary.presenter
{
    class RinominaSedutaPresenter
    {
        private RinominaSedutaView _view;
        public RinominaSedutaPresenter(RinominaSedutaView view)
        {
            if (view == null)
                throw new ArgumentNullException("view");
            _view = view;
        }
        public string NuovoNome()
        {
            return _view.NuovoNome.Text;
        }
    }
}
