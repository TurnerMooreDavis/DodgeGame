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
						if (Y > 0)
						{
							Y = Y - 1;
						}
						break;
					case ConsoleKey.S:
						if (Y < Console.WindowHeight -1)
						{
							Y = Y + 1;
						}
						break;
					case ConsoleKey.A:
						if (X > 0)
						{
							X = X - 1;
						}
						break;
					case ConsoleKey.D:
						if (X < Console.WindowWidth -1)
						{
							X = X + 1;
						}
						break;
				}
			}
			base.Update(deltaTimeMS);
		}
	}
}
