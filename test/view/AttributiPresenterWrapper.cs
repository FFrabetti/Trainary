using System.Windows.Forms;
using Trainary.presenter;
using Trainary.presenter.attributi;
using Trainary.view;

namespace Trainary.test.view
{
    class AttributiPresenterWrapper : IControlPresenter
    {
        private NewAttributoPresenter _presenter;

        public AttributiPresenterWrapper()
        {
            _presenter = new NewAttributoPresenter(new NewAttributoControl());
        }

        public Control UserControl
        {
            get { return _presenter.NewAttributoControl; }
        }

        public object Item
        {
            get { return _presenter.NewAttributo(); }
        }

    }
}
