namespace LabZero.TasksWindows
{
    partial class CardTask
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
            components = new System.ComponentModel.Container();
            dataRedactor = new DataGridView();
            файлToolStripMenuItem = new ToolStripMenuItem();
            saveFileButton = new ToolStripMenuItem();
            openFileButton = new ToolStripMenuItem();
            createFileButton = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            sortButton = new Button();
            sortTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataRedactor).BeginInit();
            SuspendLayout();
            // 
            // dataRedactor
            // 
            dataRedactor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataRedactor.Location = new Point(0, 0);
            dataRedactor.Name = "dataRedactor";
            dataRedactor.RowTemplate.Height = 25;
            dataRedactor.Size = new Size(687, 421);
            dataRedactor.TabIndex = 0;
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveFileButton, openFileButton, createFileButton });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // saveFileButton
            // 
            saveFileButton.Name = "saveFileButton";
            saveFileButton.Size = new Size(133, 22);
            saveFileButton.Text = "Сохранить";
            saveFileButton.Click += saveFileButton_Click;
            // 
            // openFileButton
            // 
            openFileButton.Name = "openFileButton";
            openFileButton.Size = new Size(133, 22);
            openFileButton.Text = "Открыть";
            openFileButton.Click += openFileButton_Click;
            // 
            // createFileButton
            // 
            createFileButton.Name = "createFileButton";
            createFileButton.Size = new Size(133, 22);
            createFileButton.Text = "Создать";
            createFileButton.Click += createFileButton_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // sortButton
            // 
            sortButton.Location = new Point(693, 52);
            sortButton.Name = "sortButton";
            sortButton.Size = new Size(85, 22);
            sortButton.TabIndex = 1;
            sortButton.Text = "Сортировка";
            sortButton.UseVisualStyleBackColor = true;
            sortButton.Click += sortButton_Click;
            // 
            // sortTextBox
            // 
            sortTextBox.Location = new Point(693, 23);
            sortTextBox.Name = "sortTextBox";
            sortTextBox.Size = new Size(85, 23);
            sortTextBox.TabIndex = 2;
            // 
            // CardTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 422);
            Controls.Add(sortTextBox);
            Controls.Add(sortButton);
            Controls.Add(dataRedactor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CardTask";
            Text = "CardTask";
            ((System.ComponentModel.ISupportInitialize)dataRedactor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        public void AddButtons()
        {
            FormManager.Instance.MainForm.menu.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
        }

        public void ClearButtons()
        {
            FormManager.Instance.MainForm.menu.Items.Remove(файлToolStripMenuItem);
        }

        #endregion

        private DataGridView dataRedactor;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem openFileButton;
        private ToolStripMenuItem saveFileButton;
        private ToolStripMenuItem createFileButton;
        private ContextMenuStrip contextMenuStrip1;
        private Button sortButton;
        private TextBox sortTextBox;
    }
}