using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainary.presenter
{
    public class LabelAttribute : Attribute
    {
        private string _label;

        // def. AttributeUsageAttribute
        // AttributeTargets (ValidOn) = all
        // AllowMultiple = false
        // Inherited = true
        public LabelAttribute(string label)
        {
            if (string.IsNullOrEmpty(label))
                throw new ArgumentException("label is null or empty");

            _label = label;
        }

        public string Label
        {
            get { return _label; }
        }

    }
}
