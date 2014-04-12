using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel; // for INotifyPropertyChanged

namespace homework_manager
{
	public class AssignmentItem : INotifyPropertyChanged
	{
		private string _title;
		public string Title
		{
			get { return _title; }
			set
			{
				_title = value;
				NotifyPropertyChanged("Title");
			}
		}

		private bool _checked;
		public bool Checked
		{
			get { return _checked; }
			set
			{
				_checked = value;
				NotifyPropertyChanged("Checked");
			}
		}



		// Constructors:
		public AssignmentItem()
		{
			Title = "";
			Checked = false;
		}
		public AssignmentItem(string title)
		{
			Title = title;
			Checked = false;
		}
		// Copy constructor
		public AssignmentItem(AssignmentItem other)
		{
			Title = other.Title;
			Checked = other.Checked;
		}



		#region Property Changed
		public event PropertyChangedEventHandler PropertyChanged;
		private void NotifyPropertyChanged(string propName)
		{
			if (PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs(propName));
		}
		#endregion
	}
}
