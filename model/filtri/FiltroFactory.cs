﻿using System;
using System.Collections.Generic;
using System.Reflection;
using Trainary.utils;

namespace Trainary.model.filtri
{
    public static partial class FiltroFactory
    {
        private static readonly Dictionary<string, IFiltroAllenamenti> _dictionary;

        static FiltroFactory()
        {
            _dictionary = new Dictionary<String, IFiltroAllenamenti>();

            foreach (Type type in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (type.GetInterface(typeof(IFiltroAllenamenti).Name) != null
                    && !type.IsAbstract && type.GetConstructor(Type.EmptyTypes) != null)
                {
                    try
                    {
                        IFiltroAllenamenti filtroAllenamenti = (IFiltroAllenamenti)Activator.CreateInstance(type);
                        if (filtroAllenamenti != null)
                            _dictionary.Add(filtroAllenamenti.GetLabelAttribute(), filtroAllenamenti);
                    }
                    catch
                    {
                        // skip
                    }
                }
            }
        }

        public static IFiltroAllenamenti GetFiltroAllenamenti(string nomeFiltro)
        {
            // If the specified key is not found, throws a KeyNotFoundException
            return _dictionary[nomeFiltro];
        }

         public static IEnumerable<String> GetNomeFiltri()
         {
            return _dictionary.Keys;
         }
    }
}

