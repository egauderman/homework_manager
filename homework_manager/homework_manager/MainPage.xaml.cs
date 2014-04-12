using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using homework_manager.Resources;

namespace homework_manager
{
	public partial class MainPage : PhoneApplicationPage
	{
		private ApplicationBarIconButton _addButton;

		// Constructor
		public MainPage()
		{
			InitializeComponent();

			ApplicationBar = new ApplicationBar();

			_addButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/add.png", UriKind.Relative));
			_addButton.Text = "add task";
			ApplicationBar.Buttons.Add(_addButton);
			//ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem("rate & review");
			//ApplicationBar.MenuItems.Add(appBarMenuItem);

		}
	}
}