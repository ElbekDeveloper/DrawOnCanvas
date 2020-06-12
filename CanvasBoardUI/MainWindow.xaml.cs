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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CanvasBoardUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Brush CustomColor { get; set; }
        public int CustomWidth { get; set; }
        public int CustomHeight { get; set; }
        Random r = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CanvasBoard_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Draw(object sender, MouseButtonEventArgs e)
        {
            
                var leftBorder = Mouse.GetPosition(CanvasBoard).X - 25;
                var topBorder = Mouse.GetPosition(CanvasBoard).Y -25;
                CustomColor = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255), (byte)r.Next(1, 255), (byte)r.Next(1, 255)));
                CustomWidth = r.Next(30, 50);
                CustomWidth = r.Next(30, 50);

                Rectangle newRect = new Rectangle
                {
                    Width = 50,
                    Height = 50,
                    Fill = CustomColor,
                    Stroke = Brushes.Black,
                    StrokeThickness = 2
                };

                Canvas.SetLeft(newRect, leftBorder);
                Canvas.SetTop(newRect, topBorder);

                CanvasBoard.Children.Add(newRect);
            

        }

        private void Erase(object sender, MouseButtonEventArgs e)
        {
            if (e.OriginalSource is Rectangle)
            {
                CanvasBoard.Children.Remove((Rectangle)e.OriginalSource);

            }

        }
    }
}
