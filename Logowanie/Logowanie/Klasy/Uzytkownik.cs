using System;
using System.Collections.Generic;
using System.Text;

namespace Logowanie.Klasy
{
    class Uzytkownik
    {
        public string Login;
        public string Haslo;
        public int Wiek;
        public string Email;
        public string PrzedstawSie()
        {
            Wiek += 10;
            string tekst = $"Użytkownik {Login} ma {Wiek} lat i adres mail: {Email}";
            return tekst;
        }

    }
}
