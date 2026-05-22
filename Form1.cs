namespace duzy_lotek;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        Text = "Duży Lotek";
    }

    private void btnLosuj_Click(object sender, EventArgs e)
    {
        List<int> wylosowaneLiczby = LosujLiczby();
        lblWynik.Text = string.Join(", ", wylosowaneLiczby);
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
