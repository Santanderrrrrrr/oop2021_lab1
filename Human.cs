using System;
using System.Collections.Generic;
using System.Text;

namespace OOPlab1 {
    public class Human {
        public string FirstName;
        public string LastName;
        public Animal Pet;
        public Phone Phone;
        public int Number;
        private Decimal salary{
            get; set;
        }
        private Car AtoB = new Car();


        public Decimal Salary{
            get{
                return Salary;
            }
            set {
                if(value >0){
                    salary+= value;
                    Console.WriteLine("The Salary value has been updated");
                    string nowGettingTime = @"E:\Leon School\second year sem 2\object oriented programming\oop2021-main\OOPlab1\Human.cs"
                    FileInfo nGT = new FileInfo(nowGettingTime);
                    DateTime nowUpdatingTIme = nGT.LastWriteTime;
                }
            }
        }

        
        
    }

}
