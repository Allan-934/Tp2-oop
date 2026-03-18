namespace tp2;
using System;

class Program
{
    static void Main()
        {
            // 1. Création et initialisation des comptes
            Compte compte1 = new Compte();
            compte1.SetNumero(1);
            compte1.SetNom("Alice");
            compte1.SetSolde(1000);

            Compte compte2 = new Compte();
            compte2.SetNumero(2);
            compte2.SetNom("Bob");
            compte2.SetSolde(500);

            Compte compte3 = new Compte();
            compte3.SetNumero(3);
            compte3.SetNom("Charlie");
            compte3.SetSolde(200);

            // 2. Opérations
            compte1.Crediter(300);              // Créditer Alice de 300
            compte2.Debiter(100);               // Débiter Bob de 100
            compte1.Transferer(compte3, 150);    // Transférer 150 d'Alice vers Charlie

            // 3. Affichage final
            Console.WriteLine("=== ÉTAT FINAL DES COMPTES ===");
            compte1.Afficher();
            compte2.Afficher();
            compte3.Afficher();
        }

   
}