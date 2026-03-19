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

            //partie 2 
            CompteEpargne ce1 = new CompteEpargne();
            ce1.SetNumero(10);
            ce1.SetNom("Diane");
            ce1.SetSolde(800);
            ce1.SetTauxInteret(0.04);
            ce1.SetDateOuverture("01/09/2024");
            

            ComptePayant cp1 = new ComptePayant();
            cp1.SetNumero(11);
            cp1.SetNom("Emma");
            cp1.SetSolde(600);
            cp1.SetCommission(2);

            // Opérations de la partie 2
            ce1.Crediter(100);              // Créditer Diane de 200
            ce1.Debiter(200);              // Débiter Diane de 200
            //ce1.Debiter(800);            // Débiter Diane de 800 (échoue)

            cp1.Crediter(50);              // Créditer Emma de 50
            cp1.Debiter(100);              // Débiter Emma de 100    
            cp1.Debiter(50);              // Débiter Emma de 50 



            // 3. Affichage final
            Console.WriteLine("=== ÉTAT FINAL DES COMPTES ===");
            compte1.Afficher();
            compte2.Afficher();
            compte3.Afficher();
            //Affichage ded la partie2 
            Console.WriteLine();
            ce1.Afficher();
            cp1.Afficher();
        }
}