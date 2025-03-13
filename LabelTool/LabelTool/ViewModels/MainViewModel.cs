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
        #endregion

        #region Constructor
        public MainViewModel(Func<ObservableCollection<ShapeObject>, CanvasViewModel> canvasFactory)
        {
            this.canvasFactory = canvasFactory;
        }
        #endregion

        #region Public Property

        #endregion

        #region Collection
        [Property]
        private UpdateObservableCollection<ShapeObject> _ShapeObjectCollection = new UpdateObservableCollection<ShapeObject>();

        [Property]
        private CanvasViewModel _CanvasViewModel = null;
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

        }

        #endregion
    }
}
