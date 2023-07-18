﻿using System;

class Program
{
	static void Main()
	{
		// DateTime example
		DateTime date1 = new DateTime(2022, 4, 1, 9, 0, 0);
		DateTime date2 = new DateTime(2022, 4, 1, 8, 0, 0);

		// Calculate the difference between the two DateTime objects
		TimeSpan timeDiff = date2 - date1;

		// Display the total number of minutes in the TimeSpan object
		Console.WriteLine("Total minutes: {0}", timeDiff.TotalMinutes);

		// DateTimeOffset example
		DateTimeOffset wib = new DateTimeOffset(2022, 4, 1, 9, 0, 0, new TimeSpan(7, 0, 0));
		DateTimeOffset wita = new DateTimeOffset(2022, 4, 1, 9, 0, 0, new TimeSpan(8, 0, 0));

		// Calculate the difference between the two DateTimeOffset objects
		TimeSpan timeDiff2 = wib - wita;

		// Display the total number of minutes in the TimeSpan object
		Console.WriteLine("Total Hours: {0}", timeDiff2.TotalHours);

		// TimeZoneInfo example
		TimeZoneInfo tz1 = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
		DateTimeOffset dto3 = TimeZoneInfo.ConvertTime(wib, tz1);

		// Display the converted DateTimeOffset object
		Console.WriteLine("Before convert DateTimeOffset object: {0}", wib);
		Console.WriteLine("Converted DateTimeOffset object: {0}", dto3);

		// DateOnly example
		DateOnly date3 = new DateOnly(2022, 4, 1);
		DateOnly date4 = date3.AddDays(10);

		// Display the new DateOnly object
		Console.WriteLine("New DateOnly object: {0}", date4);

		// TimeOnly example
		TimeOnly time1 = new TimeOnly(9, 0, 0);
		TimeOnly time2 = time1.AddMinutes(88);

		// Display the new TimeOnly object
		Console.WriteLine("New TimeOnly object: {0}", time2);

		TimeOnly time3 = new TimeOnly(10, 0, 0);
		TimeOnly time4 = new TimeOnly(14, 30, 0);

		DateTime dateTime1 = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, time1.Hour, time1.Minute, time1.Second);
		DateTime dateTime2 = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, time2.Hour, time2.Minute, time2.Second);

		TimeSpan duration = dateTime2 - dateTime1;

	}
}