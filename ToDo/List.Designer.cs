namespace ToDo
{
    partial class List
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(List));
            this.listBox = new System.Windows.Forms.ListBox();
            this.subListBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.subAddButton = new System.Windows.Forms.Button();
            this.descriptionText = new System.Windows.Forms.TextBox();
            this.subDescriptionText = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.pathText = new System.Windows.Forms.TextBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.subRemoveButton = new System.Windows.Forms.Button();
            this.moveUpButton = new System.Windows.Forms.Button();
            this.moveDownButton = new System.Windows.Forms.Button();
            this.subMoveUpButton = new System.Windows.Forms.Button();
            this.subMoveDownButton = new System.Windows.Forms.Button();
            this.minimizeIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 29);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(259, 108);
            this.listBox.TabIndex = 0;
            this.listBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox_DrawItem);
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // subListBox
            // 
            this.subListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.subListBox.FormattingEnabled = true;
            this.subListBox.Location = new System.Drawing.Point(12, 156);
            this.subListBox.Name = "subListBox";
            this.subListBox.Size = new System.Drawing.Size(259, 108);
            this.subListBox.TabIndex = 1;
            this.subListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.subListBox_DrawItem);
            this.subListBox.SelectedIndexChanged += new System.EventHandler(this.subListBox_SelectedIndexChanged);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(277, 29);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(34, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // subAddButton
            // 
            this.subAddButton.Location = new System.Drawing.Point(277, 156);
            this.subAddButton.Name = "subAddButton";
            this.subAddButton.Size = new System.Drawing.Size(34, 23);
            this.subAddButton.TabIndex = 3;
            this.subAddButton.Text = "+";
            this.subAddButton.UseVisualStyleBackColor = true;
            this.subAddButton.Click += new System.EventHandler(this.subAddButton_Click);
            // 
            // descriptionText
            // 
            this.descriptionText.Location = new System.Drawing.Point(317, 31);
            this.descriptionText.Multiline = true;
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(260, 106);
            this.descriptionText.TabIndex = 4;
            // 
            // subDescriptionText
            // 
            this.subDescriptionText.Location = new System.Drawing.Point(317, 158);
            this.subDescriptionText.Multiline = true;
            this.subDescriptionText.Name = "subDescriptionText";
            this.subDescriptionText.Size = new System.Drawing.Size(260, 106);
            this.subDescriptionText.TabIndex = 5;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(535, 296);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(42, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(451, 296);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(29, 23);
            this.browseButton.TabIndex = 7;
            this.browseButton.Text = "...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // pathText
            // 
            this.pathText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pathText.Location = new System.Drawing.Point(12, 270);
            this.pathText.Name = "pathText";
            this.pathText.Size = new System.Drawing.Size(565, 20);
            this.pathText.TabIndex = 8;
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(486, 296);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(43, 23);
            this.loadButton.TabIndex = 9;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tasks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Subtasks";
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(277, 58);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(34, 23);
            this.removeButton.TabIndex = 12;
            this.removeButton.Text = "-";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // subRemoveButton
            // 
            this.subRemoveButton.Location = new System.Drawing.Point(277, 185);
            this.subRemoveButton.Name = "subRemoveButton";
            this.subRemoveButton.Size = new System.Drawing.Size(34, 23);
            this.subRemoveButton.TabIndex = 13;
            this.subRemoveButton.Text = "-";
            this.subRemoveButton.UseVisualStyleBackColor = true;
            this.subRemoveButton.Click += new System.EventHandler(this.subRemoveButton_Click);
            // 
            // moveUpButton
            // 
            this.moveUpButton.Location = new System.Drawing.Point(277, 87);
            this.moveUpButton.Name = "moveUpButton";
            this.moveUpButton.Size = new System.Drawing.Size(34, 23);
            this.moveUpButton.TabIndex = 14;
            this.moveUpButton.Text = "˄";
            this.moveUpButton.UseVisualStyleBackColor = true;
            this.moveUpButton.Click += new System.EventHandler(this.moveUpButton_Click);
            // 
            // moveDownButton
            // 
            this.moveDownButton.Location = new System.Drawing.Point(277, 116);
            this.moveDownButton.Name = "moveDownButton";
            this.moveDownButton.Size = new System.Drawing.Size(34, 23);
            this.moveDownButton.TabIndex = 15;
            this.moveDownButton.Text = "˅";
            this.moveDownButton.UseVisualStyleBackColor = true;
            this.moveDownButton.Click += new System.EventHandler(this.moveDownButton_Click);
            // 
            // subMoveUpButton
            // 
            this.subMoveUpButton.Location = new System.Drawing.Point(277, 214);
            this.subMoveUpButton.Name = "subMoveUpButton";
            this.subMoveUpButton.Size = new System.Drawing.Size(34, 23);
            this.subMoveUpButton.TabIndex = 16;
            this.subMoveUpButton.Text = "˄";
            this.subMoveUpButton.UseVisualStyleBackColor = true;
            this.subMoveUpButton.Click += new System.EventHandler(this.subMoveUpButton_Click);
            // 
            // subMoveDownButton
            // 
            this.subMoveDownButton.Location = new System.Drawing.Point(277, 241);
            this.subMoveDownButton.Name = "subMoveDownButton";
            this.subMoveDownButton.Size = new System.Drawing.Size(34, 23);
            this.subMoveDownButton.TabIndex = 17;
            this.subMoveDownButton.Text = "˅";
            this.subMoveDownButton.UseVisualStyleBackColor = true;
            this.subMoveDownButton.Click += new System.EventHandler(this.subMoveDownButton_Click);
            // 
            // minimizeIcon
            // 
            this.minimizeIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("minimizeIcon.Icon")));
            this.minimizeIcon.Text = "Kimodo";
            this.minimizeIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.minimizeIcon_MouseClick);
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 335);
            this.Controls.Add(this.subMoveDownButton);
            this.Controls.Add(this.subMoveUpButton);
            this.Controls.Add(this.moveDownButton);
            this.Controls.Add(this.moveUpButton);
            this.Controls.Add(this.subRemoveButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.pathText);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.subDescriptionText);
            this.Controls.Add(this.descriptionText);
            this.Controls.Add(this.subAddButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.subListBox);
            this.Controls.Add(this.listBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "List";
            this.Text = "Kimodo";
            this.Resize += new System.EventHandler(this.List_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.ListBox subListBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button subAddButton;
        private System.Windows.Forms.TextBox descriptionText;
        private System.Windows.Forms.TextBox subDescriptionText;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox pathText;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button subRemoveButton;
        private System.Windows.Forms.Button moveUpButton;
        private System.Windows.Forms.Button moveDownButton;
        private System.Windows.Forms.Button subMoveUpButton;
        private System.Windows.Forms.Button subMoveDownButton;
        private System.Windows.Forms.NotifyIcon minimizeIcon;
    }
}

