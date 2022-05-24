using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            DateTime currentDate = DateTime.Now;
            string currentDateNoTime = currentDate.Date.ToShortDateString();
            Company higgsBozos = new Company("Higgs Bozos Inc.", currentDate);
            // Create three employees
            Employee xeno = new Employee("Jeremy", "Farmer", "D&D Dodger", currentDateNoTime);
            Employee eric = new Employee("Eric", "Paquette", "Movie Watcher", currentDateNoTime);
            Employee nick = new Employee("Nick", "Tate", "The Brains", currentDateNoTime);
            // Assign the employees to the company
            higgsBozos.Employees.Add(xeno);
            higgsBozos.Employees.Add(eric);
            higgsBozos.Employees.Add(nick);
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            foreach(Employee employee in higgsBozos.Employees){
                Console.WriteLine(higgsBozos.ListEmployees(employee));
            }
        }
    }
}

