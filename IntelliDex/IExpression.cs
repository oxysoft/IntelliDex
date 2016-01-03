using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wox.Plugin;

namespace IntelliDex {
	public interface IExpression {
		List<Result> MakeResults();
		IExpression Refine(Digester digest);
	}
}
