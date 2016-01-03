using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntelliDex;

namespace Tests {
	class Program {
		static void Main(string[] args) {
			Utils.Init();
			Data.Init();

			IExpression expr = ExpressionParser.Parse("pikachu");

			Console.WriteLine(expr);

			Console.ReadLine();
		}
	}
}
