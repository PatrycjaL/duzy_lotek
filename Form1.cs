namespace duzy_lotek;

using System.Threading;

public partial class Form1 : Form
{
    private List<int> glowneLiczby;
    private int trafienia3;
    private int trafienia4;
    private int trafienia5;
    private Thread watekMaszyna1;
    private Thread watekMaszyna2;
    private bool czyZatrzymac = false;

    public Form1()
    {
        InitializeComponent();
        Text = "Duży Lotek";
        glowneLiczby = LosujLiczby();
        lblGlowneLiczbyWyswietl.Text = string.Join(", ", glowneLiczby);
    }

    private void btnLosuj_Click(object sender, EventArgs e)
    {
        czyZatrzymac = false;
        btnLosuj.Enabled = false;

        watekMaszyna1 = new Thread(() => UruchomMaszyne(lblWynikMaszyna1));
        watekMaszyna2 = new Thread(() => UruchomMaszyne(lblWynikMaszyna2));

        watekMaszyna1.Start();
        watekMaszyna2.Start();
    }

    private void UruchomMaszyne(Label lblWynik)
    {
        while (!czyZatrzymac)
        {
            Invoke(() =>
            {
                WykonajLosowanie(lblWynik);
            });

            Thread.Sleep(500);
        }
    }

    private void WykonajLosowanie(Label lblWynik)
    {
        List<int> wylosowaneLiczby = LosujLiczby();

        lblWynik.Text = string.Join(", ", wylosowaneLiczby);

        int trafienia = PoliczTrafienia(wylosowaneLiczby);

        lblWynik.Text += $" | Trafienia: {trafienia}";

        switch (trafienia)
        {
            case 3:
                trafienia3++;
                break;

            case 4:
                trafienia4++;
                break;

            case 5:
                trafienia5++;
                break;

            case 6:
                czyZatrzymac = true;
                MessageBox.Show("Została wylosowana 6!");
                break;
        }

        AktualizujStatystyki();
    }

    private List<int> LosujLiczby()
    {
        Random random = new Random();
        List<int> liczby = new List<int>();
        while (liczby.Count < 6)
        {
            int liczba = random.Next(1, 50);
            if (!liczby.Contains(liczba))
            {
                liczby.Add(liczba);
            }
        }

        return liczby;
    }

    private int PoliczTrafienia(List<int> wylosowaneLiczby)
    {
        int liczbaTrafien = 0;
        foreach (int liczba in wylosowaneLiczby)
        {
            if (glowneLiczby.Contains(liczba))
            {
                liczbaTrafien++;
            }

        }

        return liczbaTrafien;
    }

    private void AktualizujStatystyki()
    {
        lblIlosc3.Text = trafienia3.ToString();
        lblIlosc4.Text = trafienia4.ToString();
        lblIlosc5.Text = trafienia5.ToString();
    }

    private void btnStop_Click(object sender, EventArgs e)
    {
        czyZatrzymac = true;
        btnLosuj.Enabled = true;
    }
}
