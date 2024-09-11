namespace LabZero
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelPresenter = new Panel();
            menu = new MenuStrip();
            трубаToolStripMenuItem1 = new ToolStripMenuItem();
            картотекаToolStripMenuItem1 = new ToolStripMenuItem();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // panelPresenter
            // 
            panelPresenter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelPresenter.BackColor = SystemColors.ControlDark;
            panelPresenter.Location = new Point(0, 27);
            panelPresenter.Name = "panelPresenter";
            panelPresenter.Size = new Size(785, 425);
            panelPresenter.TabIndex = 0;
            // 
            // menu
            // 
            menu.Items.AddRange(new ToolStripItem[] { трубаToolStripMenuItem1, картотекаToolStripMenuItem1 });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(784, 24);
            menu.TabIndex = 1;
            // 
            // трубаToolStripMenuItem1
            // 
            трубаToolStripMenuItem1.Name = "трубаToolStripMenuItem1";
            трубаToolStripMenuItem1.Size = new Size(51, 20);
            трубаToolStripMenuItem1.Text = "Труба";
            трубаToolStripMenuItem1.Click += трубаToolStripMenuItem1_Click;
            // 
            // картотекаToolStripMenuItem1
            // 
            картотекаToolStripMenuItem1.Name = "картотекаToolStripMenuItem1";
            картотекаToolStripMenuItem1.Size = new Size(74, 20);
            картотекаToolStripMenuItem1.Text = "Картотека";
            картотекаToolStripMenuItem1.Click += картотекаToolStripMenuItem1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 450);
            Controls.Add(panelPresenter);
            Controls.Add(menu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menu;
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Panel panelPresenter;
        public MenuStrip menu;
        public ToolStripMenuItem трубаToolStripMenuItem1;
        public ToolStripMenuItem картотекаToolStripMenuItem1;
    }
}
