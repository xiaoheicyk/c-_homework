// See https://aka.ms/new-console-template for more information

using System.Globalization;

Console.Write("Enter your birth date in format dd.MM.yyyy: ");
DateTime birthDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
DateTime currentDate = DateTime.Now;
int day = (currentDate - birthDate).Days;
Console.WriteLine($"You are {day} days old.");
int daysToNextAnniversary = 10000 - (day % 10000);
DateTime nextAnniversary = currentDate.AddDays(daysToNextAnniversary);
Console.WriteLine($"Your next 10,000 day anniversary will be on: {nextAnniversary.ToShortDateString()}");
