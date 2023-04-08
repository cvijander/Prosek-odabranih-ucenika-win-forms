namespace Prosek_u_odeljenju
{
    public partial class Form1 : Form
    {
        private List<Ucenik> listaUcenika = new List<Ucenik>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listaUcenika.Add(new Ucenik("Dragan", "Cvijic", 5));
            listaUcenika.Add(new Ucenik("Ana", "Cvetkovic", 4));
            listaUcenika.Add(new Ucenik("Mirko", "Petrovic", 3));
            listaUcenika.Add(new Ucenik("Milos", "Medakovic", 4));
            listaUcenika.Add(new Ucenik("Nenad", "Bjekovic", 3));
            listaUcenika.Add(new Ucenik("Mile", "Ilic", 5));
            listaUcenika.Add(new Ucenik("Milica", "Paunovic", 5));
            listaUcenika.Add(new Ucenik("Dragica", "Pejic", 5));
            listaUcenika.Add(new Ucenik("Mika", "Dragicevic", 2));
            listaUcenika.Add(new Ucenik("Pera", "Lazic", 3));
            listaUcenika.Add(new Ucenik("Laza", "Milicevic", 2));
            listaUcenika.Add(new Ucenik("Zoran", "Paracinovic", 3));
            listaUcenika.Add(new Ucenik("Bojana", "Dosen", 5));

            foreach (Ucenik uce in listaUcenika)
            {
                checkedListBox1.Items.Add(uce.ToString());
            }
            for (int i = 0; i < listaUcenika.Count; i++)
            {
                checkedListBox1.SetItemCheckState(i, CheckState.Checked);
            }
        }

        private void btnRacunaj_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<int> odabrani = new List<int>();
            for (int i = 0; i < listaUcenika.Count; i++)
            {
                if (checkedListBox1.GetItemCheckState(i) == CheckState.Checked)
                {
                    odabrani.Add(listaUcenika[i].Ocena);
                }
            }
            listBox1.Items.Add("Odabrano je " + odabrani.Count + " ucenika");
            listBox1.Items.Add("Prosecna ocena je: ");
            listBox1.Items.Add(odabrani.Average().ToString());
        }
    }
}