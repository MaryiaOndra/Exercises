using System;
using System.Runtime.CompilerServices;

namespace ClassesPartTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with incapsulation\n");
            Employee emp = new Employee("Marvin", 100, 456, 30000, "sdd");
            emp.GiveBonus(1000);
            emp.DisplayStats();

            //use get/set to  change enployee name
            emp.Name = "Marv";
            Console.WriteLine($"Employee is named: {emp.Name}");

            Employee joe = new Employee();
            joe.Age++;       
        }
    } 

    class Employee
    {
        //поля данных
        private string empName;
        private int empID;
        private float currPay;

        private string empSSN;

        //properties// свойства

        public string SocialSecurityNumber 
        {
            get { return empSSN; }
        }


        public string Name 
        {
            get { return empName; }
            set 
            {
                if (value.Length > 15)
                {
                    Console.WriteLine("Error! Name lenght exceeds 15 characters!");
                }
                else
                {
                    empName = value;
                }
            }
        }
        public int Age { get; set; }
        public int ID { get; set; }
        public float Pay { get; set; }   

        //constructors
        public Employee() { }
        public Employee(string name, int id, float pay)
            : this(name, 0, id, pay, "") { }
        public Employee(string name, int age, int id, float pay, string ssn) 
        {
            Name = name;
            ID = id;
            Age = age;
            Pay = pay;
            empSSN = ssn;
        }


        //methods
        public void GiveBonus(float amount) 
        {
            currPay += amount;
        }

        public void DisplayStats() 
        {
            Console.WriteLine("Name: {0}", empName); //name of Employee
            Console.WriteLine("ID: {0}", ID); //id of empoyee
            Console.WriteLine("Age: {0}", Age); //age of empoyee
            Console.WriteLine("Pay: {0}", currPay); //current pay
        }
    }
}
