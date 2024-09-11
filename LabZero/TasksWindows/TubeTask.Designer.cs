using System.Windows.Forms;

namespace LabZero.TasksWindows
{
    partial class TubeTaskForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            buttonCalculate = new Button();
            textLenghtTube = new TextBox();
            textExternalRadiusTube = new TextBox();
            textInternalRadiusTube = new TextBox();
            textDensityTube = new TextBox();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            label10 = new Label();
            resultVTextBox = new TextBox();
            resultMTextBox = new TextBox();
            lenghtTubeUnit = new ComboBox();
            densityTubeUnit = new ListBox();
            InternalTubeUnit = new ComboBox();
            externalRadiusTubeUnit = new ComboBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(1, 217, 246);
            label1.Location = new Point(4, 1);
            label1.Name = "label1";
            label1.Size = new Size(160, 26);
            label1.TabIndex = 0;
            label1.Text = "Длина трубы";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(1, 217, 246);
            label2.Location = new Point(4, 122);
            label2.Name = "label2";
            label2.Size = new Size(236, 26);
            label2.TabIndex = 1;
            label2.Text = "Внутренний радиус";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(1, 217, 246);
            label3.Location = new Point(4, 61);
            label3.Name = "label3";
            label3.Size = new Size(203, 26);
            label3.TabIndex = 2;
            label3.Text = "Внешний радиус";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(1, 217, 246);
            label4.Location = new Point(4, 190);
            label4.Name = "label4";
            label4.Size = new Size(258, 26);
            label4.TabIndex = 3;
            label4.Text = "Плотность материала";
            // 
            // buttonCalculate
            // 
            buttonCalculate.FlatAppearance.BorderColor = Color.FromArgb(1, 217, 246);
            buttonCalculate.FlatStyle = FlatStyle.Popup;
            buttonCalculate.ForeColor = Color.FromArgb(1, 217, 246);
            buttonCalculate.Location = new Point(490, 358);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(259, 40);
            buttonCalculate.TabIndex = 4;
            buttonCalculate.Text = "Вычислить";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // textLenghtTube
            // 
            textLenghtTube.BackColor = Color.FromArgb(63, 18, 88);
            textLenghtTube.BorderStyle = BorderStyle.FixedSingle;
            textLenghtTube.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textLenghtTube.ForeColor = Color.FromArgb(1, 217, 246);
            textLenghtTube.Location = new Point(277, 4);
            textLenghtTube.Name = "textLenghtTube";
            textLenghtTube.Size = new Size(117, 27);
            textLenghtTube.TabIndex = 5;
            // 
            // textExternalRadiusTube
            // 
            textExternalRadiusTube.BackColor = Color.FromArgb(63, 18, 88);
            textExternalRadiusTube.BorderStyle = BorderStyle.FixedSingle;
            textExternalRadiusTube.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textExternalRadiusTube.ForeColor = Color.FromArgb(1, 217, 246);
            textExternalRadiusTube.Location = new Point(277, 64);
            textExternalRadiusTube.Name = "textExternalRadiusTube";
            textExternalRadiusTube.Size = new Size(117, 27);
            textExternalRadiusTube.TabIndex = 6;
            // 
            // textInternalRadiusTube
            // 
            textInternalRadiusTube.BackColor = Color.FromArgb(63, 18, 88);
            textInternalRadiusTube.BorderStyle = BorderStyle.FixedSingle;
            textInternalRadiusTube.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textInternalRadiusTube.ForeColor = Color.FromArgb(1, 217, 246);
            textInternalRadiusTube.Location = new Point(277, 125);
            textInternalRadiusTube.Name = "textInternalRadiusTube";
            textInternalRadiusTube.Size = new Size(117, 27);
            textInternalRadiusTube.TabIndex = 7;
            // 
            // textDensityTube
            // 
            textDensityTube.BackColor = Color.FromArgb(63, 18, 88);
            textDensityTube.BorderStyle = BorderStyle.FixedSingle;
            textDensityTube.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textDensityTube.ForeColor = Color.FromArgb(1, 217, 246);
            textDensityTube.Location = new Point(277, 193);
            textDensityTube.Name = "textDensityTube";
            textDensityTube.Size = new Size(117, 27);
            textDensityTube.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(585, 211);
            label8.Name = "label8";
            label8.Size = new Size(0, 26);
            label8.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.vecteezy_metallic_pipes_clipart_design_illustration_9383410;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 398);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(1, 217, 246);
            label9.Location = new Point(212, 304);
            label9.Name = "label9";
            label9.Size = new Size(116, 38);
            label9.TabIndex = 14;
            label9.Text = "Масса";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(1, 217, 246);
            label10.Location = new Point(212, 259);
            label10.Name = "label10";
            label10.Size = new Size(124, 38);
            label10.TabIndex = 15;
            label10.Text = "Объём";
            // 
            // resultVTextBox
            // 
            resultVTextBox.BackColor = Color.FromArgb(63, 18, 88);
            resultVTextBox.BorderStyle = BorderStyle.None;
            resultVTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            resultVTextBox.ForeColor = Color.FromArgb(1, 217, 246);
            resultVTextBox.Location = new Point(342, 270);
            resultVTextBox.Name = "resultVTextBox";
            resultVTextBox.ReadOnly = true;
            resultVTextBox.Size = new Size(407, 22);
            resultVTextBox.TabIndex = 22;
            // 
            // resultMTextBox
            // 
            resultMTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            resultMTextBox.BackColor = Color.FromArgb(63, 18, 88);
            resultMTextBox.BorderStyle = BorderStyle.None;
            resultMTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            resultMTextBox.ForeColor = Color.FromArgb(1, 217, 246);
            resultMTextBox.Location = new Point(342, 317);
            resultMTextBox.Name = "resultMTextBox";
            resultMTextBox.ReadOnly = true;
            resultMTextBox.Size = new Size(431, 22);
            resultMTextBox.TabIndex = 23;
            // 
            // lenghtTubeUnit
            // 
            lenghtTubeUnit.BackColor = Color.FromArgb(63, 18, 88);
            lenghtTubeUnit.FlatStyle = FlatStyle.Flat;
            lenghtTubeUnit.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lenghtTubeUnit.ForeColor = Color.FromArgb(1, 217, 246);
            lenghtTubeUnit.FormattingEnabled = true;
            lenghtTubeUnit.Items.AddRange(new object[] { "Мм.", "См.", "Метр.", "Километр." });
            lenghtTubeUnit.Location = new Point(401, 4);
            lenghtTubeUnit.Name = "lenghtTubeUnit";
            lenghtTubeUnit.Size = new Size(99, 26);
            lenghtTubeUnit.TabIndex = 24;
            lenghtTubeUnit.Text = "Метр.";
            // 
            // densityTubeUnit
            // 
            densityTubeUnit.BackColor = Color.FromArgb(63, 18, 88);
            densityTubeUnit.BorderStyle = BorderStyle.None;
            densityTubeUnit.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            densityTubeUnit.ForeColor = Color.FromArgb(1, 217, 246);
            densityTubeUnit.FormattingEnabled = true;
            densityTubeUnit.ItemHeight = 25;
            densityTubeUnit.Items.AddRange(new object[] { "Кг./М³" });
            densityTubeUnit.Location = new Point(401, 193);
            densityTubeUnit.Name = "densityTubeUnit";
            densityTubeUnit.Size = new Size(94, 25);
            densityTubeUnit.TabIndex = 19;
            // 
            // InternalTubeUnit
            // 
            InternalTubeUnit.BackColor = Color.FromArgb(63, 18, 88);
            InternalTubeUnit.FlatStyle = FlatStyle.Flat;
            InternalTubeUnit.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            InternalTubeUnit.ForeColor = Color.FromArgb(1, 217, 246);
            InternalTubeUnit.FormattingEnabled = true;
            InternalTubeUnit.Items.AddRange(new object[] { "Мм.", "См.", "Метр.", "Километр." });
            InternalTubeUnit.Location = new Point(401, 64);
            InternalTubeUnit.Name = "InternalTubeUnit";
            InternalTubeUnit.Size = new Size(99, 26);
            InternalTubeUnit.TabIndex = 25;
            InternalTubeUnit.Text = "Метр.";
            // 
            // externalRadiusTubeUnit
            // 
            externalRadiusTubeUnit.BackColor = Color.FromArgb(63, 18, 88);
            externalRadiusTubeUnit.FlatStyle = FlatStyle.Flat;
            externalRadiusTubeUnit.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            externalRadiusTubeUnit.ForeColor = Color.FromArgb(1, 217, 246);
            externalRadiusTubeUnit.FormattingEnabled = true;
            externalRadiusTubeUnit.Items.AddRange(new object[] { "Мм.", "См.", "Метр.", "Километр." });
            externalRadiusTubeUnit.Location = new Point(401, 125);
            externalRadiusTubeUnit.Name = "externalRadiusTubeUnit";
            externalRadiusTubeUnit.Size = new Size(99, 26);
            externalRadiusTubeUnit.TabIndex = 26;
            externalRadiusTubeUnit.Text = "Метр.";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.69806F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.301939F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 171F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(externalRadiusTubeUnit, 2, 2);
            tableLayoutPanel1.Controls.Add(InternalTubeUnit, 2, 1);
            tableLayoutPanel1.Controls.Add(densityTubeUnit, 2, 3);
            tableLayoutPanel1.Controls.Add(lenghtTubeUnit, 2, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(textExternalRadiusTube, 1, 1);
            tableLayoutPanel1.Controls.Add(textDensityTube, 1, 3);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(textLenghtTube, 1, 0);
            tableLayoutPanel1.Controls.Add(textInternalRadiusTube, 1, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel1.Location = new Point(212, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.3055573F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.6944427F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 67F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.Size = new Size(571, 252);
            tableLayoutPanel1.TabIndex = 27;
            // 
            // TubeTaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(63, 18, 88);
            ClientSize = new Size(785, 422);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(resultMTextBox);
            Controls.Add(resultVTextBox);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(buttonCalculate);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TubeTaskForm";
            Text = "TubeTask";
            Load += TubeTaskForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonCalculate;
        private TextBox textLenghtTube;
        private TextBox textExternalRadiusTube;
        private TextBox textInternalRadiusTube;
        private TextBox textDensityTube;
        private Label label8;
        private PictureBox pictureBox1;
        private Label label9;
        private Label label10;
        private TextBox resultVTextBox;
        private TextBox resultMTextBox;
        private ComboBox lenghtTubeUnit;
        private ListBox densityTubeUnit;
        private ComboBox InternalTubeUnit;
        private ComboBox externalRadiusTubeUnit;
        private TableLayoutPanel tableLayoutPanel1;
    }
}