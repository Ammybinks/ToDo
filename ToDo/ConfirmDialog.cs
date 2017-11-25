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
    public partial class Error : Form
    {
        public string errorText;

        public Error()
        {
            InitializeComponent();
        }

        private void Error_Load(object sender, EventArgs e)
        {
            errorLabel.Text = errorText;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
