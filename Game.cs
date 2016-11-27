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
			enemy = new EnemyUnit(Console.WindowWidth -1, 20, "X");
			stopwatch = new Stopwatch();

		}
		private Unit player;
		private Unit enemy;

		private Stopwatch stopwatch;

		public void Run()
		{
			int desiredFPS = 10;
			int deltaTimeMs = 1000 / desiredFPS;
			while (true)
			{

				player.Update(deltaTimeMs);
				enemy.Update(deltaTimeMs);

				player.Draw();
				enemy.Draw();

				Thread.Sleep(deltaTimeMs);
			}
		}
	}
}
