using System;

namespace Classes{
    
    public class Employee
    {
        public string FirstName {get;set;}
        public string LastName {get;set;}
        public string Title {get;set;}
        public string StartDate {get;set;}

        public Employee(string firstName, string lastName, string title, string startDate){
            FirstName = firstName;
            LastName = lastName;
            Title = title;
            StartDate = startDate;
        }
    }
}