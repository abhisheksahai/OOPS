using System;

namespace OOPS
{
    abstract class Student : IStudent
    {
        public string GreetingsMessage()
        {
            return "Hello world";
        }

		public void Divide()
		{
			int c = 0;
			try
			{
				int a = 10;
				int b = 0;
				c = a / b;
			}
			catch (Exception ex)
			{
				Console.WriteLine(c);
			}
			//catch (DivideByZeroException ex)
			//{
			//	Console.WriteLine(c);
			//}
		}

		public int Multiply()
		{
			int c = 1;
			try
			{
				int a = 10;
				int b = 20;
				c = a * b;
			}
			catch (Exception ex)
			{
				return c;
			}
			finally
			{
				//return c;
			}
			return c;
		}
	}
}
