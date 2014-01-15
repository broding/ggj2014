using System;
using Flakcore.Display;
using Microsoft.Xna.Framework;
using C3.XNA;
using Flakcore;
using Microsoft.Xna.Framework.Graphics;
using Flakcore.Display.ParticleEngine;
using Flakcore.Display.ParticleEngine.EmitterData;

namespace XNA
{
	public class GameState : State
	{
		private Sprite block;
		private Sprite fall;
		private Sprite player;
		private Layer layer;
		private Layer layer2;

		public GameState ()
		{
			Random random = new Random ();

			for (int i = 0; i < 20; i++)
			{
				Sprite sprite = new Block ();
				sprite.Position.X = random.Next (0, (int)Director.ScreenSize.X);
				sprite.Position.Y = random.Next (0, 40);
				//AddChild (sprite);
			}

			//ParticleEffect effect = Director.Content.Load<ParticleEffect> ("particle");
			//ParticleEngine particles = new ParticleEngine (effect);

			layer = new Layer ();
			layer2 = new Layer ();
			
			AddLayer (layer2);
			AddLayer (layer);

			//layer2.AddChild (particles);

			//Effect ripple = Director.Content.Load<Effect>("effect");

			player = new Player ();
			Director.Camera.followNode = player;
			layer2.AddChild (player);

			//layer2.Effect = ripple;


			fall = new Block ();
			fall.Position.X = random.Next (0, (int)Director.ScreenSize.X);
			fall.Position.Y = random.Next (0, 40);
			layer2.AddChild (fall);

			block = Sprite.CreateRectangle (new Vector2 (Director.ScreenSize.X, 50), Color.Aquamarine);
			block.Position.Y = 400;
			block.Immovable = true;

			layer.AddChild (block);	
		}

		public override void Update (GameTime gameTime)
		{
			base.Update (gameTime);

			Director.Collide (block, fall);
			Director.Collide (block, player);
			Director.Collide (player, fall);
		}
	}
}

