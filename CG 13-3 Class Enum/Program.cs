using System;
using System.Collections.Generic;

namespace CG_13_3_Class_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
           //This line of code starts the program, asking the user to give their first name
           // Then is takes the inputted data and places it into a variable "name"
                Console.WriteLine("Please enter your first name to confirm your last name.");
            var name = Console.ReadLine();

            //This starts the switch statement, using the inputted variable.
                    switch (name)
                    {
                    //case "Jane": <-- original case name. This is case sensitive

                    //The following chunk of data is a repeat of code, changing the last name output that 
                    // coincides with the first name the user inputted.
                    // This code is case insensitive

                    case var names when names.Equals("Jane", StringComparison.InvariantCultureIgnoreCase):
                        Console.WriteLine($"Our records show the last name of Brown goes with {name}");
                          break;

                    case var names when names.Equals("Breona", StringComparison.InvariantCultureIgnoreCase):
                        Console.WriteLine($"Our records show that the last name of Caldwell goes with {name}");
                        break;

                    case var names when names.Equals("Adriana", StringComparison.InvariantCultureIgnoreCase):
                        Console.WriteLine($"Our records show that the last name of Disano goes with {name}");
                        break;
                    
                    case var names when names.Equals("Melissa", StringComparison.InvariantCultureIgnoreCase):
                        Console.WriteLine($"Our records show that the last name of Dodd-Ruesing goes with {name}");
                        break;
                    
                    case var names when names.Equals("Natalie", StringComparison.InvariantCultureIgnoreCase):
                        Console.WriteLine($"Our records show that the last name of Erdelt goes with {name}");
                        break;
                    
                    case var names when names.Equals("Megan", StringComparison.InvariantCultureIgnoreCase):
                        Console.WriteLine($"Our records show that the last name of Hainline goes with {name}");
                        break;
                    
                    case var names when names.Equals("Bennita", StringComparison.InvariantCultureIgnoreCase):
                        Console.WriteLine($"Our records show that the last name of Higgins goes with {name}");
                        break;
                    
                    case var names when names.Equals("Allison", StringComparison.InvariantCultureIgnoreCase):
                        Console.WriteLine($"Our records show that the last name of Hix goes with {name}");
                        break;
                    
                    case var names when names.Equals("Erin", StringComparison.InvariantCultureIgnoreCase):
                        Console.WriteLine($"Our records show that the last name of Hogan goes with {name}");
                        break;
                    
                    case var names when names.Equals("Kendra", StringComparison.InvariantCultureIgnoreCase):
                        Console.WriteLine($"Our records show that the last name of Kuhl goes with {name}");
                        break;
                    
                    case var names when names.Equals("Scott", StringComparison.InvariantCultureIgnoreCase):
                        Console.WriteLine($"Our records show that the last name of Kuhl goes with {name}");
                        break;
                    
                    case var names when names.Equals("Sandra", StringComparison.InvariantCultureIgnoreCase):
                        Console.WriteLine($"Our records show that the last name of Nelson goes with {name}");
                        break;
                    
                    case var names when names.Equals("Carolina", StringComparison.InvariantCultureIgnoreCase):
                        Console.WriteLine($"Our records show that the last name of Oppy goes with {name}");
                        break;
                    
                    case var names when names.Equals("Sarah", StringComparison.InvariantCultureIgnoreCase):
                        Console.WriteLine($"Our records show that the last name of Park goes with {name}");
                        break;
                    
                    case var names when names.Equals("Alicia", StringComparison.InvariantCultureIgnoreCase):
                        Console.WriteLine($"Our records show that the last name of Reynolds goes with {name}");
                        break;
                    
                    case var names when names.Equals("Kristen", StringComparison.InvariantCultureIgnoreCase):
                        Console.WriteLine($"Our records show that the last name of Shea goes with {name}");
                        break;
                    
                    case var names when names.Equals("Natalia", StringComparison.InvariantCultureIgnoreCase):
                        Console.WriteLine($"Our records show that the last name of Guzman Solano goes with {name}");
                        break;
                    
                    case var names when names.Equals("Temeka", StringComparison.InvariantCultureIgnoreCase):
                        Console.WriteLine($"Our records show that the last name of Spears goes with {name}");
                        break;
                    
                    case var names when names.Equals("Kendall", StringComparison.InvariantCultureIgnoreCase):
                        Console.WriteLine($"Our records show that the last name of Union goes with {name}");
                        break;
                    
                    case var names when names.Equals("Shelia", StringComparison.InvariantCultureIgnoreCase):
                        Console.WriteLine($"Our records show that the last name of Wambui goes with {name}");
                        break;
                    
                    case var names when names.Equals("Madelyn", StringComparison.InvariantCultureIgnoreCase):
                        Console.WriteLine($"Our records show that the last name of Weller goes with {name}");
                        break;

                    default:
                        Console.WriteLine("I do not show that name is on record.");
                        break;
                    }

               

            Console.ReadLine();

            }
        }


    

    }




