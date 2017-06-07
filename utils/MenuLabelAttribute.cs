using System;

namespace Trainary.utils
{
    public class MenuLabelAttribute : LabelAttribute
    {
        private string _group;

        public MenuLabelAttribute(string label, string group)
            : base(label)
        {
            if (group != null && group.Length == 0)
                throw new ArgumentException("group is empty");

            _group = group;
        }

        public MenuLabelAttribute(string label) : base(label)
        { }

        public string Group
        {
            get { return _group; }
        }

        public bool HasGroup()
        {
            return _group != null;
        }

    }
}
