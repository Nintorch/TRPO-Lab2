using System.ComponentModel;
using System.Runtime.CompilerServices;

using TRPO_Lab3.Lib;

namespace TRPO_Lab3.Wpf
{
    public class CalculateAreaViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private double _radius, _height, _area;

        public double Radius
        {
            get => _radius;
            set
            {
                _radius = value;
                OnPropertyChanged();
                UpdateArea();
            }
        }
        public double Height
        {
            get => _height;
            set
            {
                _height = value;
                OnPropertyChanged();
                UpdateArea();
            }
        }

        public double Area
        {
            get => _area;
            set
            {
                _area = value;
                OnPropertyChanged(nameof(Area));
            }
        }

        private void UpdateArea()
        {
            Area = CalculateArea.CalculateConeArea(Radius, Height);
        }
    }
}
