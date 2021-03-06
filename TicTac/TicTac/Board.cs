using System;
using System.Collections.Generic;
using System.Text;

namespace tictac
{
    class Board
    {
        
        private char[,] _positions = { 
                                    { 'X', ' ', ' ' },
                                    { ' ', 'O', ' ' },
                                    { ' ', ' ', 'X' }
                                 };

        public char[,] Positions
        {
            get { return _positions;  }
            set { _positions = value; }
        }

        public Board()
        {
        }

        public void Display()
        {
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine(" +-+-+-+");
                Console.Write(-(i-3));

                for (int j = 0; j <= 2; j++)
                {
                    Console.Write("|" + _positions[i, j]);
                }
                    
                Console.WriteLine("|");
            }

            Console.WriteLine(" +-+-+-+");
            Console.WriteLine("  A B C");

            
        }

        public void TakeXStep(string step)
        {
            TakeStep( 'X', step );
        }

        public void TakeOStep(string step)
        {
            TakeStep('O', step);
        }

        private void TakeStep( char mark, string step )
        {
            string[] r = step.Split(',');
            int col = 0;

            switch ( r[0] )
            {
                case "A": col = 0;
                    break;
                case "B": col = 1;
                    break;
                case "C": col = 2;
                    break;
            }

            _positions[-(Convert.ToInt32(r[1]) - 3), col] = mark;
        }

        private int EvaluateXPos()
        {
            return 0;
        }

        private int EvaluateOPos()
        {
            return 0;
        }

        public bool IsFull()
        {
            int cnt = 0;

            for (int i = 0; i <= 2; i++)
                for (int j = 0; j <= 2; j++)
                    if (_positions[i, j] == 'X' || _positions[i, j] == 'O')
                        cnt++;

            return (cnt == 9);
        }

        private int GetPositionValue( char mark)
        {
            int result = 0;
            int j = 0;

            //van hármas?
            bool hasThree = false;
            
            //függőleges és vízszintes
            
            while ( j <= 2 && !hasThree)
            {
                hasThree = ( _positions[j, 0] == mark
                             && _positions[j, 1] == mark
                             && _positions[j, 2] == mark
                           )
                           ||
                           ( _positions[0, j] == mark
                             && _positions[1, j] == mark
                             && _positions[2, j] == mark
                           );
                j++;
            }

            //kereszt
            
            if (!hasThree)
            {
                hasThree = (_positions[0, 0] == mark
                             && _positions[1, 1] == mark
                             && _positions[2, 2] == mark
                           )
                           ||
                           (_positions[2, 0] == mark
                             && _positions[1, 1] == mark
                             && _positions[0, 2] == mark
                           );
            }

            result = hasThree ? int.MaxValue : 0;


            //kettesek száma (egymás mellett)

            if (result == 0)
            {
                int cnt = 0;

                //kereszt

                for (int i = 0; i <= 2; i++)
                {
                    //függőleges
                    if (_positions[1, i] == mark
                        && ( _positions[0, i] == mark
                             || _positions[2, i] == mark 
                           )
                        )
                    {
                        cnt++;
                    }

                    //vízszintes
                    if (_positions[i, 1] == mark
                        && (_positions[i, 0] == mark
                             || _positions[i, 2] == mark
                           )
                        )
                    {
                        cnt++;
                    }
                }

                result = cnt;
            }

            return result;
        }


        public List<Position> GetFreePositions()
        {
            List<Position> result = new List<Position>();

            for (int i = 0; i <= 2; i++)
                for (int j = 0; j <= 2; j++)
                    if (_positions[i, j] == ' ' )
                        result.Add(new Position(i,j));

            return result;
        }
    }
}
