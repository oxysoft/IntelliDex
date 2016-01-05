using CsvHelper.Configuration;

namespace IntelliDex.classMaps {
	public class Move {
		public short Id { get; set; }
		public string Name { get; set; }
		public int Type { get; set; }
		public byte Power { get; set; }
		public byte PP { get; set; }
		public byte Accuracy { get; set; }
		public byte Target { get; set; }
		public byte DamageType { get; set; }
		public short Effect { get; set; }
		public byte EffectChance { get; set; }
		public byte ContestType { get; set; }
		public byte ContestEffect { get; set; }
	}

	public sealed class MappingMove : CsvClassMap<Move> {
		public MappingMove() {
			Map(m => m.Id).Index(0);
			Map(m => m.Name).Index(1);
			Map(m => m.Type).Index(3);
			Map(m => m.Power).Index(4).Default(0);
			Map(m => m.PP).Index(5).Default(0);
			Map(m => m.Accuracy).Index(6).Default(0);
			Map(m => m.Target).Index(8);
			Map(m => m.DamageType).Index(9);
			Map(m => m.Effect).Index(10);
			Map(m => m.EffectChance).Index(11).Default(0);
			Map(m => m.ContestType).Index(12).Default(0);
			Map(m => m.ContestEffect).Index(13).Default(0);
		}
	}
}