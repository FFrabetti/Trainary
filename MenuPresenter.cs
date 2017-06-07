using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trainary.utils;

namespace Trainary
{
    class MenuPresenter
    {
        private Type _tipo;
        private MenuStrip _menu;

        private Dictionary<string, ToolStripMenuItem> _dictionary;

        private Attribute GetCustomAttribute(MethodInfo mi, Type tipo)
        {
            object[] attrs = mi.GetCustomAttributes(tipo, false);
            if (attrs.Length == 0)
                return null;
            else
                return (Attribute) attrs[0];
        }

        public MenuPresenter(Type tipo, MenuStrip menu)
        {
            if (tipo == null)
                throw new ArgumentNullException("tipo");
            if (menu == null)
                throw new ArgumentNullException("menu");

            _tipo = tipo;
            _menu = menu;

            _dictionary = new Dictionary<string, ToolStripMenuItem>();

            InizializeMenu();
        }

        private void InizializeMenu()
        {
            foreach (MethodInfo methodInfo in _tipo.GetMethods())
            {
                if (methodInfo.GetParameters().Length != 0)
                    continue;

                MenuLabelAttribute labelAttr = (MenuLabelAttribute)GetCustomAttribute(methodInfo, typeof(LabelAttribute));

                if (labelAttr == null)
                    continue;

                // text, image, event
                ToolStripMenuItem item = new ToolStripMenuItem(labelAttr.Label, null, MenuClickHandler);
                item.Tag = methodInfo;

                if (!labelAttr.HasGroup()) // elemento di 1° lv
                {
                    _menu.Items.Add(item);
                    continue;
                }

                // elemento di 2° livello
                if (!_dictionary.ContainsKey(labelAttr.Group))
                {
                    // il parent non esiste, lo aggiungo al dizionario e al menu
                    ToolStripMenuItem parent = new ToolStripMenuItem(labelAttr.Group);
                    _dictionary.Add(labelAttr.Group, parent);
                    _menu.Items.Add(parent);
                }

                // (il parent esiste) aggiungo il figlio
                _dictionary[labelAttr.Group].DropDownItems.Add(item);
            }
        }

        private void MenuClickHandler(object sender, EventArgs e)
        {
            ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;
            MethodInfo methodInfo = (MethodInfo)toolStripMenuItem.Tag;
            methodInfo.Invoke(null, null);
        }
    }
}
