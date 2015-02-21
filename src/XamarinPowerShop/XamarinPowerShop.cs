﻿using System;

using Xamarin.Forms;
using PowerBI.Api.Client;
using PowerBI.Api.Client.Configuration;

namespace XamarinPowerShop
{
	public class App : Application
	{
		public App()
		{
			PowerBIClient.Intialize(
				new Api 
				{
					Url = "https://api.powerbi.com/beta/myorg/datasets"
				}, 
					new OAuth 
				{ 
					Authority = "https://login.windows.net/common/oauth2/authorize",
					Resource = "https://analysis.windows.net/powerbi/api",
					Client = "MyClientId",
					User = "MyUser",
					Password ="MyPassword"
				}
			);
			// The root page of your application
			MainPage = new RootPage();
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}

