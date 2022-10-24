using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_Pattern_приспособленец_
{
    // "FlyweightFactory"

    class CharacterFactory
    {
        private Hashtable characters = new Hashtable();

        public Character GetCharacter(char key)
        {
            // Uses "lazy initialization"
            Character character = characters[key] as Character;
            if (character == null)
            {
                switch (key)
                {
                    case 'A': character = new CharacterA(); break;
                    case 'B': character = new CharacterB(); break;
                    //...
                    case 'Z': character = new CharacterZ(); break;
                }
                characters.Add(key, character);
            }
            return character;
        }
    }

}
