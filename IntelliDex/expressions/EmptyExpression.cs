using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wox.Plugin;

namespace IntelliDex.expressions {
	public class EmptyExpression : IExpression {
		public IExpression Refine(Digester digest) {
			return this;
		}

		public List<Result> MakeResults() {
			return new List<Result> {
				new Result {
					Title = "Query didn't evaluate to anything!"
				}
			};
		}
	}
}
