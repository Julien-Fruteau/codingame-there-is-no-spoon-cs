using System;
using System.Collections;
using System.Collections.Generic;

namespace codingame_there_is_no_spoon_cs
{
    class Player
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine()); // the number of cells on the X axis
            int height = int.Parse(Console.ReadLine()); // the number of cells on the Y axis
            Grid grid = new Grid(width, height);

            for (int i = 0; i < height; i++)
            {
                string line = Console.ReadLine(); // width characters, each either 0 or .
                grid.Append(line);
            }

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");


            // Three coordinates: a node, its right neighbor, its bottom neighbor
            Console.WriteLine("0 0 1 0 0 1");
        }
    }

    class Grid
    {
        public int width;
        public int height;
        public List<char[]> grid = new List<char[]>();

        public Grid(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public char GetGrid(int x, int y)
        {
            return grid[y][x];
        }

        public void Append(string line)
        {
            grid.Add(line.ToCharArray());
        }

        public IEnumerator IterCoor()
        {
            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    yield return (col, row);
                }
            }
        }

        // public NextLowerNeighboor(int x, int y)
        // {
        //     y += 1;
        //     while (y < height)
        //     {
        //         if 
        //     }
        // }
    }
}
