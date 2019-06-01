using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Figure> wallsList;

        public Walls(int mapWight, int mapHeight)
        {
            wallsList = new List<Figure>();

            HorizontalLine upLine = new HorizontalLine(0, mapWight-2, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, mapWight-2, mapHeight-1, '+');
            VerticalLine leftLine = new VerticalLine(0, mapHeight-1, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, mapHeight-1, mapWight-2, '+');

            wallsList.Add(upLine);
            wallsList.Add(downLine);
            wallsList.Add(leftLine);
            wallsList.Add(rightLine);
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallsList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach (var wall in wallsList)
            {
                wall.Draw();
            }
        }
    }
}
