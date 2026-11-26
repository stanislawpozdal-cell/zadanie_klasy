using System;
using System.Collections.Generic;
using System.Text;

namespace zadanie_klasy
{
    public class Auto
    {
        private double cena { get; set; }
        private string model { get; set; }
        private string marka { get; set; }
        private double przebieg { get; set; }
        private int rocznik { get; set; }

        public Auto(double Cena, string Model, string Marka, double Przebieg, int Rocznik)
        {
            cena = Cena;
            model = Model;
            marka = Marka;
            przebieg = Przebieg;
            rocznik = Rocznik;
        }

        public void Prowadz()
        {
            przebieg += 100;
            Console.WriteLine("Przejechałeś 100KM");
        }

        public void Zatrzymaj()
        {
            Console.WriteLine($"Przebieg wynosi {przebieg}KM ");
        }

        public void Opisz()
        {
            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"Marka: {marka}");
            Console.WriteLine($"Cena: {cena}zł");
            Console.WriteLine($"Rocznik: {rocznik}r");
        }

        public void Promocja()
        {
            Console.WriteLine("Dostajesz promocje 10%");
            cena -= cena / 10;
            Console.WriteLine($"Nowa cena: {cena} ");
        }

    }

}
