namespace duzy_lotek;

public partial class Form1 : Form
{
    private List<int> glowneLiczby;
    private int trafienia3;
    private int trafienia4;
    private int trafienia5;
    public Form1()
    {
        InitializeComponent();
        Text = "Duży Lotek";
        glowneLiczby = LosujLiczby();
        lblGlowneLiczbyWyswietl.Text = string.Join(", ", glowneLiczby);
    }

    private void btnLosuj_Click(object sender, EventArgs e)
    {
        List<int> wylosowaneLiczby = LosujLiczby();
        lblWynikMaszyna1.Text = string.Join(", ", wylosowaneLiczby);
        int trafienia = PoliczTrafienia(wylosowaneLiczby);
        lblWynikMaszyna1.Text += $" | Trafienia: {trafienia}";
        switch(trafienia)
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
                MessageBox.Show("Została wylosowana 6!");
                break;
        }

        lblIlosc3.Text = trafienia3.ToString();
        lblIlosc4.Text = trafienia4.ToString();
        lblIlosc5.Text = trafienia5.ToString();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        List<int> wylosowaneLiczby = LosujLiczby();
        lblWynikMaszyna2.Text = string.Join(", ", wylosowaneLiczby);
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
        foreach(int liczba in wylosowaneLiczby)
        {
            if (glowneLiczby.Contains(liczba))
            {
                liczbaTrafien++;
            }

        }

        return liczbaTrafien;
    }

    
}
