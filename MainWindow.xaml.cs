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

namespace WpfDrop
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void BtnSuga(object sender, MouseButtonEventArgs e)
        {
            AnimaSuga();
            await Task.Delay(1500);

            Storyboard sb = (Storyboard)this.Resources["arcMoloko"]; 
            sb.Begin();
            sb = (Storyboard)this.Resources["arcMoloko2"];
            sb.Begin();
            sb = (Storyboard)this.Resources["arcMoloko3"];
            sb.Begin();
            sb = (Storyboard)this.Resources["arcMoloko4"];
            sb.Begin();
            sb = (Storyboard)this.Resources["arcMoloko5"];
            sb.Begin();
            sb = (Storyboard)this.Resources["arcMoloko6"];
            sb.Begin();
            sb = (Storyboard)this.Resources["arcMoloko7"];
            sb.Begin();
            sb = (Storyboard)this.Resources["arcMoloko8"];
            sb.Begin();
            sb = (Storyboard)this.Resources["arcMoloko9"];
            sb.Begin();
            sb = (Storyboard)this.Resources["arcMoloko10"];
            sb.Begin();
            sb = (Storyboard)this.Resources["arcMoloko12"];
            sb.Begin();
            sb = (Storyboard)this.Resources["arcMoloko13"];
            sb.Begin();
            sb = (Storyboard)this.Resources["arcMoloko14"];
            sb.Begin();
            sb = (Storyboard)this.Resources["arcMoloko15"];
            sb.Begin();
            sb = (Storyboard)this.Resources["arcMoloko16"];
            sb.Begin();
            sb = (Storyboard)this.Resources["arcMoloko17"];
            sb.Begin();
            sb = (Storyboard)this.Resources["arcMoloko18"];
            sb.Begin();
            sb = (Storyboard)this.Resources["arcMoloko19"];
            sb.Begin();
            sb = (Storyboard)this.Resources["arcMoloko20"];
            sb.Begin();
        }
        
       

        public void AnimaSuga()
        {
            DoubleAnimation animSuga = new DoubleAnimation();
            animSuga.By = 300;
            animSuga.Duration = TimeSpan.FromMilliseconds(1800);
            animSuga.AccelerationRatio = 0.5;

            Storyboard.SetTarget(animSuga, recSuga);
            Storyboard.SetTargetProperty(animSuga, new PropertyPath("(Canvas.Top)"));

            RotateTransform rotateTransform = new RotateTransform();
            recSuga.RenderTransform = rotateTransform;
            recSuga.RenderTransformOrigin = new Point(0.5, 0.5); // Установка центра вращения

            DoubleAnimation animRotate = new DoubleAnimation();
            animRotate.From = 0;
            animRotate.To = 360;
            animRotate.Duration = TimeSpan.FromMilliseconds(1800);
            animRotate.AccelerationRatio = 0.5;

            Storyboard.SetTarget(animRotate, recSuga);
            Storyboard.SetTargetProperty(animRotate, new PropertyPath("RenderTransform.Angle"));

            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(animSuga);
            storyboard.Children.Add(animRotate);
            storyboard.Begin(this);
        }
    }
}
