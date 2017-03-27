using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XNull
{
    public class Field
    {
        public const char EMPTY = ' ';
        public const int DEMENSION = 3;
        public Square[,] arrayOfSquare { get; private set; }

        public Field()
        {
            this.arrayOfSquare = new Square[DEMENSION, DEMENSION];

            for (int i = 0; i < DEMENSION; i++)
            {
                for (int j = 0; j < DEMENSION; j++)
                {
                    this.arrayOfSquare[i, j] = new Square();
                    this.arrayOfSquare[i, j].State = EMPTY;
                    this.arrayOfSquare[i, j].Coordinate = (i + 1) * 10 + j + 1;
                }
            }
        }

        public Square getSquare(int position)
        {
            int i = position / 10;
            int j = position % 10;
            return arrayOfSquare[i-1, j-1];
        }
        public void isGameOver()
        {
            if (arrayOfSquare[0, 0].State.Equals(arrayOfSquare[1, 1]) &&
            arrayOfSquare[0, 0].State.Equals(arrayOfSquare[2, 2]))
            { }
            else if (arrayOfSquare[2, 0].State.Equals(arrayOfSquare[1, 1]) &&
            arrayOfSquare[0, 2].State.Equals(arrayOfSquare[2, 0]))
            { }
            else if (arrayOfSquare[0, 0].State.Equals(arrayOfSquare[0, 1]) &&
                        arrayOfSquare[0, 0].State.Equals(arrayOfSquare[0, 2]))
            { }
            else if (arrayOfSquare[0, 0].State.Equals(arrayOfSquare[1, 0]) &&
                        arrayOfSquare[0, 0].State.Equals(arrayOfSquare[2, 0]))
            { }
            else if (arrayOfSquare[1, 0].State.Equals(arrayOfSquare[1, 1]) && 
                arrayOfSquare[1, 1].State.Equals(arrayOfSquare[1, 2]))
            { }
        }
    }
}
