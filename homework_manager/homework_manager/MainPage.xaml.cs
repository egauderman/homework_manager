using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Collections.ObjectModel; // for ObservableCollection<T>

namespace homework_manager
{
	public partial class MainPage : PhoneApplicationPage
	{
		private ApplicationBarIconButton _addButton;

		public MainPage()
		{
			InitializeComponent();

			AssignmentItemsItemsControl.DataContext = (App.Current as App).AssignmentItems;

			#region ApplicationBar
			{
				ApplicationBar = new ApplicationBar();

				_addButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/add.png", UriKind.Relative));
				_addButton.Text = "add task";
				ApplicationBar.Buttons.Add(_addButton);
				_addButton.Click += _addButton_Click;
			}
			#endregion ApplicationBar
		}

		void _addButton_Click(object sender, EventArgs e)
		{
			(App.Current as App).AssignmentItems.Add(new AssignmentItem());

			// Big-time hack to scroll to the bottom:
			AssignmentItemsScrollViewer.UpdateLayout(); // (required)
			AssignmentItemsScrollViewer.ScrollToVerticalOffset(double.MaxValue);
		}
	}
}