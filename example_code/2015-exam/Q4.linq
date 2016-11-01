/* Q4 */

var z = 10;

Func<int, int> f = y => y + z; // define function f with lexically scoped free variable z
var r = f(10); // r = 10 + 10 = 20

z = 20; // update value of z => update lexical scope => update f.Target
var s = f(10); // r = 10 + 20 = 30

Console.WriteLine("{0} {1}", r, s); // 20 30
