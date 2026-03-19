using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Ellipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var ellipse = sender as Ellipse;
            var transform = ellipse.RenderTransform as RotateTransform;
            if (transform != null)
            { }
            transform.Angle += 45;
        }
    }
}
