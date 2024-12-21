using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp13
{
    public abstract class Figure
    { 
         public float x, y;

        public float width { get; protected set; }
        public float height { get; protected set; }

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
}
