using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork4_Sharp
{
    public partial class NewForm : Form
    {
        public int _size;
        public DrawingCells _cells;
        LinkedList<Item> list;
        public NewForm(int size)
        {
            InitializeComponent();
            list = new LinkedList<Item>();
            _size = size;
            _cells = new DrawingCells(pictureBoxCells.Width, pictureBoxCells.Height, _size);
            Draw(-1);
        }
        
        private void Draw(int first)
        {
            Bitmap bmp = new(pictureBoxCells.Width, pictureBoxCells.Height);
            Graphics gr = Graphics.FromImage(bmp);
            _cells.Drawing(gr, first);
            pictureBoxCells.Image = bmp;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int kolCells = (int)numericUpDown.Value; //кол-во ячеек                 
            if (Check(kolCells)) //проверка хватает ли места
            {
                string newNodeStr = textBoxCreate.Text; //название node'а берем из текст бокса
                TreeNode newNode = new(newNodeStr); //создаем новый node 

                Item newItem = new(newNode);

                int i = rnd.Next(_cells.arr.Length);
                newItem.cluster = i;
                _cells.arr[i] = -2;
                kolCells--;

                int temp = i;
                while (kolCells >= 0)
                {
                    i = rnd.Next(_cells.arr.Length);
                    if (_cells.arr[i] == -1)
                    {
                        _cells.arr[temp] = i;
                        _cells.arr[i] = -2;
                        kolCells--;
                        temp = i;
                    }
                }
                list.AddLast(newItem);

                if (Tree.Nodes.Count == 0)
                {
                    Tree.Nodes.Add(newNode);
                }
                else if (Tree.SelectedNode != null)
                {
                    Tree.SelectedNode.Nodes.Add(newNode);
                    Tree.SelectedNode.ExpandAll();
                }
                Draw(-1);
            }
            else
            {
                MessageBox.Show("Недостаточно места", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private bool Check(int neededKol)
        {
            int kol = 0;
            for(int i = 0; i < _cells.arr.Length; i++)
            {
                if (_cells.arr[i] == -1) kol++;
            }
            if (neededKol <= kol) return true;
            return false;
        }

        private void Tree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            foreach(Item item in list)
            {
                if(item._treeNode == Tree.SelectedNode)
                {
                    Draw(item.cluster);
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            foreach (Item item in list)
            {
                if (item._treeNode == Tree.SelectedNode)
                {
                    for(int i = 0; i < item._treeNode.Nodes.Count; i++)
                    {
                        foreach (Item item in list)
                        {

                        }
                    }


                    int temp = delete.cluster;
                    int next = _cells.arr[temp];
                    item.cluster = -3;
                    while(next != -2)
                    {                        
                        _cells.arr[temp] = -1;
                        temp = next;
                        next = _cells.arr[temp];
                    }
                    _cells.arr[temp] = -1;
                }
            }
            Tree.Nodes.Remove(Tree.SelectedNode);
            Draw(-1);
        }
    }
}
