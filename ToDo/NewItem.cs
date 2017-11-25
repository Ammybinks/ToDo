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
    public partial class NewItem : Form
    {
        public string name;
        public string description;

        public NewItem()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(nameText.Text))
            {
                name = nameText.Text;
                description = descriptionText.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                Error dialog = new Error();

                dialog.errorText = "A new task cannot be created with a blank name!";

                dialog.ShowDialog();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
