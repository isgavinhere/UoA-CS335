<Query Kind="Statements" />

/* Q21 */

string[] sequence = {"the", "quick", "brown", "fox"};
int count = sequence.GroupBy(s => s.Length).Count();

Console.WriteLine(count);