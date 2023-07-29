using System;

namespace SOLIDExample
{
    // Clase que representa la información de un empleado
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public int HoursWorked { get; set; }
        public int HourlyRate { get; set; }

        // Método para mostrar los detalles del empleado
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee ID: " + EmployeeId);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Department: " + Department);
            Console.WriteLine("Hours Worked: " + HoursWorked);
            Console.WriteLine("Hourly Rate: " + HourlyRate);
        }
    }

    // Clase que se encarga de calcular el salario del empleado
    public class SalaryCalculator
    {
        public int CalculateSalary(int hoursWorked, int hourlyRate)
        {
            // Lógica de cálculo del salario
            return hoursWorked * hourlyRate;
        }
    }

    class Program
    {
        static void Main()
        {
            // Crear una instancia del empleado
            Employee employee = new Employee
            {
                EmployeeId = 1,
                Name = "John Doe",
                Department = "IT",
                HoursWorked = 160,
                HourlyRate = 20
            };

            // Mostrar los detalles del empleado
            employee.DisplayEmployeeDetails();

            // Crear una instancia del calculador de salario
            SalaryCalculator salaryCalculator = new SalaryCalculator();

            // Calcular el salario del empleado y mostrarlo
            int salary = salaryCalculator.CalculateSalary(employee.HoursWorked, employee.HourlyRate);
            Console.WriteLine("Salary: $" + salary);
        }
    }
}
