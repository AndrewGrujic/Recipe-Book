using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RecipeBook {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		List<Recipe> recipeList = new List<Recipe>();
		public MainWindow() {
			InitializeComponent();
		}

		private void AddRecipeButton_Click(object sender, RoutedEventArgs e) {
			recipeList.Add(new Recipe { recipeName = "New Recipe" });
			RecipeListBox.Items.Add(recipeList[recipeList.Count - 1].recipeName);
			RecipeListBox.SelectedIndex = RecipeListBox.Items.Count - 1;
		}

		private void RecipeListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e) {
		}

		private void RecipeListBox_MouseDown(object sender, MouseButtonEventArgs e) {

		}
	}
}