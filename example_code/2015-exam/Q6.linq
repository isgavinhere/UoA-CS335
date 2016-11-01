/* Q6 */

Func<int, Func<int, int>> h = x => (y => x + y); // h is a function which takes an integer, and returns a closure.
Func<int, int> j = h(10); // Func<int, int> j = y => 10 + y
var r = j(30); // r = 10 + 30 = 40
var s = j(40); // s = 10 + 40 = 50

Func<int, int> k = h(20); // Func<int, int> k = y => 20 + y
var t = k(30); // t = 20 + 30 = 50
var u = k(40); // u = 20 + 40 = 60

Console.WriteLine("{0} {1} {2} {3}", r, s, t, u); // 40 50 50 60
