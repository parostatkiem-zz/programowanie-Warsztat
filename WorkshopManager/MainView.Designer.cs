﻿namespace WorkshopManager
{
    partial class MainView
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("test");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Naciągnąc linkę ręcznego"}, -1, System.Drawing.SystemColors.ControlDarkDark, System.Drawing.Color.Empty, null);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Nie działa wycieraczka");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Piszczenie paska w silniku");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Spore wgniecenia na drzwiach LP"}, -1, System.Drawing.SystemColors.ControlDarkDark, System.Drawing.Color.Empty, null);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Ściąganie kierownicy podczas jazdy");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "Olej 5W40 ELF"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Empty, null);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "Olej 5W40 LIQUI MOLY"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Empty, null);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "Pasek pompy wody FEBI"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Empty, null);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "Pasek pompy wody MAXGEAR"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Empty, null);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem(new string[] {
            "Pompa wody DELPHI"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Empty, null);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem(new string[] {
            "Pompa wody FEBI"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Empty, null);
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem(new string[] {
            "Uszczelka pokrywy zaworów RINZ"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Empty, null);
            this.listViewCars = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lCarListHeader = new System.Windows.Forms.Label();
            this.btnPartsTypeEngine = new System.Windows.Forms.Button();
            this.btnPartsTypeSuspension = new System.Windows.Forms.Button();
            this.btnPartsTypeBrakes = new System.Windows.Forms.Button();
            this.btnPartsTypeChassis = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnAddNewCar = new System.Windows.Forms.Button();
            this.groupBoxCarProperties = new System.Windows.Forms.GroupBox();
            this.comboBoxCarBrand = new System.Windows.Forms.ComboBox();
            this.tbCarModel = new System.Windows.Forms.TextBox();
            this.numericUpDownCarYear = new System.Windows.Forms.NumericUpDown();
            this.tbCarEngine = new System.Windows.Forms.TextBox();
            this.btnCarRemoveProblem = new System.Windows.Forms.Button();
            this.btnCarAddNewProblem = new System.Windows.Forms.Button();
            this.lCarProblemsHeader = new System.Windows.Forms.Label();
            this.listViewCarProblems = new System.Windows.Forms.ListView();
            this.lcarYearDesc = new System.Windows.Forms.Label();
            this.lcarEngineDesc = new System.Windows.Forms.Label();
            this.lcarModelDesc = new System.Windows.Forms.Label();
            this.lcarBrandDesc = new System.Windows.Forms.Label();
            this.btnSwitchCarListMode = new System.Windows.Forms.Button();
            this.groupBoxPartProperties = new System.Windows.Forms.GroupBox();
            this.lPartBrand = new System.Windows.Forms.Label();
            this.lPartCarEngine = new System.Windows.Forms.Label();
            this.lPartCarModel = new System.Windows.Forms.Label();
            this.lPartCarBrand = new System.Windows.Forms.Label();
            this.lPartArea = new System.Windows.Forms.Label();
            this.lPartCarEngineDesc = new System.Windows.Forms.Label();
            this.lPartCarModelDesc = new System.Windows.Forms.Label();
            this.lPartCarBrandDesc = new System.Windows.Forms.Label();
            this.lPartAreaDesc = new System.Windows.Forms.Label();
            this.lPartBrandDesc = new System.Windows.Forms.Label();
            this.btnPartOrder = new System.Windows.Forms.Button();
            this.lPartsDesc = new System.Windows.Forms.Label();
            this.listViewParts = new System.Windows.Forms.ListView();
            this.tbNewCarProblemText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxCarProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCarYear)).BeginInit();
            this.groupBoxPartProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewCars
            // 
            this.listViewCars.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewCars.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewCars.FullRowSelect = true;
            this.listViewCars.GridLines = true;
            this.listViewCars.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewCars.Location = new System.Drawing.Point(3, 32);
            this.listViewCars.Name = "listViewCars";
            this.listViewCars.Size = new System.Drawing.Size(500, 250);
            this.listViewCars.TabIndex = 0;
            this.listViewCars.UseCompatibleStateImageBehavior = false;
            this.listViewCars.View = System.Windows.Forms.View.Details;
            this.listViewCars.SelectedIndexChanged += new System.EventHandler(this.listViewCars_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Marka";
            this.columnHeader1.Width = 151;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Model";
            this.columnHeader2.Width = 153;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Rocznik";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nierozwiązane problemy";
            this.columnHeader4.Width = 130;
            // 
            // lCarListHeader
            // 
            this.lCarListHeader.AutoSize = true;
            this.lCarListHeader.Location = new System.Drawing.Point(3, 8);
            this.lCarListHeader.Name = "lCarListHeader";
            this.lCarListHeader.Size = new System.Drawing.Size(153, 13);
            this.lCarListHeader.TabIndex = 1;
            this.lCarListHeader.Text = "Lista samochodów do naprawy";
            // 
            // btnPartsTypeEngine
            // 
            this.btnPartsTypeEngine.Location = new System.Drawing.Point(3, 23);
            this.btnPartsTypeEngine.Name = "btnPartsTypeEngine";
            this.btnPartsTypeEngine.Size = new System.Drawing.Size(80, 80);
            this.btnPartsTypeEngine.TabIndex = 2;
            this.btnPartsTypeEngine.Text = "Silnik";
            this.btnPartsTypeEngine.UseVisualStyleBackColor = true;
            // 
            // btnPartsTypeSuspension
            // 
            this.btnPartsTypeSuspension.Location = new System.Drawing.Point(89, 23);
            this.btnPartsTypeSuspension.Name = "btnPartsTypeSuspension";
            this.btnPartsTypeSuspension.Size = new System.Drawing.Size(80, 80);
            this.btnPartsTypeSuspension.TabIndex = 3;
            this.btnPartsTypeSuspension.Text = "Zawieszenie";
            this.btnPartsTypeSuspension.UseVisualStyleBackColor = true;
            // 
            // btnPartsTypeBrakes
            // 
            this.btnPartsTypeBrakes.Location = new System.Drawing.Point(175, 23);
            this.btnPartsTypeBrakes.Name = "btnPartsTypeBrakes";
            this.btnPartsTypeBrakes.Size = new System.Drawing.Size(80, 80);
            this.btnPartsTypeBrakes.TabIndex = 4;
            this.btnPartsTypeBrakes.Text = "Hamulce";
            this.btnPartsTypeBrakes.UseVisualStyleBackColor = true;
            // 
            // btnPartsTypeChassis
            // 
            this.btnPartsTypeChassis.Location = new System.Drawing.Point(261, 23);
            this.btnPartsTypeChassis.Name = "btnPartsTypeChassis";
            this.btnPartsTypeChassis.Size = new System.Drawing.Size(80, 80);
            this.btnPartsTypeChassis.TabIndex = 5;
            this.btnPartsTypeChassis.Text = "Karoseria";
            this.btnPartsTypeChassis.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnAddNewCar);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxCarProperties);
            this.splitContainer1.Panel1.Controls.Add(this.btnSwitchCarListMode);
            this.splitContainer1.Panel1.Controls.Add(this.lCarListHeader);
            this.splitContainer1.Panel1.Controls.Add(this.listViewCars);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxPartProperties);
            this.splitContainer1.Panel2.Controls.Add(this.btnPartOrder);
            this.splitContainer1.Panel2.Controls.Add(this.lPartsDesc);
            this.splitContainer1.Panel2.Controls.Add(this.listViewParts);
            this.splitContainer1.Panel2.Controls.Add(this.btnPartsTypeEngine);
            this.splitContainer1.Panel2.Controls.Add(this.btnPartsTypeChassis);
            this.splitContainer1.Panel2.Controls.Add(this.btnPartsTypeSuspension);
            this.splitContainer1.Panel2.Controls.Add(this.btnPartsTypeBrakes);
            this.splitContainer1.Size = new System.Drawing.Size(1067, 658);
            this.splitContainer1.SplitterDistance = 508;
            this.splitContainer1.TabIndex = 6;
            // 
            // btnAddNewCar
            // 
            this.btnAddNewCar.Location = new System.Drawing.Point(223, 3);
            this.btnAddNewCar.Name = "btnAddNewCar";
            this.btnAddNewCar.Size = new System.Drawing.Size(137, 23);
            this.btnAddNewCar.TabIndex = 4;
            this.btnAddNewCar.Text = "Dodaj nowy";
            this.btnAddNewCar.UseVisualStyleBackColor = true;
            // 
            // groupBoxCarProperties
            // 
            this.groupBoxCarProperties.Controls.Add(this.tbNewCarProblemText);
            this.groupBoxCarProperties.Controls.Add(this.comboBoxCarBrand);
            this.groupBoxCarProperties.Controls.Add(this.tbCarModel);
            this.groupBoxCarProperties.Controls.Add(this.numericUpDownCarYear);
            this.groupBoxCarProperties.Controls.Add(this.tbCarEngine);
            this.groupBoxCarProperties.Controls.Add(this.btnCarRemoveProblem);
            this.groupBoxCarProperties.Controls.Add(this.btnCarAddNewProblem);
            this.groupBoxCarProperties.Controls.Add(this.lCarProblemsHeader);
            this.groupBoxCarProperties.Controls.Add(this.listViewCarProblems);
            this.groupBoxCarProperties.Controls.Add(this.lcarYearDesc);
            this.groupBoxCarProperties.Controls.Add(this.lcarEngineDesc);
            this.groupBoxCarProperties.Controls.Add(this.lcarModelDesc);
            this.groupBoxCarProperties.Controls.Add(this.lcarBrandDesc);
            this.groupBoxCarProperties.Location = new System.Drawing.Point(3, 288);
            this.groupBoxCarProperties.Name = "groupBoxCarProperties";
            this.groupBoxCarProperties.Size = new System.Drawing.Size(500, 336);
            this.groupBoxCarProperties.TabIndex = 3;
            this.groupBoxCarProperties.TabStop = false;
            this.groupBoxCarProperties.Text = "Właścidowści samochodu";
            // 
            // comboBoxCarBrand
            // 
            this.comboBoxCarBrand.FormattingEnabled = true;
            this.comboBoxCarBrand.Items.AddRange(new object[] {
            "BMW",
            "Mercedes",
            "Fiat",
            "Skoda"});
            this.comboBoxCarBrand.Location = new System.Drawing.Point(107, 19);
            this.comboBoxCarBrand.Name = "comboBoxCarBrand";
            this.comboBoxCarBrand.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCarBrand.TabIndex = 12;
            this.comboBoxCarBrand.SelectedIndexChanged += new System.EventHandler(this.comboBoxCarBrand_SelectedIndexChanged);
            // 
            // tbCarModel
            // 
            this.tbCarModel.Location = new System.Drawing.Point(107, 46);
            this.tbCarModel.Name = "tbCarModel";
            this.tbCarModel.Size = new System.Drawing.Size(100, 20);
            this.tbCarModel.TabIndex = 11;
            this.tbCarModel.TextChanged += new System.EventHandler(this.tbCarModel_TextChanged);
            // 
            // numericUpDownCarYear
            // 
            this.numericUpDownCarYear.Location = new System.Drawing.Point(107, 95);
            this.numericUpDownCarYear.Maximum = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            this.numericUpDownCarYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericUpDownCarYear.Name = "numericUpDownCarYear";
            this.numericUpDownCarYear.Size = new System.Drawing.Size(121, 20);
            this.numericUpDownCarYear.TabIndex = 10;
            this.numericUpDownCarYear.Value = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            // 
            // tbCarEngine
            // 
            this.tbCarEngine.Location = new System.Drawing.Point(107, 70);
            this.tbCarEngine.Name = "tbCarEngine";
            this.tbCarEngine.Size = new System.Drawing.Size(100, 20);
            this.tbCarEngine.TabIndex = 9;
            this.tbCarEngine.TextChanged += new System.EventHandler(this.tbCarEngine_TextChanged);
            // 
            // btnCarRemoveProblem
            // 
            this.btnCarRemoveProblem.Location = new System.Drawing.Point(376, 121);
            this.btnCarRemoveProblem.Name = "btnCarRemoveProblem";
            this.btnCarRemoveProblem.Size = new System.Drawing.Size(114, 23);
            this.btnCarRemoveProblem.TabIndex = 7;
            this.btnCarRemoveProblem.Text = "Usuń zaznaczony";
            this.btnCarRemoveProblem.UseVisualStyleBackColor = true;
            this.btnCarRemoveProblem.Click += new System.EventHandler(this.btnCarRemoveProblem_Click);
            // 
            // btnCarAddNewProblem
            // 
            this.btnCarAddNewProblem.Location = new System.Drawing.Point(91, 121);
            this.btnCarAddNewProblem.Name = "btnCarAddNewProblem";
            this.btnCarAddNewProblem.Size = new System.Drawing.Size(75, 23);
            this.btnCarAddNewProblem.TabIndex = 6;
            this.btnCarAddNewProblem.Text = "Dodaj nowy";
            this.btnCarAddNewProblem.UseVisualStyleBackColor = true;
            this.btnCarAddNewProblem.Click += new System.EventHandler(this.btnCarAddNewProblem_Click);
            // 
            // lCarProblemsHeader
            // 
            this.lCarProblemsHeader.AutoSize = true;
            this.lCarProblemsHeader.Location = new System.Drawing.Point(9, 126);
            this.lCarProblemsHeader.Name = "lCarProblemsHeader";
            this.lCarProblemsHeader.Size = new System.Drawing.Size(50, 13);
            this.lCarProblemsHeader.TabIndex = 5;
            this.lCarProblemsHeader.Text = "Problemy";
            // 
            // listViewCarProblems
            // 
            this.listViewCarProblems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewCarProblems.CheckBoxes = true;
            this.listViewCarProblems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            listViewItem2.Checked = true;
            listViewItem2.StateImageIndex = 1;
            listViewItem3.StateImageIndex = 0;
            listViewItem4.StateImageIndex = 0;
            listViewItem5.Checked = true;
            listViewItem5.StateImageIndex = 1;
            listViewItem6.StateImageIndex = 0;
            this.listViewCarProblems.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.listViewCarProblems.Location = new System.Drawing.Point(9, 145);
            this.listViewCarProblems.MultiSelect = false;
            this.listViewCarProblems.Name = "listViewCarProblems";
            this.listViewCarProblems.ShowGroups = false;
            this.listViewCarProblems.Size = new System.Drawing.Size(491, 215);
            this.listViewCarProblems.TabIndex = 4;
            this.listViewCarProblems.UseCompatibleStateImageBehavior = false;
            this.listViewCarProblems.View = System.Windows.Forms.View.List;
            // 
            // lcarYearDesc
            // 
            this.lcarYearDesc.AutoSize = true;
            this.lcarYearDesc.Location = new System.Drawing.Point(6, 98);
            this.lcarYearDesc.Name = "lcarYearDesc";
            this.lcarYearDesc.Size = new System.Drawing.Size(46, 13);
            this.lcarYearDesc.TabIndex = 3;
            this.lcarYearDesc.Text = "Rocznik";
            // 
            // lcarEngineDesc
            // 
            this.lcarEngineDesc.AutoSize = true;
            this.lcarEngineDesc.Location = new System.Drawing.Point(6, 73);
            this.lcarEngineDesc.Name = "lcarEngineDesc";
            this.lcarEngineDesc.Size = new System.Drawing.Size(95, 13);
            this.lcarEngineDesc.TabIndex = 2;
            this.lcarEngineDesc.Text = "Oznaczenie silnika";
            // 
            // lcarModelDesc
            // 
            this.lcarModelDesc.AutoSize = true;
            this.lcarModelDesc.Location = new System.Drawing.Point(6, 49);
            this.lcarModelDesc.Name = "lcarModelDesc";
            this.lcarModelDesc.Size = new System.Drawing.Size(36, 13);
            this.lcarModelDesc.TabIndex = 1;
            this.lcarModelDesc.Text = "Model";
            // 
            // lcarBrandDesc
            // 
            this.lcarBrandDesc.AutoSize = true;
            this.lcarBrandDesc.Location = new System.Drawing.Point(6, 26);
            this.lcarBrandDesc.Name = "lcarBrandDesc";
            this.lcarBrandDesc.Size = new System.Drawing.Size(37, 13);
            this.lcarBrandDesc.TabIndex = 0;
            this.lcarBrandDesc.Text = "Marka";
            // 
            // btnSwitchCarListMode
            // 
            this.btnSwitchCarListMode.Location = new System.Drawing.Point(366, 3);
            this.btnSwitchCarListMode.Name = "btnSwitchCarListMode";
            this.btnSwitchCarListMode.Size = new System.Drawing.Size(137, 23);
            this.btnSwitchCarListMode.TabIndex = 2;
            this.btnSwitchCarListMode.Text = "Przełącz na archiwum";
            this.btnSwitchCarListMode.UseVisualStyleBackColor = true;
            // 
            // groupBoxPartProperties
            // 
            this.groupBoxPartProperties.Controls.Add(this.lPartBrand);
            this.groupBoxPartProperties.Controls.Add(this.lPartCarEngine);
            this.groupBoxPartProperties.Controls.Add(this.lPartCarModel);
            this.groupBoxPartProperties.Controls.Add(this.lPartCarBrand);
            this.groupBoxPartProperties.Controls.Add(this.lPartArea);
            this.groupBoxPartProperties.Controls.Add(this.lPartCarEngineDesc);
            this.groupBoxPartProperties.Controls.Add(this.lPartCarModelDesc);
            this.groupBoxPartProperties.Controls.Add(this.lPartCarBrandDesc);
            this.groupBoxPartProperties.Controls.Add(this.lPartAreaDesc);
            this.groupBoxPartProperties.Controls.Add(this.lPartBrandDesc);
            this.groupBoxPartProperties.Location = new System.Drawing.Point(6, 467);
            this.groupBoxPartProperties.Name = "groupBoxPartProperties";
            this.groupBoxPartProperties.Size = new System.Drawing.Size(544, 152);
            this.groupBoxPartProperties.TabIndex = 11;
            this.groupBoxPartProperties.TabStop = false;
            this.groupBoxPartProperties.Text = "Właściwości części";
            // 
            // lPartBrand
            // 
            this.lPartBrand.AutoSize = true;
            this.lPartBrand.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lPartBrand.Location = new System.Drawing.Point(138, 24);
            this.lPartBrand.Name = "lPartBrand";
            this.lPartBrand.Size = new System.Drawing.Size(82, 13);
            this.lPartBrand.TabIndex = 18;
            this.lPartBrand.Text = "Pasuje do marki";
            // 
            // lPartCarEngine
            // 
            this.lPartCarEngine.AutoSize = true;
            this.lPartCarEngine.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lPartCarEngine.Location = new System.Drawing.Point(138, 127);
            this.lPartCarEngine.Name = "lPartCarEngine";
            this.lPartCarEngine.Size = new System.Drawing.Size(82, 13);
            this.lPartCarEngine.TabIndex = 17;
            this.lPartCarEngine.Text = "Pasuje do marki";
            // 
            // lPartCarModel
            // 
            this.lPartCarModel.AutoSize = true;
            this.lPartCarModel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lPartCarModel.Location = new System.Drawing.Point(138, 99);
            this.lPartCarModel.Name = "lPartCarModel";
            this.lPartCarModel.Size = new System.Drawing.Size(82, 13);
            this.lPartCarModel.TabIndex = 16;
            this.lPartCarModel.Text = "Pasuje do marki";
            // 
            // lPartCarBrand
            // 
            this.lPartCarBrand.AutoSize = true;
            this.lPartCarBrand.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lPartCarBrand.Location = new System.Drawing.Point(138, 72);
            this.lPartCarBrand.Name = "lPartCarBrand";
            this.lPartCarBrand.Size = new System.Drawing.Size(82, 13);
            this.lPartCarBrand.TabIndex = 15;
            this.lPartCarBrand.Text = "Pasuje do marki";
            // 
            // lPartArea
            // 
            this.lPartArea.AutoSize = true;
            this.lPartArea.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lPartArea.Location = new System.Drawing.Point(137, 47);
            this.lPartArea.Name = "lPartArea";
            this.lPartArea.Size = new System.Drawing.Size(82, 13);
            this.lPartArea.TabIndex = 14;
            this.lPartArea.Text = "Pasuje do marki";
            // 
            // lPartCarEngineDesc
            // 
            this.lPartCarEngineDesc.AutoSize = true;
            this.lPartCarEngineDesc.Location = new System.Drawing.Point(6, 127);
            this.lPartCarEngineDesc.Name = "lPartCarEngineDesc";
            this.lPartCarEngineDesc.Size = new System.Drawing.Size(86, 13);
            this.lPartCarEngineDesc.TabIndex = 13;
            this.lPartCarEngineDesc.Text = "Pasuje do silnika";
            // 
            // lPartCarModelDesc
            // 
            this.lPartCarModelDesc.AutoSize = true;
            this.lPartCarModelDesc.Location = new System.Drawing.Point(6, 99);
            this.lPartCarModelDesc.Name = "lPartCarModelDesc";
            this.lPartCarModelDesc.Size = new System.Drawing.Size(91, 13);
            this.lPartCarModelDesc.TabIndex = 12;
            this.lPartCarModelDesc.Text = "Pasuje do modelu";
            // 
            // lPartCarBrandDesc
            // 
            this.lPartCarBrandDesc.AutoSize = true;
            this.lPartCarBrandDesc.Location = new System.Drawing.Point(6, 72);
            this.lPartCarBrandDesc.Name = "lPartCarBrandDesc";
            this.lPartCarBrandDesc.Size = new System.Drawing.Size(82, 13);
            this.lPartCarBrandDesc.TabIndex = 11;
            this.lPartCarBrandDesc.Text = "Pasuje do marki";
            // 
            // lPartAreaDesc
            // 
            this.lPartAreaDesc.AutoSize = true;
            this.lPartAreaDesc.Location = new System.Drawing.Point(6, 45);
            this.lPartAreaDesc.Name = "lPartAreaDesc";
            this.lPartAreaDesc.Size = new System.Drawing.Size(107, 13);
            this.lPartAreaDesc.TabIndex = 10;
            this.lPartAreaDesc.Text = "Segment samochodu";
            // 
            // lPartBrandDesc
            // 
            this.lPartBrandDesc.AutoSize = true;
            this.lPartBrandDesc.Location = new System.Drawing.Point(6, 19);
            this.lPartBrandDesc.Name = "lPartBrandDesc";
            this.lPartBrandDesc.Size = new System.Drawing.Size(37, 13);
            this.lPartBrandDesc.TabIndex = 9;
            this.lPartBrandDesc.Text = "Marka";
            // 
            // btnPartOrder
            // 
            this.btnPartOrder.Location = new System.Drawing.Point(405, 625);
            this.btnPartOrder.Name = "btnPartOrder";
            this.btnPartOrder.Size = new System.Drawing.Size(137, 23);
            this.btnPartOrder.TabIndex = 5;
            this.btnPartOrder.Text = "Zamów część";
            this.btnPartOrder.UseVisualStyleBackColor = true;
            // 
            // lPartsDesc
            // 
            this.lPartsDesc.AutoSize = true;
            this.lPartsDesc.Location = new System.Drawing.Point(3, 7);
            this.lPartsDesc.Name = "lPartsDesc";
            this.lPartsDesc.Size = new System.Drawing.Size(212, 13);
            this.lPartsDesc.TabIndex = 10;
            this.lPartsDesc.Text = "Części pasujące do wybranego samochodu";
            // 
            // listViewParts
            // 
            this.listViewParts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewParts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            listViewItem7.StateImageIndex = 0;
            listViewItem8.Checked = true;
            listViewItem8.StateImageIndex = 1;
            listViewItem9.StateImageIndex = 0;
            listViewItem10.Checked = true;
            listViewItem10.StateImageIndex = 1;
            listViewItem13.StateImageIndex = 0;
            this.listViewParts.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13});
            this.listViewParts.Location = new System.Drawing.Point(3, 111);
            this.listViewParts.MultiSelect = false;
            this.listViewParts.Name = "listViewParts";
            this.listViewParts.ShowGroups = false;
            this.listViewParts.Size = new System.Drawing.Size(547, 350);
            this.listViewParts.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewParts.TabIndex = 9;
            this.listViewParts.UseCompatibleStateImageBehavior = false;
            this.listViewParts.View = System.Windows.Forms.View.List;
            // 
            // tbNewCarProblemText
            // 
            this.tbNewCarProblemText.Location = new System.Drawing.Point(172, 123);
            this.tbNewCarProblemText.Name = "tbNewCarProblemText";
            this.tbNewCarProblemText.Size = new System.Drawing.Size(165, 20);
            this.tbNewCarProblemText.TabIndex = 13;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 658);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainView";
            this.Text = "WorkshopManager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainView_FormClosing);
            this.Load += new System.EventHandler(this.MainView_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxCarProperties.ResumeLayout(false);
            this.groupBoxCarProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCarYear)).EndInit();
            this.groupBoxPartProperties.ResumeLayout(false);
            this.groupBoxPartProperties.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewCars;
        private System.Windows.Forms.Label lCarListHeader;
        private System.Windows.Forms.Button btnPartsTypeEngine;
        private System.Windows.Forms.Button btnPartsTypeSuspension;
        private System.Windows.Forms.Button btnPartsTypeBrakes;
        private System.Windows.Forms.Button btnPartsTypeChassis;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxCarProperties;
        private System.Windows.Forms.Label lCarProblemsHeader;
        private System.Windows.Forms.ListView listViewCarProblems;
        private System.Windows.Forms.Label lcarYearDesc;
        private System.Windows.Forms.Label lcarEngineDesc;
        private System.Windows.Forms.Label lcarModelDesc;
        private System.Windows.Forms.Label lcarBrandDesc;
        private System.Windows.Forms.Button btnSwitchCarListMode;
        private System.Windows.Forms.Button btnAddNewCar;
        private System.Windows.Forms.Button btnCarRemoveProblem;
        private System.Windows.Forms.Button btnCarAddNewProblem;
        private System.Windows.Forms.GroupBox groupBoxPartProperties;
        private System.Windows.Forms.Label lPartCarEngineDesc;
        private System.Windows.Forms.Label lPartCarModelDesc;
        private System.Windows.Forms.Label lPartCarBrandDesc;
        private System.Windows.Forms.Label lPartAreaDesc;
        private System.Windows.Forms.Label lPartBrandDesc;
        private System.Windows.Forms.Button btnPartOrder;
        private System.Windows.Forms.Label lPartsDesc;
        private System.Windows.Forms.ListView listViewParts;
        private System.Windows.Forms.ComboBox comboBoxCarBrand;
        private System.Windows.Forms.TextBox tbCarModel;
        private System.Windows.Forms.NumericUpDown numericUpDownCarYear;
        private System.Windows.Forms.TextBox tbCarEngine;
        private System.Windows.Forms.Label lPartCarEngine;
        private System.Windows.Forms.Label lPartCarModel;
        private System.Windows.Forms.Label lPartCarBrand;
        private System.Windows.Forms.Label lPartArea;
        private System.Windows.Forms.Label lPartBrand;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox tbNewCarProblemText;
    }
}

