using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logowanie.Klasy;

namespace Logowanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnZaloguj_Click(object sender, EventArgs e)
        {
            Uzytkownik u1 = new Uzytkownik();
            u1.Login = "gigant";
            u1.Haslo = "gigant123";
            u1.Email = "gigant@gmail.com";
            u1.Wiek = 20;
            if (u1.Login == tbLogin.Text && u1.Haslo == tbHaslo.Text)
            {
                MessageBox.Show($"Zalogowano poprawnie. {u1.PrzedstawSie()}","Komunikat", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Login lub hasło niepoprawne", "Błąd", MessageBoxButtons.OK);
            }
        }
    }
}
