
using System.Runtime.Serialization.Json;
using System.Text.Json;
using Classes;

namespace App {
    class Core {
        // creation of a list of Vehicule, initialized when you run the app, when the app stop running the list is delete.
        static List<Vehicule> listVehicules = new List<Vehicule>() {};

        public static void Create() {
            Console.WriteLine("Marque ?");
            string marque = Console.ReadLine()!.ToLower();

            Console.WriteLine("Modele ?");
            string modele = Console.ReadLine()!.ToLower();

            Console.WriteLine("Numero (entre 4 et 6 chiffres) ?");
            int numero = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Voiture(v) ou Camion(c) ?");
            var choix = Console.ReadLine();
            switch (choix) { 
                case "v":
                    Console.WriteLine("Puissance ?");
                    int puissance = int.Parse(Console.ReadLine()!);
                    Voiture voiture = new Voiture(marque, modele, numero, puissance);
                    listVehicules.Add(voiture);
                    break;
                case "c":
                    Console.WriteLine("Poids ?");
                    int poids = int.Parse(Console.ReadLine()!);
                    Camion camion = new Camion(marque, modele, numero, poids);
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
                    var TempMa = listVehicules.Where(p => p.marque == marque).ToList();
                    foreach(var Vehicule in TempMa) {
                        Console.WriteLine(Vehicule);
                    }
                    break;
                case 2:
                    Console.WriteLine("Entrez un modele");
                    var modele = Console.ReadLine();
                    var TempMo = listVehicules.Where(p => p.marque == modele).ToList();
                    foreach(var Vehicule in TempMo) {
                        Console.WriteLine(Vehicule);
                    }
                    break;
                case 3:
                    Console.WriteLine("Entrez un numero");
                    var numero = Console.ReadLine();
                    var TempNu = listVehicules.Where(p => p.marque == numero).ToList();
                    foreach(var Vehicule in TempNu) {
                        Console.WriteLine(Vehicule);
                    }
                    break;
            }
        }

        public static void ReadAllVehicule() {
            foreach(var Vehicule in listVehicules) {
                Console.WriteLine(Vehicule.ToString());
            }
        }

        public static void UpdateVehicule() {
            Console.WriteLine("Numero du vehicule à supprimer");
            var choix = int.Parse(Console.ReadLine()!);
            var updateVehicule = listVehicules.Find(v => v.numero == choix);
            if (updateVehicule != null) {
                Console.WriteLine("Entrez le nouveau modele");
                updateVehicule.Modele = Console.ReadLine()!;
            Console.WriteLine("Véhicule mis à jour : " + updateVehicule);
            }
            else {
                Console.WriteLine("Aucun véhicule trouvé avec ce numéro.");
            }
        }

        public static void DeleteVehicule() {
            Console.WriteLine("Numero du vehicule à supprimer");
            var choix = int.Parse(Console.ReadLine()!);
            var deleteVehicule = listVehicules.Find(v => v.numero == choix);
            if (deleteVehicule != null) {
                listVehicules.Remove(deleteVehicule);
                Console.WriteLine("Véhicule supprimé.");
            }
            else {
                Console.WriteLine("Aucun véhicule trouvé avec ce numéro.");
            }
        }

        public static void SortVehicule() {
            Console.WriteLine("Trier par:\n 1- Marque alphabetique\n 2- Modele alphabetique\n 3- Numero croissant"); //4- Poids croissant 5- Puissance croissante nonfunctional
            var choix = int.Parse(Console.ReadLine()!);
            switch (choix) { 
                case 1:
                    listVehicules = listVehicules.OrderBy(p => p.marque).ToList();
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
                    listVehicules = listVehicules.OrderBy(p => p.numero).ToList();
                    foreach(var Vehicule in listVehicules) {
                        Console.WriteLine(Vehicule);
                    }
                    break;
                // case 4:
                //     listVehicules = listVehicules.OrderBy(p => p.Poids).ToList();
                //     foreach(var Vehicule in listVehicules) {
                //         Console.WriteLine(Vehicule);
                //     }
                //     break;
                // case 5:
                //     listVehicules = listVehicules.OrderBy(p => p.Puissance).ToList();
                //     foreach(var Vehicule in listVehicules) {
                //         Console.WriteLine(Vehicule);
                //     }
                //     break;
            }
        }
        public static void FilterVehicule() {
            Console.WriteLine("Filtrer par:\n 1- Marque \n 2- Modele\n 3- Numero"); // 4- Poids 5- Puissance nonfunctional
            var choix = int.Parse(Console.ReadLine()!);
            switch (choix) { 
                case 1:
                    foreach(var Vehicule in listVehicules.GroupBy(p=>p.marque)) {
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
                   foreach(var Vehicule in listVehicules.GroupBy(p=>p.numero)) {
                        Console.WriteLine(Vehicule.Key + " " + string.Join("\n", Vehicule.ToList()));
                        Console.WriteLine("-----------------");
                    }
                    break;
                // case 4:
                //    foreach(var Vehicule in listVehicules.GroupBy(p=>p.Poids)) {
                //         Console.WriteLine(Vehicule.Key + " " + string.Join("\n", Vehicule.ToList()));
                //         Console.WriteLine("-----------------");
                //     }
                //     break;
                // case 5:
                //    foreach(var Vehicule in listVehicules.GroupBy(p=>p.Puissance)) {
                //         Console.WriteLine(Vehicule.Key + " " + string.Join("\n", Vehicule.ToList()));
                //         Console.WriteLine("-----------------");
                //     }
                //     break;
            }
        }
        public static void SaveVehicule() {
            Console.WriteLine("Sauvegarder(S)\n Importer un fichier json(I)");
            var choix = Console.ReadLine();
            switch (choix) {
                case "S":
                    string fileName = "Vehicule.json";
                    string jsonSTring = JsonSerializer.Serialize(listVehicules);
                    File.WriteAllText(fileName, jsonSTring);
                    break;
                case "I":
                    Console.WriteLine("Entrez le nom de votre fichier .json (le mettre dans le dossier du projet App, exemple de nom: 'vehicle.json')");
                    var FileName = Console.ReadLine();
                    var fileContent = File.ReadAllText(FileName!);
                    var liste = JsonSerializer.Deserialize<List<Vehicule>>(fileContent);
                    listVehicules = liste!;
                    break;
            }
        }
    }
}