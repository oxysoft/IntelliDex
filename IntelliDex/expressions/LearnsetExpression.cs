using System;
using System.Collections.Generic;
using System.Linq;
using IntelliDex.classMaps;
using IntelliDex.extensions;
using Wox.Plugin;

namespace IntelliDex.expressions {
	public class LearnsetExpression : IExpression {
		public Pokemon Pokemon { get; set; }
		public MoveMethod Method { get; set; }

		public int Generation { get; set; }
		public int Game { get; set; }

		public int VersionGroup {
			get {
				if (Generation > -1) {
					return Data.VersionGroups.Values.First(m => m.Gen == Generation).Id;
				}

				if (Game > -1) {
					return Data.Games.First(g => g.Id == Game).GroupId;
//					string gamestring = Data.Games.First(g => g.Id == Game).Identifier;
//					return Data.VersionGroups.Values.First(m => m.Identifiers.Contains(gamestring)).Id;
				}

				return -1;
			}
		}

		public LearnsetExpression(Pokemon pokemon, int method = -1, int gen = 5, int game = -1) {
			Pokemon = pokemon;
			Method = Data.GetMoveMethod(method);

			Generation = gen;
			Game = game;
		}

		public List<Result> MakeResults() {
			// TODO show results (each move is a result!)

			if (VersionGroup == -1)
				return Utils.MakeErrorResult("The version group could not be evaluated");

			Dictionary<byte, List<MoveLearn>> moveMethods = Data.MoveLearns[Pokemon.Id];
			List<MoveLearn> moves = moveMethods[Method.Id];


			moves = moves.Where(m => m.VersionGroupId == VersionGroup).ToList();
			Console.WriteLine($"Moves: {moves.Count}");

			List<Result> res = new List<Result>();

			if (Method.Id == 1) {
				moves.Sort((m1, m2) => m1.Level.CompareTo(m2.Level));
			}

			foreach (MoveLearn m in moves) {
				Result r = new Result {
					Title = "" + Data.Moves[m.MoveId].Name.Replace('-', ' ').Titlelize(),
				};

				if (Method.Id == 1) {
					r.SubTitle = $"Level {m.Level}";
				}

				res.Add(r);
			}

			return res;
		}

		public IExpression Refine(Digester digest) {
			return this;
		}
	}
}