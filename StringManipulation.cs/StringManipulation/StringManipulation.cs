using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    class StringManipulation
    {
        static void Main(string[] args)
        {
            // Write a program which accepts two strings. 
            // The program should do the following: 
            Console.WriteLine("Please inter a sentence");
            string sentence = Console.ReadLine();

            // print and display the total number of occurrences of a or A
            int anOccurancea = 0;
           
            for (int counter = 0; counter < sentence.Length; counter++)
            {
                

                if (sentence[counter].ToString() == "a")
                {
                   
                    anOccurancea = anOccurancea + 1;

                    
                   
                }
                if (sentence[counter].ToString() == "A")
                {
                    anOccurancea = anOccurancea + 1;
                    
                }
                
            }
            Console.WriteLine(anOccurancea);



            Console.ReadKey();

            // replace every occurrence of „a‟ or „A‟ with @
            string newSentence = sentence.Replace('a', '@');
            string newSentence2 = newSentence.Replace('A', '@');
            Console.WriteLine(newSentence2);
            Console.ReadKey();








            sentence += " welcome";
            sentence += "to ";
            sentence += "Dot Net";

            Console.WriteLine(sentence);

            


            
            char theA;
            

            


            
            // convert both the strings to upper case 
            // concatenate the two strings and display the result 
            // declare one variable of type StringBuilder 
            // perform operations like Append(), Insert(), Remove(), Replace().

            StringBuilder MyStringBuilder = new StringBuilder("Hello World!");
            MyStringBuilder.Append(" What a beautiful day.");
            Console.WriteLine(MyStringBuilder);
            Console.ReadKey();
        }
    }
}
