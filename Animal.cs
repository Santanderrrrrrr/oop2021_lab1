using System;
using System.Collections.Generic;
using System.Text;

namespace OOPlab1 {
    public class Animal {
        public readonly string Species = "canis";
        public string Name;
        private double weight = 3.0;

        public void PrintWeight() {
            Console.WriteLine(weight);
        }

        public void Feed(double foodWeight) {
            if (weight>0){ weight += foodWeight;
            Console.WriteLine("thx for food, bro");
            Console.WriteLine("my weight is now " + weight);}
            else
            {
                Console.WriteLine("I think the animal is dead. Interaction is now impossible.");
            }
        }

        public String returnSpeciesAndName() {
            return Species + " " + Name;
        }

        public String returnNameAndOwner(string owner) {
            return Name + " " + owner;
        }

        public void TakeForAWalk(int Distance, int weight){
            if (weight>0){
                Console.WriteLine("How long was the walk?(enter number of kilometers)");
                Distance= Convert.ToInt32(Console.ReadLine());

                weight = weight - Convert.ToInt32(Distance*0.2);
                Console.WriteLine("The animal's weight is now: "+ weight);
                }
                else
                {
                    Console.WriteLine("I think the animal is dead. Interaction is now impossible.");
                }
        }

        Animal(int InitWeight){
            Console.WriteLine("Please input the weight of the numerical animal");

            this.InitWeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The weight of the animal is: " + InitWeight);

        }
    }
}
