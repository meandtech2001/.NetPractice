using furnitures; //if namespace is not specified search here also
using data; //if namespace is not specified search here also

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
		furnitures.table t1=new furnitures.table(5000);

		//Get Data Table
		data.table t2=new data.table(5,4);

		
	}
} 
