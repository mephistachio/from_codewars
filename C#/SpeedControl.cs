using System;

public class GpsSpeed 
{
    public static int Gps(int s, double[] x) {
    
    double maxSpeed=0;
      if (x.Length <= 1 || x == null ) return 0; // if x less then 1 or 0 return 0, else run
     
      maxSpeed = double.MinValue;

    	for (int i = 1; i < x.Length; i++)
    	{
       if (i + 1 < x.Length)
       {
       	double speed = ((x[i + 1] - x[i])*3600)/s;
    		if (speed > maxSpeed)
    		{
    			maxSpeed = speed;
    		}
    }      
   }
  return (int)(maxSpeed);   	
  }
}
