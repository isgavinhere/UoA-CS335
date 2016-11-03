<Query Kind="Statements" />

/* Q26 */

Func<int, bool>a = n => n <= 1;
Func<int, int> b = n => 10;
Func<int, int> c = n => { return n; };
Func<int, int> d = n => a(n) ? b(n): n*c(n-1);
Console.WriteLine("{0} {1} {2}", d(1), d(2), d(3));