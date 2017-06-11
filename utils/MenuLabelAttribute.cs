using System;
using System.Linq;

namespace Trainary.utils
{
    public class MenuLabelAttribute : Attribute
    {
        private string[] _args;

        public MenuLabelAttribute(params string[] args)
        {
            if (args == null || args.Length == 0)
                throw new ArgumentException("null or zero arguments");
            if(args.Any(str => string.IsNullOrEmpty(str)))
                throw new ArgumentException("invalid null or empty label");

            _args = args;
        }

        public string[] LabelPath
        {
            get { return _args; }
        }

    }
}
