using Classes.Exceptions;

namespace Classes {
    public class Vehicule {
        // public static string Test { get; set; } = "Test vehicule";
        private string Marque;
        public string Modele { get; set; }
        private int Numero;

        public string _marque {
            get { return Marque; }
            set {
                for (int i=0; i< value.Length; i++) {
                    if (Char.IsDigit(value[i])) {
                    throw new InvalidMarqueException("Marque Invalide");
                }
                else {
                    Marque = value;
                }
                }
            }
        }

        public int _numero {
            get { return Numero; }
            set {
                if (value.ToString().Length >= 4 && value.ToString().Length <= 6) {
                    Numero = value;
                }

                else {
                    throw new InvalidNumeroException("Longueur Numero Invalide");
                }
            }
        }

        // Méthode vehicule: constructor
        public Vehicule(string marque, string modele, int numero) {
            Marque = marque;
            Modele = modele;
            Numero = numero;
        }

        // methode ToString
        public override string ToString() {
            return $"marque: {Marque} \n modele: {Modele} \n numero: {Numero}";
        }
    }
}