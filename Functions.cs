using System;
using System.Collections.Generic;

namespace KantineLista
{
    public class Functions
    {
        public void addItem()
        {
            var orderSum = new List<int>();

                Console.WriteLine("Tast inn samlet beløp for ditt kjøp: ");
                var input = Console.ReadLine();
                Console.WriteLine("Du tasta inn {0}", input);

            orderSum.Add(Convert.ToInt32(input));
        }

        
        public void sumTotalOrders()
        {
            // supposed to count all weekly orders.
            var totalOrders = new List<int>();
        }
        public void logInToApp()
        {
            var state = true;

            while (state) 
            {
            var input = Console.ReadLine();
            System.Console.WriteLine("Tast inn eit gyldig ansatt nummer: ");

            // if (input == Employee.AnsattID CSV FIL)
            // System.Console.WriteLine("Hei {0} {1} ", firstName, lastName);
            state = false;
            }
        }
    }
}