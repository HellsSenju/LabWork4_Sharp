using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork4_Sharp
{
    public class DrawingCells
    {
        private int picWidth;
        private int picHeight;

        private int cellsSize = 20;
        private int ost;
        private int lineSize;

        public int[] arr;

        public DrawingCells(int pictureBoxWidth, int pictureBoxHeight, int size)
        {
            picWidth = pictureBoxWidth;
            picHeight = pictureBoxHeight;
            arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = -1;
            }
            lineSize = picWidth / cellsSize;
            ost = size - ((size / lineSize * lineSize));
        }

        public void Drawing(Graphics g, int temp)
        {           
            Pen pen = new(Color.Black);
            Brush br = new SolidBrush(Color.LightGray);
            Brush brBlue = new SolidBrush(Color.Blue);
            Brush brRed = new SolidBrush(Color.RebeccaPurple);

            int j = 0;
            int i = 0;
            int kol = 0;            
            while(kol < arr.Length)
            {
                if(i == lineSize)
                {
                    j++;
                    i = 0;
                }

                if (arr[kol] < 0)
                {
                    g.FillRectangle(br, i * cellsSize, j * cellsSize, cellsSize, cellsSize);
                    g.DrawRectangle(pen, i * cellsSize, j * cellsSize, cellsSize, cellsSize);
                }
                else if (arr[kol] == temp)
                {
                    g.FillRectangle(brRed, i * cellsSize, j * cellsSize, cellsSize, cellsSize);
                    g.DrawRectangle(pen, i * cellsSize, j * cellsSize, cellsSize, cellsSize);
                    temp = arr[temp];
                }
                else 
                {
                    g.FillRectangle(brBlue, i * cellsSize, j * cellsSize, cellsSize, cellsSize);
                    g.DrawRectangle(pen, i * cellsSize, j * cellsSize, cellsSize, cellsSize);
                }
                i++;
                kol++;
            }
        }

        public void DrawingLinked()
        {
            
        }
    }
}
