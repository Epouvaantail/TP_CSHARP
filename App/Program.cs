// See https://aka.ms/new-console-template for more information
using App;
using Classes;

namespace App {
    class Program : Core {
        static void Main(string[] args ) {
            
            Console.WriteLine("Choisir le numéro de l'action:\n 1- Create\n 2- Voir un véhicule\n 3- Voir tout les véhicule\n 4- Mettre à jour un véhicule\n 5- Supprimer un véhicule\n 6- Trier les véhicules\n 7- Filtrer les véhicules\n  8- Sauvegarder les véhicules");
            var choix = int.Parse(Console.ReadLine()!);

            while (choix != 0) {
                switch (choix) {
                    case 1:
                        Create();
                        break;
                    case 2:
                        ReadVehicule();
                        break;
                    case 3:
                        ReadAllVehicule();
                        break;
                    case 4:
                        UpdateVehicule();
                        break;
                    case 5:
                        DeleteVehicule();
                        break;
                    case 6:
                        SortVehicule();
                        break;
                    case 7:
                        FilterVehicule();
                        break;
                    case 8:
                        SaveVehicule();
                        break;
                }

                Console.WriteLine("Choisir le numéro de l'action:\n 1- Create\n 2- Voir un véhicule\n 3- Voir tout les véhicule 4- Mettre à jour un véhicule\n 5- Supprimer un véhicule\n 6- Trier les véhicules\n 7- Filtrer les véhicules\n  8- Sauvegarder les véhicules\n (0 pour quitter)");
                choix = int.Parse(Console.ReadLine()!);
            }
        }
    }
}

