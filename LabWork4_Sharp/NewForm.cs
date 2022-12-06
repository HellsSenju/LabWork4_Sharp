using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LabWork4_Sharp
{
    public partial class NewForm : Form
    {
        public int _size;
        public int _occupied;
        public List<int> a;
        public DrawingCells _cells;


        public List<Item> list;
        TreeNode selected;

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


        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new();
            int kolCells = (int)numericUpDown.Value; //кол-во ячеек

            if (kolCells > (_size - _occupied)) //если места не хватает
            {
                MessageBox.Show("Недостаточно места", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            if (Tree.Nodes.Count == 0 || Tree.SelectedNode != null)
            {
                string newNodeStr = textBoxCreate.Text; //название node'а берем из текст бокса
                TreeNode newNode = new(newNodeStr); //создаем новый node 

                Item newItem = new(newNode, kolCells); //создаем новый элемент для листа
                method(newItem);

                if (Tree.Nodes.Count == 0)
                {
                    Tree.Nodes.Add(newNode);
                    _occupied += kolCells;
                    list.Add(newItem);
                }
                else if (Tree.SelectedNode != null)
                {
                    Tree.SelectedNode.Nodes.Add(newNode);
                    _occupied += kolCells;
                    Tree.SelectedNode.ExpandAll(); //раскрываем все Node
                    list.Add(newItem);
                }                   
                Draw(-1);
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
                if (list[i]._treeNode.Equals(e.Node))
                {
                    Item item = findNodeInList(e.Node);
                    int temp = item.cluster;
                    while(temp != -1)
                    {


                    }
                    Draw(list[i].cluster);
                }
            }
        }


        //выбор перетаскиваемого Node'а
        private void buttonNodeMove_Click(object sender, EventArgs e)
        {           
            selected = Tree.SelectedNode; //В selectedNode заносим выбранный Node
            labelNodeMove.Text = selected.Text; //в лейбл заносим имя выбранного 
            Tree.SelectedNode.Remove(); // убираем выбранный Node
            Draw(-1);
        }
        
        
        //выбор нового места и перемещение
        private void buttonMoveToNode_Click(object sender, EventArgs e)
        {
            Tree.SelectedNode.Nodes.Add(selected); //добавляем выбранный в новое место
            labelMoveTo.Text = Tree.SelectedNode.Text; //в лейбл заносим имя нового места
            Draw(-1);
        }


        //выбор копируемого Node
        private void buttonNodeCopy_Click(object sender, EventArgs e)
        {
            selected = Tree.SelectedNode;
            if (!CheckForCopy(selected))
            {
                selected = null;
                return;
            }
            labelNodeCopy.Text = selected.Text;
            Draw(-1);
        }


        //выбор нового места копируемого элемента и копирование
        private void buttonToNode_Click(object sender, EventArgs e)
        {
            if (selected == null) return;

            a = new();

            labelCopyTo.Text = Tree.SelectedNode.Text;
            TreeNode clonedNode = (TreeNode)selected.Clone(); //клонировали узел и все его дочерние элементы
            Tree.SelectedNode.Nodes.Add(clonedNode);

            //чтобы все отрисовалось, нужно клонированный и все его дочерние узлы добавить в лист
            Item temp = findNodeInList(selected); //ищем рут, который клонировали, в листе, чтобы посмотреть количество ячеек
            Item cloned = new(clonedNode, temp.KolCells); // создаем новый элемент листа для клонированного рута
            method(cloned); //выделяем ячейки для нового элемента
            list.Add(cloned); //добавляем в лист новый элемент

            method2(selected);
            method3(clonedNode);
            Draw(-1);
        }

        // рекурсия, чтобы заполнить лист с количеством ячеек
        private void method2(TreeNode root)
        {
            foreach (TreeNode child in root.Nodes)
            {
                if (child.Nodes.Count > 0)
                    method2(child);
                Item temp = findNodeInList(child);
                a.Add(temp.KolCells);
            }
        }

        // рекурсия, чтобы заменить ноды
        private void method3(TreeNode root)
        {
            foreach (TreeNode child in root.Nodes)
            {
                if (child.Nodes.Count > 0)
                    method3(child);

                Item newItem = new(child, a[0]);
                method(newItem);
                list.Add(newItem);
                a.RemoveAt(0);
            }
        }

        //подбирает и заполняет ячейки
        private void method(Item item)
        {
            Random rnd = new();
            int i, temp;
            int cells = item.KolCells;

            do
            {
                i = rnd.Next(_cells.arr.Length); //индекс первого кластера
            } while (_cells.arr[i] != -2);

            item.cluster = i; //запоминаем индекс первого кластера в новом элементе листа
            _cells.arr[i] = -1; // отмечаем кластер как занятый
            cells--;

            temp = item.cluster;
            while (cells > 0)
            {
                i = rnd.Next(_cells.arr.Length);
                if (_cells.arr[i] == -2)
                {
                    _cells.arr[temp] = i;
                    _cells.arr[i] = -1;
                    cells--;
                    temp = i;
                }
            }
        }

        //находит передаваемый узел в листе
        private Item findNodeInList(TreeNode node)
        {
            foreach (Item temp in list)
            {
                if (temp._treeNode == node) return temp;
            }
            return null;
        }

        //проверяет хватит ли пустых ячеек при копировании
        private bool CheckForCopy(TreeNode mainNode)
        {
            int needed = 0;
            foreach(TreeNode temp in mainNode.Nodes)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i]._treeNode == temp || list[i]._treeNode == mainNode)
                    {
                        needed += list[i].KolCells;
                    }
                }
            }

            if(needed <= (_size - _occupied)){
                return true;
            }
            return false;
        }

        private void buttonDeleteNode_Click(object sender, EventArgs e)
        {
            TreeNode deleted = Tree.SelectedNode;

            method4(deleted);

         
            Draw(-1);
        }

        //
        private void method4(TreeNode root)
        {
            foreach (TreeNode child in root.Nodes)
            {
                if (child.Nodes.Count > 0)
                    method4(child);

                Item item = findNodeInList(child);
                list.Remove(item);
            }
        }
    }
}
