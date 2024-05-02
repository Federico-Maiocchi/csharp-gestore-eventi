using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace csharp_gestore_eventi
{
    //MILESTONE 1
    //Per prima cosa è necessario creare una classe Evento che abbia i seguenti attributi:
    public class Evento
    {
        //●	titolo
        private string _titolo;
       
        //●	data
        private DateTime _data;
        
        //●	capienza massima dell’evento
        private int _caprienzaMassimaEvento;
        
        //●	numero di posti prenotati
        private int _numeroPostiPrenotati;
        

        //Aggiungere metodi getter e setter in modo che:
        //●	Titolo sia in lettura e in scrittura
        public string Titolo 
        { 
            get
            {
                return _titolo;
            }

            set
            {
                //Controllo che se viene inserita una strnga vuota(implementato controllo spazi vuoti), blocca il programma
                if (string.IsNullOrWhiteSpace(value)) 
                {
                    throw new Exception("Il titolo non puà essere vuoto");
                }
                _titolo = value;
            } 
        }

        //●	Data sia in lettura e scrittura
        public DateTime Data 
        { 
            get
            {
                return _data;
            }
            set
            {
                //Controllo che se la data inserita è passata,blocca il programma,
                if(value < DateTime.Now)
                {
                    throw new Exception("La data inserità è meno recente, inserire una data corrente o prossima ");
                }
                _data = value;  
            }
        }

        //●	Numero di posti per la capienza massima sia solo in lettura
        public int CapienzaMassimaEvento 
        { 
            get
            {
                return _caprienzaMassimaEvento;
            }
        }

        //●	Numero di posti prenotati sia solo in lettura
        public int NumeroPostiPrenotati 
        { 
            get
            {
                return _numeroPostiPrenotati;
            }
        }

        //ai setters inserire gli opportuni controlli in modo che la data non sia già passata,
        //che il titolo non sia vuoto e che la capienza massima di posti sia un numero positivo.
        //In caso contrario sollevare opportune eccezioni.

        //Dichiarare un costruttore che prenda come parametri il titolo, 
        //la data e i posti a disposizione e inizializza gli opportuni attributi facendo uso dei metodi e controlli già fatti.
        //Per l’attributo posti prenotati invece si occupa di inizializzarlo lui a 0.

        public Evento(string titolo, DateTime data, int capienzaMassimaEvento)
        {
            Titolo = titolo;
            Data = data;
            NumeroPostiPrenotati = 0;
            
        }


        //Vanno inoltre implementati dei metodi public che svolgono le seguenti funzioni:

        //1.	PrenotaPosti: aggiunge i posti passati come parametro ai posti prenotati.
        //    Se l’evento è già passato o non ha posti o non ha più posti disponibili deve sollevare un’eccezione.
        public void PrenotaPosti(int postiDaPrenotare)
        {
            //Controllo se l’evento è già passato
            if (DateTime.Now > Data)
            {
                throw new Exception ("Non puoi prenotare posti per un evento passato");
            }

            //Controllo che se il numero inserito è positivo, incaso sia 0 o negativo viene bloccato
            if (postiDaPrenotare <= 0)
            {
                throw new Exception ("Il numero di posti da prenotare deve essere maggiore di zero");
            }

            //Controllo che se il numero di posti prenotati + i posti da prenotare è maggiore della capienza massima dell' evento
            //allora blocca il programma
            if (NumeroPostiPrenotati + postiDaPrenotare > CapienzaMassimaEvento)
            {
                throw new Exception("Non ci sono posti disponibili");
            }
        }

        //2.	DisdiciPosti: riduce del i posti prenotati del numero di posti indicati come parametro.

        public void DisdiciPosti()
        {

        }
        //    Se l’evento è già passato o non ci sono i posti da disdire sufficienti, deve sollevare un’eccezione.
        //3.	l’override del metodo ToString() in modo che venga restituita una stringa contenente: data formattata – titolo
        //    Per formattare la data correttamente usate nomeVariabile.ToString("dd/MM/yyyy");
        //    applicata alla vostra variabile DateTime.

    }
}
