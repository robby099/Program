/*
 * Created by SharpDevelop.
 * User: G2TC
 * Date: 7/17/2017
 * Time: 8:01 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Text;

using System.Windows.Forms;

using GMap.NET;
namespace IRSKY_NEW
{
	/// <summary>
	/// Description of Functions.
	/// </summary>
	public class Functions
	{
	    const double RADIUS = 6371300; // Radius bumi dalam Meter
	
	    /// <summary>
	    /// Convert degrees to Radians
	    /// </summary>
	    /// <param name="x">Degrees</param>
	    /// <returns>The equivalent in radians</returns>
	    /// 
	    
	    public static byte sumCal(string data){
	    	int 
		    	index, len;
		    byte sum = 0;
		    byte [] ascii = Encoding.ASCII.GetBytes(data);
		    
		    len = ascii.Length;
		    
	    	for(index = 1; index < len; index++){
		    	sum ^= ascii[index];
	    	}
		    
		    return sum;
    	
	    }
	    public static double toKMPH(double knot){
	    	return (knot * 1.852);
	    }
	    
		static double Radians(double x)
	    {
	        return x * Math.PI / 180;
	    }
		
		public Functions()
		{
			
		}
		
		/// </summary>
	    /// <param name="lon1"></param>
	    /// <param name="lat1"></param>
	    /// <param name="lon2"></param>
	    /// <param name="lat2"></param>
	    /// <returns></returns>
	    public static double DistanceBetweenPlaces( PointLatLng p1, PointLatLng p2)
	    {
	    	double rlat1, rlat2, dlat, dlng, c, angle;
	    	
	    	rlat2 = Radians(p2.Lat);
	    	rlat1 = Radians(p1.Lat);
	    	
	        dlng = Radians(p2.Lng - p1.Lng);
	        dlat = Radians(p2.Lat - p1.Lat);
	
	        angle = Math.Sin(dlat / 2) * Math.Sin(dlat / 2) + 
	        	Math.Cos(rlat1) * Math.Cos(rlat2) * 
	        	(Math.Sin(dlng / 2) * Math.Sin(dlng / 2));
	        c = 2 * Math.Atan2(Math.Sqrt(angle), Math.Sqrt(1 - angle));
	        
	        return (RADIUS * c);
	    }
	}
}
