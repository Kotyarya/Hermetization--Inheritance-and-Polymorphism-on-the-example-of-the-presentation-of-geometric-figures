using Projekt2_Aksamitnyi62325.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Projekt2_Aksamitnyi62325.Point;

namespace Projekt2_Aksamitnyi62325
{
    public partial class LabPart : Form
    {
        public LabPart()
        {
            InitializeComponent();

            bm = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bm);
            g.Clear(pic.BackColor);
            pic.Image = bm;
            figures = new Figures(new string[0], 0, g, pic, bm, indexCurrentSlide_Numeric);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        Bitmap bm;
        Graphics g;
        Figures figures;


        private void LabPart_CloseHandler(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LabPart_LoadHandler(object sender, EventArgs e)
        {
            string[] geometricsFigur = Enum.GetNames(typeof(GeometricFigur)) as string[];

            for (int i = 0; i < geometricsFigur.Length; i++)
            {
                figuresList_CheckedListBox.Items.Add(geometricsFigur[i]);
                nameFigure_ComboBox_addFigure.Items.Add(geometricsFigur[i]);

                if (geometricsFigur[i] != "Point" && geometricsFigur[i] != "Line")
                {
                    fillFiguresList_CheckedListBox.Items.Add("Fill " + geometricsFigur[i]);
                    nameFigure_ComboBox_addFigure.Items.Add("Fill " + geometricsFigur[i]);
                }
            }

            positionX_TrackBar_changeFigure.Maximum = pic.Width;
            positionY_TrackBar_changeFigure.Maximum = pic.Height;
        }

        private void setPosition_ChangeHandler(object sender, EventArgs e)
        {
            positionX_Label_changeFigure.Text = "X:" + positionX_TrackBar_changeFigure.Value;
            positionY_Label_changeFigure.Text = "Y:" + positionY_TrackBar_changeFigure.Value;
            figures.SetNewPosition(positionX_TrackBar_changeFigure.Value, positionY_TrackBar_changeFigure.Value);
        }

        private void drawFigures_ClickHandler(object sender, EventArgs e)
        {
            List<string> list = new List<string>();

            

            for (int i = 0; i < figuresList_CheckedListBox.CheckedItems.Count; i++)
            {

                list.Add(figuresList_CheckedListBox.CheckedItems[i].ToString());
                
            }

            for (int i = 0; i < fillFiguresList_CheckedListBox.CheckedItems.Count; i++)
            {

                list.Add(fillFiguresList_CheckedListBox.CheckedItems[i].ToString());

            }


            figures = new Figures(list.ToArray(), (uint)numberFigures_Numeric.Value, g, pic, bm, indexCurrentSlide_Numeric);
            figures.SetNewRandomPosition();
            figures.DrawAll();
            DrawFigure();
        }

        private void setRandomPosition_ClickHandler(object sender, EventArgs e)
        {
            figures.SetNewRandomPosition();
        }

        private void setRandomAttributes_ClickHandler(object sender, EventArgs e)
        {
            figures.SetNewRandomAttributes();
        }

        private void changeBackGround_ClickHandler(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                figures.SetNewBackColor(colorDialog.Color);
            }
        }

        private void startPresentation_ClickHandler(object sender, EventArgs e)
        {
            if (automatic_RadioButton.Checked)
            {
                figures.StartAutomaticPresenation();
            } else
            {
                figures.SetCurrentIndex(1);
                indexCurrentSlide_Numeric.Value = 2;
                indexCurrentSlide_Numeric.Value = 1;
            }

            StartPresentation();
        }

        private void stopPresentation_ClickHandler(object sender, EventArgs e)
        {
            if (automatic_RadioButton.Checked)
            {
                figures.StopAutomaticPresentation();
            } else
            {
                figures.StopManualPresentation();
            }

            StopPresentation();
        }

        private void next_ClickHandler(object sender, EventArgs e)
        {
            figures.Next();
        }

        private void previos_ClickHandler(object sender, EventArgs e)
        {
            figures.Previous();
        }

        private void addFigure_ClickHandler(object sender, EventArgs e)
        {
            figures.AddFigure(nameFigure_ComboBox_addFigure.Text, colorFigure_Button_addFigure.BackColor, (float)thicknessFigure_Numeric_addFigure.Value,lineStyleFigure_ComboBox_addFigure.Text);
        }

        private void colorFigure_ClickHandler(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            Button btn = sender as Button;

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                btn.BackColor = colorDialog.Color;
            }
        }

        private void deleteCurrentFigure_ClickHandler(object sender, EventArgs e)
        {
            figures.DeleteFigure();
        }

        private void indexCurrentSlide_ChangeHandler(object sender, EventArgs e)
        {
            Point currentFigure = figures.figuresArray[figures.currentIndex - 1];
            positionX_TrackBar_changeFigure.Value = pic.Width / 2;
            positionY_TrackBar_changeFigure.Value = pic.Height / 2;
            positionX_Label_changeFigure.Text = "X:" + positionX_TrackBar_changeFigure.Value;
            positionY_Label_changeFigure.Text = "Y:" + positionY_TrackBar_changeFigure.Value;
            colorFigure_Button_changeFigure.Enabled = false;
            lineStyleFigure_ComboBox_changeFigure.Enabled = false;
            thicknessFigure_Numeric_changeFigure.Enabled = false;
            colorFigure_Button_changeFigure.BackColor = currentFigure.color;
            lineStyleFigure_ComboBox_changeFigure.SelectedIndex = lineStyleFigure_ComboBox_changeFigure.FindStringExact(currentFigure.lineStyle.ToString());
            thicknessFigure_Numeric_changeFigure.Value = (decimal)currentFigure.lineThickness;
            colorFigure_Button_changeFigure.Enabled = true;
            lineStyleFigure_ComboBox_changeFigure.Enabled = true;
            thicknessFigure_Numeric_changeFigure.Enabled = true;
        }

        private void lineStyleFigure_SelectHandler(object sender, EventArgs e)
        {
            if (thicknessFigure_Numeric_changeFigure.Enabled)
            {
                figures.SetNewAttributes(colorFigure_Button_changeFigure.BackColor, lineStyleFigure_ComboBox_changeFigure.Text, (float)thicknessFigure_Numeric_changeFigure.Value);
            }
        }

        private void thicknessFigure_ChangeHandler(object sender, EventArgs e)
        {
            if (thicknessFigure_Numeric_changeFigure.Enabled) 
            {
                figures.SetNewAttributes(colorFigure_Button_changeFigure.BackColor, lineStyleFigure_ComboBox_changeFigure.Text, (float)thicknessFigure_Numeric_changeFigure.Value);
            }
        }

        private void colorFigure_Button_changeFigure_ClickHandler(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            Button btn = sender as Button;

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                btn.BackColor = colorDialog.Color;
                figures.SetNewAttributes(colorFigure_Button_changeFigure.BackColor, lineStyleFigure_ComboBox_changeFigure.Text, (float)thicknessFigure_Numeric_changeFigure.Value);
            }
        }

        private void figuresList_SelectHandler(object sender, ItemCheckEventArgs e)
        {
            groupBox2.Enabled = true;
            int num_checked = figuresList_CheckedListBox.CheckedItems.Count + fillFiguresList_CheckedListBox.CheckedItems.Count;

            if ((e.CurrentValue != CheckState.Checked) &&
                (e.NewValue == CheckState.Checked))
                num_checked++;
            if ((e.CurrentValue == CheckState.Checked) &&
                (e.NewValue != CheckState.Checked))
                num_checked--;

            numberFigures_Numeric.Minimum = num_checked;
            numberFigures_Numeric.Value = numberFigures_Numeric.Minimum;
        }

        private void numberFigures_ChangeHandler(object sender, EventArgs e)
        {
            drawFigures_Button.Enabled = numberFigures_Numeric.Value != 0;
        }

        private void DrawFigure()
        {
            setRandomAttributes_Button.Enabled = true;
            setRandomPosition_Button.Enabled = true;
            startPresentation_Button.Enabled = true;
            automatic_RadioButton.Enabled = true;
            manual_RadioButton.Enabled = true;
            addFigure_GroupBox.Enabled = true;
        }

        private void StartPresentation()
        {
            setRandomAttributes_Button.Enabled = false;
            setRandomPosition_Button.Enabled = false;
            drawFigures_Button.Enabled = false;
            addFigure_GroupBox.Enabled = false;
            automatic_RadioButton.Enabled = false;
            manual_RadioButton.Enabled = false;
            startPresentation_Button.Enabled = false;
            figuresList_CheckedListBox.Enabled = false;
            fillFiguresList_CheckedListBox.Enabled = false;

            bool presentationIsAutomatic = automatic_RadioButton.Checked;


            previous_Button.Enabled = !presentationIsAutomatic;
            next_Button.Enabled = !presentationIsAutomatic;
            indexCurrentSlide_GroupBox.Enabled = !presentationIsAutomatic;
            stopPresentation_Button.Enabled = true;
            changeFigure_GroupBox.Enabled = !presentationIsAutomatic;
            deleteCurrentFigure_Button.Enabled = !presentationIsAutomatic;
            reset_Button.Enabled = !presentationIsAutomatic;
        }

        private void StopPresentation()
        {
            setRandomAttributes_Button.Enabled = true;
            setRandomPosition_Button.Enabled = true;
            drawFigures_Button.Enabled = true;
            addFigure_GroupBox.Enabled = true;
            automatic_RadioButton.Enabled = true;
            manual_RadioButton.Enabled = true;
            startPresentation_Button.Enabled = true;
            figuresList_CheckedListBox.Enabled = true;
            fillFiguresList_CheckedListBox.Enabled = true;
            previous_Button.Enabled = false;
            next_Button.Enabled = false;
            indexCurrentSlide_GroupBox.Enabled = false;
            stopPresentation_Button.Enabled = false;
            changeFigure_GroupBox.Enabled = false;
            deleteCurrentFigure_Button.Enabled = false;
        }

        private void reset_ClickHandler(object sender, EventArgs e)
        {
            g.Clear(pic.BackColor);
            pic.Image = bm;
            figures = figures = new Figures(new string[0], 0, g, pic, bm, indexCurrentSlide_Numeric);
            for (int i = 0; i < this.Controls.Count; i++)
            {
                this.Controls[i].Enabled = false;
            }

            fillFiguresList_CheckedListBox.Enabled = true;
            figuresList_CheckedListBox.Enabled = true;
            changeBackGround_Button.Enabled = true;
            reset_Button.Enabled = true;
        }
    }
}
