using System;

int[] grades = new int[365];
List<string> dayOfWeeks = new List<string>();
dayOfWeeks.Add("poniedzialek");
dayOfWeeks.Add("wtorek");
dayOfWeeks.Add("sroda");
dayOfWeeks.Add("czwartek");
dayOfWeeks.Add("piatek");
dayOfWeeks.Add("sobota");
dayOfWeeks.Add("niedziela");
//Console.WriteLine(dayOfWeeks[2]);

//string[] dayOfWeeks2 = { "poniedzialek", "wtorek", "sroda", "czwartek", "piatek", "sobota", "niedziela" };
//Console.WriteLine(dayOfWeeks[0]);

foreach (var day in dayOfWeeks)
{
    Console.WriteLine(day);
}