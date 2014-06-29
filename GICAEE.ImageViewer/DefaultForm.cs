using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GICAEE.ImageViewer
{
    public partial class DefaultForm : Form
    {
        #region Construtores
        
        public DefaultForm()
        {
            this.InitializeComponent();
        }
        
        #endregion 

        #region Outros Métodos

        protected string FormatPoint(Point point)
        {
            return string.Format("X:{0}, Y:{1}", point.X, point.Y);
        }

        protected string FormatRectangle(RectangleF rect)
        {
            return string.Format("X:{0}, Y:{1}, W:{2}, H:{3}", (int)rect.X, (int)rect.Y, (int)rect.Width, (int)rect.Height);
        }

        #endregion
    }
}
