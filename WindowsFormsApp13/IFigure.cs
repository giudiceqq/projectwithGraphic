using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp13
{
    public interface IFigure
    {
        void Draw(Graphics g);
        void Hide();
        void Show();
        void Move(int deltaX, int deltaY, System.Windows.Forms.GroupBox groupBoxRight, System.Windows.Forms.GroupBox groupBoxLeft, System.Windows.Forms.GroupBox groupBoxBottom);
        void ChangeAngle(int angle);
        void ChangeWidth(float width);
        void ChangeHeight(float height);

    }
}
