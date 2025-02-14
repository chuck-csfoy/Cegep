namespace TP3_ETU
{
  public class Clan
  {
    // Ajoutez ici les propriétés qui composent un clan
    // Vous pouvez nommer vos champs en anglais ou en français. !! Gardez toutefois la même langue pour tout votre travail !!

    //Si option Enum elle serait a inserer ici.

    // - Nom du clan (string)
    public string Name { get; set; }
    // - Année de création (int)
    public int CreationYear { get; set; }
    // - Type de clan (int)
    public int Type { get; set; }
    // - Score (int)
    public int Score { get; set; }
    // - Joueurs (liste de int)
    public List<int> Players { get; set; }
  }
}
