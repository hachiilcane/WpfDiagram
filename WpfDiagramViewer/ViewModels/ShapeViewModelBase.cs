using System;
using System.Collections.Generic;
using System.Text;
using WpfDiagram.Core.Mvvm;

namespace WpfDiagramViewer.ViewModels
{
    public abstract class ShapeViewModelBase : ViewModelBase
    {
        private double _X;
        public double X
        {
            get { return _X; }
            set { SetProperty(ref _X, value); }
        }

        private double _Y;
        public double Y
        {
            get { return _Y; }
            set { SetProperty(ref _Y, value); }
        }

        private double _width;
        public double Width
        {
            get { return _width; }
            set { SetProperty(ref _width, value); }
        }

        private double _height;
        public double Height
        {
            get { return _height; }
            set { SetProperty(ref _height, value); }
        }

        private double _angle;
        public double Angle
        {
            get { return _angle; }
            set { SetProperty(ref _angle, value); }
        }
    }
}
