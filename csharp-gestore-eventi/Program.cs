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
            Console.WriteLine("");

            Console.Write("Inserisci il nome dell'evento: ");
            string titolo = Console.ReadLine();

            //Chiedere la data dell'evento
            Console.Write("Inserisci la data dell'vento una data (giorno/mese/anno): ");
            DateTime data = DateTime.Parse(Console.ReadLine());

            //Chiedere di indicare la capienza massima di posti dell'evento 
            Console.Write("Inserisci posti totali:");
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

                //Richiesta numero prenotazioni posti
                Console.WriteLine("Quanti posti vuoi prenotare?");
                int postiDaPrenotare = int.Parse(Console.ReadLine());


                try
                {
                    //Prenota i posti dentro nuovoEvento
                    //indicando il messaggio di conferma prenotazione / il numero di posti prenotati / numero di posti disponibili
                    nuovoEvento.PrenotaPosti(postiDaPrenotare);

                    //3.       Stampare a video il numero di posti prenotati e quelli disponibili.
                    Console.WriteLine($"Prenotazione confermata. posti prenotati {postiDaPrenotare}");
                    Console.WriteLine($"posti disponibili {nuovoEvento.CapienzaMassimaEvento - nuovoEvento.NumeroPostiPrenotati}");
                } 
                catch (Exception ex) 
                {
                    //In caso di errore, cattura l'eccezione e stampa l'errore
                    Console.WriteLine($"Errore prenotazione: {ex.Message}");
                }
               
            }

            //4.Ora chiedere all’utente fintanto che lo desidera, se e quanti posti vuole disdire. 
            //  Ogni volta che disdice dei posti, stampare i posti residui e quelli prenotati.
            while (true)
            {
                //Richiesta all'utente se vuole disdire i posti prenotati
                Console.WriteLine("Vuoi disdire dei posti? Si/No");
                string disdiciPrenotazione = Console.ReadLine().ToLower();

                //Controllo se risponde no, allora chiude il programma
                if (disdiciPrenotazione == "no")
                {
                    break;
                }

                //Controllo se risponde si allora passa alla fase successiva
                if (disdiciPrenotazione != "si")
                {
                    Console.WriteLine("Risposta non valida. Inserisci SI oppure NO");
                    continue;
                }

                //Richiesta numero disdetta posti
                Console.WriteLine("Quanti posti vuoi disdire?");
                int postiDaDisdire = int.Parse(Console.ReadLine());


                try
                {
                    //Disdici i posti nel nuovoEvento
                    nuovoEvento.DisdiciPosti(postiDaDisdire);
                    Console.WriteLine($"Rimossi posti prenotati con successo. Posti disdetti {postiDaDisdire}");
                    Console.WriteLine($"posti disponibili {nuovoEvento.CapienzaMassimaEvento - nuovoEvento.NumeroPostiPrenotati}");
                    Console.WriteLine($"posti prenotati {nuovoEvento.NumeroPostiPrenotati}");
                }
                catch (Exception ex)
                {
                    //In caso di errore, cattura l'eccezione e stampa l'errore
                    Console.WriteLine($"Errore posti disdetti: {ex.Message}");
                }

            }

            
             



        }
    }
}
