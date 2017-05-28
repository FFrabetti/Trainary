namespace Trainary.utils
{
    public static class LabelExtensions
    {

        public static string GetLabelAttribute<T>(this T obj)
        {
            object[] attributes = obj.GetType().GetCustomAttributes(typeof(LabelAttribute), false);

            return attributes.Length > 0 ?
                ((LabelAttribute)attributes[0]).Label : 
                obj.GetType().Name;
        }

    }
}
