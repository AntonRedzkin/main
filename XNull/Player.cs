using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XNull
{
    class Player
    {
        public const char PLAYERFIG = 'x';
        Field Battlefield;

        public Player(ref Field field)
        {
            this.Battlefield = field;
        }

        public void SetField(Inputer Inputer)
        {
            bool key = true;
            while (key)
            {
                int coordinate = Inputer.GetData();
                if (Battlefield.getSquare(coordinate).State == ' ')
                {
                    Battlefield.getSquare(coordinate).State = PLAYERFIG;
                    key = false;
                }
                else
                {
                    Console.WriteLine("This square is occupied. Enter correct square. ");
                    key = true;
                }
            }

        }
    }
}
