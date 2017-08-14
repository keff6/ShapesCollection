using ShapesCollection.Logic;
using System;

namespace ShapesCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawHeader();
            var input = string.Empty;
            AppManager appManager = new AppManager();
            
            
            Console.Write("> ");
            input = Console.ReadLine();

            while (!string.Equals(input, "exit"))
            {

                var strInput = input.Split(' ');

                switch (appManager.VerifyInput(strInput))
                {
                    case Constants.InputType.Command:
                        CommandsManager(strInput);
                        break;
                    case Constants.InputType.Number:
                        appManager.SearchShapeByCoordinate(strInput);
                        break;
                    case Constants.InputType.Shape:
                        appManager.AddShape(strInput);
                        break;
                    default:
                        Console.WriteLine("Input not recognized, please try again!");
                        break;
                }

                Console.Write("> ");
                input = Console.ReadLine();

            }                  

        }

        private static void CommandsManager(string[] command)
        {
            switch (command[0])
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
