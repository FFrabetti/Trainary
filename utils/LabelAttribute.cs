using System;

namespace Trainary.utils
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
