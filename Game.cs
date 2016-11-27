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
			enemy = new EnemyUnit(Console.WindowWidth -1, 10, "X");
			stopwatch = new Stopwatch();

		}
		private Unit player;
		private Unit enemy;

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
				enemy.Update(deltaTimeMs);

				if (player.IsCollidingWith(enemy))
				{
					GameOver();
					return;
				}

				player.Draw();
				enemy.Draw();

				Thread.Sleep(5);
			}
		}

		private void GameOver()
		{
			Console.Clear();
			Console.WriteLine("Game Over!");
		}

	}
}
