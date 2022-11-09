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
            this.textBoxCopy = new System.Windows.Forms.TextBox();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.textBoxMove = new System.Windows.Forms.TextBox();
            this.buttonMove = new System.Windows.Forms.Button();
            this.textBoxCreate = new System.Windows.Forms.TextBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.Tree = new System.Windows.Forms.TreeView();
            this.pictureBoxCells = new System.Windows.Forms.PictureBox();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelSelect = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCells)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(11, 571);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(239, 51);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxCopy
            // 
            this.textBoxCopy.Location = new System.Drawing.Point(11, 429);
            this.textBoxCopy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCopy.Name = "textBoxCopy";
            this.textBoxCopy.Size = new System.Drawing.Size(238, 27);
            this.textBoxCopy.TabIndex = 16;
            this.textBoxCopy.Text = "\"name\"";
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(11, 371);
            this.buttonCopy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(239, 51);
            this.buttonCopy.TabIndex = 15;
            this.buttonCopy.Text = "Copy to:";
            this.buttonCopy.UseVisualStyleBackColor = true;
            // 
            // textBoxMove
            // 
            this.textBoxMove.Location = new System.Drawing.Point(11, 252);
            this.textBoxMove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMove.Name = "textBoxMove";
            this.textBoxMove.Size = new System.Drawing.Size(238, 27);
            this.textBoxMove.TabIndex = 14;
            this.textBoxMove.Text = "\"name\"";
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(11, 193);
            this.buttonMove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(239, 51);
            this.buttonMove.TabIndex = 13;
            this.buttonMove.Text = "Move to:";
            this.buttonMove.UseVisualStyleBackColor = true;
            // 
            // textBoxCreate
            // 
            this.textBoxCreate.Location = new System.Drawing.Point(11, 75);
            this.textBoxCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCreate.Name = "textBoxCreate";
            this.textBoxCreate.Size = new System.Drawing.Size(238, 27);
            this.textBoxCreate.TabIndex = 12;
            this.textBoxCreate.Text = "\"name\"";
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
            this.Tree.Size = new System.Drawing.Size(413, 825);
            this.Tree.TabIndex = 10;
            this.Tree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.Tree_NodeMouseClick);
            // 
            // pictureBoxCells
            // 
            this.pictureBoxCells.Location = new System.Drawing.Point(690, 16);
            this.pictureBoxCells.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxCells.Name = "pictureBoxCells";
            this.pictureBoxCells.Size = new System.Drawing.Size(410, 825);
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
            // NewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 856);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.labelSelect);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxCopy);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.textBoxMove);
            this.Controls.Add(this.buttonMove);
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
        private TextBox textBoxCopy;
        private Button buttonCopy;
        private TextBox textBoxMove;
        private Button buttonMove;
        private TextBox textBoxCreate;
        private Button buttonCreate;
        private TreeView Tree;
        private PictureBox pictureBoxCells;
        private Label labelSize;
        private Label labelSelect;
        private NumericUpDown numericUpDown;
    }
}