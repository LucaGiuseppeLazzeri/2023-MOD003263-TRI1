// See https://aka.ms/new-console-template for more information

using System;

namespace FirstCSProject
{
    class Launcher
    {
        static void Main(String[] args)
        {
            
            // im going to 
            Console.WriteLine(KeyboardReader.GetString("Say Something: "));

            Console.WriteLine(KeyboardReader.GetInt("Enter A Int Between 0 and 100", 0, 100));

            Console.WriteLine(KeyboardReader.GetChar("Enter One Of The Following Characters, a b c d e", "abcde"));

            KeyboardReader.Pause();


        }
    }
}