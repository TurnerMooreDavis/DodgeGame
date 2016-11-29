using System;
namespace DodgeGame
{
	public class EnemyUnit : Unit
	{
		public EnemyUnit(int x, int y, string UnitCharacter) : base(x,y, UnitCharacter)
		{
			sleepTimeMS = Game.Random.Next(0, 2000);
			TimeBetweenMoves = Game.Random.Next(40, 60);
		}
		public int TimeBetweenMoves;
		private int timeSinceLastMove = 0;
		private int sleepTimeMS = 0;
		public override void Update(int deltaTimeMS)
		{
			sleepTimeMS -= deltaTimeMS;
			if (sleepTimeMS > 0)
			{
				return;
			}

			timeSinceLastMove += deltaTimeMS;
			if (timeSinceLastMove < TimeBetweenMoves)
			{
				return;
			}

			timeSinceLastMove -= TimeBetweenMoves;

			if (X > 0)
			{
				X = X - 1;
			}
			else
			{
				X = Console.WindowWidth - 1;
				Y = Game.Random.Next(0, Console.WindowHeight - 1);
				if (this.TimeBetweenMoves > 1)
				{
					this.TimeBetweenMoves -= 2;
				}
				Game.Score ++;
				sleepTimeMS = Game.Random.Next(0, 1000);
			}
			base.Update(deltaTimeMS);
		}

		public override void Draw()
		{
			if (sleepTimeMS > 0)
			{
				return;
			}
			else
			{
				base.Draw();
			}

		}
	}
}
