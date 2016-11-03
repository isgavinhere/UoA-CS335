<Query Kind="Expression" />

/* Q25 */
Func<int, int> H = null;
H = n => n <= 1? 1: 2*H(n-1) + 1;
H = Memoize(H);
int x = H(3) + H(5);