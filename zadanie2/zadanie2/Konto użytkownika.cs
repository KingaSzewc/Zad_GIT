using System;
using System.Collections.Generic;
using System.Text;

namespace zadanie2
{
    public class Konto_użytkownika
    {
        private string _login;
        private string _haslo;
        private string _imie;
        private string _nazwisko;
        private string _adres;
        private DateTime _dataUrodzenia;

        public string Login
        {
            get { return _login; }
            set { _login = value; }
        }
        public string Haslo
        {
            get
            {
                var nowehaslo = string.Empty;

                for (int i = 0; i < _haslo.Length; i++)
                {
                    nowehaslo += "*";
                }

                return nowehaslo;
            }
            set { _haslo = value; }
        }
        public string Imie
        {
            get { return _imie; }
            set { _imie = value; }
        }
        public string Nazwisko
        {
            get { return _nazwisko; }
            set { _nazwisko = value; }
        }
        public string Adres
        {
            get { return _adres; }
            set { _adres = value; }
        }
        public DateTime DataUrodzenia
        {
            get { return _dataUrodzenia; }
            set { _dataUrodzenia = value; }
        }

        public Konto_użytkownika()
        {
            _login = "login";
            _haslo = "hasloooooooooooooooooooooo";
            _imie = "imie";
            _nazwisko = "nazwisko";
            _adres = "adres";
            _dataUrodzenia = new DateTime(2000, 1, 1);       
        }
        public Konto_użytkownika(string login, string haslo, string imie, string nazwisko, string adres, DateTime dataUrodzenia)
        {
            this._login = login;
            this._haslo = haslo;
            this._imie = imie;
            this._nazwisko = nazwisko;
            this._adres = adres;
            this._dataUrodzenia = dataUrodzenia;
        }
        public string toString()
        {
            var output = string.Empty;
            output += Login;
            output += "\n";
            output += Haslo;
            output += "\n";
            output += Imie;
            output += "\n";
            output += Nazwisko;
            output += "\n";
            output += Adres;
            output += "\n";
            output += DataUrodzenia;
            output += "\n";
            return output;
        }

    }
}
