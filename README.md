 #Piramide
Quando si avvia un progetto come la costruzione di una piramide, è meglio pensarci due volte.
Il tuo compito oggi è scrivere un programma che calcoli l'altezza massima di una piramide (in piani) dato un certo numero di cubi di pietra.
Ipotizzando che:
- i piani della piramide siano quadrati
- la piramide da costruire sia compatta, cioè non ci siano cavità al suo interno. 
- ogni piano è quadrato, con una lunghezza laterale inferiore di due rispetto a quella sottostante.
- il primo piano è sempre di un mattone
Esempi:
- il primo piano ha un mattone, il secondo 9 mattoni, il terzo 25 e così via
- con 1 mattone la piramide è alta 1 piano
- con 84 mattoni la piramide è alta 4 piani
Va bene se hai blocchi rimanenti, purché tu costruisca una piramide completa.
Sviluppare:
- il metodo int Piani( int mattoni ) che torna il numero di piani
- il metodo int Rimanenti( int mattoni ) che torna il numero di mattoni rimasti dopo la costruzione

        ```
        public static int Piani(int mattoni)
        {
            if (mattoni < 1) return 0; 
            int piani = 1;
            int mattoni_rimasti = mattoni;
            while (mattoni_rimasti >= (2 * piani + 1) * (2 * piani + 1) - 2 * piani)
            {
                mattoni_rimasti -= (2 * piani + 1) * (2 * piani + 1) - 2 * piani;
                piani++;
            }
            return piani;
        }
        ```
Il metodo Piani riceve in input un intero mattoni, che rappresenta il numero di mattoni disponibili per costruire una piramide. Il metodo calcola il numero massimo di piani che possono essere costruiti con il numero di mattoni disponibili e lo restituisce come risultato.
Per fare ciò, il metodo inizia controllando se il numero di mattoni è inferiore a 1. In questo caso, restituisce subito il valore 0, perché non è possibile costruire una piramide con 0 o meno mattoni.

Successivamente, il metodo inizializza due variabili: piani a 1 (perché una piramide con un solo mattoncino ha un solo piano) e mattoni_rimasti a mattoni (perché all'inizio tutti i mattoni sono disponibili).

Il metodo entra quindi in un ciclo while che viene eseguito finché il numero di mattoni rimasti è sufficiente per costruire il numero di mattoni necessari per il prossimo piano
Ad ogni iterazione del ciclo, il numero di mattoni rimasti viene aggiornato sottraendo il numero di mattoni necessari per costruire il prossimo piano e il numero di piani viene incrementato di 1.

Alla fine del ciclo, il metodo restituisce il numero di piani calcolato.

 ```
public static int Rimanenti(int mattoni)
        {
            int piani = Piani(mattoni);
            int mattoni_necessari = (2 * piani - 1) * (2 * piani - 1);
            return mattoni - mattoni_necessari;
        }
  ```
        
Il metodo Rimanenti prende in input  il numero di mattoni disponibili e restituisce il numero di mattoni rimanenti dopo aver costruito la piramide completa.
Per calcolare il numero di mattoni rimanenti, il metodo chiama il metodo Piani per determinare il numero di piani che possono essere costruiti con il numero di mattoni forniti. Successivamente, il numero di mattoni necessari per costruire la piramide completa viene calcolato moltiplicando il numero di piani per il numero di mattoni necessari per ogni piano.
Infine, il numero di mattoni rimanenti viene calcolato sottraendo il numero di mattoni necessari dal numero di mattoni forniti e restituito come risultato.


