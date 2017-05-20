﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainary
{
	public abstract class Esercizio
	{
        private readonly Attivita _attivita;
        private readonly Attributo[] _targets;

        public Esercizio(Attivita attivita, Attributo[] targets)
        {
            if (attivita == null)
                throw new ArgumentNullException("attivita");
            if (targets == null)
                throw new ArgumentNullException("targets");
            _attivita = attivita;
            _targets = targets;
        }

        public Attivita Attivita
        {
            get
            {
                return _attivita;
            }
        }
        public Attributo[] Targets
        {
            get
            {
                return _targets;
            }
        }

        public EsercizioSvolto Svolgi()
        {
            return new EsercizioSvolto(this);
        }

        public override string ToString()
        {

            String targetsToPrint = _attivita.ToString();
            foreach (Attributo a in _targets)
            {
                targetsToPrint += a;
                targetsToPrint += " ";
            }
            return targetsToPrint;
        }
    }
}
