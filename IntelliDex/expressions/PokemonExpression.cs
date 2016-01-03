using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IntelliDex.classMaps;
using Wox.Plugin;

namespace IntelliDex.expressions {
	public class PokemonExpression : IExpression {
		private Pokemon Pokemon { get; set; }

		public PokemonExpression(Pokemon pokemon) {
			Pokemon = pokemon;
		}

		public List<Result> MakeResults() {
			List<Result> res = new List<Result>();

			
			return res;
		}

		public IExpression Refine(Digester digest) {
			if (digest.Done)
				return this;

			string accessor = digest.Digest();

			if (accessor.Equals("learnset") || accessor.Equals("ls")) {
				if (Utils.IsGen(digest.Peek()) || Utils.IsGame(digest.Peek())) {
					return new LearnsetExpression().Refine(digest);
				} else {
					return new LearnsetSelectorExpression();
				}
			}

			return this;
		}
	}
}
