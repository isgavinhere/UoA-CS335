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
