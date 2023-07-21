using furnitures; //if namespace is not specified search here also
using environ.data; //if namespace is not specified search here also

using table=furnitures.table; //This is the default Table


public class Program 
{ 
	static void Main()
	{
		Chair c=new Chair();
		System.Console.WriteLine(c);

		list l=new list();
		System.Console.WriteLine(l);

		Bed b=new Bed();
		System.Console.WriteLine(b);

		//Get Furniture Table
		table t1=new table(5000);

		//Get Data Table
		environ.data.table t2=new environ.data.table(5,4);

		
	}
} 
