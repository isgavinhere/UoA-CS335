<Query Kind="Program" />

/* Q29 */

void Main()
{
	public class Feline { }
	public class Cat: Feline { }
	public class Birman: Cat { }
	public class Tiger: Feline { }
	public class Siberian: Tiger { }
	
	static Func<Cat,Tiger> f = n => new Tiger(); //function takes a Cat, outputs a Tiger
	
	
	Func<Feline,Siberian> a = f;
	Func<Cat,Siberian> b = f;
	Func<Birman,Feline> c = f; // acceptable
	Func<Feline,Tiger> d = f;
	Func<Birman,Siberian> e = f;

}