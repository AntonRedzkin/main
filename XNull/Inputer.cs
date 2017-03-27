using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XNull
{
    class Inputer
    {
        public int GetData()
        {
            Console.WriteLine("Input startPosition (11 - 33): ");
            string input = Console.ReadLine();
            return ParseToPositionX(input)*10 + ParseToPositionY(input);
        }

        public int ParseToPositionX(string input)
        {
            int position= Int32.Parse(input);
            int positionX = position / 10;
            if (positionX > 3)
                throw new FormatException("Wrong positionX");
            return positionX;
        }
        public int ParseToPositionY(string input)
        {
            int position = Int32.Parse(input);
            int positionY = position % 10;
            if (positionY > 3)
                throw new FormatException("Wrong positionY");
            return positionY;
        }
    }
}
