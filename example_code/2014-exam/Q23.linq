<Query Kind="Statements" />

/* Q23 */
string[] sequence = {"the", "quick", "brown", "fox"};
int count = sequence.GroupBy(s => s.Length)
					.SelectMany(s => s).SelectMany(s => s).Count();
					
Console.WriteLine(count);
