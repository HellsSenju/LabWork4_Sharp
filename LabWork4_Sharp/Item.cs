using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork4_Sharp
{
    public class Item
    {
        public TreeNode _treeNode { get; set; }
        public int KolCells { get; private set; }
        public int cluster = -1;   

        public Item(TreeNode node, int kolCells)
        {
            _treeNode = node;
            KolCells = kolCells;
        }
    }
}
