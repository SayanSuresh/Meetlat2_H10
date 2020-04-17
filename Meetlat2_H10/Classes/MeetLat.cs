using System;
using System.Collections.Generic;
using System.Text;

namespace MeetLat.classes
{
    class MeteLat
    {
		private double lengte;
		public MeteLat(double meter)
		{
			lengte = meter;
		}
		public double BeginWaarde
		{
			set { lengte = value; }
		}
		public double LengteInM 
		{
			get { return lengte; }
		}
		public double LengteInCm
		{
			get { return lengte * 100; }
		}
		public double LengteInKm
		{
			get { return lengte / 1000; }
		}
		public	double LengteInFeet
		{
			get { return lengte * 3.2808; }
		}
	}
}
