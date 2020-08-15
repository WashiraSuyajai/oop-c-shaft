using System;

namespace c_shaft_workshop {
    class Program {
        static void Main (string[] args) {
            Employee e1 = new Employee();
            e1.id = "1";
            e1.setName("Pou");
            e1.setSalary(30000);

            Employee e2 = new Employee();
            e2.id = "2";
            e2.setName("Taw");
            e2.setSalary(50000);

            Employee e3 = new Employee();
            //ใช้งาน properties accessors
            e3.Name = "Honey";
            e3.Salary = 60000;

            //Console.WriteLine(e1.ToString());
            //Console.ReadLine();

            Console.WriteLine(e1.getName());
            Console.WriteLine(e1.getSalary());
            Console.WriteLine("Name = {0}, Salary = {1}", e3.Name, e3.Salary);
            Console.ReadLine();
        }
    }
}