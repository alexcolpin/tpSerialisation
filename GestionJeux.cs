namespace tpSerialisation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Text.Json;

public class GestionJeux
{
    private List<JeuVideo> liste = new List<JeuVideo>();

    public void AjouterJeu(JeuVideo jeu)
    {
        liste.Add(jeu);
    }

    public void SupprimerJeu(JeuVideo jeu)
    {
        liste.Remove(jeu);
    }

    public void Afficher()
    {
        foreach (var jeu in liste)
        {
            Console.WriteLine(jeu.Titre + " - " + jeu.Studio + " - " + jeu.Prix);
        }
    }

    public List<JeuVideo> GetListe()
    {
        return liste;
    }


    public void SauvegarderCSV(string fichier)
    {
         StreamWriter sw = new StreamWriter(fichier);
        
            foreach (JeuVideo jeu in liste)
            {
                sw.WriteLine(jeu.Titre + ";" + jeu.Studio + ";" + jeu.Prix);
            }
         sw.Close();
    }
    public void ChargerCSV(string fichier)
    {
        if (File.Exists(fichier))
        {
            liste.Clear();

            foreach (var ligne in File.ReadAllLines(fichier))
            {
                var parties = ligne.Split(';');
                liste.Add(new JeuVideo(parties[0], parties[1], double.Parse(parties[2])));
            }
        }
    }
    

    public void SauvegarderXML(string fichier)
    {
        XmlSerializer xs = new XmlSerializer(typeof(List<JeuVideo>));
        using (FileStream fs = new FileStream(fichier, FileMode.Create))
        {
            xs.Serialize(fs, liste);
        }
    }
    

    public void SauvegarderJSON(string fichier)
    {
        string json = JsonSerializer.Serialize(liste);
        File.WriteAllText(fichier, json);
    }
}



