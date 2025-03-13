using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelTool.Models
{
    public class ShapePolygon : ShapeObject
    {
        #region Constructor
        public ShapePolygon()
        {
            this.ShapeType = ShapeType.Polygon;
        }
        #endregion
    }
}
