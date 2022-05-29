
// Not completed -  Running

// Calculating peak and off peak hour between two dates
// 30 second pulse 
// Author : Shariful Islam



DateTime startDate = DateTime.Parse("2021-01-30 08:00:13 am"); 
DateTime endDate = DateTime.Parse("2021-01-31 10:00:39 am");


var peakHourStart = Convert.ToDateTime("9.00.00 am").TimeOfDay;
var peakHourEnd = Convert.ToDateTime("10.59.59 pm").TimeOfDay;

var offPeakHourStart = Convert.ToDateTime("11.00.00 pm").TimeOfDay;
var offPeakHourEnd = Convert.ToDateTime("8.59.59 am").TimeOfDay;

int count = 0;
while(startDate <= endDate)
{
    if(count !=0) startDate = startDate.AddSeconds(1);
    var tempTime = startDate.AddSeconds(30).TimeOfDay;
    if(tempTime >= peakHourStart && tempTime <= peakHourEnd)
    {
        Console.WriteLine(tempTime.ToString()+"("+ peakHourStart.ToString() +"-"+peakHourEnd.ToString()+ ")"+" = Peak hour");
    }
    else
    {
        Console.WriteLine(tempTime.ToString() + "(" + offPeakHourStart.ToString() + "-" + offPeakHourEnd.ToString() + ")" + " = OffPeak hour");

    }

    startDate = startDate.AddSeconds(30);
    count++;
}



