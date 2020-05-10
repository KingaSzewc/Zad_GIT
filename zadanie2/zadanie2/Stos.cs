using System;
using System.Collections.Generic;
using System.Text;

namespace zadanie2
{
    public class Stos
    {
        private int[] tablica;
        private int aktualnyElement;
        private int rozmiarStosu;

        public Stos(int rozmiarTablicy)
        {
            tablica = new int[rozmiarTablicy];
            aktualnyElement = -1;
            rozmiarStosu = rozmiarTablicy;
        }

        public void push(int n)
        {
            if (isFull()) {
                Console.WriteLine("Stos pełny");
                return;
            }

            aktualnyElement++;
            tablica[aktualnyElement] = n;
        }
        public int? pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stos pusty");
                return null;
            }
            var liczbaSzczyt = tablica[aktualnyElement];
            tablica[aktualnyElement] = 0;
            aktualnyElement--;
            return liczbaSzczyt;
        }

        public bool isEmpty()
        { 
            return aktualnyElement == -1;
        }

        public bool isFull()
        {
            return aktualnyElement == rozmiarStosu - 1;
        }
    }
}
