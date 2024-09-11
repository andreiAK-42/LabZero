namespace LabZero
{
    public class FormManager
    {
        private FormManager() { }
        public MainForm MainForm { get; set; }

        private static FormManager instance;

        public object CurrentForm { get; set; }
        public static FormManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FormManager();
                    instance.MainForm = new MainForm();
                }
                return instance;
            }
        }

      /*  public void OpenNewWindow(object Sender, object Target)
        {
            if (CurrentForm != Target)
            {
                ((Form)Sender).Dispose();

                var TargetForm = (Form)Target;
                TargetForm.TopLevel = false;
                TargetForm.AutoScroll = true;

                MainForm.panelPresenter.Controls.Add(TargetForm);
                TargetForm.Show();

                CurrentForm = Target;
            }
        }*/

        public void OpenNewWindowFromMain(object Target)
        {
            if (CurrentForm == null || CurrentForm.GetType() != Target.GetType())
            {
                if (CurrentForm != null)
                {
                    ((Form)CurrentForm).Dispose();
                }

                var TargetForm = (Form)Target;
                TargetForm.TopLevel = false;
                TargetForm.AutoScroll = true;

                MainForm.panelPresenter.Controls.Add(TargetForm);
                TargetForm.Show();

                CurrentForm = Target;
            }
            else
            {
                ((Form)Target).Dispose();
            }
        }
    }
}
