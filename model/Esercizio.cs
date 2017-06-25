using Trainary.model.attributi;

namespace Trainary.model
{
    public abstract class Esercizio
	{
        
        private readonly Attributo[] _targets;

        public Esercizio(Attributo[] targets)
        {
            _targets = targets == null ? new Attributo[0] : targets;
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

        public abstract string Label
        {
            get;
        }

        public abstract void Accept(Visitor visitor);

        // debug only
        public virtual string ToFullString()
        {
            return ToString();
        }
        
    }
}
