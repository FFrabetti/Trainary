using System.Windows.Forms;
using Trainary.presenter;
using Trainary.presenter.attributi;
using Trainary.view;

namespace Trainary.test.view
{
    class AttributiPresenterWrapper : IControlPresenter
    {
        private AttributiPresenter _presenter;

        public AttributiPresenterWrapper()
        {
            _presenter = new AttributiPresenter(new AttributiControl());
        }

        public Control UserControl
        {
            get { return _presenter.AttributiControl; }
        }

        public object Item
        {
            get { return _presenter.NewAttributo(); }
        }

    }
}
