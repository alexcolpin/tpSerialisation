namespace tpSerialisation;

class Program
{
    static void Main(string[] args)
    {
        GestionJeux gestion = new GestionJeux();

        gestion.AjouterJeu(new JeuVideo("Minecraft", "Mojang", 29.99));
        gestion.AjouterJeu(new JeuVideo("Mario Kart 8 Deluxe", "Nintendo", 59.99));
        gestion.AjouterJeu(new JeuVideo("The Witcher 3", "CD Projekt", 39.99));

        gestion.Afficher();
        gestion.SauvegarderCSV("jeux.csv");
    }
}

internal class GestionJeux
{
    internal void Afficher()
    {
        throw new NotImplementedException();
    }

    internal void AjouterJeu(JeuVideo jeuVideo)
    {
        throw new NotImplementedException();
    }

    internal void SauvegarderCSV(string v)
    {
        throw new NotImplementedException();
    }
}