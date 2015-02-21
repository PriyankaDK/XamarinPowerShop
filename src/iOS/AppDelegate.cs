﻿using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using Microsoft.IdentityModel.Clients.ActiveDirectory;

namespace XamarinPowerShop.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();

			//Init Active directory azure library !
			AdalInitializer.Initialize();

			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}
	}
}

