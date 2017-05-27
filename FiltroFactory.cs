using System;
using System.Collections.Generic;
using System.Reflection;

namespace Trainary
{
    public static partial class FiltroFactory
    {
        private static readonly Dictionary<string, IFiltroAllenamenti> _dictionary;

        static FiltroFactory()
        {
            _dictionary = new Dictionary<String, IFiltroAllenamenti>();
            //_dictionary.Add("Filtro per scheda", new FiltroPerScheda());
            //_dictionary.Add("Filtro per periodo", new FiltroPerPeriodo());
            //_dictionary.Add("Filtro per tipo", new FiltroPerTipo());
            foreach (Type type in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (type.GetInterface(typeof(IFiltroAllenamenti).Name) != null
                    && !type.IsAbstract && type.GetConstructor(Type.EmptyTypes) != null)
                {
                    // try catch
                    IFiltroAllenamenti fa = (IFiltroAllenamenti)Activator.CreateInstance(type);
                    if(fa != null)
                    _dictionary.Add(fa.Name, fa);
                }

            }
        }
            public static IFiltroAllenamenti GetFiltroAllenamento(string nomeFiltro)
            {
                if (!_dictionary.ContainsKey(nomeFiltro))
                    throw new ArgumentException("nomeFiltro");
                return _dictionary[nomeFiltro];
            }

            public static IEnumerable<String> GetNomeFiltri()
            {
                return _dictionary.Keys;
            }
            //public static string GetInfoLabelTo(string from)
            //{
            //    return _dictionary[from].GetInfoLabel();
            //}
            //public static IEnumerable<string> GetInfoComboBox(string from)
            //{
            //    return _dictionary[from].GetInfoComboBox();
            //}
        }
    }

