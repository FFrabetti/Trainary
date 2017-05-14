using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainary
{
    static class AttributoFactory
    {
        private static Dictionary<Units, IMeasureConverter> _converters = new Dictionary<Units, IMeasureConverter>();

        public static IMeasureConverter GetConverter(Units u)
        {
            if(!_converters.ContainsKey(u))
            {
                AddConverter(u);
            }
            return _converters[u];
        }

        private static void AddConverter(Units u)
        {
            IMeasureConverter converter = null;
            switch(u)
            {
                //case Units.YARD:
                //    converter = new LinearConverter( ... );
                //    break;

                //default:
                //    throw new ArgumentException();
            }

            _converters.Add(u, converter);
        }
        

    }
}
