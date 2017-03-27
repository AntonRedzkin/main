using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XNull
{
    class Program
    {
        static void Main(string[] args)
        {
            Inputer inputer = new Inputer();
            Outputer outputer = new Outputer();
            Field field = new Field();
            outputer.PrintField(field);
            Player player = new Player(ref field);
            AI ai = new AI(ref field);
            int count = 0;
            while (true)
            {
                count++;
                player.SetField(inputer);
                outputer.PrintField(field);
                count++;
                if (count < 9)
                {
                    Console.WriteLine("Computer turn: ");
                    ai.SetField(inputer);
                    outputer.PrintField(field);

                }
                else
                {
                    Console.WriteLine("It's a draw. ");
                }


            }
        }
    }
}
