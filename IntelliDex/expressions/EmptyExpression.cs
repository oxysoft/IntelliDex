using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntelliDex.expressions {
	class EmptyExpression : IExpression {
		public IExpression Refine(Digester digest) {
		}
	}
}
