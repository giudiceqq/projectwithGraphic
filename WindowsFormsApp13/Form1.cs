using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

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
                    DrawFigure(emb, e.Graphics);
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
            emblem.SetForm(this);
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

        public void ChangeFigureWidth(IFigure figure, float width)
        {
            figure.ChangeWidth(width);
        }

        public void ChangeFigureHeight(IFigure figure, float height)
        {
            figure.ChangeHeight(height);
        }

        public void MoveFigure(IFigure figure, int deltaX, int deltaY, GroupBox groupBoxRight, GroupBox groupBoxLeft, GroupBox groupBoxBottom)
        {
            figure.Move(deltaX, deltaY, groupBoxRight, groupBoxLeft, groupBoxBottom);
        }

        public void ChangeFigureAngle(IFigure figure, int rotationAngle)
        {
            figure.ChangeAngle(rotationAngle);
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
                ChangeFigureHeight(current, 10);
                ChangeFigureWidth(current, 10);
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
                MoveFigure(current, 10, 0, groupBox1, groupBox2, groupBox4);
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
