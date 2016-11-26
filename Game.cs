using System;
using System.Threading;
namespace DodgeGame
{
	public class Game
	{
		public Game()
		{
			player = new PlayerUnit(5, 10, "@");
			enemy = new EnemyUnit(Console.WindowWidth -1, 20, "X");

		}
		private Unit player;
		private Unit enemy;



		public void Run()
		{
			int desiredFPS = 30;
			int delayBetweenFrames = 1000 / desiredFPS;
			while (true)
			{

				player.Update();
				enemy.Update();

				player.Draw();
				enemy.Draw();

				Thread.Sleep(delayBetweenFrames);
			}
		}
	}
}
