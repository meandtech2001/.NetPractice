class Program
{

	public static void Main()
	{
		int n,r,val;
		
  		do{
		Input input= new Input();
		val=input.ReadInt("MENU\n 1. Factorial\n 2.Permutation\n 3.Combination\n 0.Exit\nChoose:");
		switch(val) 
		{
 		    case 1:
			 n=input.ReadInt("Enter: ");

    			int f=Factorial.Calculate(n);
			System.Console.WriteLine("Factorial is: "+f);
   				 break;
		    case 2:
			
			 n=input.ReadInt("n: ");

			 r=input.ReadInt("r: ");

			Permutation permutation= new Permutation();
    			int p=permutation.Calculate(n,r);
			System.Console.WriteLine(n+" P "+r+" = "+p);
   				 break;
			
		    case 3:
			
			 n=input.ReadInt("n: ");

			 r=input.ReadInt("r: ");

			Combination combination = new Combination();
    			int c=combination.Calculate(n,r);
			System.Console.WriteLine(n+" C "+r+" = "+c);
   				 break;
			
		   case 0:
                       System.Console.WriteLine("Thanks");
				 break;
		}
		
		}while(val!=0);
		
	}

}