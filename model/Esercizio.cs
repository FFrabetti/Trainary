using System;
using System.Text;
using Trainary.model.attributi;

namespace Trainary.model
{
    public abstract class Esercizio
	{
        
        private readonly Attributo[] _targets;

        public Esercizio(Attributo[] targets)
        {
            if (targets == null)
                _targets = new Attributo[0];
            else
                _targets = targets;
        }

        public Esercizio() : this(null)
        { }

        public Attributo[] Targets
        {
            get
            {
                return _targets;
            }
        }

        public abstract void Accept(Visitor visitor);

        // debug only
        public virtual string ToFullString()
        {
            return ToString();
        }
    }
}
