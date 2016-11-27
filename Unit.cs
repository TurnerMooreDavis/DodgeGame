using System;
namespace DodgeGame
{
	 abstract public class Unit
	{
		public Unit(int x, int y, string UnitCharacter)
		{
			this.X = x;
			this.Y = y;
			this.UnitCharacter = UnitCharacter;
		}
		public int X
		{
			get
			{
				return _x;
			}
			set
			{
				Undraw();
				_x = value;
			}
		}
		private int _x;


		public int Y
		{
			get
			{
				return _y;
			}
			set
			{
				Undraw();
				_y = value;
			}
		}
		private int _y;
			
		public string UnitCharacter;

		virtual public void Update(int deltaTimeMS)
		{
		}

		public void Draw()
		{
			Console.SetCursorPosition(X, Y);
			Console.Write(UnitCharacter);
		}
		public void Undraw()
		{
			Console.SetCursorPosition(X, Y);
			Console.Write(' ');
		}
	}
}
