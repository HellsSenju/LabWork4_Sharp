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
    public partial class FormDop : Form
    {
        public int _size;
        NewForm newForm;
        public FormDop()
        {
            InitializeComponent();
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            try
            {
                _size = int.Parse(textBoxSize.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Visible = false;
            newForm = new NewForm(_size);
            newForm.ShowDialog();           
        }
    }
}
