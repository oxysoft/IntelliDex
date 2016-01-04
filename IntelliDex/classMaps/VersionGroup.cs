using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CsvHelper.Configuration;

namespace IntelliDex.classMaps {
	public class VersionGroup {
		public int Id { get; set; }
		public string Identifiers { get; set; }
		public int Gen { get; set; }
		public int Order { get; set; }

		public override string ToString() {
			return $"Id: {Id}, Identifiers: {Identifiers}, Gen: {Gen}, Order: {Order}";
		}
	}

	public sealed class MappingVersionGroup : CsvClassMap<VersionGroup> {
		public MappingVersionGroup() {
			Map(m => m.Id).Index(0);
			Map(m => m.Identifiers).Index(1);
			Map(m => m.Gen).Index(2);
			Map(m => m.Order).Index(3);
		}
	}
}
