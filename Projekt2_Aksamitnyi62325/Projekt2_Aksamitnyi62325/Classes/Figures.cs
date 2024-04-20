using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Projekt2_Aksamitnyi62325.Classes
{
    public class Figures
    {

        public Point[] figuresArray { get; private set; }
        public Graphics g { get; private set; }
        public PictureBox pic { get; private set; }
        public Bitmap bmp { get; private set; }
        public uint currentIndex { get; private set; }
        public Timer timer { get; private set; }
        public NumericUpDown numeric { get; private set; }
        public List<int> modifiedFiguresIndexes { get; private set; } = new List<int> ();
        public bool presentationIsTurn { get; private set; } = false;
        public Image image { get; private set; }


        public Figures(string[] namesArr, uint numbersFigures, Graphics graphics, PictureBox picture, Bitmap bitmap, NumericUpDown numeric, Image img = null)
        {
            figuresArray = new Point[numbersFigures];
            g = graphics;
            pic = picture;
            bmp = bitmap;
            currentIndex = 1;
            image = img;
            this.numeric = numeric;

            ushort index = 0;
            double step = Math.Ceiling((float)numbersFigures / (float)namesArr.Length);

            for (int i = 0; i < step; i++)
            {
                foreach (string name in namesArr)
                {
                    switch (name)
                    {
                        case "Point":
                            if (index >= numbersFigures)
                            {
                                break;
                            }
                            figuresArray[index] = new Point(0, 0);
                            index++;
                            continue;
                        case "Line":
                            if (index >= numbersFigures)
                            {
                                break;
                            }

                            figuresArray[index] = new Line(0, 0, 70, 70);
                            index++;
                            continue;
                        case "Square":
                            if (index >= numbersFigures)
                            {
                                break;
                            }
                            figuresArray[index] = new Square(0, 0, 70);
                            index++;

                            continue;
                        case "Fill Square":
                            if (index >= numbersFigures)
                            {
                                break;
                            }

                            figuresArray[index] = new FillSquare(0, 0, 70);
                            index++;
                            continue;
                        case "Ellipse":
                            if (index >= numbersFigures)
                            {
                                break;
                            }
                            figuresArray[index] = new Ellipse(0, 0, 40, 70);
                            index++;
                            continue;
                        case "Fill Ellipse":
                            if (index >= numbersFigures)
                            {
                                break;
                            }
                            figuresArray[index] = new FillEllipse(0, 0, 40, 70);
                            index++;
                            continue;
                        case "Circle":
                            if (index >= numbersFigures)
                            {
                                break;
                            }
                            figuresArray[index] = new Circle(0, 0, 70);
                            index++;
                            continue;
                        case "Fill Circle":
                            if (index >= numbersFigures)
                            {
                                break;
                            }
                            figuresArray[index] = new FillCircle(0, 0, 70);
                            index++;
                            continue;
                        case "Rectangle":
                            if (index >= numbersFigures)
                            {
                                break;
                            }

                            figuresArray[index] = new Rectangle(0, 0, 40, 70);
                            index++;
                            continue;
                        case "Fill Rectangle":
                            if (index >= numbersFigures)
                            {
                                break;
                            }
                            figuresArray[index] = new FillRectangle(0, 0, 40, 70);
                            index++;
                            continue;
                        case "Triangle":
                            if (index >= numbersFigures)
                            {
                                break;
                            }
                            figuresArray[index] = new Polygon(0, 0, 70, 3);
                            index++;
                            continue;
                        case "Fill Triangle":
                            if (index >= numbersFigures)
                            {
                                break;
                            }
                            figuresArray[index] = new FillPolygon(0, 0, 70, 3);
                            index++;
                            continue;
                        case "Trapeze":
                            if (index >= numbersFigures)
                            {
                                break;
                            }
                            figuresArray[index] = new Trapeze(0, 0, 70, 40);
                            index++;
                            continue;
                        case "Fill Trapeze":
                            if (index >= numbersFigures)
                            {
                                break;
                            }

                            figuresArray[index] = new FillTrapeze(0, 0, 70, 40);
                            index++;
                            continue;
                        case "Diamond":
                            if (index >= numbersFigures)
                            {
                                break;
                            }
                            figuresArray[index] = new Polygon(0, 0, 70, 4);
                            index++;
                            continue;
                        case "Fill Diamond":
                            if (index >= numbersFigures)
                            {
                                break;
                            }
                            figuresArray[index] = new FillPolygon(0, 0, 70, 4);
                            index++;
                            continue;
                        case "Rhombus":
                            if (index >= numbersFigures)
                            {
                                break;
                            }
                            figuresArray[index] = new Rhombus(0, 0, 40, 70);
                            index++;
                            continue;
                        case "Fill Rhombus":
                            if (index >= numbersFigures)
                            {
                                break;
                            }
                            figuresArray[index] = new FillRhombus(0, 0, 40, 70);
                            index++;
                            continue;
                        case "Pentagon":
                            if (index >= numbersFigures)
                            {
                                break;
                            }
                            figuresArray[index] = new Polygon(0, 0, 70, 5);
                            index++;
                            continue;
                        case "Fill Pentagon":
                            if (index >= numbersFigures)
                            {
                                break;
                            }
                            figuresArray[index] = new FillPolygon(0, 0, 70, 5);
                            index++;
                            continue;
                        case "Hexagon":
                            if (index >= numbersFigures)
                            {
                                break;
                            }
                            figuresArray[index] = new Polygon(0, 0, 70, 6);
                            index++;
                            continue;
                        case "Fill Hexagon":
                            if (index >= numbersFigures)
                            {
                                break;
                            }
                            figuresArray[index] = new FillPolygon(0, 0, 70, 6);
                            index++;
                            continue;
                        case "Octagon":
                            if (index >= numbersFigures)
                            {
                                break;
                            }
                            figuresArray[index] = new Polygon(0, 0, 70, 8);
                            index++;
                            continue;
                        case "Fill Octagon":
                            if (index >= numbersFigures)
                            {
                                break;
                            }
                            figuresArray[index] = new FillPolygon(0, 0, 70, 8);
                            index++;
                            continue;
                    }
                }
            }

        }

        public void DrawAll()
        {
            foreach (Point figure in figuresArray)
            {
                figure.Draw(g);
            }
            pic.Image = bmp;
        }

        public void SetNewRandomPosition()
        {
            Random rnd = new Random();

            foreach (Point figure in figuresArray)
            {
                if (figure is Rectangle rectangle)
                {
                    figure.SetNewPosition(rnd.Next(0, pic.Width - rectangle.width), rnd.Next(0, pic.Height - rectangle.height));
                } else
                {
                    figure.SetNewPosition(rnd.Next(0, pic.Width), rnd.Next(0, pic.Height));
                }
            }
            g.Clear(pic.BackColor);
            if (!(image is null))
            {
                g.DrawImageUnscaledAndClipped(image, new System.Drawing.Rectangle(0, 0, bmp.Width, bmp.Height));
            }
            DrawAll();
        }

        public void SetNewRandomAttributes()
        {
            Random rnd = new Random();
            DashStyle[] lineStylesArray = { DashStyle.Solid, DashStyle.Dash, DashStyle.Dot, DashStyle.DashDot };

            foreach (Point figure in figuresArray)
            {
                Color color = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
                DashStyle lineStyle = lineStylesArray[rnd.Next(0, 3)];
                figure.SetNewAttributes(color, lineStyle, rnd.Next(1, 10));
            }
            g.Clear(pic.BackColor);
            if (!(image is null))
            {
                g.DrawImageUnscaledAndClipped(image, new System.Drawing.Rectangle(0, 0, bmp.Width, bmp.Height));
            }
            DrawAll();
        }

        public void SetNewBackColor(Color color)
        {
            pic.BackColor = color;
            image = null;
            g.Clear(pic.BackColor);
            if (!presentationIsTurn)
            {
                DrawAll();
            } else
            {
                SetCurrentIndex(currentIndex);
            }
            
        }

        public void SetCurrentIndex(uint index)
        { 
            presentationIsTurn = true;
            currentIndex = index;
            numeric.Value = currentIndex;
            g.Clear(pic.BackColor);
            Point figure = figuresArray[currentIndex - 1];


            if (modifiedFiguresIndexes.Contains((int)currentIndex - 1))
            {
                figure.Draw(g);
                pic.Image = bmp;
                return;
            }
            

            if (figure is Rectangle rectangle)
            {
                figure.SetNewPosition((pic.Width / 2) - (rectangle.width / 2), (pic.Height / 2) - (rectangle.height / 2));
            } else if (figure is Line line)
            {
                int width = line.x - line.x1;
                int height = line.y - line.y1;
                figure.SetNewPosition((pic.Width / 2) - (width < 0 ? (width * -1) / 2 : width / 2), (pic.Height / 2) - (height < 0 ? (height * -1) / 2 : height / 2));
            } else if (figure is CurveLine curveLine)
            {
                PointF maxX = new PointF(0,0);
                PointF maxY = new PointF(0, 0);
                PointF minX = new PointF(pic.Width,pic.Height);
                PointF minY = new PointF(pic.Width, pic.Height);

                for (int i = 0; i < curveLine.points.Count; i++)
                {
                    maxX = maxX.X > curveLine.points[i].X ? maxX : curveLine.points[i];
                    maxY = maxY.Y > curveLine.points[i].Y ? maxY : curveLine.points[i];
                    minX = minX.X < curveLine.points[i].X ? minX : curveLine.points[i];
                    minY = minY.Y < curveLine.points[i].Y ? minY : curveLine.points[i];
                }

                int x = Convert.ToInt16((pic.Width / 2) - ((maxX.X - minX.X) / 2));
                int y = Convert.ToInt16((pic.Height / 2) - ((maxY.Y - minY.Y) / 2));
                curveLine.SetNewPosition(x, y);
                figure = curveLine;
            } else
            {
                figure.SetNewPosition(pic.Width / 2, pic.Height / 2);
            }

            figure.Draw(g);
            pic.Image = bmp;
        }

        public void Next()
        {
            if (currentIndex == figuresArray.Length)
            {
                SetCurrentIndex(1);
            } else
            {
                SetCurrentIndex(currentIndex + 1);
            }
        }

        public void Previous()
        {
            if (currentIndex == 1)
            {
                SetCurrentIndex((uint)figuresArray.Length);
            } else
            {
                SetCurrentIndex(currentIndex - 1);
            }

        }

        public void StartAutomaticPresenation()
        {
            timer = new Timer();
            SetCurrentIndex(1);
            timer.Interval = 1000;
            timer.Start();
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (currentIndex == figuresArray.Length)
            {
                SetCurrentIndex(1);
            }
            else
            {
                SetCurrentIndex(currentIndex + 1);
            }
        }

        public void StopAutomaticPresentation()
        {
            currentIndex = 1;
            timer.Stop();
            timer.Dispose();
            SetNewRandomPosition();
            g.Clear(pic.BackColor);
            if (!(image is null))
            {
                g.DrawImageUnscaledAndClipped(image, new System.Drawing.Rectangle(0, 0, bmp.Width, bmp.Height));
            }
            DrawAll();
        }

        public void StopManualPresentation()
        {
            presentationIsTurn = false;
            Random rnd = new Random();
            for (int i = 0; i < figuresArray.Length; i++)
            {
                Point figure = figuresArray[i];

                if (!modifiedFiguresIndexes.Contains(i))
                {
                    if (figure is Rectangle rectangle)
                    {
                        figure.SetNewPosition(rnd.Next(0, pic.Width - rectangle.width), rnd.Next(0, pic.Height - rectangle.height));
                    }
                    else
                    {
                        figure.SetNewPosition(rnd.Next(0, pic.Width), rnd.Next(0, pic.Height));
                    }
                }
                g.Clear(pic.BackColor);
                if (!(image is null))
                {
                    g.DrawImageUnscaledAndClipped(image, new System.Drawing.Rectangle(0, 0, bmp.Width, bmp.Height));
                }
                DrawAll();
            }
        }

        public void AddFigure(string name, Color color, float lineThickness, string lineStyle)
        {
            Point figure;
            DashStyle dashStyle = DashStyle.Solid;

            switch (lineStyle)
            {
                case "Solid":
                    dashStyle = DashStyle.Solid;
                    break;
                case "Dot":
                    dashStyle = DashStyle.Dot;
                    break;
                case "Dash":
                    dashStyle = DashStyle.Dash;
                    break;
                case "DashDot":
                    dashStyle = DashStyle.DashDot;
                    break;
                default:
                    dashStyle = DashStyle.Solid;
                    break;
            }

            switch (name)
            {
                case "Point":
                    figure = new Point(0, 0);
                    break;
                case "Line":
                    figure = new Line(0, 0, 70, 70);
                    break;
                case "Square":
                    figure = new Square(0, 0, 70);
                    break;
                case "Fill Square":
                    figure = new FillSquare(0, 0, 70);
                    break;
                case "Ellipse":
                    figure = new Ellipse(0, 0, 40, 70);
                    break;
                case "Fill Ellipse":
                    figure = new FillEllipse(0, 0, 40, 70);
                    break;
                case "Circle":
                    figure = new Circle(0, 0, 70);
                    break;
                case "Fill Circle":
                    figure = new FillCircle(0, 0, 70);
                    break;
                case "Rectangle":
                    figure = new Rectangle(0, 0, 40, 70);
                    break;
                case "Fill Rectangle":
                    figure = new FillRectangle(0, 0, 40, 70);
                    break;
                case "Triangle":
                    figure = new Polygon(0, 0, 70, 3);
                    break;
                case "Fill Triangle":
                    figure = new FillPolygon(0, 0, 70, 3);
                    break;
                case "Trapeze":
                    figure = new Trapeze(0, 0, 70, 40);
                    break;
                case "Fill Trapeze":
                    figure = new FillTrapeze(0, 0, 70, 40);
                    break;
                case "Diamond":
                    figure = new Polygon(0, 0, 70, 4);
                    break;
                case "Fill Diamond":
                    figure = new FillPolygon(0, 0, 70, 4);
                    break;
                case "Rhombus":
                    figure = new Rhombus(0, 0, 40, 70);
                    break;
                case "Fill Rhombus":
                    figure = new FillRhombus(0, 0, 40, 70);
                    break;
                case "Pentagon":
                    figure = new Polygon(0, 0, 70, 5);
                    break;
                case "Fill Pentagon":
                    figure = new FillPolygon(0, 0, 70, 5);
                    break;
                case "Hexagon":
                    figure = new Polygon(0, 0, 70, 6);
                    break;
                case "Fill Hexagon":
                    figure = new FillPolygon(0, 0, 70, 6);
                    break;
                case "Octagon":
                    figure = new Polygon(0, 0, 70, 8);
                    break;
                case "Fill Octagon":
                    figure = new FillPolygon(0, 0, 70, 8);
                    break;
                default:
                    figure = new Point(0, 0);
                    break;
            }

            figure.SetNewAttributes(color, dashStyle, lineThickness);

            Random rnd = new Random();
            if (figure is Rectangle rectangle)
            {
                figure.SetNewPosition(rnd.Next(0, pic.Width - rectangle.width), rnd.Next(0, pic.Height - rectangle.height));
            }
            else
            {
                figure.SetNewPosition(rnd.Next(0, pic.Width), rnd.Next(0, pic.Height));
            }

            Point[] tempArray = new Point[figuresArray.Length + 1];

            for (uint i = 0; i < tempArray.Length; i++)
            {
                if (i == figuresArray.Length)
                {
                    tempArray[i] = figure;
                } else
                {
                    tempArray[i] = figuresArray[i];
                }
            }

            figuresArray = tempArray;
            g.Clear(pic.BackColor);
            DrawAll();
        }

        public void AddCustomFigure(string name, Color color, float lineThickness, string lineStyle, int x1, int y1, int x2, int y2)
        {
            Point figure;
            DashStyle dashStyle = DashStyle.Solid;

            if (figuresArray.Length > 0)
            {
                if (figuresArray[figuresArray.Length - 1] is BazierLine bazierLine && bazierLine.points.Count < 4)
                {
                    List<Point> tempList = new List<Point>();

                    for (int i = 0; i < figuresArray.Length; i++)
                    {
                        tempList.Add(figuresArray[i]);
                    }

                    tempList.RemoveAt(tempList.Count - 1);

                    figuresArray = tempList.ToArray();
                }
            }

            switch (lineStyle)
            {
                case "Solid":
                    dashStyle = DashStyle.Solid;
                    break;
                case "Dot":
                    dashStyle = DashStyle.Dot;
                    break;
                case "Dash":
                    dashStyle = DashStyle.Dash;
                    break;
                case "DashDot":
                    dashStyle = DashStyle.DashDot;
                    break;
                default:
                    dashStyle = DashStyle.Solid;
                    break;
            }

            int width = (x2 - x1) > 0 ? x2 - x1 : -(x2 - x1);
            int height = (y2 - y1) > 0 ? y2 - y1 : -(y2 - y1);
            int side = width > height ? height : width;
            switch (name)
            {
                case "Point":
                    figure = new Point(x1, y1);
                    break;
                case "Line":
                    figure = new Line(x1, y1, x2, y2);
                    break;
                case "TwoWayLine":
                    figure = new TwoWayLine(x1,y1,x2,y2);
                    break;
                case "Square":
                    figure = new Rectangle(x1, y1, (x2 - x1) > 0 ? side : -side, (y2 - y1) > 0 ? side : -side);
                    break;
                case "Fill Square":
                    figure = new FillRectangle(x1, y1, (x2 - x1) > 0 ? side : -side, (y2 - y1) > 0 ? side : -side);
                    break;
                case "Ellipse":
                    figure = new Ellipse(x1, y1, x2 - x1, y2 - y1);
                    break;
                case "Fill Ellipse":
                    figure = new FillEllipse(x1, y1, x2 - x1, y2 - y1);
                    break;
                case "Circle":
                    figure = new Ellipse(x1, y1, (x2 - x1) > 0 ? side : -side, (y2 - y1) > 0 ? side : -side);
                    break;
                case "Fill Circle":
                    figure = new FillEllipse(x1, y1, (x2 - x1) > 0 ? side : -side, (y2 - y1) > 0 ? side : -side);
                    break;
                case "Rectangle":
                    figure = new Rectangle(x1, y1, x2 - x1, y2 - y1);
                    break;
                case "Fill Rectangle":  
                    figure = new FillRectangle(x1, y1, x2 - x1, y2 - y1);
                    break;
                case "Triangle":
                    figure = new Triangle(x1, y1, x2, y2);
                    break;
                case "Fill Triangle":
                    figure = new FillTriangle(x1, y1, x2, y2);
                    break;
                case "Rhombus":
                    figure = new Rhombus(x1, y1, x2 - x1, y2 - y1);
                    break;
                case "Fill Rhombus":
                    figure = new FillRhombus(x1, y1, x2 - x1, y2 - y1);
                    break;
                case "CurveLine":
                    figure = new CurveLine(x1,y1) as CurveLine;
                    break;
                case "BazierLine":
                    figure = new BazierLine(x1,y1);
                    Point point = new Point(x1, y1, color);
                    point.Draw(g);
                    pic.Image = bmp;
                    break;
                default:
                    figure = new Point(x1, y1);
                    break;
            }

            if (figure is CurveLine curveLine)
            {
                curveLine.AddPoint(x1, y1);
                figure = curveLine;
            }

            figure.SetNewAttributes(color, dashStyle, lineThickness);

            Point[] tempArray = new Point[figuresArray.Length + 1];

            for (uint i = 0; i < tempArray.Length; i++)
            {
                if (i == figuresArray.Length)
                {
                    tempArray[i] = figure;
                }
                else
                {
                    tempArray[i] = figuresArray[i];
                }
            }

            figuresArray = tempArray;
            if (!(figure is BazierLine))
            {
                if (!(image is null))
                {
                    g.DrawImageUnscaledAndClipped(image, new System.Drawing.Rectangle(0, 0, bmp.Width, bmp.Height));
                }
                DrawAll();
            }

        }

        public void DeleteFigure()
        {
            List<Point> tempList = new List<Point>();

            for (int i = 0; i < figuresArray.Length; i++)
            {
                tempList.Add(figuresArray[i]);
            }

            tempList.RemoveAt((int)currentIndex - 1);

            figuresArray = tempList.ToArray();
            Previous();
        }

        public void SetNewAttributes(Color color, string lineStyle, float lineThickness)
        {
            DashStyle dashStyle = DashStyle.Solid;

            switch (lineStyle)
            {
                case "Solid":
                    dashStyle = DashStyle.Solid;
                    break;
                case "Dot":
                    dashStyle = DashStyle.Dot;
                    break;
                case "Dash":
                    dashStyle = DashStyle.Dash;
                    break;
                case "DashDot":
                    dashStyle = DashStyle.DashDot;
                    break;
                default:
                    dashStyle = DashStyle.Solid;
                    break;
            }

            figuresArray[currentIndex - 1].SetNewAttributes(color, dashStyle, lineThickness);
            g.Clear(pic.BackColor);
            figuresArray[currentIndex - 1].Draw(g);
            pic.Image = bmp;
  
        }

        public void SetNewPosition(int x, int y)
        {
            figuresArray[currentIndex - 1].SetNewPosition(x,y);
            if (!modifiedFiguresIndexes.Contains((int)currentIndex - 1))
            {
                modifiedFiguresIndexes.Add((int)currentIndex - 1);
            }

            g.Clear(pic.BackColor);
            figuresArray[currentIndex - 1].Draw(g);
            pic.Image = bmp;
        }

        public void AddPointToFigure(int x, int y)
        {
            if (figuresArray[figuresArray.Length - 1] is CurveLine curveLine)
            {
                curveLine.AddPoint(x, y);
                DrawAll();
            }    
            else if (figuresArray[figuresArray.Length - 1] is BazierLine bazierLine)
            {
                if (bazierLine.points.Count < 4)
                { 
                    bazierLine.AddPoint(x, y);
                    Point point = new Point(x, y, bazierLine.color);
                    point.Draw(g);
                    pic.Image = bmp;    
                }

                if (bazierLine.points.Count == 4)
                {
                    g.Clear(pic.BackColor);
                    if (!(image is null))
                    {
                        g.DrawImageUnscaledAndClipped(image, new System.Drawing.Rectangle(0, 0, bmp.Width, bmp.Height));
                    }
                    DrawAll();
                }
            }
            
        }

        public void ShowDrawing(string name, Color color, float lineThickness, string lineStyle, int x1, int y1, int x2, int y2)
        {
            switch (name)
            {
                case "Point":
                    return;
                case "CurveLine":
                    return;
                case "BazierLine":
                    return;
            }

            Point figure;

            DashStyle dashStyle = DashStyle.Solid;

            switch (lineStyle)
            {
                case "Solid":
                    dashStyle = DashStyle.Solid;
                    break;
                case "Dot":
                    dashStyle = DashStyle.Dot;
                    break;
                case "Dash":
                    dashStyle = DashStyle.Dash;
                    break;
                case "DashDot":
                    dashStyle = DashStyle.DashDot;
                    break;
                default:
                    dashStyle = DashStyle.Solid;
                    break;
            }

            int width = (x2 - x1) > 0 ? x2 - x1 : -(x2 - x1);
            int height = (y2 - y1) > 0 ? y2 - y1 : -(y2 - y1);
            int side = width > height ? height : width;

            switch (name)
            {
                case "Point":
                    figure = new Point(x1, y1);
                    break;
                case "Line":
                    figure = new Line(x1, y1, x2, y2);
                    break;
                case "TwoWayLine":
                    figure = new TwoWayLine(x1, y1, x2, y2);
                    break;
                case "Square":
                    figure = new Rectangle(x1, y1, (x2 - x1) > 0 ? side : -side, (y2 - y1) > 0 ? side : -side);
                    break;
                case "Fill Square":
                    figure = new FillRectangle(x1, y1, (x2 - x1) > 0 ? side : -side, (y2 - y1) > 0 ? side : -side);
                    break;
                case "Ellipse":
                    figure = new Ellipse(x1, y1, x2 - x1, y2 - y1);
                    break;
                case "Fill Ellipse":
                    figure = new FillEllipse(x1, y1, x2 - x1, y2 - y1);
                    break;
                case "Circle":
                    figure = new Ellipse(x1, y1, (x2 - x1) > 0 ? side : -side, (y2 - y1) > 0 ? side : -side);
                    break;
                case "Fill Circle":
                    figure = new FillEllipse(x1, y1, (x2 - x1) > 0 ? side : -side, (y2 - y1) > 0 ? side : -side);
                    break;
                case "Rectangle":
                    figure = new Rectangle(x1, y1, x2 - x1, y2 - y1);
                    break;
                case "Fill Rectangle":
                    figure = new FillRectangle(x1, y1, x2 - x1, y2 - y1);
                    break;
                case "Triangle":
                    figure = new Triangle(x1, y1, x2, y2);
                    break;
                case "Fill Triangle":
                    figure = new FillTriangle(x1, y1, x2, y2);
                    break;
                case "Rhombus":
                    figure = new Rhombus(x1, y1, x2 - x1, y2 - y1);
                    break;
                case "Fill Rhombus":
                    figure = new FillRhombus(x1, y1, x2 - x1, y2 - y1);
                    break;
                default:
                    figure = new Point(x1, y1);
                    break;
            }


            figure.SetNewAttributes(color, dashStyle, lineThickness);

            Bitmap tempBm = new Bitmap(pic.Width, pic.Height);
            Graphics tempG = Graphics.FromImage(tempBm);

            pic.BackgroundImage = bmp;

            figure.Draw(tempG);
            pic.Image = tempBm;
        }
    }
}
