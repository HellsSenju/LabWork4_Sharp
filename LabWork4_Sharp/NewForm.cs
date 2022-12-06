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
        public DrawingCells _drawingCells;


        public List<Item> list;
        public List<TreeNode> cloned;
        TreeNode selected;

        public NewForm(int size)
        {
            InitializeComponent();
            list = new List<Item>();
            _size = size;
            _drawingCells = new DrawingCells(pictureBoxCells.Width, pictureBoxCells.Height, _size);
            Draw();
        }
        

        private void Draw()
        {
            Bitmap bmp = new(pictureBoxCells.Width, pictureBoxCells.Height);
            Graphics gr = Graphics.FromImage(bmp);
            _drawingCells.Drawing(gr, list);        
            pictureBoxCells.Image = bmp;

            labelPrintArray.Text = "";
            for(int i = 0; i < _drawingCells._cells.Length; i++)
            {
                labelPrintArray.Text += "[" + i + "]" + "=" + _drawingCells._cells[i] + "    ";
            }
        }

        private void Draw(List<int> indexes)
        {
            Bitmap bmp = new(pictureBoxCells.Width, pictureBoxCells.Height);
            Graphics gr = Graphics.FromImage(bmp);
            _drawingCells.DrawingSelected(gr, indexes, list);
            pictureBoxCells.Image = bmp;
        }

        private void SelectCells(Item item)
        {
            Random rnd = new();
            int temp;

            for (int i = 0; i < item.KolCells; i++)
            {
                temp = rnd.Next(_size);
                if (_drawingCells._cells[temp] != 0) i--;
                else
                {
                    item._cells.Add(temp);
                    _drawingCells._cells[temp] = 1;
                    _occupied--;
                }
            }
        }


        private void buttonCreate_Click(object sender, EventArgs e)
        {

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
                SelectCells(newItem);

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
                Draw();
            }         
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            list.Clear();

            for (int i = 0; i < _drawingCells._cells.Length; i++)
            {
                _drawingCells._cells[i] = 0;
            }

            Tree.Nodes.Clear();
            Draw();
        }

        




        private void Tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node == null) return;
            List<int> indexes = new();
            foreach(int index in findNodeInList(e.Node)._cells) indexes.Add(index);
            RecAfterSelect(e.Node, indexes);
            Draw(indexes);
        }
        // рекурсия для метода Tree_AfterSelect
        private void RecAfterSelect(TreeNode root, List<int> arr)
        {
            foreach (TreeNode child in root.Nodes)
            {
                if (child.Nodes.Count > 0)
                    RecAfterSelect(child, arr);
             
                foreach (int index in findNodeInList(child)._cells)
                {
                    arr.Add(index);
                }
            }
        }





        //выбор перетаскиваемого Node'а
        private void buttonNodeMove_Click(object sender, EventArgs e)
        {           
            selected = Tree.SelectedNode; //В selectedNode заносим выбранный Node
            labelNodeMove.Text = selected.Text; //в лейбл заносим имя выбранного 
            Tree.SelectedNode.Remove(); // убираем выбранный Node
            Draw();
        }
        
        
        //выбор нового места и перемещение
        private void buttonMoveToNode_Click(object sender, EventArgs e)
        {
            Tree.SelectedNode.Nodes.Add(selected); //добавляем выбранный в новое место
            labelMoveTo.Text = Tree.SelectedNode.Text; //в лейбл заносим имя нового места
            Draw();
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
            Draw();
        }


        //выбор нового места копируемого элемента и копирование
        private void buttonToNode_Click(object sender, EventArgs e)
        {
            if (selected == null || Tree.SelectedNode == null) return;
            if (!CheckForCycle(Tree.SelectedNode)) return;

            TreeNode clone = selected;
            TreeNode newCloneNode = new TreeNode(clone.Text);

            Item cloneI = findNodeInList(clone);
            Item newCloneI = new Item(newCloneNode, cloneI.KolCells);
            SelectCells(newCloneI);
            list.Add(newCloneI);

            TreeNode dest = Tree.SelectedNode;
            labelCopyTo.Text = dest.Text;

            dest.Nodes.Add(newCloneNode);
            RecClone(clone, dest.LastNode);
  
            Draw();
        }

        private void RecClone(TreeNode root, TreeNode dest)
        {
            foreach (TreeNode child in root.Nodes)
            {
                TreeNode newNode = new TreeNode(child.Text);

                Item childI = findNodeInList(child);
                Item newCloneI = new Item(newNode, childI.KolCells);
                SelectCells(newCloneI);
                list.Add(newCloneI);

                dest.Nodes.Add(newNode);
                if (child.Nodes.Count > 0)
                    RecClone(child, dest.LastNode);
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

        private bool CheckForCycle(TreeNode node)
        {
            TreeNode parent = node.Parent;
            while (parent != null)
            {
                if (parent == selected) return false;
                parent = parent.Parent;
            }
            return true;
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

         
            Draw();
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
