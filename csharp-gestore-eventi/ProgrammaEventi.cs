﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace csharp_gestore_eventi
{
    //MILESTONE 3

    //Creare una classe ProgrammaEventi con i seguenti attributi
    public class ProgrammaEventi
    {
        //●	string Titolo
        public string Titolo {  get; set; }

        //●	List<Evento> eventi
        public List<Evento> eventi;

        //Nel costruttore valorizzare il titolo, passato come parametro,
        //e inizializzate la lista di eventi come una nuova Lista vuota di eventi.
        public ProgrammaEventi(string titolo)
        {
            Titolo = titolo;
            eventi = new List<Evento>();
        }

        //Aggiungete poi i seguenti metodi:
        //●	un metodo che aggiunge alla lista del programma eventi un Evento, passato come parametro al metodo.
        public void AggiungiEvento(Evento nuovoEvento)
        {
            //Aggiunto un nuovo evento dentro la lista eventi
            eventi.Add(nuovoEvento);
        }

        //●	un metodo che restituisce una lista di eventi con tutti gli eventi presenti in una certa data.
        public List<Evento> TrovaEventiPerData(DateTime data)
        {
            List<Evento> eventiInData = new List<Evento>();

            foreach (Evento evento in eventi)
            {
                //Controllo se la data dell'evento evento corrente corrsiponde alla data richiesta
                if (evento.Data.Date == data.Date)
                {
                    //Se è uguale, aggiungo l'evento alla lista eventiInData
                    eventiInData.Add(evento);
                }
            }

            //Restituisco la lista di eventi nella data specificata
            return eventiInData;
        }
        //●	un metodo statico che si occupa, presa una lista di eventi, di stamparla in Console,
        //o ancora meglio vi restituisca la rappresentazione in stringa della vostra lista di eventi.
        
        //●	un metodo che restituisce quanti eventi sono presenti nel programma eventi attualmente.
        
        //●	un metodo che svuota la lista di eventi.
        
        //●	un metodo che restituisce una stringa che mostra il titolo del programma e tutti gli eventi
        //aggiunti alla lista.Come nell’esempio qui sotto:
        //Nome programma evento:
        //data1 - titolo1
        //data2 - titolo2
        //data3 - titolo3
        


    }
}
