using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using Trainary.utils;

namespace Trainary
{
    public class MenuPresenter
    {
        private Type _tipo;
        private MenuStrip _menu;

        public MenuPresenter(Type tipo, MenuStrip menu)
        {
            if (tipo == null)
                throw new ArgumentNullException("tipo");
            if (menu == null)
                throw new ArgumentNullException("menu");

            _tipo = tipo;
            _menu = menu;

            InizializeMenu();
        }

        private MenuLabelAttribute GetMenuLabelAttribute(MethodInfo mi)
        {
            object[] attrs = mi.GetCustomAttributes(typeof(MenuLabelAttribute), false);
            if (attrs.Length == 0)
                return null;
            else
                return (MenuLabelAttribute)attrs[0];
        }

        private void InizializeMenu()
        {
            foreach (MethodInfo methodInfo in _tipo.GetMethods())
            {
                if (methodInfo.GetParameters().Length != 0 || !methodInfo.IsStatic)
                    continue;

                MenuLabelAttribute menuLabelAttr = GetMenuLabelAttribute(methodInfo);
                if (menuLabelAttr == null)
                    continue;

                Queue<string> queue = new Queue<string>(menuLabelAttr.LabelPath);

                ToolStripMenuItem item = InsertPath(queue, _menu.Items);
                item.Tag = methodInfo;
                item.Click += MenuClickHandler;
            }
        }

        private ToolStripMenuItem InsertPath(Queue<string> queue, ToolStripItemCollection collection)
        {
            string label = queue.Dequeue();
            ToolStripMenuItem item = new ToolStripMenuItem(label);
            item.Name = label; // per ContainsKey e indexer

            // caso base: la coda conteneva 1 elem prima del dequeue
            if (queue.Count == 0)
            {
                collection.Add(item);
                return item;
            }
            else
            {
                if (!collection.ContainsKey(label))
                    collection.Add(item);

                return InsertPath(queue, ((ToolStripMenuItem)collection[label]).DropDownItems);
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
