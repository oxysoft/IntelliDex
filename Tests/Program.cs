using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntelliDex;
using IntelliDex.extensions;

namespace Tests {
	class Program {
		static void Main(string[] args) {

			var tacho = System.Diagnostics.Stopwatch.StartNew();

			Utils.Init();
			Data.Init();

			tacho.Stop();
			Console.WriteLine("Read all data in: {0}", tacho.Elapsed);

			Console.WriteLine(ExpressionParser.Parse("pikachu ls"));
			ExpressionParser.Parse("bulbasaur ls IV").MakeResults();
			ExpressionParser.Parse("bulbasaur ls red").MakeResults();
			ExpressionParser.Parse("bulbasaur ls 3").MakeResults();

			Console.ReadLine();
		}
	}
}
