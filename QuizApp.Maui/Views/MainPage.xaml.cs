using QuizApp.Maui.ViewModels;

namespace QuizApp.Maui.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MainViewModel();
	}
}