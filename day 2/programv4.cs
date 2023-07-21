using furnitures; //if namespace is not specified search here also
using data; //if namespace is not specified search here also

using table=furnitures.table; //This is the default Table
using dtable =data.table;

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
		dtable t2=new dtable(5,4);

		
	}
} 
