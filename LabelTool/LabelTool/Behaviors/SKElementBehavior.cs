using LabelTool.ViewModels;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Xaml.Behaviors;
using SkiaSharp.Views.WPF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LabelTool.Behaviors
{
    public class SKElementBehavior : Behavior<SKGLElement>
    {

        #region Protected Functions
        protected override void OnAttached()
        {
            base.OnAttached();
            this.AssociatedObject.PaintSurface += OnPaintSurface;
            this.AssociatedObject.SizeChanged += OnSizeChanged;
        }

        protected override void OnDetaching()
        {
            base.OnDetaching();
            this.AssociatedObject.PaintSurface -= OnPaintSurface;
            this.AssociatedObject.SizeChanged -= OnSizeChanged;

            if(this.CanvasViewModel != null) 
                this.CanvasViewModel.PropertyChanged -= OnViewModelUpdated;

        }
        #endregion

        #region Dependency Property
        public static DependencyProperty CanvasViewModelProperty = DependencyProperty.Register("CanvasViewModel", typeof(CanvasViewModel), typeof(SKElementBehavior), new PropertyMetadata(OnCanvasChanged));
        public CanvasViewModel CanvasViewModel
        {
            get => (CanvasViewModel)GetValue(CanvasViewModelProperty);
            set => SetValue(CanvasViewModelProperty, value);
        }
        #endregion

        #region Event Handler
        private void OnPaintSurface(object? sender, SkiaSharp.Views.Desktop.SKPaintGLSurfaceEventArgs e)
        {
            if(this.CanvasViewModel == null) return;
            this.CanvasViewModel.PaintSurface(e.Surface.Canvas);
        }

        private void OnSizeChanged(object sender, System.Windows.SizeChangedEventArgs e)
        {

            if(this.CanvasViewModel == null) return;
            this.CanvasViewModel.ActualSize = e.NewSize;
        }

        private static void OnCanvasChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var behavior = d as SKElementBehavior;
            if (behavior == null) return;


            var oldCanvas = e.OldValue as CanvasViewModel;
            var newCanvas = e.NewValue as CanvasViewModel;


            if (oldCanvas != null) oldCanvas.PropertyChanged -= behavior.OnViewModelUpdated;
            if (newCanvas != null) newCanvas.PropertyChanged += behavior.OnViewModelUpdated;
        }

        private void OnViewModelUpdated(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            this.AssociatedObject?.InvalidateVisual();
        }
        #endregion


    }
}
