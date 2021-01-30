using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MORSEKODEN
{
    class Program
    {
        static void Main(string[] args)
        {
            //efter hvert bogstav har jeg sat et /
            Console.WriteLine("Skriv hvad du gerne ville have til konvateret til morse");
            string input = Console.ReadLine();
            string output = "";
            foreach (char bogstav in input)
            {
                output = output + morse(bogstav.ToString()) + "/";
            }
            Console.WriteLine(output);
            Console.ReadLine();
        }
        private static string morse(string bogstav1)
        {

            switch (bogstav1.ToLower())
            {
                case "a":
                    {
                        return ".-";
                        break;
                    }
                case "b":
                    {
                        return "-...";
                        break;
                    }
                case "c":
                    {
                        return "-.-.";
                        break;
                    }
                case "d":
                    {
                        return "-..";
                        break;
                    }
                case "e":
                    {
                        return ".";
                        break;
                    }
                case "f":
                    {
                        return "..-";
                        break;
                    }
                case "g":
                    {
                        return "--.";
                        break;
                    }
                case "h":
                    {
                        return "....";
                        break;
                    }
                case "i":
                    {
                        return "..";
                        break;
                    }
                case "j":
                    {
                        return ".---";
                        break;
                    }
                case "k":
                    {
                        return "-.-";
                        break;
                    }
                case "l":
                    {
                        return ".-..";
                        break;
                    }
                case "m":
                    {
                        return "--";
                        break;
                    }
                case "n":
                    {
                        return "-.";
                        break;
                    }
                case "o":
                    {
                        return "---";
                        break;
                    }
                case "p":
                    {
                        return ".--.";
                        break;
                    }
                case "q":
                    {
                        return "--.-";
                        break;
                    }
                case "r":
                    {
                        return ".-.";
                        break;
                    }
                case "s":
                    {
                        return "...";
                        break;
                    }
                case "t":
                    {
                        return "-";
                        break;
                    }
                case "u":
                    {
                        return "..-";
                        break;
                    }
                case "v":
                    {
                        return "...-";
                        break;
                    }
                case "w":
                    {
                        return ".--";
                        break;
                    }
                case "x":
                    {
                        return "-..-";
                        break;
                    }
                case "y":
                    {
                        return "-.--";
                        break;
                    }
                case "z":
                    {
                        return "--..";
                        break;
                    }
                case "æ":
                    {
                        return ".-.-";
                        break;
                    }
                case "ø":
                    {
                        return "---.";
                        break;
                    }
                case "å":
                    {
                        return ".--.-";
                        break;
                    }
                case "1":
                    {
                        return ".----";
                        break;
                    }
                case "2":
                    {
                        return "..---";
                        break;
                    }
                case "3":
                    {
                        return "...--";
                        break;
                    }
                case "4":
                    {
                        return "....-";
                        break;
                    }
                case "5":
                    {
                        return ".....";
                        break;
                    }
                case "6":
                    {
                        return "-....";
                        break;
                    }
                case "7":
                    {
                        return "--...";
                        break;
                    }
                case "8":
                    {
                        return "---..";
                        break;
                    }
                case "9":
                    {
                        return "----.";
                        break;
                    }
                case "0":
                    {
                        return "-----";
                        break;
                    }
                case " ":
                    {
                        return " ";
                        break;
                    }
                default:
                    {
                        return bogstav1;
                        break;
                    }
            }
        }
    }
}
