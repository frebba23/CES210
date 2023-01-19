using System;
using System.Collection.Generic;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Select one of the following options ");
            Console.Write("1. Write\n1. 2. Display\n2. 3. Load\n3. 4. Save\n4. 5. Quit\n5. ");

            int options = int.Parse(Console.ReadLine());
            Prompt Generator proGen = new PromptGenerator();

            if (options == 1){
                proGen.displayPrompt();
            }

            else if (options == 2){
               proGen.displayPrompt(); 
            }
            
            else if (options == 3){
               proGen.displayPrompt(); 
            }

            else if (options == 4){
               proGen.displayPrompt(); 
            }

            else if (options == 5){
               break;
            }
        }

    }
}