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
		private ApplicationBarIconButton _removeCompletedButton;

		public MainPage()
		{
			InitializeComponent();

			AssignmentItemsItemsControl.DataContext = (App.Current as App).AssignmentItems;

			#region App Bar initialization
			{
				ApplicationBar = new ApplicationBar();

				_addButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/add.png", UriKind.Relative));
				_addButton.Text = "add";
				ApplicationBar.Buttons.Add(_addButton);
				_addButton.Click += _addButton_Click;

				_removeCompletedButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/check.png", UriKind.Relative));
				_removeCompletedButton.Text = "complete";
				ApplicationBar.Buttons.Add(_removeCompletedButton);
				_removeCompletedButton.Click += _removeCompletedButton_Click;
			}
			#endregion
		}

		#region App Bar click handlers
		void _addButton_Click(object sender, EventArgs e)
		{
			(App.Current as App).AssignmentItems.Add(new AssignmentItem());

			// Big-time hack to scroll to the bottom:
			AssignmentItemsScrollViewer.UpdateLayout(); // (required)
			AssignmentItemsScrollViewer.ScrollToVerticalOffset(double.MaxValue);
		}

		void _removeCompletedButton_Click(object sender, EventArgs e)
		{
			Collection<AssignmentItem> removeThese = new Collection<AssignmentItem>();

			foreach (AssignmentItem i in (App.Current as App).AssignmentItems)
			{
				if (i.Checked)
				{
					removeThese.Add(i);
				}
			}

			foreach (AssignmentItem i in removeThese)
			{
				(App.Current as App).CompletedAssignmentItems.Add(i);
				(App.Current as App).AssignmentItems.Remove(i);
			}
		}
		#endregion
	}
}