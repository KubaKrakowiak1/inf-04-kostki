namespace mobilna
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

            public int wynikGry = 0;
        private void Rzuc(object? sender, EventArgs e)
        { 
            Random random = new Random();

            int liczbaOczek = 0;
            int[] tab = new int[5];
            for(int i = 0; i < 5; i++)
            {
                liczbaOczek= random.Next(1, 7);
                tab[i] = liczbaOczek;
            }
                zdj1.Source = $"k{tab[0]}.jpg";
                zdj2.Source = $"k{tab[1]}.jpg";
                zdj3.Source = $"k{tab[2]}.jpg";
                zdj4.Source = $"k{tab[3]}.jpg";
                zdj5.Source = $"k{tab[4]}.jpg";

            int[] licznikOczek = new int[7];

            foreach (int i in tab)
            {
                licznikOczek[i]++;
            }

            int pkt = 0;

            for (int i = 1; i <= 6; i++)
            {
                if (licznikOczek[i] >= 2)
                {
                    pkt += i * licznikOczek[i];
                }
            }

            wynikLosowania.Text = $"Wynik tego losowania: {pkt}";
            wynikGry += pkt;
            wynikGryLbl.Text = $"Wybik gry: {wynikGry}";
        }

        void Resetuj(object? sender,  EventArgs e)
        {
            zdj1.Source = "question.jpg";
            zdj2.Source = "question.jpg";
            zdj3.Source = "question.jpg";
            zdj4.Source = "question.jpg";
            zdj5.Source = "question.jpg";

            wynikGry = 0;
            wynikGryLbl.Text = $"Wynik gry: 0";
            wynikLosowania.Text = $"Wybik losowania: 0";
        }
    }
}

