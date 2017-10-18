using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tower_3D_Scheduler.Data
{
	public class AirfieldMenuData
	{
		public String Name { get; set; }
		public String Directory { get; set; }

		public AirfieldMenuData(String strName, String strDirectory)
		{
			Name = strName;
			Directory = strDirectory;
		}
	}
}
