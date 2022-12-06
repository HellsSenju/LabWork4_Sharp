using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LabWork4_Sharp
{
    public class DrawingCells
    {
        private int picWidth;
        private int picHeight;

        private int cellsSize = 30;
        private int ost;
        private int lineSize;

        public int[] _cells;
        // -1 - конец связанного 
        // -2 - незанятая 

        public DrawingCells(int pictureBoxWidth, int pictureBoxHeight, int size)
        {
            picWidth = pictureBoxWidth;
            picHeight = pictureBoxHeight;
            _cells = new int[size];
            lineSize = picWidth / cellsSize;
            //TODO проверка на то, что хватит места для отрисовки
            ost = size - ((size / lineSize * lineSize));
        }

        public void DrawingSelected(Graphics g, List<int> indexes, List<Item> list)
        {
            DrawingGray(g);
            Drawing(g, list);

            Pen pen = new(Color.Black);
            Brush brRed = new SolidBrush(Color.Red);
            int i, j;

            foreach (int index in indexes)
            {
                if (index < lineSize)
                {
                    i = index;
                    j = 0;
                }
                else
                {
                    j = index / lineSize;
                    i = index - (lineSize * j);
                }
                g.FillRectangle(brRed, i * cellsSize, j * cellsSize, cellsSize, cellsSize);
                g.DrawRectangle(pen, i * cellsSize, j * cellsSize, cellsSize, cellsSize);
            }
        }

        public void DrawingGray(Graphics g)
        {
            Pen pen = new(Color.Black);
            Brush br = new SolidBrush(Color.LightGray);

            int j = 0;
            int i = 0;
            int kol = 0;
            while (kol < _cells.Length)
            {
                if (i == lineSize)
                {
                    j++;
                    i = 0;
                }
                g.FillRectangle(br, i * cellsSize, j * cellsSize, cellsSize, cellsSize);
                g.DrawRectangle(pen, i * cellsSize, j * cellsSize, cellsSize, cellsSize);
                i++;
                kol++;
            }
        }

        public void Drawing(Graphics g, List<Item> list)
        {
            DrawingGray(g);
            Pen pen = new(Color.Black);
            Brush brBlue = new SolidBrush(Color.Blue);
            int i, j;
            foreach (Item item in list)
            {
                foreach(int index in item._cells)
                {
                    if (index < lineSize)
                    {
                        i = index;
                        j = 0;
                    }
                    else
                    {
                        j = index / lineSize;
                        i = index - (lineSize * j);
                    }
                    g.FillRectangle(brBlue, i * cellsSize, j * cellsSize, cellsSize, cellsSize);
                    g.DrawRectangle(pen, i * cellsSize, j * cellsSize, cellsSize, cellsSize);
                }  
            }
        }

/*        public void Drawing(Graphics g, List<Item> files, int Index)
        {           
            
            Brush brRed = new SolidBrush(Color.Red);

            if (Index != -1)
            {
                while (true)
                {
                    if (Index < lineSize)
                    {
                        i = Index;
                        j = 0;
                    }
                    else
                    {
                        j = Index / lineSize;
                        i = Index - lineSize * j;
                    }
                    g.FillRectangle(brRed, i * cellsSize, j * cellsSize, cellsSize, cellsSize);
                    g.DrawRectangle(pen, i * cellsSize, j * cellsSize, cellsSize, cellsSize);
                    if (_cells[Index] == -1) break;
                    Index = _cells[Index];
                }
            }            
        }*/
    }
}
