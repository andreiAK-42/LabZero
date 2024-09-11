using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabZero.TasksWindows
{
    public partial class TubeTaskForm : Form
    {
        public TubeTaskForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double lenghtTube, internalRadius, externalRadius, density;
            try
            {
                lenghtTube = TubeCalculationMethods.GetMetr(Convert.ToDouble(textLenghtTube.Text), TubeCalculationMethods.StringLenghtUnits[lenghtTubeUnit.SelectedItem.ToString()]);
                internalRadius = TubeCalculationMethods.GetMetr(Convert.ToDouble(textInternalRadiusTube.Text), TubeCalculationMethods.StringLenghtUnits[InternalTubeUnit.SelectedItem.ToString()]);
                externalRadius = TubeCalculationMethods.GetMetr(Convert.ToDouble(textExternalRadiusTube.Text), TubeCalculationMethods.StringLenghtUnits[externalRadiusTubeUnit.SelectedItem.ToString()]);
                density = Convert.ToDouble(textDensityTube.Text);

                var result = TubeCalculationMethods.GetTube(lenghtTube, internalRadius, externalRadius, density);

                resultVTextBox.Text = Math.Round(result.Item1, 3).ToString() + " М³";
                resultMTextBox.Text = Math.Round(result.Item2, 3).ToString() + " Кг.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TubeTaskForm_Load(object sender, EventArgs e)
        {

        }
    }
}
