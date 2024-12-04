using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Drawing;


namespace MyPaint
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private System.Windows.Point currentPoint;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void Canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                currentPoint = e.GetPosition(this);
            }
        }

        private void Canvas_MouseMove(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                // Create a new Line object
                Line line = new Line();

                // Set the stroke (color) of the line
                line.Stroke = Brushes.Black;  // Set to your desired color (e.g., Brushes.Red, Brushes.Blue, etc.)

                // Set the start position of the line (current point)
                line.X1 = currentPoint.X;
                line.Y1 = currentPoint.Y;

                // Set the end position of the line (current mouse position)
                line.X2 = e.GetPosition(this).X;
                line.Y2 = e.GetPosition(this).Y;

                // Update the current point to the new position
                currentPoint = e.GetPosition(this);

                // Add the line to the canvas (or your painting surface)
                Canvas.Children.Add(line);
                Canvas.UpdateLayout();
            }
        }


        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged_2(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}