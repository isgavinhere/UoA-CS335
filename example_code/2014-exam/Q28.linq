<Query Kind="Statements" />

/* Q28 */
var seq = new int[] {-4, -3, 0, 1, 2, 3, 4,};
var res = seq.Aggregate(0, (a,s) => s >= 0 ? a+1 : a-1);
Console.WriteLine(res);