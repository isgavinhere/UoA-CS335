/* Q8 */

Func<Func<int, int>, Func<int, int>, Func<int, int>> LeftToRight = (f, g) => (x => g(f(x)));
// LeftToRight is a function which takes two functions, f and g, and returns the composition g o f.

Func<Func<int, int>, Func<int, int>, Func<int, int>> RightToLeft = (f, g) => (x => f(g(x)));
// RightToLeft is a function which takes two functions, f and g, and returns the composition f o g.

int[] s = new int[] {10, 20, 30, 40};

var a = Enumerable.Select(Enumerable.Select(s, t => t*3), t => t+2);
// The inner projection multiplies each element of s by 3. The outer projection then increments each element by 2.
a.Dump(); // [32, 62, 92, 122]

var b = s.Select(LeftToRight((int t) => t*3, (int t) => t+2));
// The projection takes (f o g)(x) for each element of s, where f(x) = x*3, g(x) = x+2
b.Dump(); // [32, 62, 92, 122]

var c = s.Select(t => t+2).Select(t => t*3);
// The first projection increments each element of s by 2, the second then multiples each element by 3.
c.Dump(); // [36, 66, 96, 126]

var d = s.Select(RightToLeft((int t) => t+2, (int t) => t*3));
// The projection takes the (g o f)(x) for each element of s, where g(x) = x*3, f(x) = x+2
d.Dump(); // [32, 62, 92, 122]

var e = Enumerable.Select(s.Select(t => t*3), t => t+2);
// See a.
e.Dump(); // [32, 62, 92, 122]
