using System;
using System.Text;
using System.Threading.Tasks;

namespace c_shaft_workshop {
    class Employee {
        public string id;
        private string name;
        private double salary;

        public void displayEmployee() {
            Console.WriteLine("Name = {0} and salary = {1}", this.name, this.salary);
        }

        //setter method
        public void setName(string name) {
            this.name = name;
        }

        public void setSalary(double salary) {
            this.salary = salary;
        }

        //getter method
        public string getName() {
            return this.name;
        }

        public double getSalary() {
            return this.salary;
        }

        //properties accessors คือ method ที่รวม setter getter เอาไว้ด้วยกัน
        public string Name {
            get {
                return name;
            }
            set {
                name = value;
            }
        }

        public double Salary {
            get {return salary;}
            set {salary = value;}
        }
    }
}