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

namespace WPFShapeCanvas
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

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            PlayCanvas.Children.Clear();
        }

        private Shape GetRandomShape()
        {
            Random random = new Random();
            Shape shape = random.Next(2) == 1 ? new Rectangle() : new Ellipse();
            shape.Width = random.Next(25, 75);
            shape.Height = random.Next(25, 75);
            
            return shape;
        }

        private SolidColorBrush GetRandomColor()
        {
            Random random = new Random();
            byte Red = (byte)random.Next(0, 256);
            byte Green = (byte)random.Next(0, 256);
            byte Blue = (byte)random.Next(0, 256);
            byte Alpha = 255;

            Color c = new Color();
            c.R = Red;
            c.G = Green;
            c.B = Blue;
            c.A = Alpha;

            return new SolidColorBrush(c);
        }
    }
}
