using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace л3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const double MaxOpacity = 0.8;
        private const double MinOpacity = 0.1;

        public MainWindow()
        {
            InitializeComponent();

            var gradient = new RadialGradientBrush(Colors.Red, Colors.Yellow);
            gradient.GradientOrigin = new Point(0.5, 0.5);
            gradient.RadiusX = 0.8;
            gradient.RadiusY = 0.8;

            circle.Fill = gradient;

            var animation = new DoubleAnimation
            {
                From = MinOpacity,
                To = MaxOpacity,
                Duration = new Duration(TimeSpan.FromSeconds(1)),
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };

            circle.BeginAnimation(Ellipse.OpacityProperty, animation);
        }
    }
}
