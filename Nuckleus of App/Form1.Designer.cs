namespace Nuckleus_of_App
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.SelectedVolumeLabel = new System.Windows.Forms.Label();
            this.SelectedCleareanceLabel = new System.Windows.Forms.Label();
            this.FirstShotTimeLabel = new System.Windows.Forms.Label();
            this.SecondaryShotDurationsLabel = new System.Windows.Forms.Label();
            this.PrimaryConcentrationLabel = new System.Windows.Forms.Label();
            this.CTheraputicLabel = new System.Windows.Forms.Label();
            this.CToxLabel = new System.Windows.Forms.Label();
            this.LoadDoseLabel = new System.Windows.Forms.Label();
            this.SupportDoseLabel = new System.Windows.Forms.Label();
            this.BodyWeightLabel = new System.Windows.Forms.Label();
            this.DrugSelectorBox = new System.Windows.Forms.ComboBox();
            this.SelectedVolumeValue = new System.Windows.Forms.MaskedTextBox();
            this.PrimaryConcentrationValue = new System.Windows.Forms.MaskedTextBox();
            this.BodyWeightValue = new System.Windows.Forms.MaskedTextBox();
            this.SelectedCleareanceValue = new System.Windows.Forms.MaskedTextBox();
            this.CTheraputicValue = new System.Windows.Forms.MaskedTextBox();
            this.CToxValue = new System.Windows.Forms.MaskedTextBox();
            this.FirstShotTimeValue = new System.Windows.Forms.MaskedTextBox();
            this.LoadDoseValue = new System.Windows.Forms.MaskedTextBox();
            this.SecondaryShotDurationsValue = new System.Windows.Forms.MaskedTextBox();
            this.SupportDoseValue = new System.Windows.Forms.MaskedTextBox();
            this.ComputationTimeRangeValue = new System.Windows.Forms.MaskedTextBox();
            this.ComputationTimeRangeLabel = new System.Windows.Forms.Label();
            this.ComputeButton = new System.Windows.Forms.Button();
            this.NumberOfSecondaryInjectionsLabelValue = new System.Windows.Forms.MaskedTextBox();
            this.NumberOfSecondaryInjectionsLabel = new System.Windows.Forms.Label();
            this.graphTimer = new System.Windows.Forms.Timer(this.components);
            this.ConcentrationDataGrid = new System.Windows.Forms.DataGridView();
            this.ConcentrationChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ConcentrationDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConcentrationChart)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectedVolumeLabel
            // 
            this.SelectedVolumeLabel.Font = new System.Drawing.Font("Cambria Math", 8.25F);
            this.SelectedVolumeLabel.ForeColor = System.Drawing.Color.Black;
            this.SelectedVolumeLabel.Location = new System.Drawing.Point(29, 429);
            this.SelectedVolumeLabel.Name = "SelectedVolumeLabel";
            this.SelectedVolumeLabel.Size = new System.Drawing.Size(130, 46);
            this.SelectedVolumeLabel.TabIndex = 1;
            this.SelectedVolumeLabel.Text = "Удельный объём препарата (л/кг)";
            this.SelectedVolumeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SelectedVolumeLabel.UseCompatibleTextRendering = true;
            // 
            // SelectedCleareanceLabel
            // 
            this.SelectedCleareanceLabel.Font = new System.Drawing.Font("Cambria Math", 8.25F);
            this.SelectedCleareanceLabel.ForeColor = System.Drawing.Color.Black;
            this.SelectedCleareanceLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SelectedCleareanceLabel.Location = new System.Drawing.Point(29, 471);
            this.SelectedCleareanceLabel.Name = "SelectedCleareanceLabel";
            this.SelectedCleareanceLabel.Size = new System.Drawing.Size(143, 49);
            this.SelectedCleareanceLabel.TabIndex = 3;
            this.SelectedCleareanceLabel.Text = "Удельный клиренс препарата (л/кг/мин)";
            this.SelectedCleareanceLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SelectedCleareanceLabel.UseCompatibleTextRendering = true;
            // 
            // FirstShotTimeLabel
            // 
            this.FirstShotTimeLabel.Font = new System.Drawing.Font("Cambria Math", 8.25F);
            this.FirstShotTimeLabel.ForeColor = System.Drawing.Color.Black;
            this.FirstShotTimeLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FirstShotTimeLabel.Location = new System.Drawing.Point(525, 514);
            this.FirstShotTimeLabel.Name = "FirstShotTimeLabel";
            this.FirstShotTimeLabel.Size = new System.Drawing.Size(173, 32);
            this.FirstShotTimeLabel.TabIndex = 7;
            this.FirstShotTimeLabel.Text = "Длительность первого введения  (мин)";
            this.FirstShotTimeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.FirstShotTimeLabel.UseCompatibleTextRendering = true;
            // 
            // SecondaryShotDurationsLabel
            // 
            this.SecondaryShotDurationsLabel.Font = new System.Drawing.Font("Cambria Math", 8.25F);
            this.SecondaryShotDurationsLabel.ForeColor = System.Drawing.Color.Black;
            this.SecondaryShotDurationsLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SecondaryShotDurationsLabel.Location = new System.Drawing.Point(525, 560);
            this.SecondaryShotDurationsLabel.Name = "SecondaryShotDurationsLabel";
            this.SecondaryShotDurationsLabel.Size = new System.Drawing.Size(173, 63);
            this.SecondaryShotDurationsLabel.TabIndex = 9;
            this.SecondaryShotDurationsLabel.Text = "Длительность повторного введения (мин)";
            this.SecondaryShotDurationsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SecondaryShotDurationsLabel.UseCompatibleTextRendering = true;
            // 
            // PrimaryConcentrationLabel
            // 
            this.PrimaryConcentrationLabel.Font = new System.Drawing.Font("Cambria Math", 8.25F);
            this.PrimaryConcentrationLabel.ForeColor = System.Drawing.Color.Black;
            this.PrimaryConcentrationLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PrimaryConcentrationLabel.Location = new System.Drawing.Point(29, 527);
            this.PrimaryConcentrationLabel.Name = "PrimaryConcentrationLabel";
            this.PrimaryConcentrationLabel.Size = new System.Drawing.Size(143, 61);
            this.PrimaryConcentrationLabel.TabIndex = 12;
            this.PrimaryConcentrationLabel.Text = "Начальная концентрация препарата (мг/л)";
            this.PrimaryConcentrationLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PrimaryConcentrationLabel.UseCompatibleTextRendering = true;
            // 
            // CTheraputicLabel
            // 
            this.CTheraputicLabel.Font = new System.Drawing.Font("Cambria Math", 8.25F);
            this.CTheraputicLabel.ForeColor = System.Drawing.Color.Black;
            this.CTheraputicLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CTheraputicLabel.Location = new System.Drawing.Point(29, 601);
            this.CTheraputicLabel.Name = "CTheraputicLabel";
            this.CTheraputicLabel.Size = new System.Drawing.Size(143, 54);
            this.CTheraputicLabel.TabIndex = 14;
            this.CTheraputicLabel.Text = "Терапевтическая концентрация препарата (мг/л)";
            this.CTheraputicLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CTheraputicLabel.UseCompatibleTextRendering = true;
            // 
            // CToxLabel
            // 
            this.CToxLabel.Font = new System.Drawing.Font("Cambria Math", 8.25F);
            this.CToxLabel.ForeColor = System.Drawing.Color.Black;
            this.CToxLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CToxLabel.Location = new System.Drawing.Point(29, 666);
            this.CToxLabel.Name = "CToxLabel";
            this.CToxLabel.Size = new System.Drawing.Size(130, 55);
            this.CToxLabel.TabIndex = 16;
            this.CToxLabel.Text = "Токсическая концентрация препарата (мг/л)";
            this.CToxLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CToxLabel.UseCompatibleTextRendering = true;
            // 
            // LoadDoseLabel
            // 
            this.LoadDoseLabel.Font = new System.Drawing.Font("Cambria Math", 8.25F);
            this.LoadDoseLabel.ForeColor = System.Drawing.Color.Black;
            this.LoadDoseLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LoadDoseLabel.Location = new System.Drawing.Point(525, 623);
            this.LoadDoseLabel.Name = "LoadDoseLabel";
            this.LoadDoseLabel.Size = new System.Drawing.Size(173, 35);
            this.LoadDoseLabel.TabIndex = 18;
            this.LoadDoseLabel.Text = "Начальная доза (мг)";
            this.LoadDoseLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LoadDoseLabel.UseCompatibleTextRendering = true;
            // 
            // SupportDoseLabel
            // 
            this.SupportDoseLabel.Font = new System.Drawing.Font("Cambria Math", 8.25F);
            this.SupportDoseLabel.ForeColor = System.Drawing.Color.Black;
            this.SupportDoseLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SupportDoseLabel.Location = new System.Drawing.Point(525, 658);
            this.SupportDoseLabel.Name = "SupportDoseLabel";
            this.SupportDoseLabel.Size = new System.Drawing.Size(173, 38);
            this.SupportDoseLabel.TabIndex = 20;
            this.SupportDoseLabel.Text = "Поддерживающая доза (мг)";
            this.SupportDoseLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SupportDoseLabel.UseCompatibleTextRendering = true;
            // 
            // BodyWeightLabel
            // 
            this.BodyWeightLabel.Font = new System.Drawing.Font("Cambria Math", 8.25F);
            this.BodyWeightLabel.ForeColor = System.Drawing.Color.Black;
            this.BodyWeightLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BodyWeightLabel.Location = new System.Drawing.Point(298, 427);
            this.BodyWeightLabel.Name = "BodyWeightLabel";
            this.BodyWeightLabel.Size = new System.Drawing.Size(85, 48);
            this.BodyWeightLabel.TabIndex = 22;
            this.BodyWeightLabel.Text = "Масса пациента (кг)";
            this.BodyWeightLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BodyWeightLabel.UseCompatibleTextRendering = true;
            // 
            // DrugSelectorBox
            // 
            this.DrugSelectorBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrugSelectorBox.DropDownHeight = 200;
            this.DrugSelectorBox.DropDownWidth = 200;
            this.DrugSelectorBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DrugSelectorBox.FormattingEnabled = true;
            this.DrugSelectorBox.IntegralHeight = false;
            this.DrugSelectorBox.ItemHeight = 17;
            this.DrugSelectorBox.Items.AddRange(new object[] {
            "Фортазим",
            "Новый препарат"});
            this.DrugSelectorBox.Location = new System.Drawing.Point(29, 384);
            this.DrugSelectorBox.Name = "DrugSelectorBox";
            this.DrugSelectorBox.Size = new System.Drawing.Size(249, 25);
            this.DrugSelectorBox.TabIndex = 1;
            this.DrugSelectorBox.Text = "Выберите препарат";
            // 
            // SelectedVolumeValue
            // 
            this.SelectedVolumeValue.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedVolumeValue.Location = new System.Drawing.Point(178, 429);
            this.SelectedVolumeValue.Mask = "00.0000000000";
            this.SelectedVolumeValue.Name = "SelectedVolumeValue";
            this.SelectedVolumeValue.PromptChar = ' ';
            this.SelectedVolumeValue.Size = new System.Drawing.Size(100, 23);
            this.SelectedVolumeValue.TabIndex = 2;
            // 
            // PrimaryConcentrationValue
            // 
            this.PrimaryConcentrationValue.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.PrimaryConcentrationValue.Location = new System.Drawing.Point(178, 527);
            this.PrimaryConcentrationValue.Mask = "000.000";
            this.PrimaryConcentrationValue.Name = "PrimaryConcentrationValue";
            this.PrimaryConcentrationValue.PromptChar = ' ';
            this.PrimaryConcentrationValue.Size = new System.Drawing.Size(100, 23);
            this.PrimaryConcentrationValue.TabIndex = 8;
            // 
            // BodyWeightValue
            // 
            this.BodyWeightValue.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.BodyWeightValue.Location = new System.Drawing.Point(389, 427);
            this.BodyWeightValue.Mask = "000.00";
            this.BodyWeightValue.Name = "BodyWeightValue";
            this.BodyWeightValue.PromptChar = ' ';
            this.BodyWeightValue.Size = new System.Drawing.Size(100, 23);
            this.BodyWeightValue.TabIndex = 13;
            // 
            // SelectedCleareanceValue
            // 
            this.SelectedCleareanceValue.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.SelectedCleareanceValue.Location = new System.Drawing.Point(178, 471);
            this.SelectedCleareanceValue.Mask = "00.0000000000";
            this.SelectedCleareanceValue.Name = "SelectedCleareanceValue";
            this.SelectedCleareanceValue.PromptChar = ' ';
            this.SelectedCleareanceValue.Size = new System.Drawing.Size(100, 23);
            this.SelectedCleareanceValue.TabIndex = 3;
            // 
            // CTheraputicValue
            // 
            this.CTheraputicValue.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.CTheraputicValue.Location = new System.Drawing.Point(178, 600);
            this.CTheraputicValue.Mask = "000.000";
            this.CTheraputicValue.Name = "CTheraputicValue";
            this.CTheraputicValue.PromptChar = ' ';
            this.CTheraputicValue.Size = new System.Drawing.Size(100, 23);
            this.CTheraputicValue.TabIndex = 9;
            // 
            // CToxValue
            // 
            this.CToxValue.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.CToxValue.Location = new System.Drawing.Point(178, 666);
            this.CToxValue.Mask = "000.000";
            this.CToxValue.Name = "CToxValue";
            this.CToxValue.PromptChar = ' ';
            this.CToxValue.Size = new System.Drawing.Size(100, 23);
            this.CToxValue.TabIndex = 10;
            // 
            // FirstShotTimeValue
            // 
            this.FirstShotTimeValue.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.FirstShotTimeValue.Location = new System.Drawing.Point(711, 514);
            this.FirstShotTimeValue.Mask = "000";
            this.FirstShotTimeValue.Name = "FirstShotTimeValue";
            this.FirstShotTimeValue.PromptChar = ' ';
            this.FirstShotTimeValue.Size = new System.Drawing.Size(100, 23);
            this.FirstShotTimeValue.TabIndex = 5;
            // 
            // LoadDoseValue
            // 
            this.LoadDoseValue.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.LoadDoseValue.Location = new System.Drawing.Point(711, 623);
            this.LoadDoseValue.Mask = "00000";
            this.LoadDoseValue.Name = "LoadDoseValue";
            this.LoadDoseValue.PromptChar = ' ';
            this.LoadDoseValue.Size = new System.Drawing.Size(100, 23);
            this.LoadDoseValue.TabIndex = 11;
            // 
            // SecondaryShotDurationsValue
            // 
            this.SecondaryShotDurationsValue.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.SecondaryShotDurationsValue.Location = new System.Drawing.Point(711, 555);
            this.SecondaryShotDurationsValue.Mask = "000";
            this.SecondaryShotDurationsValue.Name = "SecondaryShotDurationsValue";
            this.SecondaryShotDurationsValue.PromptChar = ' ';
            this.SecondaryShotDurationsValue.Size = new System.Drawing.Size(100, 23);
            this.SecondaryShotDurationsValue.TabIndex = 6;
            // 
            // SupportDoseValue
            // 
            this.SupportDoseValue.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.SupportDoseValue.Location = new System.Drawing.Point(711, 652);
            this.SupportDoseValue.Mask = "00000";
            this.SupportDoseValue.Name = "SupportDoseValue";
            this.SupportDoseValue.PromptChar = ' ';
            this.SupportDoseValue.Size = new System.Drawing.Size(100, 23);
            this.SupportDoseValue.TabIndex = 12;
            // 
            // ComputationTimeRangeValue
            // 
            this.ComputationTimeRangeValue.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.ComputationTimeRangeValue.Location = new System.Drawing.Point(711, 426);
            this.ComputationTimeRangeValue.Mask = "000000";
            this.ComputationTimeRangeValue.Name = "ComputationTimeRangeValue";
            this.ComputationTimeRangeValue.PromptChar = ' ';
            this.ComputationTimeRangeValue.Size = new System.Drawing.Size(100, 23);
            this.ComputationTimeRangeValue.TabIndex = 23;
            // 
            // ComputationTimeRangeLabel
            // 
            this.ComputationTimeRangeLabel.Font = new System.Drawing.Font("Cambria Math", 8.25F);
            this.ComputationTimeRangeLabel.ForeColor = System.Drawing.Color.Black;
            this.ComputationTimeRangeLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ComputationTimeRangeLabel.Location = new System.Drawing.Point(525, 426);
            this.ComputationTimeRangeLabel.Name = "ComputationTimeRangeLabel";
            this.ComputationTimeRangeLabel.Size = new System.Drawing.Size(173, 35);
            this.ComputationTimeRangeLabel.TabIndex = 24;
            this.ComputationTimeRangeLabel.Text = "Длительность расчёта (мин)";
            this.ComputationTimeRangeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ComputationTimeRangeLabel.UseCompatibleTextRendering = true;
            // 
            // ComputeButton
            // 
            this.ComputeButton.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComputeButton.Location = new System.Drawing.Point(708, 735);
            this.ComputeButton.Name = "ComputeButton";
            this.ComputeButton.Size = new System.Drawing.Size(103, 23);
            this.ComputeButton.TabIndex = 25;
            this.ComputeButton.Text = "Рассчитать";
            this.ComputeButton.UseVisualStyleBackColor = true;
            this.ComputeButton.Click += new System.EventHandler(this.ComputeButton_Click);
            // 
            // NumberOfSecondaryInjectionsLabelValue
            // 
            this.NumberOfSecondaryInjectionsLabelValue.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.NumberOfSecondaryInjectionsLabelValue.Location = new System.Drawing.Point(711, 471);
            this.NumberOfSecondaryInjectionsLabelValue.Mask = "000";
            this.NumberOfSecondaryInjectionsLabelValue.Name = "NumberOfSecondaryInjectionsLabelValue";
            this.NumberOfSecondaryInjectionsLabelValue.PromptChar = ' ';
            this.NumberOfSecondaryInjectionsLabelValue.Size = new System.Drawing.Size(100, 23);
            this.NumberOfSecondaryInjectionsLabelValue.TabIndex = 26;
            // 
            // NumberOfSecondaryInjectionsLabel
            // 
            this.NumberOfSecondaryInjectionsLabel.Font = new System.Drawing.Font("Cambria Math", 8.25F);
            this.NumberOfSecondaryInjectionsLabel.ForeColor = System.Drawing.Color.Black;
            this.NumberOfSecondaryInjectionsLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NumberOfSecondaryInjectionsLabel.Location = new System.Drawing.Point(525, 471);
            this.NumberOfSecondaryInjectionsLabel.Name = "NumberOfSecondaryInjectionsLabel";
            this.NumberOfSecondaryInjectionsLabel.Size = new System.Drawing.Size(173, 40);
            this.NumberOfSecondaryInjectionsLabel.TabIndex = 27;
            this.NumberOfSecondaryInjectionsLabel.Text = "Количество повторных введений";
            this.NumberOfSecondaryInjectionsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NumberOfSecondaryInjectionsLabel.UseCompatibleTextRendering = true;
            // 
            // graphTimer
            // 
            this.graphTimer.Tick += new System.EventHandler(this.GraphTimer_Tick);
            // 
            // ConcentrationDataGrid
            // 
            this.ConcentrationDataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.ConcentrationDataGrid.Location = new System.Drawing.Point(29, 12);
            this.ConcentrationDataGrid.Name = "ConcentrationDataGrid";
            this.ConcentrationDataGrid.Size = new System.Drawing.Size(528, 350);
            this.ConcentrationDataGrid.TabIndex = 0;
            // 
            // ConcentrationChart
            // 
            chartArea1.Name = "График";
            this.ConcentrationChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ConcentrationChart.Legends.Add(legend1);
            this.ConcentrationChart.Location = new System.Drawing.Point(632, 12);
            this.ConcentrationChart.Name = "ConcentrationChart";
            series1.ChartArea = "График";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "ConcentrationCurve";
            series2.ChartArea = "График";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "ToxicConcentration";
            series3.ChartArea = "График";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "TheraputicConcentration";
            this.ConcentrationChart.Series.Add(series1);
            this.ConcentrationChart.Series.Add(series2);
            this.ConcentrationChart.Series.Add(series3);
            this.ConcentrationChart.Size = new System.Drawing.Size(765, 350);
            this.ConcentrationChart.TabIndex = 28;
            this.ConcentrationChart.Text = "chart1";
            this.ConcentrationChart.Click += new System.EventHandler(this.ConcentrationChart_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1498, 831);
            this.Controls.Add(this.ConcentrationChart);
            this.Controls.Add(this.ConcentrationDataGrid);
            this.Controls.Add(this.NumberOfSecondaryInjectionsLabelValue);
            this.Controls.Add(this.NumberOfSecondaryInjectionsLabel);
            this.Controls.Add(this.ComputeButton);
            this.Controls.Add(this.ComputationTimeRangeLabel);
            this.Controls.Add(this.ComputationTimeRangeValue);
            this.Controls.Add(this.SupportDoseValue);
            this.Controls.Add(this.SecondaryShotDurationsValue);
            this.Controls.Add(this.LoadDoseValue);
            this.Controls.Add(this.FirstShotTimeValue);
            this.Controls.Add(this.CToxValue);
            this.Controls.Add(this.CTheraputicValue);
            this.Controls.Add(this.SelectedCleareanceValue);
            this.Controls.Add(this.BodyWeightValue);
            this.Controls.Add(this.PrimaryConcentrationValue);
            this.Controls.Add(this.SelectedVolumeValue);
            this.Controls.Add(this.DrugSelectorBox);
            this.Controls.Add(this.BodyWeightLabel);
            this.Controls.Add(this.SupportDoseLabel);
            this.Controls.Add(this.LoadDoseLabel);
            this.Controls.Add(this.CToxLabel);
            this.Controls.Add(this.CTheraputicLabel);
            this.Controls.Add(this.PrimaryConcentrationLabel);
            this.Controls.Add(this.SecondaryShotDurationsLabel);
            this.Controls.Add(this.FirstShotTimeLabel);
            this.Controls.Add(this.SelectedCleareanceLabel);
            this.Controls.Add(this.SelectedVolumeLabel);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 24, 5, 24);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Модель фармакокинетики";
            ((System.ComponentModel.ISupportInitialize)(this.ConcentrationDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConcentrationChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.DataVisualization.Charting.Chart ConcentrationChart;
        private System.Windows.Forms.Label SelectedVolumeLabel;
        private System.Windows.Forms.Label SelectedCleareanceLabel;
        private System.Windows.Forms.Label FirstShotTimeLabel;
        private System.Windows.Forms.Label SecondaryShotDurationsLabel;
        private System.Windows.Forms.Label PrimaryConcentrationLabel;
        private System.Windows.Forms.Label CTheraputicLabel;
        private System.Windows.Forms.Label CToxLabel;
        private System.Windows.Forms.Label LoadDoseLabel;
        private System.Windows.Forms.Label SupportDoseLabel;
        private System.Windows.Forms.Label BodyWeightLabel;
        private System.Windows.Forms.ComboBox DrugSelectorBox;
        private System.Windows.Forms.Label ComputationTimeRangeLabel;
        private System.Windows.Forms.Button ComputeButton;
        internal System.Windows.Forms.MaskedTextBox PrimaryConcentrationValue;
        internal System.Windows.Forms.MaskedTextBox BodyWeightValue;
        internal System.Windows.Forms.MaskedTextBox SelectedCleareanceValue;
        internal System.Windows.Forms.MaskedTextBox CTheraputicValue;
        internal System.Windows.Forms.MaskedTextBox CToxValue;
        internal System.Windows.Forms.MaskedTextBox FirstShotTimeValue;
        internal System.Windows.Forms.MaskedTextBox LoadDoseValue;
        internal System.Windows.Forms.MaskedTextBox SecondaryShotDurationsValue;
        internal System.Windows.Forms.MaskedTextBox SupportDoseValue;
        internal System.Windows.Forms.MaskedTextBox ComputationTimeRangeValue;
        private System.Windows.Forms.MaskedTextBox SelectedVolumeValue;
        internal System.Windows.Forms.MaskedTextBox NumberOfSecondaryInjectionsLabelValue;
        private System.Windows.Forms.Label NumberOfSecondaryInjectionsLabel;
        private System.Windows.Forms.Timer graphTimer;
        private System.Windows.Forms.DataGridView ConcentrationDataGrid;
        private System.Windows.Forms.DataVisualization.Charting.Chart ConcentrationChart;
    }
}

