namespace LabWork4_Sharp
{
    partial class NewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonNodeCopy = new System.Windows.Forms.Button();
            this.buttonMoveToNode = new System.Windows.Forms.Button();
            this.textBoxCreate = new System.Windows.Forms.TextBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.Tree = new System.Windows.Forms.TreeView();
            this.pictureBoxCells = new System.Windows.Forms.PictureBox();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelSelect = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.labelPrintArray = new System.Windows.Forms.Label();
            this.labelPrintNodes = new System.Windows.Forms.Label();
            this.buttonNodeMove = new System.Windows.Forms.Button();
            this.buttonToNode = new System.Windows.Forms.Button();
            this.labelNodeMove = new System.Windows.Forms.Label();
            this.labelMoveTo = new System.Windows.Forms.Label();
            this.labelNodeCopy = new System.Windows.Forms.Label();
            this.labelCopyTo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCells)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(10, 504);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(239, 51);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "Delete All";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonNodeCopy
            // 
            this.buttonNodeCopy.Location = new System.Drawing.Point(12, 320);
            this.buttonNodeCopy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonNodeCopy.Name = "buttonNodeCopy";
            this.buttonNodeCopy.Size = new System.Drawing.Size(106, 36);
            this.buttonNodeCopy.TabIndex = 15;
            this.buttonNodeCopy.Text = "Node copy";
            this.buttonNodeCopy.UseVisualStyleBackColor = true;
            this.buttonNodeCopy.Click += new System.EventHandler(this.buttonNodeCopy_Click);
            // 
            // buttonMoveToNode
            // 
            this.buttonMoveToNode.Location = new System.Drawing.Point(10, 224);
            this.buttonMoveToNode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonMoveToNode.Name = "buttonMoveToNode";
            this.buttonMoveToNode.Size = new System.Drawing.Size(108, 34);
            this.buttonMoveToNode.TabIndex = 13;
            this.buttonMoveToNode.Text = "to Node";
            this.buttonMoveToNode.UseVisualStyleBackColor = true;
            this.buttonMoveToNode.Click += new System.EventHandler(this.buttonMoveToNode_Click);
            // 
            // textBoxCreate
            // 
            this.textBoxCreate.Location = new System.Drawing.Point(11, 75);
            this.textBoxCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCreate.Name = "textBoxCreate";
            this.textBoxCreate.Size = new System.Drawing.Size(238, 27);
            this.textBoxCreate.TabIndex = 12;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(11, 16);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(239, 51);
            this.buttonCreate.TabIndex = 11;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // Tree
            // 
            this.Tree.HideSelection = false;
            this.Tree.Location = new System.Drawing.Point(270, 16);
            this.Tree.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tree.Name = "Tree";
            this.Tree.Size = new System.Drawing.Size(413, 620);
            this.Tree.TabIndex = 10;
            this.Tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Tree_AfterSelect);
            // 
            // pictureBoxCells
            // 
            this.pictureBoxCells.Location = new System.Drawing.Point(690, 16);
            this.pictureBoxCells.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxCells.Name = "pictureBoxCells";
            this.pictureBoxCells.Size = new System.Drawing.Size(410, 620);
            this.pictureBoxCells.TabIndex = 9;
            this.pictureBoxCells.TabStop = false;
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(14, 119);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(0, 20);
            this.labelSize.TabIndex = 19;
            // 
            // labelSelect
            // 
            this.labelSelect.AutoSize = true;
            this.labelSelect.Location = new System.Drawing.Point(11, 117);
            this.labelSelect.Name = "labelSelect";
            this.labelSelect.Size = new System.Drawing.Size(180, 20);
            this.labelSelect.TabIndex = 20;
            this.labelSelect.Text = "Select the number of cells";
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(195, 115);
            this.numericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(54, 27);
            this.numericUpDown.TabIndex = 21;
            this.numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelPrintArray
            // 
            this.labelPrintArray.Location = new System.Drawing.Point(14, 640);
            this.labelPrintArray.Name = "labelPrintArray";
            this.labelPrintArray.Size = new System.Drawing.Size(1086, 80);
            this.labelPrintArray.TabIndex = 22;
            // 
            // labelPrintNodes
            // 
            this.labelPrintNodes.Location = new System.Drawing.Point(10, 750);
            this.labelPrintNodes.Name = "labelPrintNodes";
            this.labelPrintNodes.Size = new System.Drawing.Size(1090, 97);
            this.labelPrintNodes.TabIndex = 23;
            // 
            // buttonNodeMove
            // 
            this.buttonNodeMove.Location = new System.Drawing.Point(11, 182);
            this.buttonNodeMove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonNodeMove.Name = "buttonNodeMove";
            this.buttonNodeMove.Size = new System.Drawing.Size(107, 34);
            this.buttonNodeMove.TabIndex = 24;
            this.buttonNodeMove.Text = "Node move";
            this.buttonNodeMove.UseVisualStyleBackColor = true;
            this.buttonNodeMove.Click += new System.EventHandler(this.buttonNodeMove_Click);
            // 
            // buttonToNode
            // 
            this.buttonToNode.Location = new System.Drawing.Point(12, 364);
            this.buttonToNode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonToNode.Name = "buttonToNode";
            this.buttonToNode.Size = new System.Drawing.Size(106, 36);
            this.buttonToNode.TabIndex = 25;
            this.buttonToNode.Text = "to Node";
            this.buttonToNode.UseVisualStyleBackColor = true;
            this.buttonToNode.Click += new System.EventHandler(this.buttonToNode_Click);
            // 
            // labelNodeMove
            // 
            this.labelNodeMove.AutoSize = true;
            this.labelNodeMove.Location = new System.Drawing.Point(124, 189);
            this.labelNodeMove.Name = "labelNodeMove";
            this.labelNodeMove.Size = new System.Drawing.Size(15, 20);
            this.labelNodeMove.TabIndex = 26;
            this.labelNodeMove.Text = "_";
            // 
            // labelMoveTo
            // 
            this.labelMoveTo.AutoSize = true;
            this.labelMoveTo.Location = new System.Drawing.Point(124, 231);
            this.labelMoveTo.Name = "labelMoveTo";
            this.labelMoveTo.Size = new System.Drawing.Size(15, 20);
            this.labelMoveTo.TabIndex = 27;
            this.labelMoveTo.Text = "_";
            // 
            // labelNodeCopy
            // 
            this.labelNodeCopy.AutoSize = true;
            this.labelNodeCopy.Location = new System.Drawing.Point(124, 328);
            this.labelNodeCopy.Name = "labelNodeCopy";
            this.labelNodeCopy.Size = new System.Drawing.Size(15, 20);
            this.labelNodeCopy.TabIndex = 28;
            this.labelNodeCopy.Text = "_";
            // 
            // labelCopyTo
            // 
            this.labelCopyTo.AutoSize = true;
            this.labelCopyTo.Location = new System.Drawing.Point(124, 372);
            this.labelCopyTo.Name = "labelCopyTo";
            this.labelCopyTo.Size = new System.Drawing.Size(15, 20);
            this.labelCopyTo.TabIndex = 29;
            this.labelCopyTo.Text = "_";
            // 
            // NewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 856);
            this.Controls.Add(this.labelCopyTo);
            this.Controls.Add(this.labelNodeCopy);
            this.Controls.Add(this.labelMoveTo);
            this.Controls.Add(this.labelNodeMove);
            this.Controls.Add(this.buttonToNode);
            this.Controls.Add(this.buttonNodeMove);
            this.Controls.Add(this.labelPrintNodes);
            this.Controls.Add(this.labelPrintArray);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.labelSelect);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonNodeCopy);
            this.Controls.Add(this.buttonMoveToNode);
            this.Controls.Add(this.textBoxCreate);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.Tree);
            this.Controls.Add(this.pictureBoxCells);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NewForm";
            this.Text = "NewForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCells)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonDelete;
        private Button buttonNodeCopy;
        private Button buttonMoveToNode;
        private TextBox textBoxCreate;
        private Button buttonCreate;
        private TreeView Tree;
        private PictureBox pictureBoxCells;
        private Label labelSize;
        private Label labelSelect;
        private NumericUpDown numericUpDown;
        private Label labelPrintArray;
        private Label labelPrintNodes;
        private Button buttonNodeMove;
        private Button buttonToNode;
        private Label labelNodeMove;
        private Label labelMoveTo;
        private Label labelNodeCopy;
        private Label labelCopyTo;
    }
}