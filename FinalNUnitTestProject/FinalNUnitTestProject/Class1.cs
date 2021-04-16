using System;
using System.Collections.Generic;

namespace FinalNUnitTestProject {
    public class BikeStorage {

        //Instructions
        //I skal lave et system som kan holde styr på cyklerne i en cykelbutik.Der skal, som minimum, være alle CRUD metoderne, dvs. Create, Read, Update og Delete.Det vigtige er at i skal arbejde ved at designe jeres program med unit tests først.Umiddelbart er det ikke et krav at dataen er persistent (dvs.bruger en database), men hvis i har lyst må i gerne implementere det også.
        //Lav en oversigt over de klasser og metoder dit system skal bestå af(evt.som UML diagram)
        //Lav dine unit tests der passer overens med din oversigt.
        //Implementer koden således at dine tests virker.

        public int id;
        public string name;
        public Model? model;

        public BikeStorage(int id, string name, Model? model) {
            this.id = id;
            this.name = name;
            this.model = model;
        }


        public static void Create(BikeStorage bike, ListOfBikes list) {
            list.bikeStorages.Add(bike);
        }

        public static void Delete(ListOfBikes list, BikeStorage bike) {
            list.bikeStorages.Remove(bike);
        }

        public static void Update(ListOfBikes list, string oldname, string newname) {
            foreach (var item in list.bikeStorages) {
                if (item.name == oldname) {
                    item.name = newname;
                    break;
                }
            }
        }

        public static void Read(ListOfBikes list) {
            foreach (var item in list.bikeStorages) {
                Console.WriteLine(item.id + ", " + item.name + ", " + item.model);
            }
        }

    }
    public enum Model {
        Alta,
        BMW,
        Bacchetta,
        Caloi,
        Diamant,
        Excelsior,
        Fuji
    }

    public class ListOfBikes {
        public List<BikeStorage> bikeStorages = new List<BikeStorage>();

        public ListOfBikes() {
        }
    }
}
