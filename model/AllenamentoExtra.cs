﻿using System;
using Trainary.utils;

namespace Trainary.model
{
    [Label("Allenamento extra")]
    public class AllenamentoExtra : Allenamento
    {
        private string _nome;

        public AllenamentoExtra(DateTime data, EsercizioSvolto[] eserciziSvolti, string nome)
            : base(data, eserciziSvolti)
        {
            Nome = nome;
        }

        public AllenamentoExtra(DateTime data, EsercizioSvolto[] eserciziSvolti)
            : this(data, eserciziSvolti, null) { }

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value == null ? String.Empty : value;
            }
        }

        public override string ToString()
        {
            string nome = Nome.Length > 0 ? Nome : "Allenamento extra";
            return ToStringData() + " " + nome;
        }
    }
}
