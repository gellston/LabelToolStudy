using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LabelTool.ViewModels
{
    public class MouseViewModel
    {

        #region Event 
        public event Action<Point>? LeftDownEvent;
        public event Action<Point>? LeftClickEvent = null;
        public event Action<Point>? LeftDragEvent = null;

        public event Action<Point>? RightDownEvent = null;
        public event Action<Point>? RightClickEvent = null;
        public event Action<Point>? RightDragEvent = null;

        public event Action<Point>? MiddleDownEvent = null;
        public event Action<Point>? MiddleClickEvent = null;
        public event Action<Point>? MiddleDragEvent = null;

        public event Action<Point>? MoveEvent = null;
        public event Action<Point>? EnterEvent = null;
        public event Action<Point>? LeaveEvent = null;

        public event Action<Point, bool>? WheelEvent = null;
        #endregion

        #region Public Functions
        public void RaiseLeftDown(Point pt) => this.LeftDownEvent?.Invoke(pt);
        public void RaiseLeftClick(Point pt) => this.LeftClickEvent?.Invoke(pt);
        public void RaiseLeftDrag(Point pt) => LeftDragEvent?.Invoke(pt);

        public void RaiseRightDown(Point pt) => RightDownEvent?.Invoke(pt);
        public void RaiseRightClick(Point pt) => RightClickEvent?.Invoke(pt);
        public void RaiseRightDrag(Point pt) => RightDragEvent?.Invoke(pt);

        public void RaiseMiddleDown(Point pt) => MiddleDownEvent?.Invoke(pt);
        public void RaiseMiddleClick(Point pt) => MiddleClickEvent?.Invoke(pt);
        public void RaiseMiddleDrag(Point pt) => MiddleDragEvent?.Invoke(pt);

        public void RaiseMove(Point pt) => MoveEvent?.Invoke(pt);
        public void RaiseEnter(Point pt) => EnterEvent?.Invoke(pt);
        public void RaiseLeave(Point pt) => LeaveEvent?.Invoke(pt);

        public void RaiseWheel(Point pt, bool isUp) => WheelEvent?.Invoke(pt, isUp);
        #endregion


    }
}
