using Projekt2_Aksamitnyi62325.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Projekt2_Aksamitnyi62325.Point;

namespace Projekt2_Aksamitnyi62325
{
    public partial class IndPart : Form
    {
        public IndPart()
        {
            InitializeComponent();
            bm = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bm);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(pic.BackColor);
            pic.Image = bm;
            this.MaximizeBox = false; 
            this.MinimizeBox = false;
        }

        Bitmap bm;
        Graphics g;
        Figures figures;
        string currentFigure;
        bool isDraw = false;
        int x1, y1, x2, y2;
        int countBazierPoints = 0;


        private void selectFigure_SelectHandler(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton.Checked)
            {
                currentFigure = radioButton.Text;   

                if (figures.figuresArray.Length > 0 && figures.figuresArray[figures.figuresArray.Length - 1] is BazierLine bazierLine && bazierLine.points.Count < 4)
                {
                    countBazierPoints = 0;
                }
            }
        }

        private void Individual_LoadHandler(object sender, EventArgs e)
        {
            string[] geometricsFigur = Enum.GetNames(typeof(GeometricFigurWithLocation)) as string[];

            for (int i = 0; i < geometricsFigur.Length; i++)
            {
                RadioButton radioButton = new RadioButton();
                radioButton.Text = geometricsFigur[i];
                if (i == 0)
                {
                    radioButton.Location = new System.Drawing.Point(10, 10);
                } else
                {
                    radioButton.Location = new System.Drawing.Point(10, selectFigure_Panel.Controls[i - 1].Location.Y + 30);
                }

                radioButton.CheckedChanged += selectFigure_SelectHandler;
                selectFigure_Panel.Controls.Add(radioButton);
            }
            for (int i = 0; i < geometricsFigur.Length; i++)
            {

                if (geometricsFigur[i] != "Point" && geometricsFigur[i] != "Line" && geometricsFigur[i] != "CurveLine" && geometricsFigur[i] != "TwoWayLine")
                {
                    RadioButton fillRadioButton = new RadioButton();
                    fillRadioButton.Text = "Fill " + geometricsFigur[i];
                    fillRadioButton.Location = new System.Drawing.Point(10, selectFigure_Panel.Controls[selectFigure_Panel.Controls.Count - 1].Location.Y + 30);

                    fillRadioButton.CheckedChanged += selectFigure_SelectHandler;
                    selectFigure_Panel.Controls.Add(fillRadioButton);
                }
            }

            positionY_TrackBar_changeFigure.Minimum = 0;
            positionX_TrackBar_changeFigure.Minimum = 0;
            positionY_TrackBar_changeFigure.Maximum = pic.Height;
            positionX_TrackBar_changeFigure.Maximum = pic.Width;
            figures = new Figures(new string[0], 0, g, pic, bm, indexCurrentSlide_Numeric);
        }

        private void IndPart_CloseHandler(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void figureColor_ClickHandler(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            Button btn = sender as Button;

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                btn.BackColor = colorDialog.Color;
            }
        }

        private void startPresentation_ClickHandler(object sender, EventArgs e)
        {
            if (automatic_RadioButton.Checked)
            {
                figures.StartAutomaticPresenation();
            }
            else
            {
                figures.SetCurrentIndex(1);
                indexCurrentSlide_Numeric.Value = 2;
                indexCurrentSlide_Numeric.Value = 1;
            }

            StartPresentation();
        }

        private void next_ClickHandler(object sender, EventArgs e)
        {
            figures.Next();
        }

        private void previous_ClickHandler(object sender, EventArgs e)
        {
            figures.Previous();
        }

        private void stopPresentation_ClickHandler(object sender, EventArgs e)
        {
            if (automatic_RadioButton.Checked)
            {
                figures.StopAutomaticPresentation();
            }
            else
            {
                figures.StopManualPresentation();
            }

            StopPresentation();
        }

        private void setPosition_ChangeHandler(object sender, EventArgs e)
        {
            positionX_Label_changeFigure.Text = "X:" + positionX_TrackBar_changeFigure.Value;
            positionY_Label_changeFigure.Text = "Y:" + positionY_TrackBar_changeFigure.Value;
            figures.SetNewPosition(positionX_TrackBar_changeFigure.Value, positionY_TrackBar_changeFigure.Value);
        }

        private void changeBackGround_ClickHandler(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                figures.SetNewBackColor(colorDialog.Color);
            }
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

        private void colorFigure_ClickHandler(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            Button btn = sender as Button;

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                btn.BackColor = colorDialog.Color;
                figures.SetNewAttributes(colorFigure_Button_changeFigure.BackColor, lineStyleFigure_ComboBox_changeFigure.Text, (float)thicknessFigure_Numeric_changeFigure.Value);
            }
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

        private void setRandomPosition_ClickHandler(object sender, EventArgs e)
        {
            figures.SetNewRandomPosition();
        }

        private void setRandomAttributes_ClickHandler(object sender, EventArgs e)
        {
            figures.SetNewRandomAttributes();
        }

        private void deleteCurrentFigure_ClickHandler(object sender, EventArgs e)
        {
            figures.DeleteFigure();
        }

        private void pictureBox_MouseMoveHandler(object sender, MouseEventArgs e)
        {
            if (isDraw && currentFigure == "CurveLine")
            {
                figures.AddPointToFigure(e.X,e.Y);
            } else if (isDraw)
            {
                x2 = e.X; y2 = e.Y;
                figures.ShowDrawing(currentFigure, figureColor_figureAttributes_Button.BackColor, (float)lineThickness_figureAttributes_Numeric.Value, lineStyle_figureAttributes_ComboBox.Text, x1, y1, x2, y2);
            }
        }

        private void pictureBox_MouseDownHandler(object sender, MouseEventArgs e)
        {
            isDraw = true;
            x1 = e.X; y1 = e.Y;

            if (currentFigure == "BazierLine")
            {
                if (countBazierPoints == 0)
                {
                    figures.AddCustomFigure(currentFigure, figureColor_figureAttributes_Button.BackColor, (float)lineThickness_figureAttributes_Numeric.Value, lineStyle_figureAttributes_ComboBox.Text, x1, y1, x2, y2);
                    startPresentation_Button.Enabled = true;
                    countBazierPoints++;
                }
                else if (countBazierPoints == 4)
                {
                    countBazierPoints = 0;
                }
                else
                {
                    countBazierPoints++;
                    figures.AddPointToFigure(e.X, e.Y);
                    if (countBazierPoints == 4)
                    {
                        countBazierPoints = 0;
                    }
                }
            }

            if (currentFigure == "CurveLine")
            {
                figures.AddCustomFigure(currentFigure, figureColor_figureAttributes_Button.BackColor, (float)lineThickness_figureAttributes_Numeric.Value, lineStyle_figureAttributes_ComboBox.Text, x1, y1, x2, y2);
                startPresentation_Button.Enabled = true;
            }
        }

        private void pictureBox_MouseUpHandler(object sender, MouseEventArgs e)
        {
            x2 = e.X; y2 = e.Y;
            isDraw = false;


            if (currentFigure != "CurveLine" && currentFigure != "BazierLine")
            {
                startPresentation_Button.Enabled = true;
                figures.AddCustomFigure(currentFigure, figureColor_figureAttributes_Button.BackColor, (float)lineThickness_figureAttributes_Numeric.Value, lineStyle_figureAttributes_ComboBox.Text, x1, y1, x2, y2);
            }
        }

        private void reset_ClickHandler(object sender, EventArgs e)
        {
            g.Clear(pic.BackColor);
            pic.Image = bm;
            startPresentation_Button.Enabled = false;
            figures = figures = new Figures(new string[0], 0, g, pic, bm, indexCurrentSlide_Numeric);
        }

        private void save_ClickHandler(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog dialog = new SaveFileDialog();

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    bm.Save(dialog.FileName + ".jpg", ImageFormat.Jpeg);
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void open_ClickHandler(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    bm = new Bitmap(dialog.FileName);
                    g = Graphics.FromImage(bm);
                    pic.Image = bm;
                    figures = new Figures(new string[0], 0, g, pic, bm, indexCurrentSlide_Numeric, new Bitmap(dialog.FileName));
                    startPresentation_Button.Enabled = false;
                    setRandomAttributes_Button.Enabled = false;
                    setRandomPosition_Button.Enabled = false;
                }

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StartPresentation()
        {
            setRandomAttributes_Button.Enabled = false;
            setRandomPosition_Button.Enabled = false;
            automatic_RadioButton.Enabled = false;
            manual_RadioButton.Enabled = false;
            startPresentation_Button.Enabled = false;
            selectFigure_Panel.Enabled = false;
            figureAttributes_GroupBox.Enabled = false;
            pic.Enabled = false;
            reset_Button.Enabled = false;
            save_Button.Enabled = false;
            open_Button.Enabled = false;

            bool presentationIsAutomatic = automatic_RadioButton.Checked;


            previous_Button.Enabled = !presentationIsAutomatic;
            next_Button.Enabled = !presentationIsAutomatic;
            indexCurrentSlide_GroupBox.Enabled = !presentationIsAutomatic;
            stopPresentation_Button.Enabled = true;
            changeFigure_GroupBox.Enabled = !presentationIsAutomatic;
            deleteCurrentFigure_Button.Enabled = !presentationIsAutomatic;

        }

        private void StopPresentation()
        {
            setRandomAttributes_Button.Enabled = true;
            setRandomPosition_Button.Enabled = true;
            automatic_RadioButton.Enabled = true;
            manual_RadioButton.Enabled = true;
            startPresentation_Button.Enabled = true;
            selectFigure_Panel.Enabled = true;
            figureAttributes_GroupBox.Enabled = true;
            reset_Button.Enabled = true;
            pic.Enabled = true;
            save_Button.Enabled = true;
            open_Button.Enabled = true;
            previous_Button.Enabled = false;
            next_Button.Enabled = false;
            indexCurrentSlide_GroupBox.Enabled = false;
            stopPresentation_Button.Enabled = false;
            changeFigure_GroupBox.Enabled = false;
            deleteCurrentFigure_Button.Enabled = false;
        }
    }
}
