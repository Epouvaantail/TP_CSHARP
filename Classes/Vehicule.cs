using Classes.Exceptions;

namespace Classes {
    public class Vehicule {
        // public static string Test { get; set; } = "Test vehicule";
        private string? Marque;
        public string Modele { get; set; }
        private int Numero;

        public string marque {
            get { return Marque!; }
            set {
                // check if there is a digit in the Marque
                foreach ( char c in value) {
                    if (Char.IsDigit(c)) {
                        throw new InvalidMarqueException("Marque Invalide");
                    }
                    else {
                        Marque = value;
                    }
                }
            }
        }

        public int numero {
            get { return Numero; }
            set {
                // check if the value length is in between 4 and 6 number and if its a number
                if (value.ToString().Length >= 4 && value.ToString().Length <= 6) {
                    Numero = value;
                }
                else {
                    throw new InvalidNumeroException("Longueur Numero Invalide");
                }
            }
        }

        // Méthode vehicule: constructor
        public Vehicule(string _marque, string _modele, int _numero) {
            marque = _marque;
            Modele = _modele;
            numero = _numero;
        }

        // methode ToString
        public override string ToString() {
            return $"marque: {Marque} \n modele: {Modele} \n numero: {Numero}";
        }
    }
}