using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Person {
    public string Name { get; }

    public Person(string name) {
        Name = name;
    }
}

class Docent : Person {
    public string Vak { get; set; }

    public Docent(string nameIn, string vakIn) : base(nameIn) {
        Vak = vakIn;
    }

}

class House {
    /// <summary>
    /// Dit is een huis
    /// </summary>
    public int Area { get; set; }
    public int Doors { get; set; }

    public Person Owner { get; set; }
    public Person Guest { get; set; }

    public House(int area, int doors, Person owner) { 
        Area = area;
        Doors = doors;
        Owner = owner;
    }

    public string getOwner() {
        return Owner.Name;
    }
}

namespace Workshop {
    internal class Program {
        static void Main(string[] args) {
            Person wwwqr = new Person("Wieger");
            Person Henk = new Person("Henk");
            List<House> Houses = new List<House>();
            House Kartel = new House(50, 3, wwwqr);
            House Base1 = new House(10, 2, Henk);
            Houses.Add(Kartel);
            Houses.Add(Base1);
            Console.Write(Kartel.getOwner() + "\n");
            List<Person> Mensen = new List<Person>() {
                new Docent("Nigel", "C#"),
                new Docent("Marco", "C++")
            };

            foreach (Docent e in Mensen) {
                Console.Write(e.Name + " geeft les in " + e.Vak + ".\n");
            }

            Console.ReadLine();
        }
    }
}
