using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_ConsoleApp
{
    class Program
    {
		//整數運算
		static void Main(string[] args)
		{
			Q1();
			Q2();
			Q3();
			Q4();
		}
		static void Q1()
		{
			//1 + (2 + 2) * 3 - 1
			//2 + ((2 + 1) / 3 + 1) * 2

			DisplayHeader("Q1");
			int result = 1 + (2 + 2) * 3 - 1;
			int result1= 2 + ((2 + 1) / 3 + 1) * 2;
            Console.WriteLine(result);
            Console.WriteLine(result1);
			// todo 
		}
		static void Q2()
		{
			//寫程式, 計算並顯示 120 除以 7 的商數, 餘數, 各是多少
			DisplayHeader("Q2");
			// todo 
			int sum = 120/7;
			int sum1=120%7;
            Console.WriteLine("商數"+sum);
			Console.WriteLine("餘數" + sum1);
		}
		static void Q3()
		{
			DisplayHeader("Q3");
			// todo  1~10總和
            int cal=(1+10)*10/2;
            Console.WriteLine(cal);
		}
		static void Q4()
		{
			DisplayHeader("Q4");
			// todo 
			var result = (9%2==0)? "偶數":"奇數";
			var result1 = (202 % 2 == 0) ? "偶數" : "奇數";
            Console.WriteLine(result);
            Console.WriteLine(result1);
		}

		static void DisplayHeader(string title)
		{
			Console.WriteLine("\r\n");
			Console.WriteLine(title);
			Console.WriteLine(new string('=', 40));
		}
	}
}
