public class CompteEpargne: Compte
{
    private double tauxInteret;
    private string dateOuverture = string.Empty;

    // Getters
    public double GetTauxInteret() { return tauxInteret; }
    public string GetDateOuverture() { return dateOuverture; }
    // Setters
    public void SetTauxInteret(double tauxInteret) { this.tauxInteret = tauxInteret; }
    public void SetDateOuverture(string dateOuverture) { this.dateOuverture = dateOuverture; }

   
    public void Afficher()
    {
        Console.WriteLine($"Compte Epargne | Compte N°: {numero} | Nom: {nom} | Solde: {solde} euros | Taux d'intérêt: {tauxInteret}% | Date d'ouverture: {dateOuverture}");
    }
}