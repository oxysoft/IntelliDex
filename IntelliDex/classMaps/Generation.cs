using CsvHelper.Configuration;

namespace IntelliDex.classMaps {
	public class Generation {
		private string identifier;

		public string Identifier {
			get { return identifier; }
			set { identifier = value.ToLower().Split('-')[1]; } // the roman numeral!
		}

		public int Id { get; set; }

		public override string ToString() {
			return $"Identifier: {Identifier}, Id: {Id}";
		}
	}

	public sealed class MappingGeneration : CsvClassMap<Generation> {
		public MappingGeneration() {
			Map(m => m.Id).Index(0);
			Map(m => m.Identifier).Index(2);
		}
	}
}