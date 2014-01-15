using System;
using Flakcore.Display;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

namespace XNA
{
	public class Player : Sprite
	{
		public Player ()
		{
			Sprite sprite = Sprite.CreateRectangle (new Microsoft.Xna.Framework.Vector2 (50, 50), Color.Red);
			this.Width = 50;
			this.Height = 50;
			AddChild (sprite);

			this.ConvexShape = sprite.ConvexShape;
		}

		public override void Update (Microsoft.Xna.Framework.GameTime gameTime)
		{
			base.Update (gameTime);

			Velocity.Y += 5;

			
			KeyboardState keyboardState = Keyboard.GetState();

			if (keyboardState.IsKeyDown (Keys.Left))
				Velocity.X = -250;
			else if (keyboardState.IsKeyDown (Keys.Right))
				Velocity.X = 250;
			else
				Velocity.X = 0;

			if (keyboardState.IsKeyDown (Keys.Up))
				Velocity.Y -= 20;


		}
	}
}

