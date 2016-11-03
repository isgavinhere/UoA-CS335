<Query Kind="Statements" />

/* Q22 */

string[] sequence = {"the", "quick", "brown", "fox"};
int count = sequence.GroupBy(s => s.Length)
					.SelectMany(s => s).Count();
					
Console.WriteLine(count);