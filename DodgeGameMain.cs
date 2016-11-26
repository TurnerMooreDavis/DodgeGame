using System;  // need .net stuff

namespace DodgeGame
{
	class DodgeGameMain
	{
		static void Main()
		{
			Console.CursorVisible = false;
			Game game = new Game();
			game.Run();
			Console.SetCursorPosition(0, Console.WindowHeight - 1);
		}
	}
}