using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Tower_3D_Scheduler.Data;

namespace Tower_3D_Scheduler
{
	/// <summary>
	/// Interaction logic for ucAirlines.xaml
	/// </summary>
	public partial class ucAirlines : UserControl
	{
		public ObservableCollection<Airline> Airlines { get; set; }

		public ucAirlines()
		{
			Airlines = new ObservableCollection<Airline>();
			Airlines.Add(new Airline("1", "2", "3", "4", "5"));
			Airlines.Add(new Airline("1", "2", "3", "4", "5"));
			Airlines.Add(new Airline("1", "2", "3", "4", "5"));
			Airlines.Add(new Airline("1", "2", "3", "4", "5"));
			Airlines.Add(new Airline("1", "2", "3", "4", "5"));
			Airlines.Add(new Airline("1", "2", "3", "4", "5"));

			InitializeComponent();
		}
	}
}
