using System;
using System.Text;
using Trainary.model.attributi;

namespace Trainary.model
{
    public class Circuito : Esercizio
    {
        private readonly Esercizio[] _esercizi;

        public Circuito(Attributo[] targets, Esercizio[] esercizi) : base(targets)
        {
            if (esercizi == null)
                throw new ArgumentNullException("esercizi");
            if (esercizi.Length < 2)
                throw new ArgumentException("un circuito deve contenere almeno 2 esercizi");
            
            _esercizi = esercizi;
        }

        public Circuito(Esercizio[] esercizi) : this(new Attributo[0], esercizi)
        {
        }

        public override Esercizio[] Esercizi {
            get
            {
               return _esercizi;
            }
        }

        public override void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("Circuito");

            for (int i = 0; i < Targets.Length; i++)
            {
                if (i == 0)
                    sb.Append(" [");
                else
                    sb.Append(", ");

                sb.Append(Targets[i]);

                if (i == Targets.Length - 1)
                    sb.Append("]");
            }

            return sb.ToString();
        }

        // debug only
        public override string ToFullString()
        {
            StringBuilder result = new StringBuilder();
            StringBuilder ident = new StringBuilder();
            RecoursiveToFullString(result, ident, this);

            return result.ToString().Trim();
        }

        private void RecoursiveToFullString(StringBuilder result, StringBuilder ident, Esercizio e)
        {
            if(e is Circuito)
            {
                result.Append(Environment.NewLine + ident + e);
                ident.Append("    ");
                foreach (Esercizio subEs in ((Circuito)e).Esercizi)
                    RecoursiveToFullString(result, ident, subEs);
            }
            else // caso base
            {
                result.Append(Environment.NewLine + ident + e);
            }
        }

        //protected override bool EqualsEsercizi(Esercizio other)
        //{
        //    if(other.GetType() == typeof(Circuito))
        //    {
        //        bool trovato = false;
        //        Circuito circuito = (Circuito)other;
        //        foreach(Esercizio es in Esercizi)
        //        {
        //            foreach(Esercizio esOther in circuito.Esercizi)
        //            {
        //                if (es.Equals(esOther))
        //                    trovato = true;
        //            }
        //            if (!trovato) return false;
        //        }
        //    }
        //    return false;
        //}
    }
}
