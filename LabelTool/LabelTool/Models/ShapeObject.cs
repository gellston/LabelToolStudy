using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace LabelTool.Models
{
    public class ShapeObject
    {
        #region Public Proprty
        public string LabelName { get; set; } = "";
        public ShapeType ShapeType {get;set;}
        #endregion
    }
}
