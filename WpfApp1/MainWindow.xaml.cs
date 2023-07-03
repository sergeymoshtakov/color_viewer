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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ViewModel viewModel;
        public MainWindow()
        {
            InitializeComponent();
            viewModel = new ViewModel();
            this.DataContext = viewModel;
            UpdateColor();
        }

        private void Slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            viewModel = (ViewModel)this.DataContext;
            if (viewModel != null)
            {
                viewModel.Alpha = (int)e.NewValue;
                UpdateColor();
            }
        }
        private void Slider2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            viewModel = (ViewModel)this.DataContext;
            if (viewModel != null)
            {
                viewModel.Red = (int)e.NewValue;
                UpdateColor();
            }
        }
        private void Slider3_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            viewModel = (ViewModel)this.DataContext;
            if (viewModel != null)
            {
                viewModel.Green = (int)e.NewValue;
                UpdateColor();
            }
        }
        private void Slider4_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            viewModel = (ViewModel)this.DataContext;
            if (viewModel != null)
            {
                viewModel.Blue = (int)e.NewValue;
                UpdateColor();
            }
        }

        private void UpdateColor()
        {
            if (viewModel != null)
            {
                viewModel.Color = Color.FromArgb((byte)viewModel.Alpha, (byte)viewModel.Red, (byte)viewModel.Green, (byte)viewModel.Blue);
            }
        }

    }
}
