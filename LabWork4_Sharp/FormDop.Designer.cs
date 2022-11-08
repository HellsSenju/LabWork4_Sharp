namespace LabWork4_Sharp
{
    partial class FormDop
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
            this.labelEnter = new System.Windows.Forms.Label();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.buttonSet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEnter
            // 
            this.labelEnter.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEnter.Location = new System.Drawing.Point(22, 42);
            this.labelEnter.Name = "labelEnter";
            this.labelEnter.Size = new System.Drawing.Size(360, 41);
            this.labelEnter.TabIndex = 0;
            this.labelEnter.Text = "Enter the size";
            this.labelEnter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxSize
            // 
            this.textBoxSize.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSize.Location = new System.Drawing.Point(51, 97);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(300, 52);
            this.textBoxSize.TabIndex = 1;
            this.textBoxSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonSet
            // 
            this.buttonSet.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSet.Location = new System.Drawing.Point(118, 167);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(168, 46);
            this.buttonSet.TabIndex = 2;
            this.buttonSet.Text = "Set";
            this.buttonSet.UseVisualStyleBackColor = true;
            this.buttonSet.Click += new System.EventHandler(this.buttonSet_Click);
            // 
            // FormDop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 244);
            this.Controls.Add(this.buttonSet);
            this.Controls.Add(this.textBoxSize);
            this.Controls.Add(this.labelEnter);
            this.Name = "FormDop";
            this.Text = "FormDop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelEnter;
        private TextBox textBoxSize;
        private Button buttonSet;
    }
}