using System.Collections.Generic;
using Wox.Plugin;

namespace IntelliDex.expressions {
	public class LearnsetSelectorExpression : IExpression {
		public List<Result> MakeResults() {
			// TODO return list of generations that you can select
			return null;
		}

		public IExpression Refine(Digester digest) {
			return this;
		}
	}
}