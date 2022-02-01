using System;

public class Class1
{
	public class interest
    {
		public double total;
		public mybank(int cost, double rate)
        {
			total = cost + (rate * rate);
			return total;
        }
		public static mybank operator +(mybank b)
        {
			b.total = +b.total;
        }
    }
	public Class1()
	{
		public static void Main(string args[])
        {
			interest i = new interest();
			double amount = +i.mybank(50000, 0.5);
			Console.WriteLine("Interest amount " + amount);
        }
	}
}
