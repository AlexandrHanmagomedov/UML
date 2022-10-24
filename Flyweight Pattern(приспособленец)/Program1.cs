using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Flyweight_Pattern_приспособленец_
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            // Build a document with text
            string document = "AAZZBBZB";
            char[] chars = document.ToCharArray();

            CharacterFactory f = new CharacterFactory();

            // extrinsic state
            int pointSize = 6;

            // For each character use a flyweight object
            foreach (char c in chars)
            {
                pointSize++;
                Character character = f.GetCharacter(c);
                character.Display(pointSize);
            }

            // Wait for user
            Console.Read();
        }
    }
 
}
