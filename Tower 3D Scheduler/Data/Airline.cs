using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tower_3D_Scheduler.Data
{
	public class Airline
	{
		public String ICAO { get; set; }
		public String IATA { get; set; }
		public String CallSign { get; set; }
		public String AirlineName { get; set; }
		public String Country { get; set; }

		public Airline() { }
		public Airline (String strICAO, String strIATA, String strCallSign, String strAirlineName, String strCountry)
		{
			ICAO = strICAO;
			IATA = strIATA;
			CallSign = strCallSign;
			AirlineName = strAirlineName;
			Country = strCountry;
		}

		public Airline(String[] strAirlineData)
		{
			ICAO = strAirlineData[0];
			IATA = strAirlineData[1];
			CallSign = strAirlineData[2];
			AirlineName = strAirlineData[3];
			Country = strAirlineData[4];
		}
	}
}
