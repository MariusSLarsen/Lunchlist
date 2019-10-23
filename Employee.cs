using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;


namespace KantineLista
{
    public class Employee
    {
        int AnsattId;
        string firstName;
        string lastName;

        

        public Employee() {
        }

        public Employee(string csvLine) {
            string[] values = csvLine.Split(';');

            this.AnsattId = Convert.ToInt32(values[0]);
            this.firstName = Convert.ToString(values[1]);
            this.lastName = Convert.ToString(values[2]);
        }   
    }
}