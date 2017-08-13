using System;

namespace ShapesCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawHeader();
            var command = string.Empty;
            
            Console.Write("> ");
            command = Console.ReadLine();

            while (!string.Equals(command, "exit")) 
            {             

                var str = command.Split(' ');                

                if(str.Length == 1)
                {
                    switch (command)
                    {
                        case "help":
                            DrawInstructions();
                            break;

                        case "file":
                            Console.WriteLine("You choose to load from a file");
                            break;

                        case "stats":
                            Console.WriteLine("You choose to see the stats");
                            break;

                        case "clear":
                            Console.Clear();
                            Console.WriteLine("You choose to clear console");
                            break;

                        default:
                            Console.WriteLine("Command not recognized. Try again!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Build a shape");
                }


                Console.Write("> ");
                command = Console.ReadLine();
                
            }             

        }


        public static void DrawHeader()
        {
            Console.Write("--------------------------------------------------------------------------------\n"+
                          "              Welcome to SHAPES COLLECTION - by Kevin Fallas                    \n"+
                          "--------------------------------------------------------------------------------");
        }

        public static void DrawInstructions()
        {
            Console.Clear();
            Console.Write("--------------------------------------------------------------------------------\n" +
                          "                       SHAPE COLLECTIONS - GUIDE / HELP                         \n" +
                          "--------------------------------------------------------------------------------\n" +
                          "+ INPUT FORMATS (x.y,z represents numbers)\n" +
                          " - Add new shape: shape_name x y z...\n" +
                          " - Delete shape: delete shape_id\n" +
                          " - Scan point(pair of numbers): x y\n\n" +
                          " - Load data from an external file: file filename.txt\n\n" +
                          "+ COMMANDS\n" +
                          " - help: show this page\n" +
                          " - stats: show the actual shapes collection status\n" +
                          " - clear: clears the console\n" +
                          " - exit: exits the application\n" +
                          "--------------------------------------------------------------------------------");


        }
    }
}
