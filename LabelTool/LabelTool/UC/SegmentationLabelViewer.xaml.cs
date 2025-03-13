using LabelTool.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LabelTool.UC
{
    /// <summary>
    /// SegmentationLabelViewer.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class SegmentationLabelViewer : UserControl
    {
        #region Constructor
        public SegmentationLabelViewer()
        {
            InitializeComponent();
        }
        #endregion

        #region Dependency Property
        public static DependencyProperty CanvasViewModelProperty = DependencyProperty.Register("CanvasViewModel", typeof(CanvasViewModel), typeof(SegmentationLabelViewer));
        public CanvasViewModel CanvasViewModel
        {
            get => (CanvasViewModel)GetValue(CanvasViewModelProperty); 
            set => SetValue(CanvasViewModelProperty, value);
        }
        #endregion
    }
}
