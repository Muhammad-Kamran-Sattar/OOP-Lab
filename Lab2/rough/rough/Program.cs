using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO



namespace rough
    {
        class Program
        {
            static void Main(string[] args)
            {
                string writeText = "Hello World!";  // Create a text string
                File.WriteAllText("filename.txt", writeText);  // Create a file and write the contents of writeText to it

                string readText = File.ReadAllText("filename.txt"); // Read the contents of the file
                Console.WriteLine(readText); // Output the content
            }
        }
    }

