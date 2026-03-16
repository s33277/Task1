using System;

Console.WriteLine("Enter some nums to find the average:");
string userNumsString = Console.ReadLine();
string[] userNums = userNumsString.Split();

Console.WriteLine("Average: "+StatisticsHelper.GetAverage(userNums));