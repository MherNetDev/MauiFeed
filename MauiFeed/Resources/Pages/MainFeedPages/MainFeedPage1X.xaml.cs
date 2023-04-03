using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using X1_All_EVENTS;
using X1_FEED;
using System.Text;
using System.Security.Cryptography.X509Certificates;

namespace MauiFeed.Resources.Pages.MainFeedPages;

public partial class MainFeedPage1X : ContentPage
{
    public static int k=0;

    public MainFeedPage1X(string buttonPressed)
	{
        k++;
      
		InitializeComponent();
        somemain();
        async void somemain()
        {
            if (k==0) { 
            Program program = new Program();
            await program.X1_Caller(buttonPressed);
            }
            else
            {
                Navigation.PushModalAsync(new OddsPage1X());
            }
        }

        MainFeed1XLabel.Text = buttonPressed;
        
	}
        public void navigatetoother()
        {
            Navigation.PushModalAsync(new OddsPage1X());
        }

}



class Program
    {
        HttpClient client = new HttpClient();
        public static int[] C_Events_FBET = new int[10000];
        public static string[] C_ALL_FBET = new string[10000];
        public static string[] C_ALL_FBET_SubSports = new string[10000];
        public static int[] C_INDEX_FBET = new int[10000];
        public static int[] C_Events_Index = new int[10000];
        public static string[] C_FBET_SportName = new string[10000];

        public static double[] x1isxods = new double[8];
        public static double[] fonisxods = new double[9];

        public static bool doubleFlipper = true;
        public static string fbetcatch = "0";
        public static int fbetcatchhowmany = 0;
        public static int Choose_Fbet;
        public static int t = 0;
        public static int fbetsportsint = 0;
        public static int g = 2;
        public static int a = 0;
        public static int ChooseEvent;
        public static string Event_URL;
        public static string Event_URL_All;
        public static string someexp;
        public static int SportIntFbet;
        public static int BetChoose;
        public static int X1CSCHOOSER;
        public static string Choosed_Event_Teams;
        public static string id;


        //all
        public static int[] AllEventstest = new int[10000];


        public async Task X1_Caller(string buttonPressed)
        {
        Dictionary<int, string> dict = new Dictionary<int, string>()
{
    { 1, "football" },
    { 2, "Ice Hockey" },
    { 3, "Basketball" },
    { 4, "Tennis" },
    { 5, "Baseball" },
    { 6, "Volleyball" },
    { 7, "rugby" },
    { 8, "Handball" },
    { 9, "boks" },
    { 10, "Table Tennis" },
    { 11, "Chess" },
    { 13, "American Football" },
    { 14, "Futsal" },
    { 17, "Polo" },
    { 18, "Motorsport" },
    { 19, "Biathlon" },
    { 20, "TV-Games" },
    { 21, "Darts" },
    { 22, "Alpine Skiing" },
    { 23, "Ski Jumping" },
    { 24, "Skiing" },
    { 26, "Formula l" },
    { 28, "Australian Rulesl" },
    { 29, "Volleyball" },
    { 30, "Snooker" },
    { 40, "Esports" }
};
            var SportInt = dict.FirstOrDefault(x => x.Value == buttonPressed).Key;
            Program2 program2 = new Program2();
        MainFeedPage1X mainFeedPage1X = new MainFeedPage1X("asd");
         mainFeedPage1X.navigatetoother();
           // await program2.GetSportEventsLive(Convert.ToInt32( SportInt));

        }


}

