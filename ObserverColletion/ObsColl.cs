using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverColletion
{
    class Employee
    {
        public string Name;
        public bool? IsManager;
        public double? Salary;
    }
    internal class EmployeeList : ObservableCollection<Employee>
    {
        public EmployeeList() {
            Add( new Employee() { Name = "Jan Kowalski", IsManager = false, Salary = 12345.67 });
            Add( new Employee() { Name = "Janina Kowalska", IsManager = true, Salary = 32345.67 });
            Add( new Employee() { Name = "Marek Nowak" });
            Add( new Employee() { Name = "Maria Nowak" });
        }
    }
    
    
}
