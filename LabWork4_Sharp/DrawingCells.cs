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

        public int[] arr;
        // -1 - конец связанного 
        // -2 - незанятая 

        public DrawingCells(int pictureBoxWidth, int pictureBoxHeight, int size)
        {
            picWidth = pictureBoxWidth;
            picHeight = pictureBoxHeight;
            arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = -2;
            }
            lineSize = picWidth / cellsSize;
            //TODO проверка на то, что хватит места для отрисовки
            ost = size - ((size / lineSize * lineSize));
        }

        public void Drawing(Graphics g, List<Item> files, int Index)
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
                g.FillRectangle(br, i * cellsSize, j * cellsSize, cellsSize, cellsSize);
                g.DrawRectangle(pen, i * cellsSize, j * cellsSize, cellsSize, cellsSize);
                i++;
                kol++;
            }
            i = 0;
            j = 0;
            int index = 0;
            int kolLineSize = 0; //количество целых lineSize относительно индекса первого кластера
            for(int l = 0; l < files.Count; l++)
            {
                if (files[l] != null)
                {
                    index = files[l].cluster;
                    while (true)
                    {
                        if (index < lineSize)
                        {
                            i = index;
                        }
                        else
                        {
                            j = index / lineSize;
                            i = index - lineSize * j;
                        }
                        g.FillRectangle(brBlue, i * cellsSize, j * cellsSize, cellsSize, cellsSize);
                        g.DrawRectangle(pen, i * cellsSize, j * cellsSize, cellsSize, cellsSize);
                        if (arr[index] == -1) break;
                        index = arr[index];
                    }
                }               
            }
            if(Index != -1)
            {
                i = 0;
                j = 0;
                while (true)
                {
                    if (Index < lineSize)
                    {
                        i = Index;
                    }
                    else
                    {
                        j = Index / lineSize;
                        i = Index - lineSize * j;
                    }
                    g.FillRectangle(brRed, i * cellsSize, j * cellsSize, cellsSize, cellsSize);
                    g.DrawRectangle(pen, i * cellsSize, j * cellsSize, cellsSize, cellsSize);
                    if (arr[Index] == -1) break;
                    Index = arr[Index];
                }
            }
            
        }
    }
}
