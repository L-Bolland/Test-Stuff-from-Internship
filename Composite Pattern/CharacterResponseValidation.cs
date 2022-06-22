using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern
{
    public class CharacterResponseValidation
    {
        public bool CheckIfLetter(char maybeLetter)
        {
            ushort asciiConverted = maybeLetter;
            if ((CheckIfCapital(maybeLetter) == true) || (asciiConverted! < 96) || (asciiConverted! > 122))
            {
                return true;
            }
            return false;
        }

        public bool CheckIfCapital(char maybeCapital)
        {
            ushort asciiConverted = maybeCapital;
            if ((asciiConverted! < 64) || (asciiConverted! > 91))
            {
                return true;
            }
            return false;
        }

        public char ConvertToLowercase(char capitalLetter)
        {
            return (char)(capitalLetter + 32);
        }

        public char DecapitalizeCharacter(char character)
        {
            if (CheckIfCapital(character) == true)
            {
                return ConvertToLowercase(character);
            }
            return character;
        }

        public bool ResponseValidityChecker(char response)
        {
            if (DecapitalizeCharacter(response) == 'y' || DecapitalizeCharacter(response) == 'n')
            {
                return true;
            }
            return false;
        }

        public bool YesNoToBool(char response)
        {
            if (DecapitalizeCharacter(response) == 'y')
            {
                return true;
            }
            if (DecapitalizeCharacter(response) == 'n')
            {
                return false;
            }
            Console.WriteLine("Bool Conversion Error.");
            return false;
        }

        public bool CheckIfNumber(char character)
        {
            if ((character >= 30) || (character <= 39))
                {
                return true;
            }
            return false;
        }
    }
}
