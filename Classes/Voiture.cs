
namespace Classes {
    public class Voiture : Vehicule {
        // public static string Test2 { get; set; } = "Test Voiture";
        public int Puissance { get; set;}

        // Méthode voiture: constructor
        public Voiture ( string marque, string modele , int numero, int puissance) : base(marque, modele, numero) {
            Puissance = puissance;
        }

        // methode ToString
        public override string ToString() {
            return string.Format(base.ToString(),"puissance:", Puissance);
        }
    }
}