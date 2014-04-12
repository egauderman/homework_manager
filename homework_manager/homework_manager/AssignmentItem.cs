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
	}
}
