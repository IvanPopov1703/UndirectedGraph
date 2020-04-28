using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndirectedGraph
{
    class CellDraw
    {
        public string Name { get; set; } //Название вершины
        public int CoordX { get; private set; }  //Координата x
        public int CoordY { get; private set; }  //Координата y

        public CellDraw(string name, int x, int y)
        {
            Name = name;
            CoordX = x;
            CoordY = y;
        }
    }
}
