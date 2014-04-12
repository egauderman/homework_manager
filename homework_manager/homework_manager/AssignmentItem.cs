using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_manager
{
	class AssignmentItem
	{
		public string Title { get; set; }
		public bool Checked { get; set; }

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
	}
}
