namespace duzy_lotek;

public partial class Form1 : Form
{
    private List<int> glowneLiczby;
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

    
}
