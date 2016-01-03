using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IntelliDex.expressions;
using Wox.Plugin;

namespace IntelliDex {
	public class ExpressionParser {
		public static IExpression Parse(string query) {
			Digester digest = new Digester(query);

			if (digest.Done)
				return new EmptyExpression();

			string type = digest.Digest();

			if (Utils.IsPokemon(type)) {
				return new PokemonExpression().Refine(digest);
			} else {
			}

			return new EmptyExpression();
		}

	}
}
