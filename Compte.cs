public class Compte
    {
        private int numero;
        private string nom = string.Empty;
        private double solde;

        // Getters
        public int GetNumero() { return numero; }
        public string GetNom() { return nom; }
        public double GetSolde() { return solde; }

        // Setters
        public void SetNumero(int numero) { this.numero = numero; }
        public void SetNom(string nom) { this.nom = nom; }
        public void SetSolde(double solde) { this.solde = solde; }

        // Méthodes métier
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
            Console.WriteLine($"Compte N°: {numero} | Titulaire: {nom} | Solde: {solde} euros");
        }
    }