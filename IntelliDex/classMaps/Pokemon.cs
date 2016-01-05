using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CsvHelper.Configuration;

namespace IntelliDex.classMaps {
	public class Pokemon {
		public short Id { get; set; }
		public short Species { get; set; }
		public byte Height { get; set; }
		public short Weight { get; set; }
		public short Exp { get; set; }
		public short Order { get; set; }
		public string Name { get; set; }

		public override string ToString() {
			return $"Id: {Id}, Species: {Species}, Height: {Height}, Weight: {Weight}, Exp: {Exp}, Order: {Order}, Name: {Name}";
		}
	}

	public sealed class MappingPokemon : CsvClassMap<Pokemon> {
		public MappingPokemon() {
			Map(m => m.Id).Index(0);
			Map(m => m.Name).Index(1);
			Map(m => m.Species).Index(2);
			Map(m => m.Height).Index(3);
			Map(m => m.Weight).Index(4);
			Map(m => m.Exp).Index(5);
			Map(m => m.Order).Index(6);
		}
	}
}
