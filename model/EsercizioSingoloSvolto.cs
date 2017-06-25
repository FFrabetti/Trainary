namespace Trainary.model
{
    public class EsercizioSingoloSvolto : EsercizioSvolto
    {
        private static readonly EsercizioSvolto[] EMPTY = new EsercizioSvolto[0];

        public EsercizioSingoloSvolto(EsercizioSingolo esercizio) : base(esercizio)
        {
        }

        public override EsercizioSvolto[] SottoEserciziSvolti
        {
            get
            {
                return EMPTY;
            }
        }

    }
}
