using System;
using Scuola;

namespace ScuolaStatale
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont2 = 0;
            int risposta = Gestione.Risposta();
            while (risposta == 1)
            {
                string classe = Gestione.Inserisci();
                risposta = Gestione.Risposta();
                cont2++;
            }
            int volte = Gestione.Contatore(cont2);
            for (int cont=0; cont < volte; cont++)
                {
                    int voto = Gestione.Voto();
                    if (voto <= 10 && voto >= 2)
                    {
                        Console.WriteLine("il voto è stato inserito corettamente.");
                    }
                    else
                    {
                        Console.WriteLine("voto inserito non valido riprova con un voto da 2 a 10.");
                    cont--;
                    }
                int vototot =+ voto;
                int media = Gestione.Media(voto);
                int mediaIstituto = Gestione.MediaIstituto(voto, cont2);
                Console.WriteLine($"la media dell'istituto è {mediaIstituto}, la media della classe è {media}");
                Console.ReadLine();
            }        
        }
    }
}
