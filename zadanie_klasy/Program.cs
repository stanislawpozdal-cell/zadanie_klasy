using zadanie_klasy;

int parsuj(string a)
{
    if (int.TryParse(a,out int wynik))
    {
        return wynik;
    }
    else
    {
        return -1;
    }
}

double parsuj_d(string a)
{
    if (double.TryParse(a.Replace('.',','), out double wynik))
    {
        return wynik;
    }
    else
    {
        return -1.0;
    }
}

Auto samochód = new(100000.0, "Passat", "Volkswagen", 0, 2026);
while (true)
{
    
    Console.WriteLine("\nWybierz:\n0 jeżeli chesz zakończyć program\n1 jeżeli chcesz wypisać dane swojego samochodu\n2 jeżeli chcesz prowadzić swój samochód\n3 jeżeli chcesz zatrzymać samochód\n4 jeżeli chcesz zrobić promocję\n5 jeżeli chesz stworzyć nowy samochód");
    int wynik = parsuj(Console.ReadLine());

    if (wynik == 0)
    {
        break;
    }
    else if (wynik == 1)
    {
        samochód.Opisz();
    }
    else if (wynik == 2)
    {
        samochód.Prowadz();
    }
    else if (wynik == 3)
    {
        samochód.Zatrzymaj();
    }
    else if (wynik == 4)
    {
        samochód.Promocja();
    }
    else if (wynik == 5)
    {
        Console.Write("Podaj cene: ");
        double Cena = parsuj_d(Console.ReadLine());
        Console.Write("Podaj Model: ");
        string Model = Console.ReadLine();
        Console.Write("Podaj Markę: ");
        string Marka = Console.ReadLine();
        Console.Write("Podaj Przebieg: ");
        double Przebieg = parsuj_d(Console.ReadLine());
        Console.Write("Podaj Rocznik: ");
        int rocznik = parsuj(Console.ReadLine());

        if (Cena!=-1 || Przebieg != -1.0 || rocznik != -1)
        {
            samochód = new(Cena, Model, Marka, Przebieg, rocznik);
        }
        else
        {
            Console.WriteLine("Niepoprawne dane");
        }
        
    }
    else
        Console.WriteLine("Nieznana opcja");
}
