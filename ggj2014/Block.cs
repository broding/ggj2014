using System;
using Flakcore.Display;
using Microsoft.Xna.Framework;
using Flakcore;
using Microsoft.Xna.Framework.Graphics;

namespace XNA
{
	public class Block : Sprite
	{
		public Block ()
		{
			LoadTexture (Director.Content.Load<Texture2D> ("logo"));
		}

		public override void Update (Microsoft.Xna.Framework.GameTime gameTime)
		{
			base.Update (gameTime);

			Velocity.Y += 5;
		}
	}
}

