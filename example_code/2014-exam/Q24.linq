<Query Kind="Statements" />

/* Q24 */
Func<int, int> H = null;
H = n => n <= 1 ? 1:2*H(n-1) + 1;
int x = H(3) + H(5);