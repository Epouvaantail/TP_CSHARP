
using System.Text.Json;
using Classes;

namespace App {
    class Core {

        static List<Vehicule> listVehicules = new List<Vehicule>() {};

        public static void Create() {
            Console.WriteLine("Marque ?");
            string marque = Console.ReadLine()!;

            Console.WriteLine("Modele ?");
            string modele = Console.ReadLine()!;

            Console.WriteLine("Numero (entre 4 et 6 chiffres) ?");
            int numero = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Voiture(v) ou Camion(c) ?");
            var choix = Console.ReadLine();
            switch (choix) { 
                case "v":
                    Console.WriteLine("Puissance ?");
                    int puissance = int.Parse(Console.ReadLine()!);
                    Vehicule voiture = new Vehicule(marque, modele, numero);
                    listVehicules.Add(voiture);
                    break;
                case "c":
                    Console.WriteLine("Poids ?");
                    double poids = int.Parse(Console.ReadLine()!);
                    Vehicule camion = new Vehicule(marque, modele, numero);
                    listVehicules.Add(camion);
                    break;
            }
            Console.WriteLine("Vehicule créé !");
        }

        public static void ReadVehicule() {
            Console.WriteLine("Chercher par:\n 1- Marque \n 2- Modele\n 3- Numero");
            var choix = int.Parse(Console.ReadLine()!);
            switch (choix) {
                case 1:
                    Console.WriteLine("Entrez une marque");
                    var marque = Console.ReadLine();
                    var TempMa = listVehicules.Where(p => p._marque == marque).ToList();
                    foreach(var Vehicule in TempMa) {
                        Console.WriteLine(Vehicule);
                    }
                    break;
                case 2:
                    Console.WriteLine("Entrez un modele");
                    var modele = Console.ReadLine();
                    var TempMo = listVehicules.Where(p => p._marque == modele).ToList();
                    foreach(var Vehicule in TempMo) {
                        Console.WriteLine(Vehicule);
                    }
                    break;
                case 3:
                    Console.WriteLine("Entrez un numero");
                    var numero = Console.ReadLine();
                    var TempNu = listVehicules.Where(p => p._marque == numero).ToList();
                    foreach(var Vehicule in TempNu) {
                        Console.WriteLine(Vehicule);
                    }
                    break;
            }
        }

        public static void ReadAllVehicule() {
            foreach(var Vehicule in listVehicules) {
                Console.WriteLine(Vehicule);
            }
        }

        public static void UpdateVehicule() {
            // Newvehicule.Marque("Volvo");
        }

        public static void DeleteVehicule() {
            // listVehicule.Remove(newVehicule);
        }

        public static void SortVehicule() {
            Console.WriteLine("Trier par:\n 1- Marque alphabetique\n 2- Modele alphabetique\n 3- Numero croissant");
            var choix = int.Parse(Console.ReadLine()!);
            switch (choix) { 
                case 1:
                    listVehicules = listVehicules.OrderBy(p => p._marque).ToList();
                    foreach(var Vehicule in listVehicules) {
                        Console.WriteLine(Vehicule);
                    }
                    break;
                case 2:
                    listVehicules = listVehicules.OrderBy(p => p.Modele).ToList();
                    foreach(var Vehicule in listVehicules) {
                        Console.WriteLine(Vehicule);
                    }
                    break;
                case 3:
                    listVehicules = listVehicules.OrderBy(p => p._numero).ToList();
                    foreach(var Vehicule in listVehicules) {
                        Console.WriteLine(Vehicule);
                    }
                    break;
            }
        }
        public static void FilterVehicule() {
            Console.WriteLine("Filtrer par:\n 1- Marque \n 2- Modele\n 3- Numero");
            var choix = int.Parse(Console.ReadLine()!);
            switch (choix) { 
                case 1:
                    foreach(var Vehicule in listVehicules.GroupBy(p=>p._marque)) {
                        Console.WriteLine(Vehicule.Key + " " + string.Join("\n", Vehicule.ToList()));
                        Console.WriteLine("-----------------");
                    }
                    break;
                case 2:
                    foreach(var Vehicule in listVehicules.GroupBy(p=>p.Modele)) {
                        Console.WriteLine(Vehicule.Key + " " + string.Join("\n", Vehicule.ToList()));
                        Console.WriteLine("-----------------");
                    }
                    break;
                case 3:
                   foreach(var Vehicule in listVehicules.GroupBy(p=>p._numero)) {
                        Console.WriteLine(Vehicule.Key + " " + string.Join("\n", Vehicule.ToList()));
                        Console.WriteLine("-----------------");
                    }
                    break;
            }
        }
        public static void SaveVehicule() {
            Console.WriteLine("Sauvegarder(S)\n Load un fichier json(L)");
            var choix = Console.ReadLine();
            switch (choix) {
                case "S":
                    string fileName = "Vehicule.json";
                    string jsonSTring = JsonSerializer.Serialize(listVehicules);
                    File.WriteAllText(fileName, jsonSTring);
                    break;
                case "L":
                    Console.WriteLine("Entrez le nom de votre fichier .json (le mettre dans le dossier du projet App)");
                    var FileName = Console.ReadLine();
                    var fileContent = File.ReadAllText(FileName!);
                    var liste = JsonSerializer.Deserialize<Vehicule>(fileContent);
                    break;
            }
        }
    }
}