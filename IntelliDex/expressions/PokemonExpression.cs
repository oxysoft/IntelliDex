using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntelliDex.expressions {
	class PokemonExpression : IExpression {
		public PokemonExpression() {
		}

		public IExpression Refine(Digester digest) {
			if (digest.Done)
				return this;

			return this;
		}
	}
}
