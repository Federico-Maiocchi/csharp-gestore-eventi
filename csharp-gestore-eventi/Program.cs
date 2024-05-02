using Microsoft.VisualBasic;
using System;
using System.Security.Principal;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace csharp_gestore_eventi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MILESTONE 4


            //Una volta completata la classe ProgrammaEventi, usatela nel vostro programma principale Program.cs per
            //creare un nuovo programma di Eventi che l’utente vuole organizzare, chiedendogli qual è il titolo
            //del suo programma eventi.

            //Chiedere all'utente il nome del programma degli eventi
            Console.Write("Inserisci il nome del tuo programma Eventi: ");
            string titoloProgramma = Console.ReadLine();

            //Instanziare un nuovo programma eventi con il titolo scelto dall'utente
            ProgrammaEventi nuovoProgrammaEventi = new ProgrammaEventi(titoloProgramma);


            //Chiedete poi al vostro utente quanti eventi vuole aggiungere, e fategli inserire ad uno ad uno
            //tutti gli eventi necessari chiedendo man mano tutte le informazioni richieste all’utente.

            //Attenzione: qui si gestite eventuali eccezioni lanciate dagli eventi creati, 
            //in questo caso il programma informa l’utente dell’errore e non aggiunge l’evento al programma eventi
            //(o meglio alla lista di Eventi del programmaEventi), ma comunque chiederà in continuazione all’utente
            //di inserire eventi fintanto che non raggiunge il numero di eventi specificato inizialmente dall’utente.

            //Chiedere all'utente quanti eventi fanno parte del programma
            Console.Write("Indica il numero di eventi da inserire: ");
            int numeroEventi = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            
            //Iterare quante volte deve chiedere all'utente 
            for (int i = 0; i < numeroEventi; i++)
            {

                Console.WriteLine($"Inserimento dell'evento {i + 1}");

                Console.Write("Titolo evento: ");
                string titoloEvento = Console.ReadLine();


                Console.Write("Data evento (gg/mm/aaaa): ");
                DateTime dataEvento = DateTime.Parse(Console.ReadLine());


                Console.Write("Numero massimo posti: ");
                int capienzaMassimaEvento = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                Evento nuovoEvento = null;
                try
                {
                    nuovoEvento = new Evento(titoloEvento, dataEvento, capienzaMassimaEvento);

                    nuovoProgrammaEventi.AggiungiEvento(nuovoEvento);

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Errore nella creazione di un nuovo evento: {ex.Message}");
                }

            }

            //Una volta compilati tutti gli eventi:

            //1.Stampate il numero di eventi presenti nel vostro programma eventi
            Console.WriteLine($"NUmero eventi presenti in questo programma: {nuovoProgrammaEventi.NumeroEventi()}");

            //2.Stampate la lista di eventi inseriti nel vostro programma usando il metodo già fatto
            Console.WriteLine($"Lista eventi che fanno parte di questo programma: ");
            Console.WriteLine(ProgrammaEventi.StampaEventi(nuovoProgrammaEventi.eventi));

            //3.Chiedere all’utente una data e stampate tutti gli eventi in quella data. Usate il metodo che v
            //  i restituisce una lista di eventi in una data dichiarata e create un metodo statico
            //  che si occupa di stampare una lista di eventi che gli arriva.
            //  Passate dunque la lista di eventi in data al metodo statico, per poterla stampare.
            Console.WriteLine("Inserisci una data (formato dd/MM/yyyy) per visualizzare gli eventi in quella data:  ");
            DateTime dataUtente = DateTime.Parse(Console.ReadLine());

            List<Evento> eventiInData = nuovoProgrammaEventi.TrovaEventiPerData(dataUtente);
            Console.WriteLine("Eventi in data " + dataUtente.ToString("dd / MM / yyyy") + ":");
            Console.WriteLine(ProgrammaEventi.StampaEventi(eventiInData));

            //4.Eliminate tutti gli eventi dal vostro programma.
            nuovoProgrammaEventi.SvuotaEventi();
            Console.WriteLine("Gli eventi sono stati cancellati");









            ////MILESTONE 2

            ////1.    Nel vostro programma principale Program.cs, chiedete all’utente di inserire un nuovo evento con
            ////      tutti i parametri richiesti dal costruttore.

            ////Chiedere all'utente il titolo dell'evento
            //Console.WriteLine("Aggiungi un Evento");
            //Console.WriteLine("");

            //Console.Write("Inserisci il nome dell'evento: ");
            //string titolo = Console.ReadLine();

            ////Chiedere la data dell'evento
            //Console.Write("Inserisci la data dell'vento una data (giorno/mese/anno): ");
            //DateTime data = DateTime.Parse(Console.ReadLine());

            ////Chiedere di indicare la capienza massima di posti dell'evento 
            //Console.Write("Inserisci posti totali:");
            //int capienzaMassima = int.Parse(Console.ReadLine());

            ////Creazione dell'evento
            //Evento nuovoEvento = new Evento(titolo, data, capienzaMassima);

            ////2.    Dopo che l’evento è stato istanziato, chiedete all’utente se e quante prenotazioni
            ////      vuole fare e provare ad effettuarle.
            //while (true)
            //{
            //    //Richiesta all'utente se vuole prenotare
            //    Console.WriteLine("Vuoi prenotare dei posti per l'evento? Si/No");
            //    string confermaPrenotazione = Console.ReadLine().ToLower();

            //    //COntrollo se risponde no, allora chiude il programma
            //    if (confermaPrenotazione == "no")
            //    {
            //        break;
            //    }

            //    //Controllo se risponde si allora passa alla fase successiva
            //    if (confermaPrenotazione != "si" && confermaPrenotazione != "si")
            //    {
            //        Console.WriteLine("Risposta non valida. Inserisci SI oppure NO");
            //        continue;
            //    }

            //    //Richiesta numero prenotazioni posti
            //    Console.WriteLine("Quanti posti vuoi prenotare?");
            //    int postiDaPrenotare = int.Parse(Console.ReadLine());


            //    try
            //    {
            //        //Prenota i posti dentro nuovoEvento
            //        //indicando il messaggio di conferma prenotazione / il numero di posti prenotati / numero di posti disponibili
            //        nuovoEvento.PrenotaPosti(postiDaPrenotare);

            //        //3.       Stampare a video il numero di posti prenotati e quelli disponibili.
            //        Console.WriteLine($"Prenotazione confermata. posti prenotati {postiDaPrenotare}");
            //        Console.WriteLine($"posti disponibili {nuovoEvento.CapienzaMassimaEvento - nuovoEvento.NumeroPostiPrenotati}");
            //    } 
            //    catch (Exception ex) 
            //    {
            //        //In caso di errore, cattura l'eccezione e stampa l'errore
            //        Console.WriteLine($"Errore prenotazione: {ex.Message}");
            //    }

            //}

            ////4.Ora chiedere all’utente fintanto che lo desidera, se e quanti posti vuole disdire. 
            ////  Ogni volta che disdice dei posti, stampare i posti residui e quelli prenotati.
            //while (true)
            //{
            //    //Richiesta all'utente se vuole disdire i posti prenotati
            //    Console.WriteLine("Vuoi disdire dei posti? Si/No");
            //    string disdiciPrenotazione = Console.ReadLine().ToLower();

            //    //Controllo se risponde no, allora chiude il programma
            //    if (disdiciPrenotazione == "no")
            //    {
            //        break;
            //    }

            //    //Controllo se risponde si allora passa alla fase successiva
            //    if (disdiciPrenotazione != "si")
            //    {
            //        Console.WriteLine("Risposta non valida. Inserisci SI oppure NO");
            //        continue;
            //    }

            //    //Richiesta numero disdetta posti
            //    Console.WriteLine("Quanti posti vuoi disdire?");
            //    int postiDaDisdire = int.Parse(Console.ReadLine());


            //    try
            //    {
            //        //Disdici i posti nel nuovoEvento
            //        nuovoEvento.DisdiciPosti(postiDaDisdire);
            //        Console.WriteLine($"Rimossi posti prenotati con successo. Posti disdetti {postiDaDisdire}");
            //        Console.WriteLine($"posti disponibili {nuovoEvento.CapienzaMassimaEvento - nuovoEvento.NumeroPostiPrenotati}");
            //        Console.WriteLine($"posti prenotati {nuovoEvento.NumeroPostiPrenotati}");
            //    }
            //    catch (Exception ex)
            //    {
            //        //In caso di errore, cattura l'eccezione e stampa l'errore
            //        Console.WriteLine($"Errore posti disdetti: {ex.Message}");
            //    }

            //}

        }
    }
}
