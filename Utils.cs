using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCSProject
{
    internal static class KeyboardReader
    {

        public static int GetInt(String displayText, int lowerBound, int upperBound)
        {
            bool valid = false;

            int returnValue;

            do
            {
                returnValue = GetInt(displayText);
                if (returnValue >= lowerBound && returnValue <= upperBound)
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Number not within acceptable range.\n");
                }
                

             } while (!valid);

            return returnValue;
        }

        public static int GetInt(string displayText) {
            int returnValue = 0;
            bool valid = false;

            do
            {
                try
                {
                    returnValue = int.Parse(GetString(displayText));
                    valid = true;
                }
                catch(FormatException ex)
                { 
                    Console.WriteLine(ex.Message);
                }

            }while (!valid);
            
            return returnValue;
        }

        public static string GetString(String displayText)
        {
            bool valid = false;
            string returnValue  = "";

            do
            {
                try
                {
                    Console.WriteLine(displayText);
                    returnValue = Console.ReadLine();
                    if (returnValue != null)
                    {
                        valid = true;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }while (!valid);

            return returnValue;
        }

        public static char GetChar(String displayText,string allowedCharacters)
        {
            char returnValue;
            bool valid = false;

            do
            {
                returnValue = GetChar(displayText);
                for(int i = 0; i < allowedCharacters.Length; i++)
                {
                    if (returnValue == allowedCharacters[i])
                    {
                        valid = true;
                        break;
                    }
                }
                if (!valid)
                {
                    Console.WriteLine("Invalid Charcter Entered, Please Try Again.\n");
                }
            }while (!valid);

            return returnValue;


        }

        public static char GetChar(string displayText)
        {
            char returnValue = '#';
            bool valid = false;

            do
            {
                string input = GetString(displayText);
                if (input.Length != 1)
                {
                    Console.WriteLine("Invalid Number Of Characters Entered, Please Only Enter A Single Character");
                }
                else
                {
                    returnValue = input[0];
                    valid = true;
                }

            }while(!valid);

            return returnValue;
        }

        public static void Pause()
        {
            Console.WriteLine("Press Enter To Continue...");
            Console.ReadLine();

        }

    }
}
