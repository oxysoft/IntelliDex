using System;
using System.Collections.Generic;
using IntelliDex.classMaps;
using Wox.Plugin;

namespace IntelliDex.expressions {
	public class LearnsetExpression : IExpression {
		public Pokemon Pokemon { get; set; }
		public MoveMethod Method { get; set; }

		public LearnsetExpression(Pokemon pokemon, int method, int gen, int game) {
			Pokemon = pokemon;
		}

		public List<Result> MakeResults() {
			// TODO show results (each move is a result!)

			return null;
		}

		public IExpression Refine(Digester digest) {
			return this;
		}
	}
}