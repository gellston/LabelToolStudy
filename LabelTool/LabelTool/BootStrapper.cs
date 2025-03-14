using ConvMVVM2.Core.MVVM;
using LabelTool.Models;
using LabelTool.ViewModels;
using LabelTool.Views;
using LabelTool.Windows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelTool
{
    public class BootStrapper : AppBootstrapper
    {
        protected override void OnStartUp(IServiceContainer container)
        {

        }

        protected override void RegionMapping(IRegionManager layerManager)
        {
            layerManager.Mapping<MainView>("MainView");
        }

        protected override void RegisterModules()
        {

        }

        protected override void RegisterServices(IServiceCollection serviceCollection)
        {
            #region Windows
            serviceCollection.AddSingleton<MainWindow>();
            #endregion


            #region ViewModels
            serviceCollection.AddSingleton<MainViewModel>();
            serviceCollection.AddInstance<CanvasViewModel>();
            serviceCollection.AddSingleton<Func<ObservableCollection<ShapeObject>, CanvasViewModel>>((container) =>
            {
                return (collection) => new CanvasViewModel(collection);
            });

            serviceCollection.AddSingleton<Func<MouseViewModel>>((container) =>
            {
                return () => new MouseViewModel();
            });
            #endregion


            #region Views
            serviceCollection.AddSingleton<MainView>();
            #endregion
        }

        protected override void ViewModelMapping(IViewModelMapper viewModelMapper)
        {

        }
    }
}
