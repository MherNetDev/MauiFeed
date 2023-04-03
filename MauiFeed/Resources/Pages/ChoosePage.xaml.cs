using HtmlAgilityPack;
using Microsoft.VisualBasic;
using System;
using System.Net.Http;

namespace MauiFeed.Resources.Pages;

public partial class ChoosePage : ContentPage
{
	public ChoosePage()
	{
		InitializeComponent();
         Main2();
           async void Main2()
           {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync("https://www.google.com");
            var responseContent = await response.Content.ReadAsStringAsync();
            var document = new HtmlDocument();
            document.LoadHtml(responseContent);
            var searchBoxElement = document.DocumentNode.SelectSingleNode("//input[@name='q']");
            var searchText = searchBoxElement.GetAttributeValue("value", "");
            ChooseLabel.Text = searchText.ToString();
            await Task.Delay(2000);
            ChooseLabel.Text = "NaN";
            await Task.Delay(2000);
            ChooseLabel.Text = DateAndTime.Today.ToString();


        }

    }
   

    private void Button1X_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new BetPage1X());
    }

    private void ButtonFonBet_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new BetPageFonBet());

    }

    private void ButtonDafaBet_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new BetPageDafaBet());

    }
}