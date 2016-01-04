using System.Collections.Generic;
using IntelliDex.classMaps;
using Wox.Plugin;

namespace IntelliDex.expressions {
	public class LearnsetSelectorExpression : IExpression {
		public Pokemon Pokemon { get; set; }

		public LearnsetSelectorExpression(Pokemon pokemon) {
			Pokemon = pokemon;
		}

		public List<Result> MakeResults() {
			// TODO return list of generations that you can select
			List<Result> res = new List<Result>();

			return res;
		}

		public IExpression Refine(Digester digest) {
			if (digest.Done)
				return this;

			string def = digest.Digest();

			//	if (Utils.IsGen(digest.Peek()) || Utils.IsGame(digest.Peek())) {
			//	}

			if (Utils.IsGen(def)) {
				// default is level up when unspecified
				return new LearnsetExpression(Pokemon, Data.GetMoveMethod("level up"), -1, -1);
			} else if (Utils.IsGame(def)) {
				return new LearnsetExpression(Pokemon, Data.GetMoveMethod("level up"), -1, -1);
			}

			return this;
		}
	}
}