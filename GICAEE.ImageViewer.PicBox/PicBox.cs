using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace GICAEE.ImageViewer
{
    [DefaultProperty("Image")]
    [ToolboxBitmap(typeof(PicBox), "PicBox.bmp")]
    [ToolboxItem(true)]
	
	static class Constantes{
        private const int MaxZoom = 3000;
		private const int MinZoom = 1;
    }
    
		public class PicBox
		{
		}
	}
}
