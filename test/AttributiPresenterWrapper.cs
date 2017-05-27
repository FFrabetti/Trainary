using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trainary.presenter;

namespace Trainary.test
{
    class AttributiPresenterWrapper : IControlPresenter
    {
        private AttributiPresenter _presenter;

        public AttributiPresenterWrapper(AttributiPresenter presenter)
        {
            _presenter = presenter;
        }

        public Control Control
        {
            get
            {
                return _presenter.Control;
            }
        }

        public object Item
        {
            get
            {
                return _presenter.NewAttributo();
            }
        }
    }
}
