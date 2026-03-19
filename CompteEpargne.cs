public class CompteEpargne
{
    private double tauxInteret;
    private string dateOuverture;
    // attribut copie de compte.cs
    private int numero;
    private string nom = string.Empty;
    private double solde;

    // Getters
    public double GetTauxInteret() { return tauxInteret; }
    public string GetDateOuverture() { return dateOuverture; }
    // Setters
    public void SetTauxInteret(double tauxInteret) { this.tauxInteret = tauxInteret; }
    public void SetDateOuverture(string dateOuverture) { this.dateOuverture = dateOuverture; }

    // getters et setters de Compte.cs copie 

    public int GetNumero() { return numero; }
    public string GetNom() { return nom; }
    public double GetSolde() { return solde; }
    public void SetNumero(int numero) { this.numero = numero; }
    public void SetNom(string nom) { this.nom = nom; }
    public void SetSolde(double solde) { this.solde = solde; }

    public void Crediter(double montant)
    {
        solde += montant;
    }

    public bool Debiter(double montant)
    {
        if (montant <= solde)
        {
            solde -= montant;
            return true;
        }
        return false;
    }

    public void Transferer(Compte destinataire, double montant)
    {
        if (this.Debiter(montant))
        {
            destinataire.Crediter(montant);
        }
    }
    public void Afficher()
    {
        Console.WriteLine($"Compte Epargne | Compte N°: {numero} | Nom: {nom} | Solde: {solde} euros | Taux d'intérêt: {tauxInteret}% | Date d'ouverture: {dateOuverture}");
    }
}