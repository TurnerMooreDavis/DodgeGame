using System;
namespace DodgeGame
{
	public class PlayerUnit : Unit
	{
		public PlayerUnit(int x, int y, string unitCharacter) : base(x, y, unitCharacter)
		{
		}
		override public void Update(int deltaTimeMS)
		{
			if (Console.KeyAvailable == true)
			{
				ConsoleKeyInfo cki = Console.ReadKey(true);
				switch (cki.Key)
				{
					case ConsoleKey.W:
						Y = Y - 1;
						break;
					case ConsoleKey.S:
						Y = Y + 1;
						break;
					case ConsoleKey.A:
						X = X - 1;
						break;
					case ConsoleKey.D:
						X = X + 1;
						break;
				}
			}
			base.Update(deltaTimeMS);
		}
	}
}
