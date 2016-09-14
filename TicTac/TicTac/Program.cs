using System;
using System.Collections.Generic;
using System.Text;

namespace tictac
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
           
            board.TakeXStep("A,2");
            board.TakeXStep("A,1");
            board.TakeXStep("B,1");
            board.TakeXStep("C,3");
            board.TakeOStep("C,2");
            //board.TakeOStep("B,3");

            board.Display();

            if ( board.IsFull() )
            {
                Console.WriteLine("vége");
            }
        }
    }
}
