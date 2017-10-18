using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		String m_strTower3DDirectory;

		public MainWindow()
		{
			InitializeComponent();
		}

		private void MenuItemOpen_Click(object sender, RoutedEventArgs e)
		{
			// TEMP REMOVAL

			//System.Windows.Forms.FolderBrowserDialog dlg = new System.Windows.Forms.FolderBrowserDialog();
			//System.Windows.Forms.DialogResult dr = dlg.ShowDialog();
			//if (dr == System.Windows.Forms.DialogResult.OK)
			//{
				//m_strTower3DDirectory = dlg.SelectedPath;
m_strTower3DDirectory = @"G:\Steam\steamapps\common\Tower 3D Pro";		
				LoadAirfields();
			//}
		}

		private void LoadAirfields()
		{
			m_mnuAirfields.Items.Clear();

			String strAirfieldDirectory = String.Format("{0}\\Extensions\\Airfields", m_strTower3DDirectory);
			String[] strAirfields = Directory.GetDirectories(strAirfieldDirectory);
			foreach (String strAirfield in strAirfields)
			{
				MenuItem mnuItem = new MenuItem();

				int iIndex = strAirfield.LastIndexOf('\\');
				if (iIndex <= 0)
				{
					mnuItem.Header = strAirfield;
				}
				else
				{
					mnuItem.Header = strAirfield.Substring(iIndex + 1);
				}

				mnuItem.Click += OnAirportMenuItem_Click;
				mnuItem.Tag = new AirfieldMenuData((String)mnuItem.Header, strAirfield);
				m_mnuAirfields.Items.Add(mnuItem);
			}
		}

		void OnAirportMenuItem_Click(object sender, RoutedEventArgs e)
		{
			MenuItem mnuItem = (MenuItem)sender;
			Console.WriteLine("{0} {1}", ((AirfieldMenuData)(mnuItem.Tag)).Name, ((AirfieldMenuData)(mnuItem.Tag)).Directory);
			LoadAirlines((AirfieldMenuData)(mnuItem.Tag));
		}

		private void LoadAirlines(AirfieldMenuData data)
		{
			m_ucAirlines.Airlines.Clear();

			String strFileName = String.Format("{0}\\{1}_airlines.txt", data.Directory, data.Name);
			StreamReader stream = File.OpenText(strFileName);
			String strLine;
			while((strLine = stream.ReadLine()) != null)
			{
				String[] strAirlineData = strLine.Split(',');
				if (strAirlineData.Length >= 5)
				{
					Airline airline = new Airline(strAirlineData);
					m_ucAirlines.Airlines.Add(airline);
				}
			}
		}
	}
}
