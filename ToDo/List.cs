using System;
using Microsoft.Win32;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ToDo
{
    public partial class List : Form
    {
        List<Item> items = new List<Item>();
        int previousIndex = -1;
        int subPreviousIndex = -1;
        
        public List()
        {
            InitializeComponent();
            
            foreach (object item in listBox.Items)
            {
                items.Add(new Item(listBox.GetItemText(item)));
            }

            RegistryKey rk = Registry.CurrentUser.OpenSubKey
            ("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            rk.SetValue("Kimodo", Application.ExecutablePath.ToString());
            //rk.DeleteValue(this.Name, false);
        }

        private void List_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                minimizeIcon.Visible = true;
            }
        }



        private void listBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if(e.Index !=  -1)
            {
                Font f = e.Font;

                if (items[e.Index].cleared)
                {
                    f = new Font(f, FontStyle.Strikeout);
                }
            e.DrawBackground();
            e.Graphics.DrawString(((ListBox)(sender)).Items[e.Index].ToString(), f, new SolidBrush(e.ForeColor), e.Bounds);
            e.DrawFocusRectangle();
            }
        }

        private void subListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            Font f = e.Font;

            if(listBox.SelectedIndex > -1)
            {
                if (items[listBox.SelectedIndex].items.Count > e.Index)
                {
                    if (items[listBox.SelectedIndex].items[e.Index].cleared)
                    {
                        f = new Font(f, FontStyle.Strikeout);
                    }
                }
            }

            e.DrawBackground();
            e.Graphics.DrawString(((ListBox)(sender)).Items[e.Index].ToString(), f, new SolidBrush(e.ForeColor), e.Bounds);
            e.DrawFocusRectangle();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(previousIndex > -1 && items.Count - 1 > previousIndex)
            {
                items[previousIndex].description = descriptionText.Text;

                if (subPreviousIndex > -1 && items[previousIndex].items.Count - 1 > subPreviousIndex)
                {
                    items[previousIndex].items[subPreviousIndex].description = subDescriptionText.Text;
                }
            }

            if (listBox.SelectedIndex != -1)
            {
                if (previousIndex == listBox.SelectedIndex)
                {
                    items[listBox.SelectedIndex].cleared = !items[listBox.SelectedIndex].cleared;
                }
                else
                {
                    subListBox.Items.Clear();
                    foreach (Item item in items[listBox.SelectedIndex].items)
                    {
                        subListBox.Items.Add(item.name);
                    }
                }

                descriptionText.Text = items[listBox.SelectedIndex].description;

                subDescriptionText.Text = "";
            }

            listBox.Refresh();

            subPreviousIndex = -1;

            previousIndex = listBox.SelectedIndex;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            using (NewItem dialog = new NewItem())
            {
                switch (dialog.ShowDialog())
                {
                    case DialogResult.OK:
                        {
                            items.Add(new Item(dialog.name, dialog.description));
                            listBox.Items.Add(dialog.name);

                            listBox.SelectedIndex = listBox.Items.Count - 1;
                        }
                        break;
                }
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if(listBox.SelectedIndex != -1)
            {
                int i = listBox.SelectedIndex;

                items.RemoveAt(i);
                listBox.Items.RemoveAt(i);

                listBox.Refresh();
                subListBox.Items.Clear();

                descriptionText.Text = "";

                if (i >= listBox.Items.Count)
                {
                    listBox.SelectedIndex = i - 1;
                }
                else
                {
                    listBox.SelectedIndex = i;
                }
            }
        }

        private void moveUpButton_Click(object sender, EventArgs e)
        {
            if(listBox.SelectedIndex > 0)
            {
                int i = listBox.SelectedIndex;
                Item item = items[i];

                items.RemoveAt(i);

                listBox.Items.RemoveAt(i);

                items.Insert(i - 1, item);

                listBox.Items.Insert(i - 1, item.name);
                
                listBox.SelectedIndex = i - 1;

                listBox.Refresh();
            }
        }

        private void moveDownButton_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex < listBox.Items.Count - 1)
            {
                int i = listBox.SelectedIndex;
                Item item = items[i];

                items.RemoveAt(i);

                listBox.Items.RemoveAt(i);

                items.Insert(i + 1, item);

                listBox.Items.Insert(i + 1, item.name);

                listBox.SelectedIndex = i + 1;

                listBox.Refresh();
            }
        }



        private void subListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(subPreviousIndex > -1 && items[listBox.SelectedIndex].items.Count - 1 > subPreviousIndex)
            {
                items[listBox.SelectedIndex].items[subPreviousIndex].description = subDescriptionText.Text;
            }

            if (subListBox.SelectedIndex != -1)
            {
                if (subPreviousIndex == subListBox.SelectedIndex)
                {
                    items[listBox.SelectedIndex].items[subListBox.SelectedIndex].cleared = !items[listBox.SelectedIndex].items[subListBox.SelectedIndex].cleared;
                }

                subDescriptionText.Text = items[listBox.SelectedIndex].items[subListBox.SelectedIndex].description;
            }

            subListBox.Refresh();

            subPreviousIndex = subListBox.SelectedIndex;
        }

        private void subAddButton_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {
                using (NewItem dialog = new NewItem())
                {
                    switch (dialog.ShowDialog())
                    {
                        case DialogResult.OK:
                            {
                                items[listBox.SelectedIndex].items.Add(new Item(dialog.name, dialog.description));
                                subListBox.Items.Add(dialog.name);

                                subListBox.SelectedIndex = subListBox.Items.Count - 1;
                            }
                            break;
                    }
                }
            }
            else
            {
                Error dialog = new Error();

                dialog.errorText = "You haven't selected a task to add a subtask to!";

                dialog.ShowDialog();
            }
        }

        private void subRemoveButton_Click(object sender, EventArgs e)
        {
            if (subListBox.SelectedIndex != -1)
            {
                int i = subListBox.SelectedIndex;

                items[listBox.SelectedIndex].items.RemoveAt(i);
                subListBox.Items.RemoveAt(i);

                subListBox.Refresh();

                subDescriptionText.Text = "";

                if (i >= subListBox.Items.Count)
                {
                    subListBox.SelectedIndex = i - 1;
                }
                else
                {
                    subListBox.SelectedIndex = i;
                }
            }
        }

        private void subMoveUpButton_Click(object sender, EventArgs e)
        {
            if (subListBox.SelectedIndex > 0)
            {
                int i = listBox.SelectedIndex;
                int o = subListBox.SelectedIndex;
                Item item = items[i].items[o];

                items[i].items.RemoveAt(o);
                subListBox.Items.RemoveAt(o);

                items[i].items.Insert(o - 1, item);
                subListBox.Items.Insert(o - 1, item.name);

                subListBox.SelectedIndex = o - 1;

                subListBox.Refresh();
            }
        }

        private void subMoveDownButton_Click(object sender, EventArgs e)
        {
            if (subListBox.SelectedIndex < subListBox.Items.Count - 1)
            {
                int i = listBox.SelectedIndex;
                int o = subListBox.SelectedIndex;
                Item item = items[i].items[o];

                items[i].items.RemoveAt(o);
                subListBox.Items.RemoveAt(o);

                items[i].items.Insert(o + 1, item);
                subListBox.Items.Insert(o + 1, item.name);

                subListBox.SelectedIndex = o + 1;

                subListBox.Refresh();
            }
        }



        private void saveButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(pathText.Text + "\\List.txt"))
            {
                for(int i = 0; i < items.Count; i++)
                {
                    writer.WriteLine(FormString(items[i]));
                    writer.WriteLine(items[i].description);

                    for(int o = 0; o < items[i].items.Count; o++)
                    {
                        writer.WriteLine(FormString(items[i].items[o]));
                        writer.WriteLine(items[i].items[o].description);
                    }

                    writer.WriteLine("\\");
                }
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            items.Clear();
            listBox.Items.Clear();
            subListBox.Items.Clear();

            using (StreamReader reader = new StreamReader(pathText.Text + "\\List.txt"))
            {
                int i = 0;
                int o = 0;

                string line = reader.ReadLine();

                while(line != null)
                {
                    if(line == "\\")
                    {
                        i++;
                        o = 0;
                    }
                    else if(items.Count <= i)
                    {
                        items.Add(new ToDo.Item(line.Remove(line.Count() - 4, 4), GetBool(line)));
                    }
                    else if (items[i].description == null)
                    {
                        items[i].description = line;
                    }
                    else if (items[i].items.Count <= o)
                    {
                        items[i].items.Add(new Item(line.Remove(line.Count() - 4, 4), GetBool(line)));
                    }
                    else if (items[i].items[o].description == null)
                    {
                        items[i].items[o].description = line;

                        o++;
                    }

                    line = reader.ReadLine();
                }

                foreach (Item item in items)
                {
                    listBox.Items.Add(item.name);
                }

                if(listBox.SelectedIndex > -1)
                {
                    foreach (Item item in items[listBox.SelectedIndex].items)
                    {
                        subListBox.Items.Add(item.name);
                    }
                }
            }
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.SelectedPath = pathText.Text;
            DialogResult result = dialog.ShowDialog();

            if(result == DialogResult.OK)
            {
                pathText.Text = dialog.SelectedPath;
            }
        }



        private void minimizeIcon_MouseClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            Activate();

            minimizeIcon.Visible = false;
        }



        private string FormString(Item i)
        {
            string s = i.name + " \\ " + (i.cleared ? 1 : 0);

            return s;
        }

        private bool GetBool(string l)
        {
            bool result;

            l = l.Substring(l.Length - 1);

            if (l == "1")
            {
                result = true;
            }
            else if (l == "0")
            {
                result = false;
            }
            else
            {
                result = false;
            }

            return result;
        }
    }
}
