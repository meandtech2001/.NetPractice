class FactorialProgram
{
     static void Main()
        {
		int n = 5;
		FactorialProgram f = new FactorialProgram();
		int fn = f.Factorial(n); 

		System.Console.WriteLine("Factorial of "+n+" is "+fn);
	}

	int Factorial(int x)
	{
		int fx=1;
		while(x>1)
			fx*=x--;

		return fx;
	}

}