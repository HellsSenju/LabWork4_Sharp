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


        List<Item> list;
        TreeNode selectedNode;

        public NewForm(int size)
        {
            InitializeComponent();
            list = new List<Item>();
            _size = size;
            _cells = new DrawingCells(pictureBoxCells.Width, pictureBoxCells.Height, _size);
            Draw(-1);
        }
        

        private void Draw(int index)
        {
            Bitmap bmp = new(pictureBoxCells.Width, pictureBoxCells.Height);
            Graphics gr = Graphics.FromImage(bmp);
            _cells.Drawing(gr, list, index);
            pictureBoxCells.Image = bmp;
            labelPrintNodes.Text = "";
            for(int i = 0; i < list.Count; i++)
            {
                labelPrintNodes.Text += "Node: " + list[i]._treeNode.Text + " -> first: " + list[i].cluster + "    ";
            }

            labelPrintArray.Text = "";
            for(int i = 0; i < _cells.arr.Length; i++)
            {
                labelPrintArray.Text += "[" + i + "]" + "=" + _cells.arr[i] + "    ";
            }
        }


        private bool Check(int neededKol)
        {
            int kol = 0;
            for (int i = 0; i < _cells.arr.Length; i++)
            {
                if (_cells.arr[i] == -2) kol++;
            }
            if (neededKol <= kol) return true;
            return false;
        }


        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int kolCells = (int)numericUpDown.Value; //кол-во ячеек
                                                     
            if (Check(kolCells)) //проверка хватает ли места
            {
                if(Tree.Nodes.Count == 0 || Tree.SelectedNode != null)
                {
                    string newNodeStr = textBoxCreate.Text; //название node'а берем из текст бокса
                    TreeNode newNode = new(newNodeStr); //создаем новый node 

                    Item newItem = new(newNode); //создаем новый элемент для листа

                    int i = 0;
                    do 
                    {
                        i = rnd.Next(_cells.arr.Length); //индекс первого кластера
                    } while (_cells.arr[i] != -2);

                    newItem.cluster = i; //запоминаем индекс первого кластера в новом элементе листа
                    _cells.arr[i] = -1; // отмечаем кластер как занятый
                    kolCells--;

                    //если у Node'а нексолько ячеек (начало)
                    int temp = newItem.cluster;
                    while (kolCells > 0)
                    {
                        i = rnd.Next(_cells.arr.Length);
                        if (_cells.arr[i] == -2)
                        {
                            _cells.arr[temp] = i;
                            _cells.arr[i] = -1;
                            kolCells--;
                            temp = i;
                        }
                    }
                    //(конец)

                    if (Tree.Nodes.Count == 0)
                    {
                        Tree.Nodes.Add(newNode);
                        list.Add(newItem);
                    }
                    else if (Tree.SelectedNode != null)
                    {
                        Tree.SelectedNode.Nodes.Add(newNode);
                        Tree.SelectedNode.ExpandAll(); //раскрываем все Node
                        list.Add(newItem);
                    }                   
                }
                Draw(-1);
            }
            else
            {
                MessageBox.Show("Недостаточно места", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            list.Clear();

            for (int i = 0; i < _cells.arr.Length; i++)
            {
                _cells.arr[i] = -2;
            }

            Tree.Nodes.Clear();
            Draw(-1);
        }

        
        private void Tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i]._treeNode == e.Node)
                {
                    Draw(list[i].cluster);
                }
            }
        }


        //выбор перетаскиваемого Node'а
        private void buttonNodeMove_Click(object sender, EventArgs e)
        {           
            selectedNode = Tree.SelectedNode; //В selectedNode заносим выбранный Node
            labelNodeMove.Text = selectedNode.Text; //в лейбл заносим имя выбранного 
            Tree.SelectedNode.Remove(); // убираем выбранный Node
            Draw(-1);
        }
        
        
        //выбор нового места и перемещение
        private void buttonMoveToNode_Click(object sender, EventArgs e)
        {
            Tree.SelectedNode.Nodes.Add(selectedNode); //добавляем выбранный в новое место
            labelMoveTo.Text = Tree.SelectedNode.Text; //в лейбл заносим имя нового места
            Draw(-1);
        }


        //выбор копируемого Node
        private void buttonNodeCopy_Click(object sender, EventArgs e)
        {
            TreeNode copied = Tree.SelectedNode;
            selectedNode = copied;
            labelNodeCopy.Text = copied.Text;
            Draw(-1);
        }



        //выбор нового места копируемого элемента и копирование
        private void buttonToNode_Click(object sender, EventArgs e)
        {
            Tree.SelectedNode.Nodes.Add(selectedNode);
            labelCopyTo.Text = selectedNode.Text;
            Draw(-1);
        }
    }
}
