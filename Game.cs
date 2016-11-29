using System;
using System.Threading;
using System.Diagnostics;
namespace DodgeGame
{
	public class Game
	{
		public Game()
		{
			player = new PlayerUnit(5, 10, "@");
			enemies = new Unit[numEnemies];
			Random = new Random();
			Score = 0;
			for (int i = 0; i < enemies.Length; i++)
			{
				int row = Game.Random.Next(0, Console.WindowHeight - 1);
				enemies[i] = new EnemyUnit(Console.WindowWidth - 1, row, "X");
			}
			stopwatch = new Stopwatch();

		}
		public static Random Random;
		public static int Score;
		private Unit player;
		private Unit[] enemies;
		private int numEnemies = 15;
		private Stopwatch stopwatch;

		public void Run()
		{
			stopwatch.Start();
			long timeAtPreviousFrame = stopwatch.ElapsedMilliseconds;

			while (true)
			{
				int deltaTimeMs = (int)(stopwatch.ElapsedMilliseconds - timeAtPreviousFrame);
				timeAtPreviousFrame = stopwatch.ElapsedMilliseconds;
				player.Update(deltaTimeMs);
				for (int i = 0; i < enemies.Length; i++)
				{
					enemies[i].Update(deltaTimeMs);

					if (player.IsCollidingWith(enemies[i]))
					{
						GameOver();
						return;
					}
				}


				player.Draw();
				foreach (Unit u in enemies)
				{
					u.Draw();
				}

				Console.SetCursorPosition(0, Console.WindowHeight - 1);
				Console.Write("SCORE: " + Score);

				Thread.Sleep(5);
			}
		}

		private void GameOver()
		{
			Console.Clear();
			Console.WriteLine("Game Over! Final Score is: " + Score);
		}

	}
}
