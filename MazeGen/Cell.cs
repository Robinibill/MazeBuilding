using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;


namespace Challenges.MazeGen
{
    class Cell
    {
        //Properties of cell object

        public int x { get; set; }
        public int y { get; set; }
        public int size { get; set; }
        public bool top    { get; set; }
        public bool bottom { get; set; }
        public bool right  { get; set; }
        public bool left   { get; set; }


        public bool visited { get; set; }
        //construcor for cell
        public Cell(int X,int Y)
        {
            x = X;
            y = Y;
        }
        //data generator for load of cell, adds nesesary data. u can run program without this option in program.
        public void Generate(int size)
        {
            this.visited = false;

            this.top    = true;
            this.bottom = true;
            this.right  = true;
            this.left   = true;

            this.size = size;
        }
        public void RemoveWall(int Side)
        {
            if (Side == 1) { this.top    = false; }
            if (Side == 2) { this.right  = false; }
            if (Side == 3) { this.bottom = false; }
            if (Side == 4) { this.left   = false; }
            else {
                Console.WriteLine("OUT OF RANGE");
            }
        }
        public void CheckNeighbors(MazeGen.Cell[,] grid, Cell cell)
        {
            if (grid[cell.x,cell.y].visited == false)
        }

        public void Update()
        {

        }
    }
}
