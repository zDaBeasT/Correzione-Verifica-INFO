using System;

namespace Scuola
{
    public class Gestione
    {
        public static string Inserisci()
        {
            string n;
            Console.WriteLine("inserisci una classe:");
            n = Convert.ToString(Console.ReadLine());
            return n;
        }
        public static int Risposta()
        {
            int risposta;
            Console.WriteLine("inserire 1 per continuare oppure inserire 0 per uscire:");
                risposta = int.Parse(Console.ReadLine());
            return risposta;
        }
        public static int Voto()
        {
            Console.WriteLine("Inserisci voto scolastico:");
            int voto = int.Parse(Console.ReadLine());
            return voto;
        }
        public static int Contatore(int cont2) 
        {
            int volte = cont2 * 15;
            return volte;
        }
        public static int MediaIstituto(int voto,int cont2 )
        {
            
            int media = voto / (cont2 * 15);
            return media;
        }
        public static int Media(int voto)
        {
            int mediaIstituto = voto / 15;
                return mediaIstituto;
        }
    }
}
