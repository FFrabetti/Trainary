using System;
using System.Reflection;

namespace Trainary.model.attributi
{
    public static partial class QuantitaFactory
    {

        public static Quantita NewQuantita(params object[] args)
        {
            Type[] types = new Type[args.Length];
            for(int i=0; i<args.Length; i++)
                types[i] = args[i].GetType();

            ConstructorInfo constructor;
            foreach(Type t in typeof(QuantitaFactory).GetNestedTypes())
            {
               if(
                    t.IsSubclassOf(typeof(Quantita)) &&
                    !t.IsAbstract &&
                    (constructor=t.GetConstructor(types)) != null
                 )
                {
                    return (Quantita) constructor.Invoke(args);
                    //Activator.CreateInstance(t, args);
                }
            }

            throw new ArgumentException("No constructor found for the given arguments");
        }

        public static Quantita TryNewQuantita(params object[] args)
        {
            Quantita result = null;
            try
            {
                result = NewQuantita(args);
            } catch(Exception e)
            {
                // do nothing
            }
            return result;
        }

        // debug only
        internal static string StrTryNewQuantita(params object[] args)
        {
            string result;
            try
            {
                result = NewQuantita(args).ToString();
            }
            catch (Exception e)
            {
                result = e.GetType().Name + ": " + e.Message;
            }
            return result;
        }

    }
}
