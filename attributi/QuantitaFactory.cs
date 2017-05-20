using System;

namespace Trainary.attributi
{
    public static partial class QuantitaFactory
    {
        // può trovare dinamicamente le classi che implementano IQuantita e i loro costruttori
        // invocandoli secondo bisogno

        public static IQuantita newQuantita(double value, TipoQuantita tipo)
        {
            return newQuantita(value, UnitaDiMisura.GetBase(tipo));
        }

        public static IQuantita newQuantita(double value, UnitaDiMisura unita)
        {
            return new SingleValue(value, unita);
        }

        public static IQuantita newQuantita(TimeSpan timeSpan)
        {
            return new Durata(timeSpan);
        }

        public static IQuantita newQuantita(int h, int m, int s)
        {
            return new Durata(h, m, s);
        }

        public static IQuantita newQuantita(double value)
        {
            return new NumeroPuro(value);
        }
    }
}
