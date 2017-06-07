using System;
using Trainary.model;

namespace Trainary.test.model
{
    class DiarioTest
    {
        public static void Test()
        {
            Attivita a1 = new Attivita("Corsa");
            Attivita a2 = new Attivita("Palestra");
            Attivita a3 = new Attivita("Nuoto");

            EsercizioSingolo es1 = new EsercizioSingolo(a1);
            SvolgiVisitor sv = new SvolgiVisitor();
            es1.Accept(sv);
            EsercizioSvolto es1Svolto = sv.EsercizioSvolto;

            EsercizioSingolo es2 = new EsercizioSingolo(a1);
            es2.Accept(sv);
            EsercizioSvolto es2Svolto = sv.EsercizioSvolto;

            EsercizioSingolo es3 = new EsercizioSingolo(a2);
            es3.Accept(sv);
            EsercizioSvolto es3Svolto = sv.EsercizioSvolto;

            EsercizioSingolo es4 = new EsercizioSingolo(a3);
            es4.Accept(sv);
            EsercizioSvolto es4Svolto = sv.EsercizioSvolto;

            Esercizio[] esercizi1 = new Esercizio[] { es1, es2 };
            EsercizioSvolto[] esercizi1Svolti = new EsercizioSvolto[] { es1Svolto, es2Svolto };

            Esercizio[] esercizi2 = new Esercizio[] { es1, es3, es4 };
            EsercizioSvolto[] esercizi2Svolti = new EsercizioSvolto[] { es1Svolto, es3Svolto, es4Svolto };
            Circuito c1 = new Circuito(esercizi2);
            CircuitoSvolto circuitoSvolto = new CircuitoSvolto(c1);

            //Allenamenti Extra

            AllenamentoExtra aE1 = new AllenamentoExtra(DateTime.Today, esercizi1Svolti, "Primo");
            AllenamentoExtra aE2 = new AllenamentoExtra(DateTime.Today.AddDays(-1), esercizi1Svolti, "Secondo");
            AllenamentoExtra aE3 = new AllenamentoExtra(DateTime.Today.AddDays(-20), esercizi1Svolti, "Terzo");
            AllenamentoExtra aE4 = new AllenamentoExtra(DateTime.Today.AddDays(-50), esercizi1Svolti);

            Diario.GetInstance().Allenamenti.Add(aE1);
            Diario.GetInstance().Allenamenti.Add(aE2);
            Diario.GetInstance().Allenamenti.Add(aE3);
            Diario.GetInstance().Allenamenti.Add(aE4);



            //Allenamenti Programmati
            Scheda s1 = new Scheda("myScheda1", ScopoDellaScheda.Dimagrimento, new Periodo(DateTime.Today, DateTime.Today.AddDays(60)));
            Scheda s2 = new Scheda("myScheda2", ScopoDellaScheda.Dimagrimento, new Periodo(DateTime.Today, DateTime.Today.AddDays(60)));

            GestoreSchede.GetSchede().Add(s1);
            GestoreSchede.GetSchede().Add(s2);

            Seduta sed1 = s1.AggiungiSeduta(esercizi1);
            Seduta sed2 = s1.AggiungiSeduta(c1.Esercizi);

            Seduta sed3 = s2.AggiungiSeduta(esercizi2);
            
            AllenamentoProgrammato aP1 = new AllenamentoProgrammato(DateTime.Today, esercizi1Svolti, sed1);
            AllenamentoProgrammato aP2 = new AllenamentoProgrammato(DateTime.Today, esercizi2Svolti, sed2);
            AllenamentoProgrammato aP3 = new AllenamentoProgrammato(DateTime.Today, esercizi2Svolti, sed3);

            Diario.GetInstance().Allenamenti.Add(aP1);
            Diario.GetInstance().Allenamenti.Add(aP2);
            Diario.GetInstance().Allenamenti.Add(aP3);
        }
    }
}
