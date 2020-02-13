using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            void printIt(string text) //this function write text in the center of console
            {
                Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2, Console.CursorTop);
                Console.WriteLine(text);
            }


            printIt("********************************************"); //Printing Output header

            var name = "gurpreetsinghladhroia"; //value to be processed and displayed *input*

            int i = 0; //necessary for forLoop()

            char[] charArr = name.ToCharArray(); //converting given value to array
            
            foreach (char ch in charArr) //for each character of given value [loop]
            {
                var index = (ch < 97 ? ch - 64 : ch - 96); //getting the postion of alphabet (a)1, (b)2, (c)3

                System.Text.StringBuilder line = new System.Text.StringBuilder("");  //building line to print each time character changed, it should be appendable

                for (i = 0; i < index; i++) // foreach loop of characetr count 
                {
                    line.Append(ch); //appending same character in same line which will print after loop

                }

                printIt(line.ToString()); //here output printed after converting to string
            }

            printIt("********************************************"); //footer of console

            Console.ReadLine(); //using this insted of break
        }

    }


}
