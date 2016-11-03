<Query Kind="Statements" />

/* Q20 */

string[] sequence= {"quick", "brown", "fox"};
int count = sequence.SelectMany(s => s).Count();

Console.WriteLine(count);