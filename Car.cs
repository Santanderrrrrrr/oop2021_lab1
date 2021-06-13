using System;
using System.Collections.Generic;
using System.Text;

namespace OOPlab1 {
    public class Car{
        public readonly string Make;
        public string Model;
        private double price;
        private Decimal CarValue{
            get; set;
        }
        public Car GetCar(){
            return Car;
        }
        public void SetCar(Decimal Salary, Decimal CarValue, Car AtoB, string Model, string Make){
            bool CompMakeToModel=Model.equals(Make);
            if (Salary>CarValue){
                    if(CompMakeToModel==false){
                    Console.WriteLine("It seems this car is within means");
                    Car AtoB = new Car();
                    return AtoB;
                }
            }
            else{
                Console.WriteLine("This car is beyond your means.");
            }
        }

        public void ToString( string Make, string Model, double price, Decimal CarValue)
        {
            Console.Writeline(" Here is some info about the car: " + Make + ", " + Model +  ", "
            + price.ToString() +  ", " + CarValue.ToString());
        }

        
    }
    
    }


