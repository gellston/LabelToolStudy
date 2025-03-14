using ConvMVVM2.Core.Attributes;
using ConvMVVM2.Core.MVVM;
using LabelTool.Collection;
using LabelTool.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelTool.ViewModels
{
    public partial class MainViewModel : ViewModelBase, IServiceInitializable
    {

        #region Private Property
        private readonly Func<ObservableCollection<ShapeObject>, CanvasViewModel> canvasFactory;
        private readonly Func<MouseViewModel> mouseFactory;
        #endregion

        #region Constructor
        public MainViewModel(Func<ObservableCollection<ShapeObject>, CanvasViewModel> canvasFactory, Func<MouseViewModel> mouseFactory)
        {
            this.canvasFactory = canvasFactory;
            this.mouseFactory = mouseFactory;
          
        }
        #endregion

        #region Public Property

        #endregion

        #region Collection
        [Property]
        private UpdateObservableCollection<ShapeObject> _ShapeObjectCollection = new UpdateObservableCollection<ShapeObject>();

        [Property]
        private CanvasViewModel _CanvasViewModel = null;

        [Property]
        private MouseViewModel _MouseViewModel = null;
        #endregion

        #region Command
        [RelayCommand]
        private void Polygon()
        {
            try
            {

            }
            catch
            {

            }

        }

        [RelayCommand]
        private void Brush()
        {
            try
            {

            }
            catch
            {

            }

        }


        [RelayCommand]
        private void Cursor()
        {
            try
            {

            }
            catch
            {

            }

        }



        [RelayCommand]
        private void Erase()
        {
            try
            {

            }
            catch
            {

            }

        }


        #endregion

        #region Event Handler
        public void OnServiceInitialized()
        {

            this.CanvasViewModel = this.canvasFactory(this.ShapeObjectCollection);
            this.MouseViewModel = this.mouseFactory();


            this.MouseViewModel.LeftClickEvent += LeftClickEvent;
            this.MouseViewModel.MoveEvent += MoveEvent;
            this.MouseViewModel.RightClickEvent += RightClickEvent;

            this.MouseViewModel.MiddleClickEvent += PanStartEvent;
            this.MouseViewModel.WheelEvent += WheelEvent;
            this.MouseViewModel.MiddleDragEvent += MiddleDragEvent;
        }

        private void MiddleDragEvent(System.Windows.Point point)
        {

            //Refresh drawing
            this.CanvasViewModel.Refresh();
        }

        private void WheelEvent(System.Windows.Point point, bool isUpWheel)
        {

        }

        private void PanStartEvent(System.Windows.Point point)
        {
         
            
            //Refresh drawing
            this.CanvasViewModel.Refresh();
        }

        private void RightClickEvent(System.Windows.Point point)
        {
   
        }

        private void MoveEvent(System.Windows.Point point)
        {
         
        }

        private void LeftClickEvent(System.Windows.Point point)
        {
           
        }

        #endregion
    }
}
