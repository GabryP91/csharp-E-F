/*
    A – Rispondi alle seguenti domande argomentando la risposta:
        1) Descrivi i tipi di dato primitivi che conosci.

            I tipi di dato primitivi si suddividiono in varie categorie, i più famosi sono:

                                    (interi)
                                   * byte(occupano 1 byte -> 8 bit) è possibile rappresentare numeri interi da 0 a 255
                                   * int(occupano 4 byte) è possibile rappresentare numeri interi da -2,147,483,648 a 2,147,483,647
                                   * short(occupano 2 byte) è possibile rappresentare numeri interi da -32.768 a 32.767
                                   * long(occupano 8 byte) è possibile rappresentare numeri interi da -9,223,372,036,854,775,808 a 9,223,372,036,854,775,807
                                   ----------------------------------------------------------------------------------------------------------
                                    (con la virgola)
                                   * float(occupano 8 byte) è possibile rappresentare numeri con la virgola da -3.402823e38 a 3.402823e38
                                   * double(occupano 8 byte) è possibile rappresentare numeri con la virgola da -1.79769313486232e308 a 1.79769313486232e308
                                   * decimal(occupano 16 byte) è possibile rappresentare numeri con la virgola ~28-29 cifre decimali (usato per valute)
                                   ----------------------------------------------------------------------------------------------------------
                                    (carattere)
                                   * char(occupano 2 byte) è possibile rappresentare un singolo carattere Unicode (sistema di codifica che assegna un numero univoco ad ogni carattere)
                                   ----------------------------------------------------------------------------------------------------------
                                    (booleano)
                                   * bool(occupano 1 byte) è possibile rappresentare solo due valori: true/false
                                   ----------------------------------------------------------------------------------------------------------
                                    (tipo primitivo speciale: object )
                                   * object qualsiasi valore può essere assegnato a object (int,float,char,decimal), ma potrebbe richiedere unboxing/casting per l'uso.
            
        2) Cosa sono i reference?

            I reference rappresentano i puntatori ad una precisa parte di memoria, lo stack, la quale a sua volta punta ad un'altra parte di memoria heap nella quale è conservato l'oggetto vero e proprio.
            I tipi reference vengono copiati per riferimento non per valore come i tipi primitivi/valore (int,char,decimal ecc....)
    
        3) Che cos’è un namespace?
            
            è un contenitore che serve a organizzare il codice e a evitare conflitti tra nomi di classi o funzioni, nel quale è possibile lavorare inserendo/modificando le varie funzionalità del prorpio progetto.

        4) Cosa si intende con indentazione?

            è lo spazio o il rientro che si lascia all'inizio di una riga di codice per renderlo più leggibile e strutturato.

        5) Descrivi l’utilizzo della parola this.

           è un riferimento all'oggetto corrente della classe in cui viene utilizzata.
           In altre parole, permette di accedere agli attributi, metodi e costruttori dell'oggetto che sta eseguendo il codice.

        6) Cosa sono le Stringhe in C#?
            
            le stringhe in C# sono tipi di dato per riferimento, il che significa che quando creiamo una variabile di tipo stringa,
            questa non contiene direttamente il valore della stringa, ma contiene un riferimento alla memoria dove è memorizzata la stringa effettiva.
            Sono immutabili, cioè una volta che una stringa è stata creata, il suo contenuto non può essere cambiato. Se tenti di modificarla, 
            verrà creata una nuova stringa in memoria e il riferimento verrà aggiornato.

        7) Cos’è un blocco di codice?

            una serie di istruzioni o comandi che vengono eseguiti insieme come parte di una singola struttura logica, delimitata da parentesi graffe

        8) Quali strutture di controllo conosci? Descrivile e fai un esempio.
            
            Strutture di controllo più famose:
            
            1)Condizionali:
                * if/else => (Consente di eseguire un blocco di codice se una condizione è vera, e un altro blocco se la condizione è falsa)
                          
                               ES: int x = 3 if(x<5){...}else{...}
               
                * switch => (permette di eseguire un blocco di codice in base al valore di una variabile. È utile quando bisogna confrontare la stessa variabile con più valori possibili.Tramite uso delle parole chiavi case,break,default permette di gestire l'esecuzione del codice)
                
                               ES: int x = 3 switch(x){case 1:(...break)case 2:(...break)case 3:(...break)default:(...break)}
            2)di Ripetizione:
                * for => (esegue un blocco di codice per un numero definito di iterazioni. Viene utilizzato quando il numero di ripetizioni è noto a priori.)
                
                               ES: for(int i=0; i<10; i++){.....}

                * while => (esegue un blocco di codice finché una condizione è vera. La condizione viene verificata prima dell'esecuzione del blocco di codice.)
                
                               ES: while(condizione){....}

                * do-while => ( simile al while, ma la condizione viene verificata dopo l'esecuzione del blocco di codice, il che significa che il blocco di codice viene eseguito almeno una volta, anche se la condizione è falsa.)
                
                               ES: do{....}while(condizione)

            3)di Interruzione del Flusso:              
               * break => (termina immediatamente il ciclo o il blocco switch in cui si trova.)
                
                               ES: for(int i=0; i<10; i++)
                                        { if (i == 5)
                                           {
                                                break; // Interrompe il ciclo quando i è 5
                                          }}
               * continue => (termina l'iterazione corrente di un ciclo e passa direttamente alla successiva.)
                
                               ES: for(int i=0; i<10; i++)
                                        { if (i == 5)
                                           {
                                                continue; // Salta l'iterazione quando i è 5
                                          }}
                * return => (viene usato per uscire da un metodo e, se il metodo restituisce un valore, per restituirlo)
                
                               ES: int Somma(int a, int b)
                                    {
                                        return a + b; // Restituisce il risultato della somma
                                    }

        9) Spiega l’utilizzo dell’operatore ternario.
            
            è un operatore condizionale che consente di scrivere una condizione in modo compatto, anziché usare una struttura if-else. 
            È chiamato "ternario" perché è composto da tre parti:
                    
                    * Una condizione (espressione booleana)
                    * Un risultato se la condizione è vera (?) 
                    * Un risultato se la condizione è falsa (:) 

        10) Qual è la funzione di break? E di continue?

            La parola chiave break serve a uscire immediatamente da un ciclo (o da un'istruzione switch) e proseguire l'esecuzione del programma con il codice che segue il ciclo.

            La parola chiave continue viene utilizzata per saltare l'iterazione corrente di un ciclo e proseguire con l'iterazione successiva.


    B – Esercizi C#

        1) Creare un metodo che stampi a schermo i numeri pari da 1 a 14. Utilizzare sia un ciclo while, sia un ciclo for.
        2) Creare un metodo che stampi a schermo i numeri dispari da 14 a -3. Utilizzare sia un while che un ciclo for.
        3) Creare un programma che stampi a schermo la somma dei numeri da 1 a 10. Utilizzare sia un ciclo while, sia un ciclo for.
        4) Creare un programma che stampi a schermo le tabelline dei numeri da 1 a 10.

                Es.: 1*1 = 1, 1*2 = 2, …
                2*1 = 2, 2*2 = 4, …
                …
        5) Creare un programma che abbia all’interno una serie di interi scelti dal programmatore. Stampare il massimo tra tutti gli elementi.
        6) Creare un programma che lasci inserire numeri in input all’utente finché la sequenza di numeri è decrescente, cioè l’ultimo elemento immesso dall’utente deve essere più piccolo del precedente. 
           L’algoritmo alla fine deve stampare quanti numeri sono stati immessi e la loro media.
        7) Creare una classe che rappresenti una macchinetta per il caffè a cialde. Dotare la classe degli
        attributi e dei costruttori appropriati. Dotare la classe dei metodi necessari per fare queste
        azioni:
        a. Simulare un caffè, usando una cialda.
        b. Svuotare il cassetto delle cialde usate quando è pieno.
        c. Mostrare quanti caffè sono stati fatti in totale.
        d. Mostrare quanti caffè sono stati fatti dall’ultima volta che si è svuotato il cassetto delle cialde usate.
        8) Creare alcune istante della classe creata per gestire la macchinetta per il caffè a cialde in modo da fornire qualche esempio. 

*/

namespace csharp_E_F
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int scelta;

            while (true) // Loop infinito fino a scelta di uscita
            {
                Console.WriteLine("\n---------------------------------------------------\n");
                Console.WriteLine("Seleziona un esercizio da 1 a 7 oppure digita 0 per uscire:");

                Console.WriteLine("Caso [1]: Stampa a schermo un array di numeri pari da 1 a 14");
                Console.WriteLine("Caso [2]: Stampa a schermo un array di numeri dispari da 14 a -3");
                Console.WriteLine("Caso [3]: Stampa a schermo la somma dei numeri da 1 a 10");
                Console.WriteLine("Caso [4]: Stampa a schermo tabelline dei numeri");
                Console.WriteLine("Caso [5]: Dati una serie di interi scelti dal programmatore. Stampare il massimo tra tutti gli elementi");
                Console.WriteLine("Caso [6]: Stampa numeri decrescenti");
                Console.WriteLine("Caso [7]: Creare istanza classe MacchinettaCaffe");
      

                Console.WriteLine("\nFai la tua scelta\n");

                // Controllo input utente
                while (!int.TryParse(Console.ReadLine(), out scelta))
                {
                    Console.WriteLine("Sintassi errata. Inserisci un numero intero positivo:");
                }

                if (scelta == 0)
                {
                    Console.WriteLine("Uscita dal programma...");
                    break; // Esce dal loop e termina il programma
                }

                Console.WriteLine("\n---------------------------------------------------\n");

                switch (scelta)
                { 

                    case 1:
                        Console.WriteLine("ESERCIZIO 1\n");
                        StampaArray();
                        break;
                    case 2:
                        Console.WriteLine("ESERCIZIO 2\n");
                        StampaArray2();
                        break;
                    case 3:
                        Console.WriteLine("ESERCIZIO 3\n");
                        StampaArray3();
                        break;
                    case 4:
                        Console.WriteLine("ESERCIZIO 4\n");
                        StampaArray4();
                        break;
                    case 5:
                        Console.WriteLine("ESERCIZIO 5\n");
                        StampaArray5();
                        break;
                    case 6:
                        Console.WriteLine("ESERCIZIO 6\n");
                        StampaArray6();
                        break;
                    case 7:
                        Console.WriteLine("ESERCIZIO 7\n");

                        // Creiamo una nuova macchinetta con 15 cialde iniziali
                        MacchinettaCaffe macchinetta = new MacchinettaCaffe(15);

                        macchinetta.StatoMacchinetta();

                        // Simuliamo alcuni caffè
                        macchinetta.FaiCaffe();
                        macchinetta.FaiCaffe();
                        macchinetta.FaiCaffe();

                        // Mostriamo il numero di caffè fatti fino ad ora
                        macchinetta.MostraCaffeFattiTotali();
                        macchinetta.MostraCaffeFattiDallUltimaVolta();

                        Console.WriteLine();

                        macchinetta.StatoMacchinetta();

                        // Svuotiamo il cassetto e facciamo altri caffè
                        macchinetta.SvuotaCassetto();
                        macchinetta.FaiCaffe();

                        // Mostriamo di nuovo lo stato della macchinetta
                        macchinetta.MostraCaffeFattiTotali();
                        macchinetta.MostraCaffeFattiDallUltimaVolta();
                        macchinetta.StatoMacchinetta();

                        break;
                }

            }

        }

       /*
         Creare un metodo che stampi a schermo i numeri pari da 1 a 14. Utilizzare sia un ciclo while, sia un ciclo for.
       */
        static void StampaArray()
        {
            int[] numeri = new int[8];

            int index = 0,j = 0;

            for (int i = 0; i < 15; i++)
            {

                if (i % 2 != 0)
                {
                    continue;
                }

                numeri[index] = i;
                index++;
            }

            //stampo l'array su una sola riga
            Console.WriteLine("\nArray formato da: Versione for\n");
            //stampo l'array su una sola riga
            Console.WriteLine(string.Join(" ", numeri));

            index = 0;

      
            while (j < 15)
            {
                if (j % 2 == 0)
                {
                    numeri[index] = j;  // Aggiungi i numeri pari
                    index++;
                }
                j++;

            }

            //stampo l'array su una sola riga
            Console.WriteLine("\nArray formato da: Versione while\n");
            //stampo l'array su una sola riga
            Console.WriteLine(string.Join(" ", numeri));
        }

        /*
          Creare un metodo che stampi a schermo i numeri dispari da 14 a -3. Utilizzare sia un while che un ciclo for.
        */
        static void StampaArray2()
        {
            int[] numeri = new int[8];

            int index = 0, j = 14;

            for (int i = 14; i > -3; i--)
            {

                if (i % 2 == 0)
                {
                    continue;
                }

                numeri[index] = i;
                index++;
            }

            //stampo l'array su una sola riga
            Console.WriteLine("\nArray formato da: Versione for\n");
            //stampo l'array su una sola riga
            Console.WriteLine(string.Join(" ", numeri));

            index = 0 ;

            while (j > -3)
            {
                if (j % 2 != 0)
                {
                    numeri[index] = j;  // Aggiungi i numeri dispari
                    index++; // Incrementa l'indice per il prossimo elemento
                }
                j--;

            }

            //stampo l'array su una sola riga
            Console.WriteLine("\nArray formato da: Versione while\n");
            //stampo l'array su una sola riga
            Console.WriteLine(string.Join(" ", numeri));
        }

        /*
          Creare un programma che stampi a schermo la somma dei numeri da 1 a 10. Utilizzare sia un ciclo while, sia un ciclo for.
        */
        static void StampaArray3()
        {

            int somma = 0, j = 0;

            Console.WriteLine("\n------METODO FOR-----\n");

            for (int i = 0; i <= 10; i++)
            {
               
                Console.WriteLine("\nElemento{0} sommato a {1}\n", i, somma);
                somma += i;
            }

            
            Console.WriteLine("\nSomma finale: Versione for {0}\n",somma);

            somma = 0;


            Console.WriteLine("\n------METODO WHILE-----\n");

            while (true)
            {
                if (j > 10)
                {
                    break;
                }
               
                Console.WriteLine("\nElemento{0} sommato a {1}\n", j, somma);
                somma += j;
                j++;

            }

            Console.WriteLine("\nSomma finale: Versione while {0}\n", somma);
        }

        /*
         Creare un programma che stampi a schermo le tabelline dei numeri da 1 a 10.
       */
        static void StampaArray4()
        {

            // Ciclo per i numeri da 1 a 10
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Tabellina del {i}:");

                // Ciclo per moltiplicare ogni numero per 1, 2, ..., 10
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }

                // Aggiungi una riga vuota per separare le tabelline
                Console.WriteLine();
            }
        }

        /*
         Creare un programma che abbia all’interno una serie di interi scelti dal programmatore. Stampare il massimo tra tutti gli elementi.
       */
        static void StampaArray5()
        {
            int n;

            Console.WriteLine("Quanti numeri vuoi inserire?");

            // Controllo input utente
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Sintassi errata. Inserisci un numero intero positivo:");
            }

            int[] numeri = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Inserisci il numero in posizione {i + 1}: ");

                int temp;

                //Controllo
                while (!int.TryParse(Console.ReadLine(), out temp))
                {
                    Console.WriteLine("Sintassi errata. Inserisci un numero");
                }

                numeri[i] = temp;
            }

            int massimo = numeri[0];

            //parto dalla posizione successiva alla prima dal momento che l'ho già ottenuta
            for (int i = 1; i < numeri.Length; i++)
            {
                if (numeri[i] > massimo) // confrontiamo il valore nell'array con il massimo corrente
                {
                    massimo = numeri[i]; // aggiorniamo il massimo
                }
            }

            Console.WriteLine("\nIl massimo sarà: {0}", massimo);
        }

        /*
           Creare un programma che lasci inserire numeri in input all’utente finché la sequenza di numeri è decrescente, 
            cioè l’ultimo elemento immesso dall’utente deve essere più piccolo del precedente. 
           L’algoritmo alla fine deve stampare quanti numeri sono stati immessi e la loro media.
        */
        static void StampaArray6()
        {
            int n, count=0;

            int previousNumber = 0;  // Inizializziamo un valore molto grande come punto di partenza


            Console.WriteLine("Quanti numeri vuoi inserire?");

            // Controllo input utente
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Sintassi errata. Inserisci un numero intero positivo:");
            }

            int[] numeri = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Inserisci il numero in posizione {i + 1}: ");

                int temp;

                //Controllo
                while (!int.TryParse(Console.ReadLine(), out temp) )
                {
                    Console.WriteLine("Sintassi errata oppure numero maggiore del precedente. riprovare");
                }

                // Se è il primo numero, non fare il controllo sulla sequenza decrescente
                if (count > 0 && temp >= previousNumber)
                {
                    Console.WriteLine("Errore\n");
                    break;  // Esce dal ciclo se la sequenza non è più decrescente
                }


                previousNumber = temp;
                count++;
            }

            if (count > 0)
            {
                double somma = 0;

                Console.WriteLine($"\nHai inserito {count} numeri.");

                // Calcoliamo la somma e la media
                somma = count * (previousNumber + 1);  // Usa la somma di numeri
                double media = somma / count;  

                Console.WriteLine($"La media dei numeri è: {media}");
            }
        }


        /*
           Creare una classe che rappresenti una macchinetta per il caffè a cialde. Dotare la classe degli
            attributi e dei costruttori appropriati. Dotare la classe dei metodi necessari per fare queste
            azioni:
                a. Simulare un caffè, usando una cialda.
                b. Svuotare il cassetto delle cialde usate quando è pieno.
                c. Mostrare quanti caffè sono stati fatti in totale.
                d. Mostrare quanti caffè sono stati fatti dall’ultima volta che si è svuotato il cassetto delle cialde usate.
        */
        public class MacchinettaCaffe
        {
            // Attributi
            private int cialdeUsate;
            private int cialdeTotali;
            private int caffèFattiUltimaVolta;
            private const int CapienzaCassetto = 10; // La capienza del cassetto delle cialde usate

            // Costruttore
            public MacchinettaCaffe(int cialde)
            {
                this.cialdeTotali = cialde; // Numero di cialde iniziali
                this.cialdeUsate = 0;
                this.caffèFattiUltimaVolta = 0;
            }

            // Metodo per simulare la preparazione di un caffè
            public void FaiCaffe()
            {
                if (this.cialdeTotali > 0) // Verifica se ci sono cialde disponibili
                {
                    this.cialdeTotali--; // Usato una cialda
                    this.cialdeUsate++;  // Aggiunta una cialda usata al cassetto
                    this.caffèFattiUltimaVolta++; // Aumenta i caffè fatti nell'ultima sessione

                    Console.WriteLine("Caffè preparato!");
                }
                else
                {
                    Console.WriteLine("Non ci sono più cialde disponibili!");
                }

                // Se il cassetto è pieno, svuotalo
                if (this.cialdeUsate == CapienzaCassetto)
                {
                    this.SvuotaCassetto();
                }
            }

            // Metodo per svuotare il cassetto delle cialde usate
            public void SvuotaCassetto()
            {
                this.cialdeUsate = 0; // Svuota il cassetto
                Console.WriteLine("Cassetto delle cialde usate svuotato!");
            }

            // Metodo per mostrare il numero totale di caffè fatti
            public void MostraCaffeFattiTotali()
            {
                Console.WriteLine($"Numero totale di caffè fatti: {this.caffèFattiUltimaVolta}");
            }

            // Metodo per mostrare il numero di caffè fatti dall'ultima volta che è stato svuotato il cassetto
            public void MostraCaffeFattiDallUltimaVolta()
            {
                Console.WriteLine($"Caffè fatti dall'ultima volta che è stato svuotato il cassetto: {this.caffèFattiUltimaVolta}");
            }

            // Metodo per visualizzare lo stato della macchinetta
            public void StatoMacchinetta()
            {
                Console.WriteLine($"Cialde totali disponibili: {this.cialdeTotali}");
                Console.WriteLine($"Cialde usate nel cassetto: {this.cialdeUsate}");
                Console.WriteLine($"Capienza del cassetto: {CapienzaCassetto}\n");
            }
        }
    }
}
