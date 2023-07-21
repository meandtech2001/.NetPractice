public class Program 
{ 
	static void Main()
	{
		furntiures.Chair c=new furntiures.Chair();
		System.Console.WriteLine(c);

		data.list l=new data.list();
		System.Console.WriteLine(l);

		furntiures.Bed b=new furntiures.Bed();
		System.Console.WriteLine(b);

		//What is in the LHS?
		furntiures.table t1=new furntiures.table(5000); //RHS looks like furntiures.Table

		
		data.table t2=new data.table(5,4);

	}
} 
