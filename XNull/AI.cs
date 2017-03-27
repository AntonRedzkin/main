using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XNull
{
    class AI
    {
        public const char AIFIG = '0';
        Field Battlefield;

        public AI(ref Field field)
        {
            this.Battlefield = field;
        }

        public void SetField(Inputer Inputer)
        {
            int coordinate = GetRandomCoordinate();
            Battlefield.getSquare(coordinate).State = AIFIG;//
        }

        public int GetRandomCoordinate()
        {
            Random Random = new Random();
            int minValue = 1;
            int maxValue = 4;
            int coordinate = 0;
            bool key = true;
            while (key)
            {
                int coordinateX = Random.Next(minValue, maxValue);
                int coordinateY = Random.Next(minValue, maxValue);
                coordinate = coordinateX * 10 + coordinateY;
                Console.WriteLine(coordinate);
                int state = Battlefield.getSquare(coordinate).State;//
                if (state != ' ')
                {
                    coordinate = 0;
                    key = true;
                }
                else
                {
                    key = false;
                }                
            }
            return coordinate;
        }
    }
}
