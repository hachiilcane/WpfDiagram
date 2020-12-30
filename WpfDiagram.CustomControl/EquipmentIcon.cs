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

namespace WpfDiagram.CustomControl
{
    /// <summary>
    /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
    ///
    /// Step 1a) Using this custom control in a XAML file that exists in the current project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:WpfDiagram.CustomControl"
    ///
    ///
    /// Step 1b) Using this custom control in a XAML file that exists in a different project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:WpfDiagram.CustomControl;assembly=WpfDiagram.CustomControl"
    ///
    /// You will also need to add a project reference from the project where the XAML file lives
    /// to this project and Rebuild to avoid compilation errors:
    ///
    ///     Right click on the target project in the Solution Explorer and
    ///     "Add Reference"->"Projects"->[Select this project]
    ///
    ///
    /// Step 2)
    /// Go ahead and use your control in the XAML file.
    ///
    ///     <MyNamespace:EquipmentIcon/>
    ///
    /// </summary>
    public class EquipmentIcon : Control
    {
        static EquipmentIcon()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(EquipmentIcon), new FrameworkPropertyMetadata(typeof(EquipmentIcon)));
        }

        public string Kind
        {
            get { return (string)GetValue(KindProperty); }
            set { SetValue(KindProperty, value); }
        }

        public static readonly DependencyProperty KindProperty =
            DependencyProperty.Register(nameof(Kind), typeof(string), typeof(EquipmentIcon),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.None, KindPropertyChangedCallback));

        private static void KindPropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((EquipmentIcon)d).UpdateData();
        }

        public PathGeometry Data
        {
            get { return (PathGeometry)GetValue(DataProperty); }
            private set { SetValue(DataPropertyKey, value); }
        }

        private static readonly DependencyPropertyKey DataPropertyKey =
            DependencyProperty.RegisterReadOnly(nameof(Data), typeof(PathGeometry), typeof(EquipmentIcon),
                new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));

        public static readonly DependencyProperty DataProperty = DataPropertyKey.DependencyProperty;

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            UpdateData();
        }

        private void UpdateData()
        {
            Data = EquipmentIconDataFactory.CreateGeometry(Kind);
        }

        public Brush Fill
        {
            get { return (Brush)GetValue(FillProperty); }
            set { SetValue(FillProperty, value); }
        }
        private static readonly Brush _defaultFill = Brushes.White;

        public static readonly DependencyProperty FillProperty =
            DependencyProperty.Register(nameof(Fill), typeof(Brush), typeof(EquipmentIcon),
                new FrameworkPropertyMetadata(_defaultFill, FrameworkPropertyMetadataOptions.AffectsRender));
    }
}
