using LabZero.TasksWindows;

namespace LabZero
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void òğóáàToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ((CardTask)FormManager.Instance.CurrentForm).ClearButtons();
            FormManager.Instance.OpenNewWindowFromMain(new TubeTaskForm());
            FormManager.Instance.MainForm.menu.Items.Remove(FormManager.Instance.MainForm.òğóáàToolStripMenuItem1);

            if (!FormManager.Instance.MainForm.menu.Items.Contains(FormManager.Instance.MainForm.êàğòîòåêàToolStripMenuItem1))
            {
                FormManager.Instance.MainForm.menu.Items.Add(FormManager.Instance.MainForm.êàğòîòåêàToolStripMenuItem1);
            }
        }

        private void êàğòîòåêàToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormManager.Instance.OpenNewWindowFromMain(new CardTask());

            if (!FormManager.Instance.MainForm.menu.Items.Contains(FormManager.Instance.MainForm.òğóáàToolStripMenuItem1))
            {
                FormManager.Instance.MainForm.menu.Items.Add(FormManager.Instance.MainForm.òğóáàToolStripMenuItem1);
            }

            if (FormManager.Instance.MainForm.menu.Items.Contains(FormManager.Instance.MainForm.êàğòîòåêàToolStripMenuItem1))
            {
                FormManager.Instance.MainForm.menu.Items.Remove(FormManager.Instance.MainForm.êàğòîòåêàToolStripMenuItem1);
            }
            ((CardTask)FormManager.Instance.CurrentForm).AddButtons();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FormManager.Instance.OpenNewWindowFromMain(new TubeTaskForm());
        }
    }
}
