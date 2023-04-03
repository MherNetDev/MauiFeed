using MauiFeed.Resources.Pages;

namespace MauiFeed;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new ChoosePage();
	}
}
