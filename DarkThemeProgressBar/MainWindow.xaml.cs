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

namespace DarkThemeProgressBar
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

		private void StartAnimationClicked(object sender, RoutedEventArgs e)
		{
			DoubleAnimation animation = new DoubleAnimation();
			animation.Completed += new EventHandler(AnimationCompleted);

			animation.From = loadRectangle.ActualWidth;
			animation.To = mainGrid.ColumnDefinitions.ElementAt(1).ActualWidth;
			animation.Duration = TimeSpan.FromSeconds(5);

			loadRectangle.BeginAnimation(Rectangle.WidthProperty, animation);
		}
		private void AnimationCompleted(object sender, EventArgs e)
		{
			MessageBox.Show("Анимация завершена!");
		}
	}
}
