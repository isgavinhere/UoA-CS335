/* Q19 */

void Main(){
	Func<int, int> q = F(n => n*n);

	var a = q(10);
	
	var b = q(10);

	var c = q(10);

	Console.WriteLine("{0} {1} {2}", a, b, c);
}

public Func<int, int> F (Func<int, int>p) {

	var y = 0;

	return x => { y += 1; return p(x)+y;};
}
