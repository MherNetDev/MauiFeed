using MauiFeed.Resources.Pages.MainFeedPages;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Shapes;

namespace MauiFeed.Resources.Pages;

public partial class BetPage1X : ContentPage
{
	public BetPage1X()
	{
		InitializeComponent();
		labelworker();

        foreach (View view in ButtonStackLayout.Children)
        {
            if (view is Button button)
            {
                button.Clicked += Button_Clicked;
            }
        }

    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        Button clickedButton = (Button)sender;
        string some = clickedButton.X.ToString();
        string buttonName = clickedButton.Text;
        LabelFeed1X.Text = "You clicked the " + buttonName + " button.";
        await Navigation.PushModalAsync(new MainFeedPage1X(buttonName));

    }

    private async void BackButton1X_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopModalAsync();
    }
	public void labelworker() {
		LabelFeed1X.Text = "Choose Sport";
                 
    }            
}

