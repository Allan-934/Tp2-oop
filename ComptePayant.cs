public class ComptePayant
{
    private int commision;
    private int nombreOperations = 0;
    // attribut copie de compte.cs
    private int numero;
    private string nom = string.Empty;
    private double solde;

    // Getters
    public int GetCommission() { return commision; }
    public int GetNombreOperations() { return nombreOperations; }
    // Setters
    public void SetCommission(int commision) { this.commision = commision; }
    public void SetNombreOperations(int nombreOperations) { this.nombreOperations = nombreOperations; }

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
        nombreOperations++;
    }

    public bool Debiter(double montant)
    {
        if (montant <= solde)
        {
            solde -= montant;
            nombreOperations++;
            return true;
        }
        return false;
    }

    public void Transferer(Compte destinataire, double montant)
    {
        if (this.Debiter(montant))
        {
            destinataire.Crediter(montant);
            nombreOperations++;
        }
    }

    public void Afficher()
    {
        Console.WriteLine($"Compte Payant | Numéro:{numero} | Nom: {nom} | Solde: {solde} euros |Commission: {commision} | Nombre d'opérations: {nombreOperations}");
    }
}