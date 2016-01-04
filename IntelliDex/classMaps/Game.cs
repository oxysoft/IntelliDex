using CsvHelper.Configuration;

namespace IntelliDex.classMaps {
	public class Game {

		public int Id { get; set; }
		public int GroupId { get; set; }
		public string Identifier { get; set; }
		public string PrettyIdentifier { get; set; }

		public override string ToString() {
			return $"Id: {Id}, GroupId: {GroupId}, Identifier: {Identifier}, PrettyIdentifier: {PrettyIdentifier}";
		}
	}

	public sealed class MappingGame : CsvClassMap<Game> {
		public MappingGame() {
			Map(m => m.Id).Index(0);
			Map(m => m.GroupId).Index(1);
			Map(m => m.Identifier).Index(2);
			Map(m => m.PrettyIdentifier).Index(3);
		}
	}
}