using CsvHelper.Configuration;

namespace IntelliDex.classMaps {
	public class MoveMethod {
		public int Id { get; set; }
		public string Identifier { get; set; }
		public string IdentifierPretty { get; set; }

		public override string ToString() {
			return $"Id: {Id}, Identifier: {Identifier}, IdentifierPretty: {IdentifierPretty}";
		}
	}

	public sealed class MappingMoveMethod : CsvClassMap<MoveMethod> {
		public MappingMoveMethod() {
			Map(m => m.Id).Index(0);
			Map(m => m.Identifier).Index(1);
			Map(m => m.IdentifierPretty).Index(2);
		}
	}
}