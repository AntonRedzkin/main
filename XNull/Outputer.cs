using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XNull
{
    class Outputer
    {
        public void PrintField(Field field)
        {
            for (int i = 0; i < field.arrayOfSquare.GetLength(0); i++)
            {
                for (int j = 0; j < field.arrayOfSquare.GetLength(0); j++)
                {
                    Console.Write("{0,3}|", field.arrayOfSquare[i,j].State);
                }
                Console.WriteLine("");
            }
            
        }
    }
}
