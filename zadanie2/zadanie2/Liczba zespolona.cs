using System;
using System.Collections.Generic;
using System.Text;

namespace zadanie2
{
    public class Liczba_zespolona
    {
        private double _rzeczywista;
        private double _urojona;
        public double X
        {
            get { return _rzeczywista; }
            set { _rzeczywista = value; }
        }
        public double Y
        {
            get { return _urojona; }
            set { _urojona = value; }
        }
        public Liczba_zespolona()
        {

        }

        public Liczba_zespolona(double x, double y)
        {
            this._rzeczywista = x;
            this._urojona = y;
        }       
        
        public static Liczba_zespolona Dodaj(Liczba_zespolona liczba1, Liczba_zespolona liczba2)
        {
            var x = liczba1.X + liczba2.X;
            var y = liczba1.Y + liczba2.Y;
            return new Liczba_zespolona(x, y);
        }

        public static Liczba_zespolona Odejmij(Liczba_zespolona liczba1,Liczba_zespolona liczba2)
        {
            var x = liczba1.X - liczba2.X;
            var y = liczba1.Y - liczba2.Y;
            return new Liczba_zespolona(x, y);
        }

        public static Liczba_zespolona Mnozenie(Liczba_zespolona liczba1, Liczba_zespolona liczba2)
        {
            var x = liczba1.X * liczba2.X;
            var y = liczba1.Y * liczba2.Y;
            return new Liczba_zespolona(x, y);
        }

        public static Liczba_zespolona Dzielenie(Liczba_zespolona liczba1, Liczba_zespolona liczba2)
        {
            var x = liczba1.X / liczba2.X;
            var y = liczba1.Y / liczba2.Y;
            return new Liczba_zespolona(x, y);
        }

        public string toString()
        {
            var output = string.Empty;
            if (X != 0)
            {
                output += $"{X}";
            }
            if (X != 0 && Y != 0 && Y > 0)
            {
                output += $"+";
            }
            if (Y != 0 && Y < 0)
            {
                output += $"-";
            }
            if (Y != 0)
            {
                output += $"i*{Math.Abs(Y)}";
            }
            return output;
        }
    }
}
