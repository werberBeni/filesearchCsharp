using System;
using System.Data.SqlClient;
using System.IO;

namespace projectsearch
{
    class Program
    {
        static void Main(string[] args)
        {

            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-OQ6F1E1; Initial Catalog=cproject; Integrated Security=True");
            SqlCommand com = new SqlCommand("insert into search, cn");
            char choice;
            do
            {
                Console.WriteLine("Please enter your search choice: ");
                Console.WriteLine("1. Enter file name to search.");
                Console.WriteLine("2. Enter file name to search + parent directory to search in.");
                Console.WriteLine("3. view the history search.");
                Console.WriteLine("4. End of searcing... ");
                choice = Console.ReadKey().KeyChar;
                Console.WriteLine();
                switch (choice)
                {
                    case '1':
                        Console.Write("Please enter search word: ");
                        string searchWord = Console.ReadLine();
                        break;
                    case '2':
                        Console.Write("Please enter parent directory to search in: ");
                        string[] array1 = Directory.GetFiles(Console.ReadLine());

                        // Display all files.
                        Console.WriteLine("--- Files: ---");
                        foreach (string name in array1)
                        {
                            Console.WriteLine(name);
                        }
                        //C:/inetpub/wwwroot
                       // string searchdirectory = Console.ReadLine();
                        // Console.Write("Please enter search word: ");
                        //string searchword2 = Console.ReadLine();
                        //string[] result = Directory.GetFiles("c://inetpub//wwwroot");
                        //Console.WriteLine(result);
                        break;
                    case '3':
                        break;
                }

            }
            while (choice != '4');
        }
    }
    }

