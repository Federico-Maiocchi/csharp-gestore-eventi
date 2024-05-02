using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
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

        


    }
}
