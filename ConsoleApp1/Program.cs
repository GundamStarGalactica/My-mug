using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> mug = new List<string>();



            while (true)
            {
                Console.WriteLine("Whatcha wanna do dude? Add, Remove, List, or Quit");
                string command = Console.ReadLine();
                if (command == "add")


                {
                    // Print "What is the mug"
                    Console.WriteLine("What is the mug");
                    // Get mug from user
                    string name = Console.ReadLine();
                    // Add mug to list
                    mug.Add(name);
                    // Print "mug was added to the list"
                    Console.WriteLine( "Mug was added to the list");
                }
                if (command == "list")
                {
                    //Show list
                    mug.ForEach(Console.WriteLine);


                }
                if (command == "remove")

                {


                    Console.WriteLine("What is the mug");
                    string name = Console.ReadLine();
                    mug.Remove(name);
                    Console.WriteLine("Mug has been removed from the list");
                 

                    
                    
                }
                
                if (command == "q")
                {

                    break;



                }
            }


        }
    }
}
    

