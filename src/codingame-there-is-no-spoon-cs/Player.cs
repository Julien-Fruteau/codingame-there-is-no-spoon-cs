using System;
using System.Collections;
using System.Collections.Generic;

namespace codingame_there_is_no_spoon_cs
{
    class Player
    {
        // public int width;
        // public int height;
        // public List<char[]> grid = new List<char[]>();
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine()); // the number of cells on the X axis
            int height = int.Parse(Console.ReadLine()); // the number of cells on the Y axis
            // Grid grid = new Grid(width, height);
            Grid grid = new Grid(width, height);

            for (int i = 0; i < height; i++)
            {
                string line = Console.ReadLine(); // width characters, each either 0 or .
                grid.AddLine(line);
            }

            IEnumerable<int[]> iEnumCoordinates = grid.IterCoordinates();

            //To retrieve all the items from the above IEnumerator object, we cannot use foreach loop instead of that we need to invoke MoveNext() Boolean method. 
            foreach(int[] coordinates in iEnumCoordinates)
            {
                Console.WriteLine(coordinates);
            }
            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");
            // for(x, y) in grid.IterCoor():
            //     # print(x, y, grid(x, y), file = sys.stderr)
            //     if grid(x, y) == "0":
            //         line = "{} {}".format(x, y)
            //     else:
            //         continue
            //     if grid.NextRightNeighboor(x, y):
            //         line += " {} {}".format(*grid.NextRightNeighboor(x, y))
            //     else:
            //         line += " -1 -1"
            //     if grid.NextLowerNeighboor(x, y):
            //         line += " {} {}".format(*grid.NextLowerNeighboor(x, y))
            //     else:
            //         line += " -1 -1"
            //     print(line)


            // Three coordinates: a node, its right neighbor, its bottom neighbor
            Console.WriteLine("0 0 1 0 0 1");
        }

        // public Grid(int width, int height)
        // {
        //     this.width = width;
        //     this.height = height;
        // }
    }

    public class Grid
    {
        public int width;
        public int height;
        public List<char[]> grid = new List<char[]>();

        public Grid(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public string GetCoorValue(int x, int y)
        {
            char[] row = grid[y];
            char coorValue = row[x];
            return coorValue.ToString();
        }

        public void AddLine(string line)
        {
            grid.Add(line.ToCharArray());
        }

        // public IEnumerator<int[]> IterCoor()
        // {
        //     for (int row = 0; row < height; row++)
        //     {
        //         for (int col = 0; col < width; col++)
        //         {
        //             yield return new int[] {col, row};
        //         }
        //     }
        // }

        public IEnumerable<int[]> IterCoordinates()
        {
            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    yield return new int[] { col, row };
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

        // def NextLowerNeighboor(self, x, y):
        // y += 1
        // while y<self.height:
        //     if grid(x, y) == '0':
        //         return (x, y)
        //     y += 1
        // return None

        // def NextRightNeighboor(self, x, y) :
        //     x += 1
        //     while x<self.width:
        //         if grid(x, y) == '0':
        //             return (x, y)
        //         x += 1
        //     return None
    }

}
