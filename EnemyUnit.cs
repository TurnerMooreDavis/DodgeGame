using System;
namespace DodgeGame
{
	public class EnemyUnit : Unit
	{
		public EnemyUnit(int x, int y, string UnitCharacter) : base(x,y, UnitCharacter)
		{
		}
		public int TimeBetweenMoves = 100;
		private int timeSinceLastMove = 0;

		public override void Update(int deltaTimeMS)
		{
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
			}
		}
	}
}
