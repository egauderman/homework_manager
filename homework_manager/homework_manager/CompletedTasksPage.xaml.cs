using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace homework_manager
{
	public partial class CompletedTasksPage : PhoneApplicationPage
	{
		public CompletedTasksPage()
		{
			InitializeComponent();

			CompletedItemsItemsControl.DataContext = (App.Current as App).CompletedAssignmentItems;
		}
	}
}