using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo
{
    public partial class ChoiceDialog : Form
    {
        public string text;
        
        public ChoiceDialog()
        {
            InitializeComponent();
        }

        private void ChoiceDialog_Load(object sender, EventArgs e)
        {
            textLabel.Text = text;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
