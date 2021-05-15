using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

struct EmptyPoint
{
    public int row;
    public int column;

    public EmptyPoint(int a, int b)
    {
        row = a;
        column = b;
    }
}

namespace fifteensWinForm
{
    class Numbers
    {
        private const int SIZE = 4;

        public int[,] table { get; private set; } 
        private int[,] inittable { get; set; }

        private List<int> LiB = new List<int>();

        private EmptyPoint empty;
        private EmptyPoint initempty;

        private int changes = 0;

        public Numbers()
        {
            table = new int[SIZE, SIZE];
            inittable = new int[SIZE, SIZE];
            NewGame();        
        }

        private void NewGame()
        {
            Random rand = new Random();     
            List<int> liA = new List<int>();
                for (int i = 0; i < SIZE * SIZE; i++)
                {
                    liA.Add(i);
                }

                int boundary = 15;

                for (int i = 0; i < SIZE; i++)
                {
                    for (int j = 0; j < SIZE; j++)
                    {
                        int index = rand.Next(0, boundary);

                        int item = liA[index];
                        LiB.Add(item);

                        if (item == 0)
                        {
                            empty.row = i;
                            empty.column = j;
                            initempty.row = i;
                            initempty.column = j;
                        }

                        table[i, j] = item;
                        inittable[i, j] = item;

                        liA.RemoveAt(index);
                        boundary--;
                    }
                }
            MakePossibleToWin();
        }

        private void MakePossibleToWin()
        {
            if (!IsPossibleToWin())
            {
                bool gotTheFirst = false;

                EmptyPoint NOTempty1 = new EmptyPoint();
                EmptyPoint NOTempty2 = new EmptyPoint();

                for (int i = 0; i < SIZE; i++)
                {
                    if (LiB[i] != 0 && !gotTheFirst)
                    {
                        NOTempty1 = new EmptyPoint(0, i);
                        gotTheFirst = true;
                    }
                    else if (LiB[i] != 0)
                    {
                        NOTempty2 = new EmptyPoint(0, i);
                        break;
                    }
                }
                Swap(NOTempty1, NOTempty2);
            }
        }

        public void SetInitialTable()
        {            
            Copy(this);
            empty.row = initempty.row;
            empty.column = initempty.column;
            changes = 0;
        }

        private static void Copy(Numbers numbers)
        {
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    numbers.table[i, j] = numbers.inittable[i, j];
                }
            }
        }


        private void Swap(EmptyPoint first, EmptyPoint second)
        {
            int bufItem = table[first.row, first.column];
            table[first.row, first.column] = table[second.row, second.column];
            table[second.row, second.column] = bufItem;

            inittable[first.row, first.column] = table[first.row, first.column];
            inittable[second.row, second.column] = bufItem;
        }

        private int GetLloydNumber()
        {
            int result = 0;

            for (int i = 0; i < SIZE * SIZE; i++)
            {
                int m = i;
                for (int k = m + 1; k < SIZE * SIZE; k++)
                {
                    if (LiB[m] > LiB[k])
                    {
                        result++;
                    }
                }
            }
            return result + empty.row + 1;
        }

        public EmptyPoint GetEmpty()
        {
            return empty;
        }

        public bool IsPossibleToWin()
        {
            return GetLloydNumber() % 2 == 0;
        }

        public void Change(int m, int n)
        {           
                table[empty.row, empty.column] = table[m, n];
                table[m, n] = 0;

                empty.row = m;
                empty.column = n;
                changes++;
        }

        public int GetChanges()
        {
            return changes;
        }

        public bool WonAlready()
        {
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {                  
                    if (table[i, j] != (i * SIZE + j + 1) % 16)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public bool CanBeChanged(int m, int n)
        {
            if (((m == empty.row) || (n == empty.column)) && ((Math.Abs(m - empty.row) == 1) || (Math.Abs(n - empty.column) == 1)))
            {
                return true;
            }
            return false;
        }
    }
}

