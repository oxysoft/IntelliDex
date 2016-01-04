using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IntelliDex.classMaps;
using IntelliDex.extensions;
using Wox.Plugin;

namespace IntelliDex.expressions {
	public class PokemonExpression : IExpression {
		private Pokemon Pokemon { get; set; }

		public PokemonExpression(Pokemon pokemon) {
			Pokemon = pokemon;
		}

		public List<Result> MakeResults() {
			List<Result> res = new List<Result>();

			res.Add(new Result {
				Title = Pokemon.Name.Capitalize(),
				SubTitle = $"Weight: {Pokemon.Height}, Height: {Pokemon.Weight}",
				IcoPath = $"Images\\pokemon-thumbs\\{Pokemon.Id}.png"
			});
			
			return res;
		}

		public IExpression Refine(Digester digest) {
			if (digest.Done)
				return this;

			string accessor = digest.Digest();

			if (accessor.Equals("learnset") || accessor.Equals("ls")) {
				return new LearnsetSelectorExpression(Pokemon).Refine(digest);
			}

			return this;
		}
	}
}
