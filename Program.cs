using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;



namespace KantineLista
{
    class Program
    {
        static void Main(string[] args)
        {
            Functions functions = new Functions();
            functions.addItem();



            
            var path = "./Lokalefiler/employee.csv";
            List<Employee> values = File.ReadAllLines(path)
                                            .Skip(1) //skips header in csv
                                            .Select(v => {
                                                return new Employee();
                                                })
                                            .ToList();
                                            
        }
    }
}