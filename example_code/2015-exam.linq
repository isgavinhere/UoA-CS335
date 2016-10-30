/* Q4 */

var z = 10;

Func<int, int> f = y => y + z; // define function f with lexically scoped free variable z
var r = f(10); // r = 10 + 10 = 20

z = 20; // update value of z => update lexical scope => update f.Target
var s = f(10); // r = 10 + 20 = 30

Console.WriteLine("{0} {1}", r, s); // 20 30

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

/* Q6 */

Func<int, Func<int, int>> h = x => (y => x + y); // h is a function which takes an integer, and returns a closure.
Func<int, int> j = h(10); // Func<int, int> j = y => 10 + y
var r = j(30); // r = 10 + 30 = 40
var s = j(40); // s = 10 + 40 = 50

Func<int, int> k = h(20); // Func<int, int> k = y => 20 + y
var t = k(30); // t = 20 + 30 = 50
var u = k(40); // u = 20 + 40 = 60

Console.WriteLine("{0} {1} {2} {3}", r, s, t, u); // 40 50 50 60

/* Q7 */

Func<Func<int, bool>, Func<int, int>, Func<int, int>> Loop = null;
// Loop is a function which takes two (unnamed) functions and returns a new function.
// The first function takes an integer and returns a boolean.
// The second function, and the return function, both take an integer and return a new integer. 
// The return function takes an integer and returns a new integer. 

Loop = (c, f) => n => c(n) ? Loop(c,f) (f(n)): n;
// Loop takes functions c and f, and returns a new function.
// The new function takes an integer argument n.
// If c(n) evaluates to True, the Loop function will recursively call itself with the result of f(n)...
// ...otherwise, it returns n (base case).

Func<int, int> w = Loop(n => n < 10, n => n + 2);
// w is a function which evaluates to the result of calling Loop with c, f defined as inline lambdas.
// c(n) returns True if n is less than 10, f(n) returns n+2. 
// In familiar procedural syntax: while(n < 10) {n+=2;} return n;

var r = w(2); 
// w(2) = Loop(c(2), f(2))  = Loop(True, 4)
//      = Loop(c(4), f(4)   = Loop(True, 6) 
//      = Loop(c(6), f(6)   = Loop(True, 8)
//      = Loop(c(8), g(8)   = Loop(True, 10)
//      = Loop(c(10), g(10) = Loop(False, 12) 
//      = 10
var s = w(3); 
// w(3) = Loop(c(3), f(3))   = Loop(True, 5)
//      = Loop(c(5), f(5)    = Loop(True, 7)
//      = Loop(c(7), f(7))   = Loop(True, 9)
//      = Loop(c(9), f(9))   = Loop(True, 11)
//      = Loop(c(11), f(11)) = Loop(False, 13) 
//      = 11

Console.WriteLine("{0} {1}", r, s); // 10 11