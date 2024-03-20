
namespace Classes {
    public class Camion : Vehicule {
        // public static string Test3 { get; set; } = "Test Camion";
        public int Poids { get; set;}

        // Méthode Camion: constructor
        public Camion ( string marque, string modele , int numero, int poids) : base(marque, modele, numero) {
            Poids = poids;
        }

        // methode ToString
        public override string ToString() {
            return string.Format(base.ToString(),"poid:", Poids);
        }
    }
}