using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Security.Policy;

namespace WindowsFormsApp13
{

    public partial class Form1 : Form
    {
        Emblem current; 
        public Color red = Color.FromArgb(255, 76, 76);
        public Color chosencolor = Color.FromArgb(217, 4, 41);

        List<Emblem> emblems = new List<Emblem>(); 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            this.DoubleBuffered = true;

            foreach (var emb in emblems)
            {
                if (emb.visible) 
                {
                    DrawFigure(emb,e.Graphics);

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                HideFigure(current);
                Invalidate(); 
                current = null;
            }
            else
            {
                MessageBox.Show("Ничего не выбрано");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                ShowFigure(current);

                
                Invalidate(); 

            }


            else
            {
                MessageBox.Show("Ничего не выбрано");
            }
        }

        private void createbutton_Click(object sender, EventArgs e) 
        {
            Pen pen = new Pen(red, 5);
            Emblem emblem = new Emblem(pen, 100, 100, 200, 200, 1f, 30);
            emblems.Add(emblem);

            if (current != null)
            {
                current.SetColor(red); 
                current.Pen = new Pen(red, 5);
                Invalidate();
            }

            currentObjectsComboBox.Items.Add(emblem); 
            current = emblem;
            current.Pen = new Pen(chosencolor, 5);
            Invalidate(); 
        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (current != null)
            {
                current.SetColor(red);
                current.Pen = new Pen(red, 5);
                Invalidate();
            }

            current = currentObjectsComboBox.SelectedItem as Emblem;

            if (current != null)
            {

                current.SetColor(chosencolor);
                current.Pen = new Pen(chosencolor, 5);
                Invalidate(); 
            }
            
        }




        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }


        public interface IFigure
        {
            void Draw(Graphics g);
            void Hide();
            void Show();

            void Move(int deltaX, int deltaY, GroupBox groupBoxRight, GroupBox groupBoxLeft, GroupBox groupBoxBottom);
            void ChangeAngle(int angle);
            void ChangeWidth(float width);
            void ChangeHeight(float height);

         



        }
        public void DrawFigure(IFigure figure, Graphics g)
        { 
            figure.Draw(g);
        }
        public void HideFigure(IFigure figure)
        {
            figure.Hide();
        }
        public void ShowFigure(IFigure figure)
        {
            figure.Show();
        }
        public void ChangeFigureWidth(IFigure figure,float width)
        {
            figure.ChangeWidth(width); 
        }


        public void ChangeFigureHeight(IFigure figure, float width)
        {
            figure.ChangeHeight(width);
        }


        public void MoveFigure(IFigure figure, int deltaX, int deltaY, GroupBox groupBoxRight, GroupBox groupBoxLeft, GroupBox groupBoxBottom)
        {
            figure.Move(deltaX,deltaY,groupBoxRight,groupBoxLeft,groupBoxBottom);
        }
        public void ChangeFigureAngle(IFigure figure, int RotationAngle)
        {
            figure.ChangeAngle(RotationAngle);

        }




        class Emblem : Figure,IFigure
        {

            public float Radius { get; private set; }
            public int RotationAngle { get; private set; }
            public static int IdCounter { get; private set; }
            public Color EmblemColor { get; set; }

            public Emblem(Pen pen, int x, int y, float width, float height, float radius, int rotationAngle)
                : base(pen, x, y, width, height, radius, rotationAngle)
            {
                this.Radius = radius;
                this.RotationAngle = rotationAngle;
                this.EmblemColor = pen.Color;
            }
            public void SetId()
            {
                IdCounter++;
            }
          

            public override void Draw(Graphics g)
            {
                if (!visible)
                    return;

                int centerX = (int)(x + width / 2);
                int centerY = (int)(y + height / 2);
                Radius = width / 2;

                g.TranslateTransform(centerX, centerY);
                g.RotateTransform(RotationAngle - 30, MatrixOrder.Prepend);

                Point[] trianglePoints =
                {
                    new Point((int)(Radius * Math.Cos(0)), (int)(Radius * Math.Sin(0))),
                    new Point((int)(Radius * Math.Cos(120 * Math.PI / 180)), (int)(Radius * Math.Sin(120 * Math.PI / 180))),
                    new Point((int)(Radius * Math.Cos(240 * Math.PI / 180)), (int)(Radius * Math.Sin(240 * Math.PI / 180)))
                };

                g.DrawEllipse(Pen, -width / 2, -height / 2, width, height);
                g.DrawRectangle(Pen, -width / 2, -height / 2, width, height);
                g.DrawPolygon(Pen, trianglePoints);

                g.ResetTransform();
            }
    
            public override string ToString()
            {
                this.SetId();
                return $"Эмблема {IdCounter}";
            }

            public void Move(int deltaX, int deltaY, GroupBox groupBoxRight, GroupBox groupBoxLeft, GroupBox groupBoxBottom)
            {
                if (y + deltaY + height > groupBoxBottom.Location.Y)
                {
                    y = groupBoxBottom.Location.Y - height;
                    return;
                }

                if (x + deltaX < groupBoxLeft.Location.X)
                {
                    x = groupBoxLeft.Location.X;
                    return;
                }

                if (x + deltaX + width <= groupBoxRight.Location.X)
                {
                    x += deltaX;
                    y = Math.Max(0, y + deltaY);
                }
                else
                {
                    x = groupBoxRight.Location.X - width;
                    y = Math.Max(0, y + deltaY);
                }
            }
            public void SetColor(Color color)
            {
                this.EmblemColor = color;  
            }

            public void ChangeAngle(int angle)
            { 
                this.RotationAngle += angle;
            }


        }


        abstract class Figure
        {
            public float x, y;

            public float width { get; private set; }
            public float height { get; private set; }
            public bool visible { get; private set; }
            public Pen Pen;

            public Figure(Pen pen, int x, int y, float width, float height, float radius, int rectangle)
            {
                this.x = x;
                this.y = y;
           
                Pen = pen;
                this.width = width;
                this.height = height;
         
        
                this.visible = true;
            }

            public void Hide()
            {
                this.visible = false;
            }

            public void Show()
            {
                this.visible = true;
            }
            public void ChangeWidth(float width)
            {
                
                    this.width += width;
                
            }
            public void ChangeHeight(float height)
            {
               
                    this.height += height;
                
            }



            public abstract void Draw(Graphics g);
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                MoveFigure(current, 0, -10, groupBox1, groupBox2, groupBox4);
               
                Invalidate();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                MoveFigure(current, 0, -50, groupBox1, groupBox2, groupBox4);
      
                Invalidate();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                MoveFigure(current, -10, 0, groupBox1, groupBox2, groupBox4);
                
                Invalidate();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                MoveFigure(current, -50, 0, groupBox1, groupBox2, groupBox4);
          
                Invalidate();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                MoveFigure(current, 0, 10, groupBox1, groupBox2, groupBox4);
        
                Invalidate();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                MoveFigure(current, 0, 50, groupBox1, groupBox2, groupBox4);
              
                Invalidate();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                ShowFigure(current);

                ChangeFigureHeight(current, -10);

                ChangeFigureWidth(current, -10);

       
                Invalidate();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                ShowFigure(current);
                ChangeFigureHeight(current, +10);

                ChangeFigureWidth(current, +10);
                Invalidate();
            }

        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                MoveFigure(current, 50, 0, groupBox1, groupBox2, groupBox4);
                Invalidate();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                MoveFigure(current,10, 0, groupBox1, groupBox2, groupBox4);
                Invalidate();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                
                ChangeFigureAngle(current, 30);
                Invalidate();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                ChangeFigureAngle(current, -30);


                Invalidate();
            }
        }
    }
}
