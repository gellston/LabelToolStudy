using ConvMVVM2.Core.MVVM;
using LabelTool.Models;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LabelTool.ViewModels
{
    public partial class CanvasViewModel : ViewModelBase
    {
        #region Private Property
        private ObservableCollection<ShapeObject> shapeObjects = new ObservableCollection<ShapeObject>();
        private SKPaint strokePaint;
        private SKPaint fillPaint;
        #endregion

        #region Constructor
        public CanvasViewModel(ObservableCollection<ShapeObject> objects)
        {
            this.shapeObjects.CollectionChanged += (sender, e) => this.OnPropertyChanged();


            this.strokePaint = new()
            {
                IsAntialias = true,
                StrokeWidth = 1,
                Style = SKPaintStyle.Stroke
            };

            this.fillPaint = new()
            {
                IsAntialias = true,
                StrokeWidth = 1,
                Style = SKPaintStyle.Fill,
                Color = SKColors.Blue,
                //TextSize = 20,
                //Typeface = SKFontManager.Default.MatchCharacter('가')
            };
        }


        #endregion

        #region Public Property
        public Size ActualSize { get; set; } = new Size();
        #endregion


        #region Public Functions
        public void PaintSurface(SKCanvas canvas)
        {
            canvas.Clear(SKColors.Red);

            foreach (var obj in shapeObjects)
            {
                switch (obj)
                {
                    case ShapePolygon polygon:

                        break;
                    case ShapeBrush brush:

                        break;
                    default:
                        break;
                }
            }
        }

        public void Refresh()
        {
            this.OnPropertyChanged("");
        }
        #endregion

    }
}
