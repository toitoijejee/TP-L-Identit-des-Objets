using System;
using System.Collections.Generic;

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

    class ProduitPerissable : Produit
    {
        private int joursAvantPeremption;

        public ProduitPerissable(string c, string n, double p, int j) : base(c, n, p)
        {
            this.joursAvantPeremption = j;
        }

        public int GetJoursAvantPeremption()
        {
            return joursAvantPeremption;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {            
            List<object> inventaire = new List<object>();
            Produit p1 = new Produit("A01", "Souris", 15.0);
            inventaire.Add(12);               
            inventaire.Add("Dépôt Central");    
            inventaire.Add(p1);               

            foreach (object item in inventaire)
            {
                Console.WriteLine($"Type réel : {item.GetType()}");
                
                Console.WriteLine($"Description : {item.ToString()}");

                if (item is Produit p)
                {
                    Console.WriteLine($"Code Article détecté : {p.GetCodeArticle()}");
                }
                Console.WriteLine();
            }
        }
    }
}
