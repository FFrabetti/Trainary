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
                throw new ArgumentException("null or empty arguments");
            if(args.Any(str => str.Length == 0))
                throw new ArgumentException("invalid empty label");

            _args = args;
        }

        public string[] LabelPath
        {
            get { return _args; }
        }

    }
}
