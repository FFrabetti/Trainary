using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainary
{
    public enum Units
    {
        NONE,
        [UnitInfo("m", "metre")]
        METRE,
        [UnitInfo("s", "second")]
        SECOND,
        [UnitInfo("kg", "kilogram")]
        KILOGRAM,
        [UnitInfo("g")]
        GRAM,
        [UnitInfo("yd")]
        YARD,
    }

    public class UnitInfoAttribute : Attribute
    {
        private string _symbol;
        private string _name;

        internal UnitInfoAttribute(string symbol, string name)
        {
            _symbol = symbol;
            _name = name;
        }

        internal UnitInfoAttribute(string symbol) : this(symbol, null) { }

        public string Symbol { get { return _symbol; } }

        public string Name { get { return _name; } }
    }

    public static class UnitsExtensions
    {
        public static string GetSymbol(this Units unit)
        {
            UnitInfoAttribute attr = unit.GetAttribute<UnitInfoAttribute>();
            return attr != null ? attr.Symbol : default(string);
        }

        public static string GetName(this Units unit)
        {
            UnitInfoAttribute attr = unit.GetAttribute<UnitInfoAttribute>();
            return attr != null ? attr.Name : unit.ToString();
        }
    }
}
