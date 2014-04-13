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
	public partial class CreateItem : PhoneApplicationPage
	{
		public CreateItem()
		{
			InitializeComponent();
		}

		#region App Bar handlers

		private void SaveButton_Click(object sender, EventArgs e)
		{
			(App.Current as App).AssignmentItems.Add(new AssignmentItem(NewTitleBox.Text));

			(App.Current as App).NewAssignmentItems = true;

			NavigationService.GoBack();
		}
		private void CancelButton_Click(object sender, EventArgs e)
		{
			NavigationService.GoBack();
		}

		#endregion
	}
}