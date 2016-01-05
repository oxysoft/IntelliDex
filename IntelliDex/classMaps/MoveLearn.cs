using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CsvHelper.Configuration;

namespace IntelliDex.classMaps {
	public class MoveLearn {
		public short PokeId { get; set; }
		public byte VersionGroupId { get; set; }
		public short MoveId { get; set; }
		public byte Method { get; set; }
		public byte Level { get; set; }
		public byte Order { get; set; }
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
