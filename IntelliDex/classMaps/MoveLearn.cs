using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CsvHelper.Configuration;

namespace IntelliDex.classMaps {
	public class MoveLearn {
		public int PokeId { get; set; }
		public int VersionGroupId { get; set; }
		public int MoveId { get; set; }
		public int Method { get; set; }
		public int Level { get; set; }
		public int Order { get; set; }
	}

	public sealed class MappingMoveLearn : CsvClassMap<MoveLearn> {
		public MappingMoveLearn() {
			Map(m => m.PokeId).Index(0);
			Map(m => m.VersionGroupId).Index(1);
			Map(m => m.MoveId).Index(2);
			Map(m => m.Method).Index(3);
			Map(m => m.Level).Index(4);
			Map(m => m.Order).Index(5).Default(-1);
		}
	}
}
