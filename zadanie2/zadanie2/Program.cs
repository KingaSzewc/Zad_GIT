using System;

namespace zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            //zadanie1
            //Konto_użytkownika konto1 = new Konto_użytkownika();
            //var stringg = konto1.toString();
            //Console.WriteLine(stringg);

            //zadanie2
            //Liczba_zespolona liczba1 = new Liczba_zespolona(0, -4);
            //Liczba_zespolona liczba2 = new Liczba_zespolona(5, 8);
            //Liczba_zespolona liczba3 = Liczba_zespolona.Dodaj(liczba1, liczba2);
            //Liczba_zespolona liczba4 = Liczba_zespolona.Odejmij(liczba1, liczba2);
            //Liczba_zespolona liczba5 = Liczba_zespolona.Mnozenie(liczba1, liczba2);
            //Liczba_zespolona liczba6 = Liczba_zespolona.Dzielenie(liczba1, liczba2);
            //Console.WriteLine(liczba3.toString());
            //Console.WriteLine(liczba4.toString());
            //Console.WriteLine(liczba5.toString());
            //Console.WriteLine(liczba6.toString());



            //zadanie3
            Stos stos = new Stos(5);

            for (int i = 0; i < 10; i++)
            {
                stos.push(i);
            }

            for (int i = 0; i < 10; i++)
            {
                var liczba = stos.pop();
                if (liczba != null)
                {
                    Console.WriteLine(liczba);
                }
            }
        }

    }
}
