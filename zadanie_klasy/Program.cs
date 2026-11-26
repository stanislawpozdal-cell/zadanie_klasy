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
List<Auto> samochody = new List<Auto>();
Auto samochód = new(100000.0, "Passat", "Volkswagen", 0, 2026);
samochody.Add(samochód);
while (true)
{
    
    Console.WriteLine("\nWybierz:\n0 jeżeli chesz zakończyć program\n1 jeżeli chcesz wypisać dane swoich  samochodów\n2 jeżeli chcesz prowadzić swój samochód\n3 jeżeli chcesz zatrzymać samochód\n4 jeżeli chcesz zrobić promocję\n5 jeżeli chesz stworzyć nowy samochód");
    int wynik = parsuj(Console.ReadLine());

    if (wynik == 0)
    {
        break;
    }
    else if (wynik == 1)
    {
        int i = 0;
        foreach (var samochod in samochody)
        {
            Console.WriteLine($"Indeks: {i}");
            samochod.Opisz();
            Console.WriteLine("\n");
            i++;
        }
            
        
        
    }
    else if (wynik == 2)
    {
        Console.Write("Podaj indeks samochodu, który chcesz prowadzić: ");
        int i = parsuj(Console.ReadLine());
        if (i >= 0 && i < samochody.Count)
        {
            samochody[i].Prowadz();
        }
        else
        {
            Console.WriteLine("Niepoprawny indeks");
        }
    }
    else if (wynik == 3)
    {
        Console.Write("Podaj indeks samochodu, który chcesz zatrzymać: ");
        int i = parsuj(Console.ReadLine());
        if (i >= 0 && i < samochody.Count)
        {
            samochody[i].Zatrzymaj();
        }
        else
        {
            Console.WriteLine("Niepoprawny indeks");
        }
    }
    else if (wynik == 4)
    {
        Console.Write("Podaj indeks samochodu, któremu chcesz zrobić promocję: ");
        int i = parsuj(Console.ReadLine());
        if (i >= 0 && i < samochody.Count)
        {
            samochody[i].Promocja();
        }
        else
        {
            Console.WriteLine("Niepoprawny indeks");
        }
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

        if (Cena!=-1 && Przebieg != -1.0 && rocznik != -1 && rocznik <= 2026 && rocznik >= 1900)
        {
            Auto nowy_samochod = new(Cena, Model, Marka, Przebieg, rocznik);
            samochody.Add(nowy_samochod);
        }
        else
        {
            Console.WriteLine("Niepoprawne dane");
        }
        
    }
    else
        Console.WriteLine("Nieznana opcja");
}
