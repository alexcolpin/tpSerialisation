class JeuVideo
{
    private string titre;
    private string studio;
    private double prix;

    public string Titre { get => titre; set => titre = value; }
    public string Studio { get => studio; set => studio = value; }
    public double Prix { get => prix; set => prix = value; }

    // constructeur vide
    public JeuVideo() { }

    // constructeur avec paramètres
    public JeuVideo(string t, string s, double p)
    {
        titre = t;
        studio = s;
        prix = p;
    }
}