using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelTool.Models
{
    public class ShapeBrush : ShapeObject
    {
        #region Constructor
        public ShapeBrush()
        {
            this.ShapeType = ShapeType.Brush;
        }
        #endregion
    }
}
