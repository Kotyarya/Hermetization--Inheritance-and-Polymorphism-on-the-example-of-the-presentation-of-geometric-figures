namespace Projekt2_Aksamitnyi62325
{
    partial class LabPart
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
            this.figuresList_CheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.fillFiguresList_CheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.changeBackGround_Button = new System.Windows.Forms.Button();
            this.startPresentation_Button = new System.Windows.Forms.Button();
            this.automatic_RadioButton = new System.Windows.Forms.RadioButton();
            this.manual_RadioButton = new System.Windows.Forms.RadioButton();
            this.indexCurrentSlide_GroupBox = new System.Windows.Forms.GroupBox();
            this.indexCurrentSlide_Numeric = new System.Windows.Forms.NumericUpDown();
            this.next_Button = new System.Windows.Forms.Button();
            this.previous_Button = new System.Windows.Forms.Button();
            this.stopPresentation_Button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numberFigures_Numeric = new System.Windows.Forms.NumericUpDown();
            this.drawFigures_Button = new System.Windows.Forms.Button();
            this.setRandomPosition_Button = new System.Windows.Forms.Button();
            this.setRandomAttributes_Button = new System.Windows.Forms.Button();
            this.reset_Button = new System.Windows.Forms.Button();
            this.addFigure_GroupBox = new System.Windows.Forms.GroupBox();
            this.addFigure_Button_addFigure = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lineStyleFigure_ComboBox_addFigure = new System.Windows.Forms.ComboBox();
            this.thicknessFigure_Numeric_addFigure = new System.Windows.Forms.NumericUpDown();
            this.colorFigure_Button_addFigure = new System.Windows.Forms.Button();
            this.nameFigure_ComboBox_addFigure = new System.Windows.Forms.ComboBox();
            this.positionY_Label_changeFigure = new System.Windows.Forms.Label();
            this.positionX_Label_changeFigure = new System.Windows.Forms.Label();
            this.positionY_TrackBar_changeFigure = new System.Windows.Forms.TrackBar();
            this.positionX_TrackBar_changeFigure = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lineStyleFigure_ComboBox_changeFigure = new System.Windows.Forms.ComboBox();
            this.thicknessFigure_Numeric_changeFigure = new System.Windows.Forms.NumericUpDown();
            this.colorFigure_Button_changeFigure = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.deleteCurrentFigure_Button = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.changeFigure_GroupBox = new System.Windows.Forms.GroupBox();
            this.indexCurrentSlide_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.indexCurrentSlide_Numeric)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberFigures_Numeric)).BeginInit();
            this.addFigure_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessFigure_Numeric_addFigure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionY_TrackBar_changeFigure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionX_TrackBar_changeFigure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessFigure_Numeric_changeFigure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.changeFigure_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // figuresList_CheckedListBox
            // 
            this.figuresList_CheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.figuresList_CheckedListBox.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.figuresList_CheckedListBox.FormattingEnabled = true;
            this.figuresList_CheckedListBox.Location = new System.Drawing.Point(1116, 132);
            this.figuresList_CheckedListBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.figuresList_CheckedListBox.Name = "figuresList_CheckedListBox";
            this.figuresList_CheckedListBox.Size = new System.Drawing.Size(158, 136);
            this.figuresList_CheckedListBox.TabIndex = 0;
            this.figuresList_CheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.figuresList_SelectHandler);
            // 
            // fillFiguresList_CheckedListBox
            // 
            this.fillFiguresList_CheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fillFiguresList_CheckedListBox.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillFiguresList_CheckedListBox.FormattingEnabled = true;
            this.fillFiguresList_CheckedListBox.Location = new System.Drawing.Point(1282, 132);
            this.fillFiguresList_CheckedListBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.fillFiguresList_CheckedListBox.Name = "fillFiguresList_CheckedListBox";
            this.fillFiguresList_CheckedListBox.Size = new System.Drawing.Size(158, 136);
            this.fillFiguresList_CheckedListBox.TabIndex = 2;
            this.fillFiguresList_CheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.figuresList_SelectHandler);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(1110, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select geometric figures";
            // 
            // changeBackGround_Button
            // 
            this.changeBackGround_Button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeBackGround_Button.Location = new System.Drawing.Point(362, 48);
            this.changeBackGround_Button.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.changeBackGround_Button.Name = "changeBackGround_Button";
            this.changeBackGround_Button.Size = new System.Drawing.Size(728, 69);
            this.changeBackGround_Button.TabIndex = 5;
            this.changeBackGround_Button.Text = "Change the background color";
            this.changeBackGround_Button.UseVisualStyleBackColor = true;
            this.changeBackGround_Button.Click += new System.EventHandler(this.changeBackGround_ClickHandler);
            // 
            // startPresentation_Button
            // 
            this.startPresentation_Button.Enabled = false;
            this.startPresentation_Button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.startPresentation_Button.Location = new System.Drawing.Point(15, 132);
            this.startPresentation_Button.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.startPresentation_Button.Name = "startPresentation_Button";
            this.startPresentation_Button.Size = new System.Drawing.Size(322, 92);
            this.startPresentation_Button.TabIndex = 6;
            this.startPresentation_Button.Text = "Turn on the presentation of geometric figures";
            this.startPresentation_Button.UseVisualStyleBackColor = true;
            this.startPresentation_Button.Click += new System.EventHandler(this.startPresentation_ClickHandler);
            // 
            // automatic_RadioButton
            // 
            this.automatic_RadioButton.AutoSize = true;
            this.automatic_RadioButton.Checked = true;
            this.automatic_RadioButton.Enabled = false;
            this.automatic_RadioButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.automatic_RadioButton.Location = new System.Drawing.Point(15, 246);
            this.automatic_RadioButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.automatic_RadioButton.Name = "automatic_RadioButton";
            this.automatic_RadioButton.Size = new System.Drawing.Size(155, 33);
            this.automatic_RadioButton.TabIndex = 7;
            this.automatic_RadioButton.TabStop = true;
            this.automatic_RadioButton.Text = "Automatic";
            this.automatic_RadioButton.UseVisualStyleBackColor = true;
            // 
            // manual_RadioButton
            // 
            this.manual_RadioButton.AutoSize = true;
            this.manual_RadioButton.Enabled = false;
            this.manual_RadioButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.manual_RadioButton.Location = new System.Drawing.Point(222, 246);
            this.manual_RadioButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.manual_RadioButton.Name = "manual_RadioButton";
            this.manual_RadioButton.Size = new System.Drawing.Size(122, 33);
            this.manual_RadioButton.TabIndex = 8;
            this.manual_RadioButton.Text = "Manual";
            this.manual_RadioButton.UseVisualStyleBackColor = true;
            // 
            // indexCurrentSlide_GroupBox
            // 
            this.indexCurrentSlide_GroupBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.indexCurrentSlide_GroupBox.Controls.Add(this.indexCurrentSlide_Numeric);
            this.indexCurrentSlide_GroupBox.Enabled = false;
            this.indexCurrentSlide_GroupBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.indexCurrentSlide_GroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.indexCurrentSlide_GroupBox.Location = new System.Drawing.Point(15, 309);
            this.indexCurrentSlide_GroupBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.indexCurrentSlide_GroupBox.Name = "indexCurrentSlide_GroupBox";
            this.indexCurrentSlide_GroupBox.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.indexCurrentSlide_GroupBox.Size = new System.Drawing.Size(318, 82);
            this.indexCurrentSlide_GroupBox.TabIndex = 9;
            this.indexCurrentSlide_GroupBox.TabStop = false;
            this.indexCurrentSlide_GroupBox.Text = "Figure index (slide)";
            // 
            // indexCurrentSlide_Numeric
            // 
            this.indexCurrentSlide_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.indexCurrentSlide_Numeric.Location = new System.Drawing.Point(8, 35);
            this.indexCurrentSlide_Numeric.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.indexCurrentSlide_Numeric.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.indexCurrentSlide_Numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.indexCurrentSlide_Numeric.Name = "indexCurrentSlide_Numeric";
            this.indexCurrentSlide_Numeric.Size = new System.Drawing.Size(304, 35);
            this.indexCurrentSlide_Numeric.TabIndex = 0;
            this.indexCurrentSlide_Numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.indexCurrentSlide_Numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.indexCurrentSlide_Numeric.ValueChanged += new System.EventHandler(this.indexCurrentSlide_ChangeHandler);
            // 
            // next_Button
            // 
            this.next_Button.Enabled = false;
            this.next_Button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.next_Button.Location = new System.Drawing.Point(176, 398);
            this.next_Button.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.next_Button.Name = "next_Button";
            this.next_Button.Size = new System.Drawing.Size(158, 60);
            this.next_Button.TabIndex = 10;
            this.next_Button.Text = "Next ⇒";
            this.next_Button.UseVisualStyleBackColor = true;
            this.next_Button.Click += new System.EventHandler(this.next_ClickHandler);
            // 
            // previous_Button
            // 
            this.previous_Button.Enabled = false;
            this.previous_Button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.previous_Button.Location = new System.Drawing.Point(14, 398);
            this.previous_Button.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.previous_Button.Name = "previous_Button";
            this.previous_Button.Size = new System.Drawing.Size(159, 60);
            this.previous_Button.TabIndex = 11;
            this.previous_Button.Text = "⇐ Previous";
            this.previous_Button.UseVisualStyleBackColor = true;
            this.previous_Button.Click += new System.EventHandler(this.previos_ClickHandler);
            // 
            // stopPresentation_Button
            // 
            this.stopPresentation_Button.Enabled = false;
            this.stopPresentation_Button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.stopPresentation_Button.Location = new System.Drawing.Point(14, 465);
            this.stopPresentation_Button.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.stopPresentation_Button.Name = "stopPresentation_Button";
            this.stopPresentation_Button.Size = new System.Drawing.Size(322, 92);
            this.stopPresentation_Button.TabIndex = 12;
            this.stopPresentation_Button.Text = "Turn off the presentation of geometric figures";
            this.stopPresentation_Button.UseVisualStyleBackColor = true;
            this.stopPresentation_Button.Click += new System.EventHandler(this.stopPresentation_ClickHandler);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox2.Controls.Add(this.numberFigures_Numeric);
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(1116, 315);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox2.Size = new System.Drawing.Size(326, 112);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enter the number of geometrics figres";
            // 
            // numberFigures_Numeric
            // 
            this.numberFigures_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberFigures_Numeric.Location = new System.Drawing.Point(8, 65);
            this.numberFigures_Numeric.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.numberFigures_Numeric.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numberFigures_Numeric.Name = "numberFigures_Numeric";
            this.numberFigures_Numeric.Size = new System.Drawing.Size(304, 35);
            this.numberFigures_Numeric.TabIndex = 0;
            this.numberFigures_Numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numberFigures_Numeric.ValueChanged += new System.EventHandler(this.numberFigures_ChangeHandler);
            // 
            // drawFigures_Button
            // 
            this.drawFigures_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.drawFigures_Button.Enabled = false;
            this.drawFigures_Button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.drawFigures_Button.Location = new System.Drawing.Point(1116, 435);
            this.drawFigures_Button.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.drawFigures_Button.Name = "drawFigures_Button";
            this.drawFigures_Button.Size = new System.Drawing.Size(328, 92);
            this.drawFigures_Button.TabIndex = 13;
            this.drawFigures_Button.Text = "Start";
            this.drawFigures_Button.UseVisualStyleBackColor = true;
            this.drawFigures_Button.Click += new System.EventHandler(this.drawFigures_ClickHandler);
            // 
            // setRandomPosition_Button
            // 
            this.setRandomPosition_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.setRandomPosition_Button.Enabled = false;
            this.setRandomPosition_Button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.setRandomPosition_Button.Location = new System.Drawing.Point(1116, 535);
            this.setRandomPosition_Button.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.setRandomPosition_Button.Name = "setRandomPosition_Button";
            this.setRandomPosition_Button.Size = new System.Drawing.Size(328, 92);
            this.setRandomPosition_Button.TabIndex = 14;
            this.setRandomPosition_Button.Text = "Randomly change the position of the figures";
            this.setRandomPosition_Button.UseVisualStyleBackColor = true;
            this.setRandomPosition_Button.Click += new System.EventHandler(this.setRandomPosition_ClickHandler);
            // 
            // setRandomAttributes_Button
            // 
            this.setRandomAttributes_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.setRandomAttributes_Button.Enabled = false;
            this.setRandomAttributes_Button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.setRandomAttributes_Button.Location = new System.Drawing.Point(1116, 635);
            this.setRandomAttributes_Button.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.setRandomAttributes_Button.Name = "setRandomAttributes_Button";
            this.setRandomAttributes_Button.Size = new System.Drawing.Size(328, 92);
            this.setRandomAttributes_Button.TabIndex = 15;
            this.setRandomAttributes_Button.Text = "Randomly change the attributes of the figures";
            this.setRandomAttributes_Button.UseVisualStyleBackColor = true;
            this.setRandomAttributes_Button.Click += new System.EventHandler(this.setRandomAttributes_ClickHandler);
            // 
            // reset_Button
            // 
            this.reset_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reset_Button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.reset_Button.Location = new System.Drawing.Point(1116, 735);
            this.reset_Button.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.reset_Button.Name = "reset_Button";
            this.reset_Button.Size = new System.Drawing.Size(328, 92);
            this.reset_Button.TabIndex = 16;
            this.reset_Button.Text = "Reset";
            this.reset_Button.UseVisualStyleBackColor = true;
            this.reset_Button.Click += new System.EventHandler(this.reset_ClickHandler);
            // 
            // addFigure_GroupBox
            // 
            this.addFigure_GroupBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.addFigure_GroupBox.Controls.Add(this.addFigure_Button_addFigure);
            this.addFigure_GroupBox.Controls.Add(this.label3);
            this.addFigure_GroupBox.Controls.Add(this.label2);
            this.addFigure_GroupBox.Controls.Add(this.lineStyleFigure_ComboBox_addFigure);
            this.addFigure_GroupBox.Controls.Add(this.thicknessFigure_Numeric_addFigure);
            this.addFigure_GroupBox.Controls.Add(this.colorFigure_Button_addFigure);
            this.addFigure_GroupBox.Controls.Add(this.nameFigure_ComboBox_addFigure);
            this.addFigure_GroupBox.Enabled = false;
            this.addFigure_GroupBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.addFigure_GroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addFigure_GroupBox.Location = new System.Drawing.Point(15, 565);
            this.addFigure_GroupBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.addFigure_GroupBox.Name = "addFigure_GroupBox";
            this.addFigure_GroupBox.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.addFigure_GroupBox.Size = new System.Drawing.Size(318, 231);
            this.addFigure_GroupBox.TabIndex = 10;
            this.addFigure_GroupBox.TabStop = false;
            this.addFigure_GroupBox.Text = "Add a figure";
            // 
            // addFigure_Button_addFigure
            // 
            this.addFigure_Button_addFigure.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.addFigure_Button_addFigure.Location = new System.Drawing.Point(8, 174);
            this.addFigure_Button_addFigure.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.addFigure_Button_addFigure.Name = "addFigure_Button_addFigure";
            this.addFigure_Button_addFigure.Size = new System.Drawing.Size(304, 52);
            this.addFigure_Button_addFigure.TabIndex = 17;
            this.addFigure_Button_addFigure.Text = "Add a figure";
            this.addFigure_Button_addFigure.UseVisualStyleBackColor = true;
            this.addFigure_Button_addFigure.Click += new System.EventHandler(this.addFigure_ClickHandler);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F);
            this.label3.Location = new System.Drawing.Point(171, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "Line style";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F);
            this.label2.Location = new System.Drawing.Point(171, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Line thickness";
            // 
            // lineStyleFigure_ComboBox_addFigure
            // 
            this.lineStyleFigure_ComboBox_addFigure.AllowDrop = true;
            this.lineStyleFigure_ComboBox_addFigure.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "78",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "78",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "78",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "78"});
            this.lineStyleFigure_ComboBox_addFigure.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.lineStyleFigure_ComboBox_addFigure.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lineStyleFigure_ComboBox_addFigure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lineStyleFigure_ComboBox_addFigure.FormattingEnabled = true;
            this.lineStyleFigure_ComboBox_addFigure.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.lineStyleFigure_ComboBox_addFigure.Items.AddRange(new object[] {
            "Solid",
            "Dash",
            "Dot",
            "DashDot"});
            this.lineStyleFigure_ComboBox_addFigure.Location = new System.Drawing.Point(8, 129);
            this.lineStyleFigure_ComboBox_addFigure.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lineStyleFigure_ComboBox_addFigure.Name = "lineStyleFigure_ComboBox_addFigure";
            this.lineStyleFigure_ComboBox_addFigure.Size = new System.Drawing.Size(157, 37);
            this.lineStyleFigure_ComboBox_addFigure.TabIndex = 20;
            // 
            // thicknessFigure_Numeric_addFigure
            // 
            this.thicknessFigure_Numeric_addFigure.Location = new System.Drawing.Point(8, 85);
            this.thicknessFigure_Numeric_addFigure.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.thicknessFigure_Numeric_addFigure.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.thicknessFigure_Numeric_addFigure.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.thicknessFigure_Numeric_addFigure.Name = "thicknessFigure_Numeric_addFigure";
            this.thicknessFigure_Numeric_addFigure.Size = new System.Drawing.Size(156, 35);
            this.thicknessFigure_Numeric_addFigure.TabIndex = 19;
            this.thicknessFigure_Numeric_addFigure.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // colorFigure_Button_addFigure
            // 
            this.colorFigure_Button_addFigure.BackColor = System.Drawing.Color.Red;
            this.colorFigure_Button_addFigure.Location = new System.Drawing.Point(172, 32);
            this.colorFigure_Button_addFigure.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.colorFigure_Button_addFigure.Name = "colorFigure_Button_addFigure";
            this.colorFigure_Button_addFigure.Size = new System.Drawing.Size(140, 45);
            this.colorFigure_Button_addFigure.TabIndex = 18;
            this.colorFigure_Button_addFigure.UseVisualStyleBackColor = false;
            this.colorFigure_Button_addFigure.Click += new System.EventHandler(this.colorFigure_ClickHandler);
            // 
            // nameFigure_ComboBox_addFigure
            // 
            this.nameFigure_ComboBox_addFigure.AllowDrop = true;
            this.nameFigure_ComboBox_addFigure.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "78",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "78",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "78",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "78"});
            this.nameFigure_ComboBox_addFigure.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.nameFigure_ComboBox_addFigure.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.nameFigure_ComboBox_addFigure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nameFigure_ComboBox_addFigure.FormattingEnabled = true;
            this.nameFigure_ComboBox_addFigure.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.nameFigure_ComboBox_addFigure.Location = new System.Drawing.Point(8, 35);
            this.nameFigure_ComboBox_addFigure.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.nameFigure_ComboBox_addFigure.Name = "nameFigure_ComboBox_addFigure";
            this.nameFigure_ComboBox_addFigure.Size = new System.Drawing.Size(157, 37);
            this.nameFigure_ComboBox_addFigure.TabIndex = 17;
            // 
            // positionY_Label_changeFigure
            // 
            this.positionY_Label_changeFigure.AutoSize = true;
            this.positionY_Label_changeFigure.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.positionY_Label_changeFigure.Location = new System.Drawing.Point(501, 111);
            this.positionY_Label_changeFigure.Name = "positionY_Label_changeFigure";
            this.positionY_Label_changeFigure.Size = new System.Drawing.Size(40, 29);
            this.positionY_Label_changeFigure.TabIndex = 36;
            this.positionY_Label_changeFigure.Text = "Y: ";
            // 
            // positionX_Label_changeFigure
            // 
            this.positionX_Label_changeFigure.AutoSize = true;
            this.positionX_Label_changeFigure.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.positionX_Label_changeFigure.Location = new System.Drawing.Point(501, 38);
            this.positionX_Label_changeFigure.Name = "positionX_Label_changeFigure";
            this.positionX_Label_changeFigure.Size = new System.Drawing.Size(43, 29);
            this.positionX_Label_changeFigure.TabIndex = 35;
            this.positionX_Label_changeFigure.Text = "X: ";
            // 
            // positionY_TrackBar_changeFigure
            // 
            this.positionY_TrackBar_changeFigure.Location = new System.Drawing.Point(338, 111);
            this.positionY_TrackBar_changeFigure.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.positionY_TrackBar_changeFigure.Name = "positionY_TrackBar_changeFigure";
            this.positionY_TrackBar_changeFigure.Size = new System.Drawing.Size(156, 69);
            this.positionY_TrackBar_changeFigure.TabIndex = 34;
            this.positionY_TrackBar_changeFigure.Scroll += new System.EventHandler(this.setPosition_ChangeHandler);
            // 
            // positionX_TrackBar_changeFigure
            // 
            this.positionX_TrackBar_changeFigure.Location = new System.Drawing.Point(338, 38);
            this.positionX_TrackBar_changeFigure.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.positionX_TrackBar_changeFigure.Name = "positionX_TrackBar_changeFigure";
            this.positionX_TrackBar_changeFigure.Size = new System.Drawing.Size(156, 69);
            this.positionX_TrackBar_changeFigure.TabIndex = 33;
            this.positionX_TrackBar_changeFigure.Scroll += new System.EventHandler(this.setPosition_ChangeHandler);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10F);
            this.label8.Location = new System.Drawing.Point(174, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 23);
            this.label8.TabIndex = 32;
            this.label8.Text = "Line style";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10F);
            this.label9.Location = new System.Drawing.Point(172, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 23);
            this.label9.TabIndex = 31;
            this.label9.Text = "Line thickness";
            // 
            // lineStyleFigure_ComboBox_changeFigure
            // 
            this.lineStyleFigure_ComboBox_changeFigure.AllowDrop = true;
            this.lineStyleFigure_ComboBox_changeFigure.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "78",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "78",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "78",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "78"});
            this.lineStyleFigure_ComboBox_changeFigure.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.lineStyleFigure_ComboBox_changeFigure.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lineStyleFigure_ComboBox_changeFigure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lineStyleFigure_ComboBox_changeFigure.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lineStyleFigure_ComboBox_changeFigure.FormattingEnabled = true;
            this.lineStyleFigure_ComboBox_changeFigure.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.lineStyleFigure_ComboBox_changeFigure.Items.AddRange(new object[] {
            "Solid",
            "Dash",
            "Dot",
            "DashDot"});
            this.lineStyleFigure_ComboBox_changeFigure.Location = new System.Drawing.Point(9, 38);
            this.lineStyleFigure_ComboBox_changeFigure.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lineStyleFigure_ComboBox_changeFigure.Name = "lineStyleFigure_ComboBox_changeFigure";
            this.lineStyleFigure_ComboBox_changeFigure.Size = new System.Drawing.Size(157, 37);
            this.lineStyleFigure_ComboBox_changeFigure.TabIndex = 30;
            this.lineStyleFigure_ComboBox_changeFigure.SelectedIndexChanged += new System.EventHandler(this.lineStyleFigure_SelectHandler);
            // 
            // thicknessFigure_Numeric_changeFigure
            // 
            this.thicknessFigure_Numeric_changeFigure.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.thicknessFigure_Numeric_changeFigure.Location = new System.Drawing.Point(9, 86);
            this.thicknessFigure_Numeric_changeFigure.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.thicknessFigure_Numeric_changeFigure.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.thicknessFigure_Numeric_changeFigure.Name = "thicknessFigure_Numeric_changeFigure";
            this.thicknessFigure_Numeric_changeFigure.Size = new System.Drawing.Size(156, 35);
            this.thicknessFigure_Numeric_changeFigure.TabIndex = 29;
            this.thicknessFigure_Numeric_changeFigure.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.thicknessFigure_Numeric_changeFigure.ValueChanged += new System.EventHandler(this.thicknessFigure_ChangeHandler);
            // 
            // colorFigure_Button_changeFigure
            // 
            this.colorFigure_Button_changeFigure.BackColor = System.Drawing.Color.Red;
            this.colorFigure_Button_changeFigure.Location = new System.Drawing.Point(9, 131);
            this.colorFigure_Button_changeFigure.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.colorFigure_Button_changeFigure.Name = "colorFigure_Button_changeFigure";
            this.colorFigure_Button_changeFigure.Size = new System.Drawing.Size(158, 45);
            this.colorFigure_Button_changeFigure.TabIndex = 28;
            this.colorFigure_Button_changeFigure.UseVisualStyleBackColor = false;
            this.colorFigure_Button_changeFigure.Click += new System.EventHandler(this.colorFigure_ClickHandler);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10F);
            this.label10.Location = new System.Drawing.Point(172, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 23);
            this.label10.TabIndex = 37;
            this.label10.Text = "Color";
            // 
            // deleteCurrentFigure_Button
            // 
            this.deleteCurrentFigure_Button.Enabled = false;
            this.deleteCurrentFigure_Button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.deleteCurrentFigure_Button.Location = new System.Drawing.Point(16, 842);
            this.deleteCurrentFigure_Button.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.deleteCurrentFigure_Button.Name = "deleteCurrentFigure_Button";
            this.deleteCurrentFigure_Button.Size = new System.Drawing.Size(316, 71);
            this.deleteCurrentFigure_Button.TabIndex = 39;
            this.deleteCurrentFigure_Button.Text = "Delete this figure";
            this.deleteCurrentFigure_Button.UseVisualStyleBackColor = true;
            this.deleteCurrentFigure_Button.Click += new System.EventHandler(this.deleteCurrentFigure_ClickHandler);
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic.Location = new System.Drawing.Point(344, 132);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(763, 559);
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            // 
            // changeFigure_GroupBox
            // 
            this.changeFigure_GroupBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.changeFigure_GroupBox.Controls.Add(this.lineStyleFigure_ComboBox_changeFigure);
            this.changeFigure_GroupBox.Controls.Add(this.positionX_TrackBar_changeFigure);
            this.changeFigure_GroupBox.Controls.Add(this.colorFigure_Button_changeFigure);
            this.changeFigure_GroupBox.Controls.Add(this.positionY_TrackBar_changeFigure);
            this.changeFigure_GroupBox.Controls.Add(this.thicknessFigure_Numeric_changeFigure);
            this.changeFigure_GroupBox.Controls.Add(this.label8);
            this.changeFigure_GroupBox.Controls.Add(this.positionY_Label_changeFigure);
            this.changeFigure_GroupBox.Controls.Add(this.positionX_Label_changeFigure);
            this.changeFigure_GroupBox.Controls.Add(this.label10);
            this.changeFigure_GroupBox.Controls.Add(this.label9);
            this.changeFigure_GroupBox.Enabled = false;
            this.changeFigure_GroupBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.changeFigure_GroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.changeFigure_GroupBox.Location = new System.Drawing.Point(345, 732);
            this.changeFigure_GroupBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.changeFigure_GroupBox.Name = "changeFigure_GroupBox";
            this.changeFigure_GroupBox.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.changeFigure_GroupBox.Size = new System.Drawing.Size(765, 180);
            this.changeFigure_GroupBox.TabIndex = 23;
            this.changeFigure_GroupBox.TabStop = false;
            this.changeFigure_GroupBox.Text = "Change this figure";
            // 
            // LabPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1458, 931);
            this.Controls.Add(this.changeFigure_GroupBox);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.deleteCurrentFigure_Button);
            this.Controls.Add(this.addFigure_GroupBox);
            this.Controls.Add(this.reset_Button);
            this.Controls.Add(this.setRandomAttributes_Button);
            this.Controls.Add(this.setRandomPosition_Button);
            this.Controls.Add(this.drawFigures_Button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.stopPresentation_Button);
            this.Controls.Add(this.previous_Button);
            this.Controls.Add(this.next_Button);
            this.Controls.Add(this.indexCurrentSlide_GroupBox);
            this.Controls.Add(this.manual_RadioButton);
            this.Controls.Add(this.automatic_RadioButton);
            this.Controls.Add(this.startPresentation_Button);
            this.Controls.Add(this.changeBackGround_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fillFiguresList_CheckedListBox);
            this.Controls.Add(this.figuresList_CheckedListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "LabPart";
            this.Text = "Laboratory part";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LabPart_CloseHandler);
            this.Load += new System.EventHandler(this.LabPart_LoadHandler);
            this.indexCurrentSlide_GroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.indexCurrentSlide_Numeric)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numberFigures_Numeric)).EndInit();
            this.addFigure_GroupBox.ResumeLayout(false);
            this.addFigure_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessFigure_Numeric_addFigure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionY_TrackBar_changeFigure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionX_TrackBar_changeFigure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessFigure_Numeric_changeFigure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.changeFigure_GroupBox.ResumeLayout(false);
            this.changeFigure_GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox figuresList_CheckedListBox;
        private System.Windows.Forms.CheckedListBox fillFiguresList_CheckedListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button changeBackGround_Button;
        private System.Windows.Forms.Button startPresentation_Button;
        private System.Windows.Forms.RadioButton automatic_RadioButton;
        private System.Windows.Forms.RadioButton manual_RadioButton;
        private System.Windows.Forms.GroupBox indexCurrentSlide_GroupBox;
        private System.Windows.Forms.NumericUpDown indexCurrentSlide_Numeric;
        private System.Windows.Forms.Button next_Button;
        private System.Windows.Forms.Button previous_Button;
        private System.Windows.Forms.Button stopPresentation_Button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numberFigures_Numeric;
        private System.Windows.Forms.Button drawFigures_Button;
        private System.Windows.Forms.Button setRandomPosition_Button;
        private System.Windows.Forms.Button setRandomAttributes_Button;
        private System.Windows.Forms.Button reset_Button;
        private System.Windows.Forms.GroupBox addFigure_GroupBox;
        private System.Windows.Forms.ComboBox nameFigure_ComboBox_addFigure;
        private System.Windows.Forms.Button colorFigure_Button_addFigure;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox lineStyleFigure_ComboBox_addFigure;
        private System.Windows.Forms.NumericUpDown thicknessFigure_Numeric_addFigure;
        private System.Windows.Forms.Button addFigure_Button_addFigure;
        private System.Windows.Forms.Label positionY_Label_changeFigure;
        private System.Windows.Forms.Label positionX_Label_changeFigure;
        private System.Windows.Forms.TrackBar positionY_TrackBar_changeFigure;
        private System.Windows.Forms.TrackBar positionX_TrackBar_changeFigure;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox lineStyleFigure_ComboBox_changeFigure;
        private System.Windows.Forms.NumericUpDown thicknessFigure_Numeric_changeFigure;
        private System.Windows.Forms.Button colorFigure_Button_changeFigure;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button deleteCurrentFigure_Button;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox changeFigure_GroupBox;
    }
}