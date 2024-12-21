using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    internal class Emblem : Figure, IFigure
    {
        public float Radius { get; private set; }
        public int RotationAngle { get; private set; }
        public static int IdCounter { get; private set; }
        public Color EmblemColor { get; set; }
        private Form parentForm;

        public Emblem(Pen pen, int x, int y, float width, float height, float radius, int rotationAngle)
            : base(pen, x, y, width, height, radius, rotationAngle)
        {
            this.Radius = radius;
            this.RotationAngle = rotationAngle;
            this.EmblemColor = pen.Color;
        }

        public void SetForm(Form form)
        {
            this.parentForm = form;
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

        public void Move(int deltaX, int deltaY, System.Windows.Forms.GroupBox groupBoxRight, System.Windows.Forms.GroupBox groupBoxLeft, System.Windows.Forms.GroupBox groupBoxBottom)
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

        public void ChangeAngle(int angle)
        {
            this.RotationAngle += angle;
        }

        public void ChangeWidth(float width)
        {
            this.width += width;
        }

        public void ChangeHeight(float height)
        {
            this.height += height;
        }

        public void SetColor(Color color)
        {
            this.EmblemColor = color;
            this.Pen = new Pen(color, this.Pen.Width); 
        }


    }
}
