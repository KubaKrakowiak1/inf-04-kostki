class Program
{
    static void Main(string[] args)
    {
        Losuj();
    }

    static void Losuj()
    {
        char ponownie;

            int ileKostek = 0;
            do
            {
                Console.WriteLine("Ile kostek chcesz rzucić?(3 - 10)");
                ileKostek = int.Parse(Console.ReadLine());
            } while (ileKostek < 3 || ileKostek > 10);

        do
        {
            Random rand = new Random();
            int kostki = 0;
            int[] tab = new int[ileKostek];

            for (int i = 1; i <= ileKostek; i++)
            {
                kostki = rand.Next(1, 7);
                Console.WriteLine($"Kostka {i}: {kostki}");
                tab[i - 1] = kostki;
            }

            Console.WriteLine(Licz(tab));
            Console.WriteLine("Jeszcze raz? (t/n)");
            ponownie = char.Parse(Console.ReadLine());
        } while (ponownie == 't');
    }

    static int Licz(int[] tab)
    {
        int[] licznikOczek = new int[7];

        foreach(int i in tab)
        {
            licznikOczek[i]++;
        }

        int pkt = 0;

        for(int i = 1; i <= 6; i++)
        {
            if (licznikOczek[i] >= 2)
            {
                pkt += i * licznikOczek[i];
            }
        }

        return pkt;
    }
}

/************************************************
 nazwa: Losuj
 opis: Pobiera liczbę kostek, losuje wyniki rzutów,
       wyświetla wyniki i punkty oraz umożliwia
       powtórzenie gry.
 parametry: brak
 zwracany typ i opis: brak(void)
************************************************/