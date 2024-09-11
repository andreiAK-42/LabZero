using System.Data;

namespace LabZero.TasksWindows
{
    public partial class CardTask : Form
    {
        DataTable Table;

        public CardTask()
        {
            InitializeComponent();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            CreateBaseColumn();

            OpenFileDialog Dialog = new OpenFileDialog();

            Dialog.Filter = "База данных | *.json";
            Dialog.Multiselect = false;

            if (Dialog.ShowDialog() == DialogResult.OK && Dialog.FileName != "")
            {
                BaseData baseData = new BaseData().GetFromFile(Dialog.FileName);

                for (int counterI = 0; counterI <= baseData.Users.Length - 1; ++counterI)
                {
                    dataRedactor.Rows.Insert(counterI, baseData.Users[counterI].LastName, baseData.Users[counterI].City, baseData.Users[counterI].Age);
                }
            }
        }

        private void createFileButton_Click(object sender, EventArgs e)
        {
            CreateBaseColumn();

            Table = null;
        }

        private void saveFileButton_Click(object sender, EventArgs e)
        {
            List<User> users = new List<User>();

            for (int counterRow = 0; counterRow <= dataRedactor.Rows.Count - 1; ++counterRow)
            {
                if (dataRedactor.Rows[counterRow].Cells[2].Value == null)
                {
                    continue;
                }

                bool ageCorrect = Int32.TryParse(dataRedactor.Rows[counterRow].Cells[2].Value.ToString(), out int number);

                if (dataRedactor.Rows[counterRow].Cells[0].Value == null || dataRedactor.Rows[counterRow].Cells[1].Value == null || !ageCorrect)
                {
                    continue;
                }

                users.Add(new User(dataRedactor.Rows[counterRow].Cells[0].Value.ToString(), dataRedactor.Rows[counterRow].Cells[1].Value.ToString(), number));
            }

            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "json files (*.json)|*.json";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    myStream.Close();
                    BaseData.SaveData(new BaseData(users), saveFileDialog1.FileName);
                }
            }
        }

        public void CreateBaseColumn()
        {
            TryClearList();
            dataRedactor.Columns.Add("LastName", "Фамилия");
            dataRedactor.Columns.Add("City", "Город");
            dataRedactor.Columns.Add("Age", "Возраст");
        }

        public void GetTable()
        {
            Table = new DataTable();

            Table.Columns.Add("Фамилия");
            Table.Columns.Add("Город");
            Table.Columns.Add("Возраст");

            for (int counterRow = 0; counterRow <= dataRedactor.Rows.Count - 1; ++counterRow)
            {
                Table.Rows.Add(dataRedactor.Rows[counterRow].Cells[0].Value, dataRedactor.Rows[counterRow].Cells[1].Value, dataRedactor.Rows[counterRow].Cells[2].Value);
            }
        }

        public void TryClearList()
        {
            try
            {
                dataRedactor.Columns.Clear();
                dataRedactor.Rows.Clear();
            }
            catch
            {

            }
        }

        public void GetMediumAge(DataTable table)
        {
            double medium = 0;
            int counter = 0;

            if (table.Rows.Count >= 1)
            {

                for (int counterRow = 0; counterRow <= table.Rows.Count - 1; ++counterRow)
                {
                    if (table.Rows[counterRow].ItemArray[2].ToString() == null)
                    {
                        continue;
                    }

                    bool ageCorrect = Int32.TryParse(table.Rows[counterRow].ItemArray[2].ToString(), out int number);

                    if (ageCorrect)
                    {
                        medium += number;
                        ++counter;
                    }
                }
            }
            MessageBox.Show($"Средний возраст: {(medium / counter == 0 ? "Не удалось определить" : medium / counter)}", "Средний возраст", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            if (Table == null)
            {
                GetTable();
            }

            if (sortTextBox.Text == null || sortTextBox.Text == "")
            {
                dataRedactor.DataSource = Table;
            }
            else
            {
                TryClearList();

                DataView dataView = new DataView(Table);
                dataView.RowFilter = $"Город = '{sortTextBox.Text}'";
                var dvTable = dataView.ToTable();

                GetMediumAge(dvTable);

                dataRedactor.DataSource = dvTable;
            }
        }
    }
}
