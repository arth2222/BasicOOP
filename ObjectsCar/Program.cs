using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsCar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car ford = new Car();//lager et tomt obj av typen Car som heter ford
            ford.RegNr = "br12431"; //Setter props her
            ford.KmKjørt = 200000;
            ford.Forbruk = 0.9;

            //string word = "Hei";

            //word.HasWord();

            var bensinBrukt = ford.BensinBrukt; //henter property Bensinbrukt og lagrer i variabelen bensinbrukt
            Console.WriteLine("Bensinbrukt: " + bensinBrukt);
            Console.WriteLine("Fordens regnr: " + ford.RegNr);
            

            //kan vi legge objekter i en array eller liste? jada
            Car[] someCars = new Car[5];
            someCars[0] = ford; //Slik, her legger vi objektet vi lagde der oppe inn på den første plassen i en array
            //List
            List<Car> allCars = new List<Car>();
            allCars.Add(ford);

            //Hvordan loope oss igjennom? 2 eksempler

            foreach (Car car in allCars)
            {
                //do some stuff
                Console.WriteLine(car.RegNr);
            }
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(someCars[0].BensinBrukt);
            }
            Console.ReadLine();
        }
    }

    public class Car //definering av klassen Car, (som vi lager objekter av)
    {
        //4 properties get betyr kan read, set betyr kan skrive til, sette en verdi
        public string RegNr { get; set; }
        public int KmKjørt { get; set; }
        public double Forbruk { get; set; }
        public double BensinBrukt//her er det litt logikk. Dette kunne også ha vært i en metode
        {
            get
            {
                return KmKjørt * Forbruk;
            }
        }
    }
}
