/* Q5 */

Func<Func<int, int>, Func<int, int>, int, int, int> h = (f, g, x, y) => f(x) + g(y); 
// h is a function which takes two functions, f and g, and two integers, x and y.
// f and g both take a single integer, do something, and return a new integer.
// h passes x to f, y to g, and returns the sum of the resultant values.

var r = h(n => n+n, n => n+1, 10, 20); 
// f(x) = x+x = 10+10 = 20
// g(y) = y+1 = 20+1 = 21
// r = f(x) + g(y) = 20 + 21 = 41

var s = h(n => n*n, n => n+n, 10, 20);
// f(x) = x*x = 10*10 = 100
// g(x) = y+y = 20+20 = 40
// s = f(x) + g(y) = 100 + 40 = 140

Console.WriteLine("{0} {1}", r, s); // 41 140
