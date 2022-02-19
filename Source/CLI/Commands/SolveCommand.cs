﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;
using Spectre.Console.Cli;
using System.Threading;
using System.Diagnostics;

namespace Wordler {
	class SolveCommand : Command<SolveCommand.Settings> {
		public class Settings : AppSettings {

		}

		public override int Execute([NotNull] CommandContext context, [NotNull] Settings settings) {
			Console.WriteLine(settings.Hard);
			Console.WriteLine(settings.WordList);

			var task = new LiveTask<string, Solver>();
			task.Run(new Solver(
				settings.Hard,
				settings.WordList,
				settings.LeaderboardLength,
				settings.Threads,
				settings.wordClues,
				typeof(BruteForce)
			));

			return 0;
		}
	}
}
