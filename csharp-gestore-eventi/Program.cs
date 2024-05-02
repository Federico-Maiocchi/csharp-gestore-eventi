using System.Security.Principal;

namespace csharp_gestore_eventi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MILESTONE 2

            //1.    Nel vostro programma principale Program.cs, chiedete all’utente di inserire un nuovo evento con
            //      tutti i parametri richiesti dal costruttore.

            //Chiedere all'utente il titolo dell'evento
            Console.WriteLine("Aggiungi un Evento");
            Console.WriteLine("Inserisci il Titolo");
            string titolo = Console.ReadLine();

            //Chiedere la data dell'evento
            Console.WriteLine("Inserisci una data giorno/mese/anno");
            DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/mm/yyyy", null);

            //Chiedere di indicare la capienza massima di posti dell'evento 
            Console.WriteLine("Inserisci la capienza massima di posti");
            int capienzaMassima = int.Parse(Console.ReadLine());

            //Creazione dell'evento
            Evento nuovoEvento = new Evento(titolo, data, capienzaMassima);

            //2.    Dopo che l’evento è stato istanziato, chiedete all’utente se e quante prenotazioni
            //      vuole fare e provare ad effettuarle.
            while (true)
            {
                //Richiesta all'utente se vuole prenotare
                Console.WriteLine("Vuoi prenotare dei posti per l'evento? Si/No");
                string confermaPrenotazione = Console.ReadLine().ToLower();

                //COntrollo se risponde no, allora chiude il programma
                if (confermaPrenotazione == "no")
                {
                    break;
                }

                //Controllo se risponde si allora passa alla fase successiva
                if (confermaPrenotazione != "si" && confermaPrenotazione != "si")
                {
                    Console.WriteLine("Risposta non valida. Inserisci SI oppure NO");
                    continue;
                }

                //Richiesta conferma prenotazioni posti
                Console.WriteLine("Quanti posti vuoi prenotare?");
                int postiDaPrenotare = int.Parse(Console.ReadLine());


                try
                {
                    //Prenota i posti dentro nuovoEvento
                    //indicando il messaggio di conferma prenotazione / il numero di posti prenotati / numero di posti disponibili
                    nuovoEvento.PrenotaPosti(postiDaPrenotare);
                    Console.WriteLine($"Prenotazione confermata. posti prenotati {nuovoEvento.PrenotaPosti}, " +
                        $"posti disponibili {nuovoEvento.CapienzaMassimaEvento - nuovoEvento.NumeroPostiPrenotati}");
                } 
                catch (Exception ex) 
                {
                    //In caso di errore, cattura l'eccezione e stampa l'errore
                    Console.WriteLine($"Errore prenotazione: {ex.Message}");
                }
               
            }

            //3.Stampare a video il numero di posti prenotati e quelli disponibili.
            //4.Ora chiedere all’utente fintanto che lo desidera, se e quanti posti vuole disdire. 
            //  Ogni volta che disdice dei posti, stampare i posti residui e quelli prenotati. 



        }
    }
}
