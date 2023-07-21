namespace environ
{
namespace data
{

public class table 
{ 
	public int rows=5;
	public int columns=3;

	public table(int r,int c)
	{
		rows=r;
		columns=c;
	System.Console.WriteLine("rows "+r+"columns "+c);
	}
} 

}
}