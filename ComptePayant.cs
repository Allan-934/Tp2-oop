public class ComptePayant: Compte 
{
    private int commision;
    private int nombreOperations = 0;

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

    public void Crediter(int nombreOperations)
    {
        this.nombreOperations++; 
    }

    public bool Debiter(int nombreOperations, double solde)
    {
            this.nombreOperations++;
            solde -= commision;
            return true;
    }

    public void Transferer(Compte destinataire, double montant)
    {
        if (this.Debiter(montant))
        {
            destinataire.Crediter(montant);
            nombreOperations++;
            solde -= commision;

        }
    }

    public void Afficher()
    {
        Console.WriteLine($"Compte Payant | Numéro:{numero} | Nom: {nom} | Solde: {solde} euros |Commission: {commision} | Nombre d'opérations: {nombreOperations}");
    }
}