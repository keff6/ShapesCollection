using ShapesCollection.Classes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ShapesCollection.Logic
{
    
    public class AppManager
    {
        private Dictionary<int, Shape> _shapesCollection =  new Dictionary<int,Shape>();
        private int _index = 0;

        public void AddShape(string[] shapeData)
        {
            string shape = shapeData[0];

            //1- Validar datos ingresados
            if (IsValidShapeName(shape))
            {
                double[] numericValues = GetNumericValues(shapeData.Skip(1).ToArray());

                if (IsValidLength(shape, numericValues.Length))
                {
                    //2- llamar a la fabrica de shapes
                    Shape newShape = ShapeFactory.MakeNewShape(shape, numericValues);

                    //3- Agregar shape a collection
                    _index = GetNextIndex();
                    _shapesCollection.Add(_index, newShape);

                    //4- Imprimir
                    Console.WriteLine("=> shape " + _index + ": " + newShape.Description());

                }

            }
        }

        private int GetNextIndex()
        {
            //_index += ++_index;
            return ++_index;
        }


        private bool IsValidShapeName(string name)
        {
            switch (name)
            {
                case Constants.Circle:
                case Constants.Square:
                case Constants.Rectangle:
                case Constants.Donut:
                case Constants.Triangle:
                case Constants.Ellipse:
                    return true;
                default:
                    return false;
            }
        }

        private bool IsValidLength(string shape, int valuesLength)
        {
            //TODO: mejorar logica
            bool isValid = false;

            if(((string.Equals(shape,Constants.Circle) || string.Equals(shape,Constants.Square))
                && valuesLength == 3) || 
                    ((string.Equals(shape,Constants.Rectangle) || string.Equals(shape,Constants.Donut))
                && valuesLength == 4) || (string.Equals(shape, Constants.Triangle) && valuesLength == 6))
            {
                isValid = true;
            }
            

            return isValid;
        }

         
        private double[] GetNumericValues(string[] data)
        {
            double[] formattedValues = null;
            try
            {
                formattedValues = new double[data.Length];
                double parsedString;
                for (int i = 0; i < data.Length; i++)
                {
                    //TODO: Resolver lo del punto y la coma
                    if (!double.TryParse(data[i], NumberStyles.Any, new NumberFormatInfo() { NumberDecimalSeparator = "." }, out parsedString))
                    {
                        throw new Exception("Incorrect format argument");
                    }
                    else
                    {
                        formattedValues[i] = parsedString;
                    }
                }                
            }
            catch(Exception ex){
                Console.WriteLine("There was a problem: {0}", ex.Message);
            }
            return formattedValues;
        }


        internal Constants.InputType VerifyInput(string[] input)
        {
            Constants.InputType type = Constants.InputType.Default;
            double parseResult;
            bool startsWithNumber = double.TryParse(input[0], out parseResult);

            if (input.Length == 1 && !startsWithNumber)
            {
                type = Constants.InputType.Command;
            }
            else if (input.Length == 2 && (startsWithNumber && double.TryParse(input[1], out parseResult)))
            {
                type = Constants.InputType.Number;
            }
            else if (input.Length > 2 && input.Length < 8 && !startsWithNumber)
            {
                type = Constants.InputType.Shape;
            }

            return type;
        }

        internal void SearchShapeByCoordinate(string[] coordinate)
        {
            Console.WriteLine("Search point (" + coordinate[0] + "," + coordinate[1] + ")");
        }
    }
}
