using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace CordinateNavigationBot
{
    class Converter
    {
        private static bool isUnitOccupied(Bitmap bitmap, int iOffset, int jOffset, int iLenght, int jLength)
        {
            int[] sum = { 0, 0, 0 };
            for (int i = iOffset; i < iOffset + jLength; i++)
            {
                for (int j = jOffset; j < jOffset + jLength; j++)
                {
                    Color c = bitmap.GetPixel(i, j);
                    sum[0] += c.R;
                    sum[1] += c.G;
                    sum[2] += c.B;
                }
            }
            //
            return false;
        }
        public static bool[,] ConvertToGrid(Bitmap bitmap, int width, int height, int unitSize)
        {
            int gridCols = width / unitSize;//number of columns in the resulting grid
            int gridRows = height / unitSize;//number of rows in the resulting grid 
            int unitPixelWidth = bitmap.Width / gridCols;//number of pixels in 1 unit width
            int unitPixelHeight = bitmap.Height / gridRows;//number of pixels in 1 unit height
            bool[,] grid = new bool[gridRows, gridCols];
            //now filling the grid
            for (int i = 0; i < gridRows; i++)
            {
                for (int j = 0; j < gridCols; j++)
                {
                    //now we are in a cell of the grid 
                }
            }


            return grid;
        }

        }
    }
