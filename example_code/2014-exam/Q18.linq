/* Q18 */

void Main(){
	
	var x = F(n => n+1, n => n*n)(10);
	Console.WriteLine("{0}", x);
}

public Func<int, int> F (Func<int, int>p, Func<int, int>q){
	return x => p(q(x));
}
