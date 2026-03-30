using System;

namespace ExerciceProduit
{
    class Produit
    {
        private string codeArticle;
        private string designation;
        private double prix;

        public Produit(string code, string nom, double px)
        {
            this.codeArticle = code;
            this.designation = nom;
            this.prix = px;
        }

        public string GetCodeArticle()
        {
            return codeArticle;
        }

        public override string ToString()
        {
            return $"Produit {{ codeArticle={codeArticle}, designation={designation}, prix={prix} }}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Produit autre)
            {
                return this.codeArticle == autre.codeArticle;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(codeArticle);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Produit p1 = new Produit("A01", "Souris", 15.0);
            Produit p2 = new Produit("A01", "Souris", 15.0);

      
            HashSet<Produit> panier = new HashSet<Produit>();
            panier.Add(p1);
            panier.Add(p2);

            // 2. Le constat
            Console.WriteLine("Nombre de produits dans le panier (HashSet) :");
            Console.WriteLine(panier.Count);
        }
    }
}
